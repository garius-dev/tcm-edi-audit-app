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
using tcm_edi_audit_core_new.Models.EDI;
using tcm_edi_audit_core_new.Models.EDI.Settings;
using tcm_edi_audit_core_new.Models.Settings;
using tcm_edi_audit_core_new.Services;
using tcm_edi_audit_core_new.Settings.Services;

namespace tcm_edi_audit_core_new
{
    public partial class frmHome : Form
    {
        private AppSettings _settings;
        private AppSettingsLocal _localSettings;

        private FileManagerService _fileManagerService;
        private List<ExcelEntry> _excelEntries;
        private ExcelService _excelService;

        private ConfigManagerService _configManagerService;

        public frmHome()
        {
            InitializeComponent();

            _settings = new AppSettings();
            _localSettings = new AppSettingsLocal();
            _configManagerService = new ConfigManagerService();

            _fileManagerService = new FileManagerService();
            _excelEntries = new List<ExcelEntry>();
            _excelService = new ExcelService();
        }

        private void SetCheckButtonState(bool btnChecked)
        {
            if (btnChecked)
            {
                btnCheckFixFiles.Tag = "1";
                btnCheckFixFiles.Image = Properties.Resources.sqare_check_icon_dark;
            }
            else
            {
                btnCheckFixFiles.Tag = "0";
                btnCheckFixFiles.Image = Properties.Resources.sqare_uncheck_icon_dark;
            }
        }

