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
using static tcm_edi_audit_core_new.Settings.Services.ExcelService;

namespace tcm_edi_audit_core_new
{
    public partial class frmHome : Form
    {
        private AppSettings? _settings;
        private AppSettingsLocal _localSettings;

        private FileManagerService _fileManagerService;
        private List<ExcelEntry> _excelEntries;
        private ExcelService _excelService;
        private List<ExcelSheetParsedResult<ExcelEntry>> _excelWorksheets;

        private ConfigManagerService _configManagerService;

        public frmHome()
        {
            InitializeComponent();

            _localSettings = new AppSettingsLocal();
            _configManagerService = new ConfigManagerService();

            _fileManagerService = new FileManagerService();
            _excelEntries = new List<ExcelEntry>(); // Initialize the field to avoid CS8618
            _excelService = new ExcelService();
            _excelWorksheets = new List<ExcelSheetParsedResult<ExcelEntry>>();
        }


        private async Task<DialogResult> LoadConfigForm()
        {
            if (_settings == null) { throw new ArgumentNullException(nameof(AppSettings)); }

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
                _settings = await _configManagerService.LoadSettingsFromCloud();

                if (_settings == null)
                {
                    MessageBox.Show("Não foi possível carregar as configurações. Verifique sua conexão com a internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _localSettings = _configManagerService.LoadSettings() ?? new AppSettingsLocal();


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as configurações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool TryLoadExcelFile(bool forceUpload)
        {
            cmbWorksheet.SafeInvoke(() => cmbWorksheet.Enabled = false);
            btnViewWorksheet.SafeInvoke(() => btnViewWorksheet.Enabled = false);
            btnLockWorksheet.SafeInvoke(() => btnLockWorksheet.Enabled = false);

            if (!forceUpload)
            {
                if (_excelWorksheets.IsNullOrEmpty()) { return false; }

                PopulateComboboxes();
                return true;
            }

            if (!string.IsNullOrEmpty(_localSettings.ReferenceExcelFilePath))
            {
                try
                {
                    _excelWorksheets = _excelService.ExtractStructuredDataFromExcel<ExcelEntry>(_localSettings.ReferenceExcelFilePath, _settings);

                    PopulateComboboxes();
                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _localSettings.ReferenceExcelFilePath = string.Empty;
                    _configManagerService.SaveSettings(_localSettings);

                    return false;
                }
            }

            return false;
        }

        public void PopulateComboboxes()
        {
            if (!_excelWorksheets.IsNullOrEmpty())
            {
                var worksheets = _excelWorksheets
                            .Select(s => s.SheetName?.Trim().ToUpper())
                            .Distinct()
                            .OrderBy(c => c)
                            .ToList();

                //worksheets.Insert(0, "Selecione uma planilha");
                worksheets.Insert(0, "TODOS");

                cmbWorksheet.SafeInvoke(() => cmbWorksheet.DataSource = null);
                cmbWorksheet.SafeInvoke(() => cmbWorksheet.DataSource = worksheets);
                cmbWorksheet.SafeInvoke(() => cmbWorksheet.Enabled = true);

                btnViewWorksheet.SafeInvoke(() => btnViewWorksheet.Enabled = true);
                btnLockWorksheet.SafeInvoke(() => btnLockWorksheet.Enabled = true);
            }
            else
            {
                cmbWorksheet.SafeInvoke(() => cmbWorksheet.DataSource = null);
                cmbWorksheet.SafeInvoke(() => cmbWorksheet.Enabled = false);

                btnViewWorksheet.SafeInvoke(() => btnViewWorksheet.Enabled = false);
                btnLockWorksheet.SafeInvoke(() => btnLockWorksheet.Enabled = false);
            }

            btnLockWorksheet.SetCheckState(false, Properties.Resources.circle_check_icon_green_24_24, Properties.Resources.circle_solid_icon_24_24);
        }

        private bool TrySetDefaultWorkSheet(string? workSheet = null)
        {

            if (workSheet == null)
            {
                _excelEntries = new List<ExcelEntry>();
                btnAudit.Enabled = false;
            }

            if (workSheet == "TODOS")
            {
                _excelEntries = _excelWorksheets.SelectMany(w => w.Entries).ToList();
                return true;
            }
            else
            {
                var foundWorkSheet = _excelWorksheets.FirstOrDefault(w => w.SheetName?.Trim().ToUpper() == workSheet?.Trim().ToUpper());

                if (foundWorkSheet != null)
                {
                    _excelEntries = foundWorkSheet.Entries;
                    return true;

                }
                else
                {
                    _excelEntries = new List<ExcelEntry>();
                    return false;
                }
            }
        }



        public void TryEnableAuditButton()
        {
            bool buttonEnabled = true;

            if (string.IsNullOrEmpty(txtFolderRootPath.Text?.Trim()))
            {
                buttonEnabled = false;
            }

            if (string.IsNullOrEmpty(txtOutputPath.Text?.Trim()))
            {
                buttonEnabled = false;
            }

            if (string.IsNullOrEmpty(txtExcelFilePath.Text?.Trim()))
            {
                buttonEnabled = false;
            }

            if (_excelWorksheets.IsNullOrEmpty())
            {
                buttonEnabled = false;
            }

            if (_excelEntries.IsNullOrEmpty())
            {
                buttonEnabled = false;
            }

            btnAudit.Enabled = buttonEnabled;
        }

        private async Task<List<EdiValidationResult>> ValidateFiles(bool tryFixIt = false)
        {
            if (_settings == null) throw new ArgumentNullException(nameof(AppSettings));

            EdiParserService parser = new EdiParserService(_settings);
            EdiValidatorService validatorService = new EdiValidatorService(_settings);
            ExcelService excelService = new ExcelService();
            List<EdiValidationResult> validatonResults = new List<EdiValidationResult>();

            //TryLoadExcelFile(false);
            List<ExcelEntry> excelEntries = _excelEntries;

            foreach (var excelEntry in excelEntries)
            {
                if (string.IsNullOrEmpty(excelEntry.RequestCode))
                {
                    excelEntry.RequestCode = "000001";
                }
            }

            if (!excelEntries.IsNullOrEmpty())
            {
                foreach (var excelEntry in excelEntries)
                {
                    var files = _fileManagerService.GetEdiFiles(_localSettings.SourceFolderPath, null, $"320_{excelEntry.Invoice}");

                    if (!files.IsNullOrEmpty())
                    {
                        foreach (var file in files)
                        {
                            var lines = await _fileManagerService.ReadEdiFileAsync(file.FullName);

                            var parseResult = parser.ParseFile(lines);

                            EdiValidationResult validatonResult = validatorService.Validate(parseResult, excelEntries, excelEntry.Invoice, tryFixIt);
                            validatonResult.File = file;
                            validatonResult.Protocol = excelEntry.Protocol;
                            validatonResult.Invoice = excelEntry.Invoice;
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
            btnCheckFixFiles.SwapCheckState(Properties.Resources.sqare_check_icon_dark, Properties.Resources.sqare_uncheck_icon_dark);

            _localSettings.TryFixIt = btnCheckFixFiles.GetCheckState();
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

            if (!string.IsNullOrEmpty(_localSettings.ReferenceExcelFilePath))
            {
                if (!TryLoadExcelFile(true))
                {
                    _localSettings.ReferenceExcelFilePath = string.Empty;
                    _configManagerService.SaveSettings(_localSettings);
                }
            }

            txtExcelFilePath.Text = _localSettings.ReferenceExcelFilePath;
            txtFolderRootPath.Text = _localSettings.SourceFolderPath;
            txtOutputPath.Text = _localSettings.OutputFolderPath;

            btnCheckFixFiles.SetCheckState(_localSettings.TryFixIt, Properties.Resources.sqare_check_icon_dark, Properties.Resources.sqare_uncheck_icon_dark);

            this.Enabled = true;
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

            TryEnableAuditButton();
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

            TryEnableAuditButton();

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

                    if (TryLoadExcelFile(true))
                    {
                    }
                }
            }

            TryEnableAuditButton();

        }

        private async void btnAudit_Click(object sender, EventArgs e)
        {


            btnAudit.SafeInvoke(() => btnAudit.Enabled = false);
            btnAudit.SafeInvoke(() => btnAudit.Text = "Processando...");
            picLoadingGif.SafeInvoke(() => picLoadingGif.Visible = true);

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
                btnAudit.SafeInvoke(() => btnAudit.Text = "Auditar");
                btnAudit.SafeInvoke(() => btnAudit.Enabled = true);
                picLoadingGif.SafeInvoke(() => picLoadingGif.Visible = false);
            }
        }

        private void cmbWorksheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLockWorksheet.SetCheckState(false, Properties.Resources.circle_check_icon_green_24_24, Properties.Resources.circle_solid_icon_24_24);
            _excelEntries = new List<ExcelEntry>();
            TryEnableAuditButton();

        }



        private void btnLockWorksheet_Click(object sender, EventArgs e)
        {
            btnLockWorksheet.SwapCheckState(Properties.Resources.circle_check_icon_green_24_24, Properties.Resources.circle_solid_icon_24_24);
            if (btnLockWorksheet.GetCheckState())
            {
                TrySetDefaultWorkSheet(cmbWorksheet.SelectedItem?.ToString());
            }
            else
            {
                _excelEntries = new List<ExcelEntry>();
            }

            TryEnableAuditButton();

        }

        private void btnViewWorksheet_Click(object sender, EventArgs e)
        {
            frmExcelEntries frmExcelEntries = new frmExcelEntries(_excelWorksheets, cmbWorksheet.SelectedItem?.ToString());
            frmExcelEntries.ShowDialog();
        }
    }
}
