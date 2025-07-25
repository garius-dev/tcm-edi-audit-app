using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcm_edi_audit_core_new.Extensions;
using tcm_edi_audit_core_new.Models.DTOs;
using tcm_edi_audit_core_new.Models.EDI;
using tcm_edi_audit_core_new.Models.Settings;

namespace tcm_edi_audit_core_new
{
    public partial class frmValidatorResult : Form
    {
        private AppSettingsLocal _localSettings;
        private List<EdiValidationResult> _validationResults;
        private List<EdiValidationDisplayModel> _validationDisplayItems;

        public frmValidatorResult(List<EdiValidationResult> validationResults, AppSettingsLocal localSettings)
        {
            InitializeComponent();

            _localSettings = localSettings ?? throw new ArgumentNullException(nameof(localSettings));
            _validationResults = validationResults ?? throw new ArgumentNullException(nameof(validationResults));
            _validationDisplayItems = _validationResults.ToDisplayModel(GetCheckButtonState());
        }

        private void frmValidatorResult_Load(object sender, EventArgs e)
        {
            LoadDatagridView();
            PopulateComboboxes();

            if (_validationResults.IsNullOrEmpty())
            {
                btnSaveFiles.Enabled = false;
                btnExpandSelection.Enabled = false;
            }
        }

        private void LoadDatagridView()
        {
            dgvValidatorResult.DataSource = new BindingSource { DataSource = _validationDisplayItems };
            dgvValidatorResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvValidatorResult.RowHeadersWidth = 35;
            dgvValidatorResult.ReadOnly = true;
            dgvValidatorResult.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void PopulateComboboxes()
        {
            var status = _validationDisplayItems
                            .Select(s => s.Status)
                            .Distinct()
                            .OrderBy(c => c)
                            .ToList();

            status.Insert(0, "Todos");
            cmbStatus.DataSource = null;
            cmbStatus.DataSource = status;

            var files = _validationDisplayItems
                            .Select(s => s.FileName)
                            .Distinct()
                            .OrderBy(c => c)
                            .ToList();

            files.Insert(0, "Todos");
            cmbFiles.DataSource = null;
            cmbFiles.DataSource = files;
        }

        private void ApplyCombinedFilters()
        {
            string status = cmbStatus.SelectedItem?.ToString() ?? string.Empty;
            string files = cmbFiles.SelectedItem?.ToString() ?? string.Empty;

            var filtered = _validationDisplayItems.AsEnumerable();

            if (!string.IsNullOrEmpty(status) && status != "Todos")
                filtered = filtered.Where(w => w.Status == status);

            if (!string.IsNullOrEmpty(files) && files != "Todos")
                filtered = filtered.Where(w => w.FileName == files);

            filtered = filtered.OrderByPriority();

            dgvValidatorResult.DataSource = new BindingSource { DataSource = filtered };
        }

        private void SetCheckButtonState(bool btnChecked)
        {
            if (btnChecked)
            {
                btnExpandSelection.Tag = "1";
                btnExpandSelection.Image = Properties.Resources.sqare_check_icon_dark;
            }
            else
            {
                btnExpandSelection.Tag = "0";
                btnExpandSelection.Image = Properties.Resources.sqare_uncheck_icon_dark;
            }
        }

        private bool GetCheckButtonState()
        {
            if (btnExpandSelection.Tag != null && btnExpandSelection.Tag.ToString() == "1")
            {
                return true;
            }
            return false;
        }

        private void SwapCheckButtonState()
        {
            bool currentState = GetCheckButtonState();
            SetCheckButtonState(!currentState);
        }

        private void SaveFiles()
        {
            if (!_validationDisplayItems.IsNullOrEmpty())
            {
                var protocolGroup = _validationResults.GroupBy(g => g.Protocol)
                    .Select(s => new
                    {
                        Protocol = s.Key,
                        Items = s.ToList()
                    }).ToList();

                string dateString = DateTime.Now.ToString("yyyy-MM-dd");

                foreach (var protocolItem in protocolGroup)
                {
                    string outputResultFolderPath = Path.Combine(_localSettings.OutputFolderPath, dateString, protocolItem.Protocol);
                    FileExtensions.CheckOrCreateFolder(outputResultFolderPath);

                    foreach (var item in protocolItem.Items)
                    {
                        if (item.Status == EdiValidationStatus.Warning && item.File != null)
                        {
                            var fixedFileContent = item.EdiLines.ToStringBuild();
                            string fixedFilePath = Path.Combine(outputResultFolderPath, item.File.Name);

                            FileExtensions.CreateOrReplaceFile(fixedFilePath, fixedFileContent);
                        }
                        else if (item.Status == EdiValidationStatus.Success && item.File != null)
                        {
                            FileExtensions.CopyFileReplacingIfExists(item.File.FullName, outputResultFolderPath);
                        }
                        else if (item.Status == EdiValidationStatus.Error && item.File != null)
                        {
                            FileExtensions.DeleteFileIfExists(Path.Combine(outputResultFolderPath, item.File.Name));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há arquivos para salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnExpandSelection_Click(object sender, EventArgs e)
        {
            SwapCheckButtonState();

            _validationDisplayItems = _validationResults.ToDisplayModel(GetCheckButtonState());

            dgvValidatorResult.DataSource = null;
            dgvValidatorResult.DataSource = new BindingSource { DataSource = _validationDisplayItems };
            dgvValidatorResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvValidatorResult.RowHeadersWidth = 35;
            dgvValidatorResult.ReadOnly = true;
            dgvValidatorResult.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            PopulateComboboxes();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFiles.DataSource = null;

            var files = _validationDisplayItems
                            .Where(w => w.Status == cmbStatus.SelectedItem?.ToString() || cmbStatus.SelectedItem?.ToString() == "Todos")
                            .Select(s => s.FileName)
                            .Distinct()
                            .OrderBy(c => c)
                            .ToList();

            files.Insert(0, "Todos");

            cmbFiles.DataSource = files;
        }

        private void cmbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyCombinedFilters();
        }

        private async void btnSaveFiles_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                btnSaveFiles.Enabled = false;
                btnSaveFiles.Text = "Salvando...";
                picLoadingGif.Visible = true;
            }));

            await Task.Delay(1);

            try
            {
                await Task.Run(() => SaveFiles());
                MessageBox.Show("Arquivos salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    btnSaveFiles.Text = "Salvar Arquivos";
                    btnSaveFiles.Enabled = true;
                    picLoadingGif.Visible = false;
                }));
            }
        }
    }
}