        private bool GetCheckButtonState()
        {
            if (btnCheckFixFiles.Tag != null && btnCheckFixFiles.Tag.ToString() == "1")
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

        private async Task<AppSettings?> LoadSettingsFromCloud()
        {
            return await _configManagerService.LoadSettingsFromCloud();
        }

        private async Task<DialogResult> LoadConfigForm()
        {
            DialogResult result;

            using (frmSplashScreen splash = new frmSplashScreen())
            {
                splash.FormTitle = "CARREGANDO CONFIGURAÇÕES...";

                splash.Show();
                splash.Refresh();

                await Task.Delay(200);

                splash.Close();

                using (var frm = new frmConfig(_settings))
                {
                    result = frm.ShowDialog();
                    if (frm._settings != null)
                    {
                        _settings = frm._settings;
                    }
                }
            }

            return result;
        }

        private async Task<bool> TryLoadSettings()
        {
            try
            {
                var appSettingsResult = await LoadSettingsFromCloud();

                if (appSettingsResult == null)
                {
                    MessageBox.Show("Não foi possível carregar as configurações. Verifique sua conexão com a internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _settings = appSettingsResult;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as configurações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoadControls()
        {
            if (_localSettings != null)
            {
                txtFolderRootPath.Text = _localSettings.SourceFolderPath;
                txtExcelFilePath.Text = _localSettings.ReferenceExcelFilePath;
                txtOutputPath.Text = _localSettings.OutputFolderPath;
                SetCheckButtonState(_localSettings.TryFixIt);

                if (!TryLoadExcelFile(false))
                {
                    txtExcelFilePath.Text = string.Empty;
                    _localSettings.ReferenceExcelFilePath = string.Empty;
                    _configManagerService.SaveSettings(_localSettings);
                }
            }

            ValidatePreConfig();
        }

        private void ValidatePreConfig()
        {
            btnAudit.Enabled = !string.IsNullOrEmpty(txtFolderRootPath.Text) && !string.IsNullOrEmpty(txtExcelFilePath.Text) && !string.IsNullOrEmpty(txtOutputPath.Text);


        }

        private bool TryLoadExcelFile(bool preView = false)
        {
            if (!string.IsNullOrEmpty(txtExcelFilePath.Text))
            {
                try
                {
                    _excelEntries = _excelService.Load(_localSettings.ReferenceExcelFilePath, _settings);
                    if (preView)
                    {
                        frmExcelEntries frmExcelEntries = new frmExcelEntries(_excelEntries);
                        frmExcelEntries.ShowDialog();
                    }
                    return true;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtExcelFilePath.Text = string.Empty;
                    _localSettings.ReferenceExcelFilePath= string.Empty;
                    _configManagerService.SaveSettings(_localSettings);

                    return false;
                }
            }

            return false;
        }

        private async Task<List<EdiValidationResult>> ValidateFiles(bool tryFixIt = false)
        {
            EdiParserService parser = new EdiParserService(_settings);
            EdiValidatorService validatorService = new EdiValidatorService(_settings);
            ExcelService excelService = new ExcelService();
            List<EdiValidationResult> validatonResults = new List<EdiValidationResult>();

            List<ExcelEntry> excelEntries = _excelEntries;

            if (!excelEntries.IsNullOrEmpty())
            {
                foreach (var excelEntry in excelEntries)
                {
                    var files = _fileManagerService.GetEdiFiles(_localSettings.SourceFolderPath, null, $"_{excelEntry.Invoice}");

                    if (!files.IsNullOrEmpty())
                    {
                        foreach (var file in files)
                        {
                            var lines = await _fileManagerService.ReadEdiFileAsync(file.FullName);

                            var parseResult = parser.ParseFile(lines);

                            EdiValidationResult validatonResult = validatorService.Validate(parseResult, excelEntries, excelEntry.Invoice, tryFixIt);
                            validatonResult.File = file;
                            validatonResult.Protocol = excelEntry.Protocol;
                            validatonResults.Add(validatonResult);
                        }
                    }
                    else
                    {
                        // No files found for the current invoice
                    }
                }
            }
            else
            {
                // No entries found in the Excel file
            }

            return validatonResults;
        }

        private void btnCheckFixFiles_Click(object sender, EventArgs e)
        {
            SwapCheckButtonState();
            _localSettings.TryFixIt = GetCheckButtonState();
            _configManagerService.SaveSettings(_localSettings);
        }

        private async void btnConfig_Click(object sender, EventArgs e)
        {
            await LoadConfigForm();
        }

        private async void frmHome_Load(object sender, EventArgs e)
        {
            this.Enabled = false;

            if (!await TryLoadSettings())
            {
                this.Close();
            }

            this.Enabled = true;

            _localSettings = _configManagerService.LoadSettings() ?? new AppSettingsLocal();
            LoadControls();
        }

        private void btnRootFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Selecione a pasta de exportação dos arquivos EDI",
                ShowNewFolderButton = true
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                txtFolderRootPath.Text = selectedPath;

                _localSettings.SourceFolderPath = selectedPath;
                _configManagerService.SaveSettings(_localSettings);
            }

            ValidatePreConfig();
        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Selecione a pasta de resultado dos arquivos EDI",
                ShowNewFolderButton = true
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                txtOutputPath.Text = selectedPath;

                _localSettings.OutputFolderPath = selectedPath;
                _configManagerService.SaveSettings(_localSettings);
            }

            ValidatePreConfig();
        }

        private void btnExcelFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files (*.xls;*.xlsx;*.xlsm)|*.xls;*.xlsx;*.xlsm|Todos os Arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione o Planilha de referência";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    txtExcelFilePath.Text = selectedFile;

                    _localSettings.ReferenceExcelFilePath = selectedFile;
                    _configManagerService.SaveSettings(_localSettings);

                    if (!string.IsNullOrEmpty(txtExcelFilePath.Text))
                    {
                        TryLoadExcelFile(true);
                    }
                }
            }

            ValidatePreConfig();
        }

        private async void btnAudit_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                btnAudit.Enabled = false;
                btnAudit.Text = "Processando...";
                picLoadingGif.Visible = true;
            }));

            await Task.Delay(1);

            try
            {
                var filesValidated = await Task.Run(() => ValidateFiles(_localSettings.TryFixIt));

                frmValidatorResult frmValidatorResult = new frmValidatorResult(filesValidated, _localSettings);

                frmValidatorResult.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    btnAudit.Text = "Auditar";
                    btnAudit.Enabled = true;
                    picLoadingGif.Visible = false;
                }));
            }
        }
    }
}
