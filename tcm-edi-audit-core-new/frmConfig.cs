using DocumentFormat.OpenXml.Spreadsheet;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            //if(_settings.ExcelPatternColumnSettings == null)
            //{
            //    _settings.ExcelPatternColumnSettings = ObjectExtensions.LoadDefaultExcelColumns();
            //}

            //dgvExcelConfig.DataSource = new BindingSource { DataSource = _settings.ExcelPatternColumnSettings };
            //dgvExcelConfig.Columns[0].ReadOnly = true;
            //dgvExcelConfig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvExcelConfig.RowHeadersWidth = 35;
            //dgvExcelConfig.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

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
            btnSave.Enabled = false;
            LoadDatagridView();
            LoadComboBox();
            LoadControls();
            LoadExcelConfig();
            btnSave.Enabled = true;
        }

        public void AddExcelProfile()
        {

            if (_settings == null) return;

            TabPage tabPage = new TabPage("New")
            {
                Padding = new Padding(8)
            };

            // >>> DataGridView Container <<<
            Panel container_Grid = new Panel()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(0)
            };

            DataGridView dgv = new DataGridView
            {
                Name = Guid.NewGuid().ToString(),
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.None,
                BackgroundColor = System.Drawing.Color.White,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                RowHeadersWidth = 35,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
                AllowUserToAddRows = true,
                AllowUserToDeleteRows = true,
                ReadOnly = false
            };

            var bindingList = new BindingList<ExcelColumnMap>(new List<ExcelColumnMap>());
            dgv.DataSource = bindingList;

            foreach (DataGridViewColumn col in dgv.Columns)
                col.ReadOnly = false;

            container_Grid.Controls.Add(dgv);

            // >>> Divisor entre TextBox e Grid <<<
            Panel divisor_02 = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 8
            };

            // >>> TextBox <<<
            TextBox txt = new TextBox()
            {
                Dock = DockStyle.Fill,
            };
            txt.Font = new System.Drawing.Font(txt.Font.FontFamily, 12, txt.Font.Style);

            // >>> Delete Button <<<
            Button btnDeleteTab = new Button()
            {
                Dock = DockStyle.Right,
                Width = 30,
                Image = Properties.Resources.trash_bin_20_20,
                ImageAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand,
                //Text = "X",
                //BackColor = System.Drawing.Color.FromArgb(220, 53, 69),
                //ForeColor = System.Drawing.Color.White,
                //FlatStyle = FlatStyle.Flat
            };
            btnDeleteTab.FlatAppearance.BorderSize = 0;

            // Evento de deletar a TabPage
            btnDeleteTab.Click += (s, e) =>
            {
                if (tabControlExcelContainer.TabPages.Count > 1)
                {
                    tabControlExcelContainer.TabPages.Remove(tabPage);

                }
            };

            // >>> Horizontal Container for TextBox + Button <<<
            Panel horizontalContainer = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 30
            };
            horizontalContainer.Controls.Add(txt);
            horizontalContainer.Controls.Add(btnDeleteTab);

            // >>> Label do título <<<
            Label lbl = new Label()
            {
                Dock = DockStyle.Top,
                Text = "Nome do perfil:",
                AutoSize = false,
                Height = 24,
                ForeColor = System.Drawing.Color.FromArgb(46, 80, 159),
                Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
            };

            // >>> Divisor topo <<<
            Panel divisor_01 = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 8
            };

            // >>> Ordem de Adição (Bottom-Up) <<<
            tabPage.Controls.Add(container_Grid);    // Fill (DGV)
            tabPage.Controls.Add(divisor_02);        // Spacer
            tabPage.Controls.Add(horizontalContainer); // TextBox + Button
            tabPage.Controls.Add(lbl);               // Title
            tabPage.Controls.Add(divisor_01);        // Top Spacer

            tabControlExcelContainer.Controls.Add(tabPage);

            tabControlExcelContainer.SelectedTab = tabPage;
        }

        public List<ExcelHeaderProfile> GetCurrentExcelConfig()
        {
            List<ExcelHeaderProfile> profiles = new List<ExcelHeaderProfile>();

            foreach (TabPage tabPage in tabControlExcelContainer.TabPages)
            {
                var dgv = ControlsExtensions.FindControls<DataGridView>(tabPage).FirstOrDefault(); //tabPage.Controls.OfType<DataGridView>().FirstOrDefault();
                var txt = ControlsExtensions.FindControls<TextBox>(tabPage).FirstOrDefault();

                if(dgv != null)
                {
                    dgv.CreateControl();
                    dgv.Refresh();
                }
                else
                {
                    continue;
                }

                if (dgv != null && txt != null && dgv.Rows.Count > 0)
                {
                    ExcelHeaderProfile profile = new ExcelHeaderProfile()
                    {
                        ProfileName = txt.Text.Trim().ToUpper()
                    };

                    List<ExcelColumnMap> excelColumnMaps = new List<ExcelColumnMap>();

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string header = row.Cells[0].Value?.ToString() ?? string.Empty;

                        if (string.IsNullOrEmpty(header.Trim()))
                        {
                            continue;
                        }

                        string property = row.Cells[1].Value?.ToString() ?? string.Empty;
                        excelColumnMaps.Add(new ExcelColumnMap() { Header = header, Property = property });
                    }

                    if(excelColumnMaps.Count > 0 && !string.IsNullOrEmpty(txt.Text.Trim().ToUpper()))
                    {
                        profile.Columns = excelColumnMaps;
                        profiles.Add(profile);
                    }                    
                }
            }

            return profiles;
        }

        public void LoadExcelConfig()
        {
            tabControlExcelContainer.TabPages.Clear();

            if (_settings == null) return;

            if (!_settings.ExcelHeaderProfiles.IsNullOrEmpty())
            {
                foreach (var profile in _settings.ExcelHeaderProfiles)
                {
                    TabPage tabPage = new TabPage(profile.ProfileName)
                    {
                        Padding = new Padding(8)
                    };

                    // >>> DataGridView Container <<<
                    Panel container_Grid = new Panel()
                    {
                        Dock = DockStyle.Fill,
                        Padding = new Padding(0)
                    };

                    DataGridView dgv = new DataGridView
                    {
                        Name = Guid.NewGuid().ToString(),
                        Dock = DockStyle.Fill,
                        BorderStyle = BorderStyle.None,
                        BackgroundColor = System.Drawing.Color.White,
                        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                        RowHeadersWidth = 35,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
                        AllowUserToAddRows = true,
                        AllowUserToDeleteRows = true,
                        ReadOnly = false
                    };

                    var bindingList = new BindingList<ExcelColumnMap>(profile.Columns);
                    dgv.DataSource = bindingList;

                    foreach (DataGridViewColumn col in dgv.Columns)
                        col.ReadOnly = false;

                    dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgv.Font, FontStyle.Bold);

                    container_Grid.Controls.Add(dgv);

                    // >>> Divisor entre TextBox e Grid <<<
                    Panel divisor_02 = new Panel()
                    {
                        Dock = DockStyle.Top,
                        Height = 8
                    };

                    // >>> TextBox <<<
                    TextBox txt = new TextBox()
                    {
                        Dock = DockStyle.Fill,
                        Text = profile.ProfileName
                    };
                    txt.Font = new System.Drawing.Font(txt.Font.FontFamily, 10, txt.Font.Style);

                    // >>> Delete Button <<<
                    Button btnDeleteTab = new Button()
                    {
                        Dock = DockStyle.Right,
                        Width = 50,
                        Image = Properties.Resources.trash_bin_20_20,
                        ImageAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand,

                        //Text = "X",
                        //BackColor = System.Drawing.Color.FromArgb(220, 53, 69),
                        //ForeColor = System.Drawing.Color.White,
                        //FlatStyle = FlatStyle.Flat
                    };
                    btnDeleteTab.FlatAppearance.BorderSize = 0;

                    // Evento de deletar a TabPage
                    btnDeleteTab.Click += (s, e) =>
                    {
                        if (tabControlExcelContainer.TabPages.Count > 1)
                        {
                            tabControlExcelContainer.TabPages.Remove(tabPage);

                        }
                    };

                    // >>> Horizontal Container for TextBox + Button <<<
                    Panel horizontalContainer = new Panel()
                    {
                        Dock = DockStyle.Top,
                        Height = 30
                    };
                    horizontalContainer.Controls.Add(txt);
                    horizontalContainer.Controls.Add(btnDeleteTab);

                    // >>> Label do título <<<
                    Label lbl = new Label()
                    {
                        Dock = DockStyle.Top,
                        Text = "Nome do perfil:",
                        AutoSize = false,
                        Height = 24,
                        ForeColor = System.Drawing.Color.FromArgb(46, 80, 159),
                        Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
                    };

                    // >>> Divisor topo <<<
                    Panel divisor_01 = new Panel()
                    {
                        Dock = DockStyle.Top,
                        Height = 8
                    };

                    // >>> Ordem de Adição (Bottom-Up) <<<
                    tabPage.Controls.Add(container_Grid);    // Fill (DGV)
                    tabPage.Controls.Add(divisor_02);        // Spacer
                    tabPage.Controls.Add(horizontalContainer); // TextBox + Button
                    tabPage.Controls.Add(lbl);               // Title
                    tabPage.Controls.Add(divisor_01);        // Top Spacer

                    tabControlExcelContainer.Controls.Add(tabPage);
                }
            }
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
                    _settings.ExcelHeaderProfiles = GetCurrentExcelConfig();
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
                LoadExcelConfig();
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

        private void button4_Click(object sender, EventArgs e)
        {
            AddExcelProfile();
        }
    }
}
