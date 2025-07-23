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
using tcm_edi_audit_core_new.Models.EDI.Settings;
using tcm_edi_audit_core_new.Models.Settings;
using tcm_edi_audit_core_new.Settings.Services;

namespace tcm_edi_audit_core_new
{
    public partial class frmConfig : Form
    {
        public AppSettings? _settings;
        private AppSettings? _settingsBackup;

        private ConfigManagerService _configManagerService;

        public frmConfig(AppSettings settings)
        {
            InitializeComponent();

            _settings = settings ?? new AppSettings();
            _settingsBackup = settings?.DeepClone();
            _configManagerService = new ConfigManagerService();
        }

        private void LoadDatagridView()
        {
            if (_settings == null)
            {
                MessageBox.Show("Configurações não carregadas corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Veículos
            dgvVehicles.DataSource = new BindingSource { DataSource = _settings.Vehicles };
            dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicles.RowHeadersWidth = 35;
            dgvVehicles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            //Filiais
            dgvBranches.DataSource = new BindingSource { DataSource = _settings.Branches };
            dgvBranches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBranches.RowHeadersWidth = 35;
            dgvBranches.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            //Fluxos
            dgvFlow.DataSource = new BindingSource { DataSource = _settings.CollectTypes };
            dgvFlow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFlow.RowHeadersWidth = 35;
            dgvFlow.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            //Definição das colunas do EDI
            _settings.EdiFieldDefinitions = _settings.EdiFieldDefinitions.OrderBy(o => o.LineCode).ThenBy(o => o.ColumnId).ToList();
            dgvEdiFieldValidationSettings.DataSource = new BindingSource { DataSource = _settings.EdiFieldDefinitions };
            dgvEdiFieldValidationSettings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEdiFieldValidationSettings.RowHeadersWidth = 35;
            dgvEdiFieldValidationSettings.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEdiFieldValidationSettings.Columns[0].ReadOnly = true;
            dgvEdiFieldValidationSettings.Columns[1].ReadOnly = true;
            dgvEdiFieldValidationSettings.Columns[2].ReadOnly = true;
            dgvEdiFieldValidationSettings.Columns[3].ReadOnly = true;
            dgvEdiFieldValidationSettings.Columns[4].ReadOnly = true;
            dgvEdiFieldValidationSettings.Columns[5].ReadOnly = true;
            dgvEdiFieldValidationSettings.Columns[6].ReadOnly = true;

            //Definição das linhas gerais do EDI
            dgvCodeDefinitions.DataSource = new BindingSource { DataSource = _settings.EdiLineCodeDefinitions };
            dgvCodeDefinitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCodeDefinitions.RowHeadersWidth = 35;
            dgvCodeDefinitions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            //Administradores
            _settings.AdminUsers = _settings.AdminUsers.OrderBy(o => o.UserName).ToList();
            dgvAdmins.DataSource = new BindingSource { DataSource = _settings.AdminUsers };
            dgvAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmins.RowHeadersWidth = 35;
            dgvAdmins.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            //Excel Patterns            
            if(_settings.ExcelPatternColumnSettings == null)
            {
                _settings.ExcelPatternColumnSettings = ObjectExtensions.LoadDefaultExcelColumns();
            }

            dgvExcelConfig.DataSource = new BindingSource { DataSource = _settings.ExcelPatternColumnSettings };
            dgvExcelConfig.Columns[0].ReadOnly = true;
            dgvExcelConfig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExcelConfig.RowHeadersWidth = 35;
            dgvExcelConfig.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        public void LoadControls()
        {
            txtWorkSheetName.Text = _settings?.ExcelWorkSheetname ?? string.Empty;
        }

        public void LoadComboBox()
        {
            cmbLineCode.DataSource = null;
            cmbDataType.DataSource = null;

            if (_settings != null)
            {
                var codes = _settings.EdiFieldDefinitions
                            .Select(s => s.LineCode)
                            .Distinct()
                            .OrderBy(c => c)
                            .ToList();

                codes.Insert(0, "Todos");

                cmbLineCode.DataSource = codes;


                var typeOfData = _settings.EdiFieldDefinitions
                                .Select(s => s.FieldType)
                                .Distinct()
                                .OrderBy(c => c)
                                .ToList();

                typeOfData.Insert(0, "Todos");

                cmbDataType.DataSource = typeOfData;
            }
        }

        private void ApplyCombinedFilters()
        {
            string? lineCode = cmbLineCode.SelectedItem?.ToString();
            string? fieldType = cmbDataType.SelectedItem?.ToString();

            if (_settings != null)
            {
                var filtered = _settings.EdiFieldDefinitions.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(lineCode) && lineCode != "Todos")
                    filtered = filtered.Where(w => w.LineCode == lineCode);

                if (!string.IsNullOrWhiteSpace(fieldType) && fieldType != "Todos")
                    filtered = filtered.Where(w => w.FieldType == fieldType);

                dgvEdiFieldValidationSettings.DataSource = new BindingSource { DataSource = filtered.ToList() };
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            LoadDatagridView();
            LoadComboBox();
            LoadControls();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();


            //_settingsBackup = _settings?.DeepClone();

            btnClose.Enabled = false;

            btnSave.Enabled = false;
            btnSave.Text = "Salvando...";

            picLoadingGif.Visible = true;

            try
            {
                if (_settings != null)
                {
                    _settings.ExcelWorkSheetname = txtWorkSheetName.Text.Trim();


                    if (_settings.IsDifferentTo(_settingsBackup))
                    {
                        bool saveResult = await _configManagerService.SaveSettingsToCloud(_settings);

                        if (!saveResult)
                        {
                            MessageBox.Show("Não foi possível salvar as configurações. Verifique sua conexão com a internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Configurações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Configurações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                _settings = _settingsBackup;
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally
            {
                btnSave.Text = "Salvar";
                btnSave.Enabled = true;

                btnClose.Enabled = true;

                picLoadingGif.Visible = false;

                LoadDatagridView();
                LoadComboBox();
                _settingsBackup?.Dispose();
            }
        }

        private void cmbLineCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyCombinedFilters();
        }

        private void cmbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyCombinedFilters();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Validate();
            _settingsBackup?.Dispose();
        }
    }
}
