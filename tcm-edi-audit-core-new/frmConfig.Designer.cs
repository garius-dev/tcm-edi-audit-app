namespace tcm_edi_audit_core_new
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            tabsConfigs = new TabControl();
            tabCodes = new TabPage();
            pnlTabCodes = new Panel();
            tblCodesMain = new TableLayoutPanel();
            tblCodesBottom = new TableLayoutPanel();
            pnlCodesBot1 = new Panel();
            dgvVehicles = new DataGridView();
            lblVehiclesTitle = new Label();
            pnlCodesBot0 = new Panel();
            dgvFlow = new DataGridView();
            lblFlowTitle = new Label();
            pnlCodesTop0 = new Panel();
            dgvBranches = new DataGridView();
            lblBranchTitle = new Label();
            tabPositions = new TabPage();
            pnlTabPositions = new Panel();
            pnlPositionsMain = new Panel();
            dgvEdiFieldValidationSettings = new DataGridView();
            pnlPositionsTop = new Panel();
            lblDataTypeTitle = new Label();
            lblLineCodeTitle = new Label();
            cmbDataType = new ComboBox();
            cmbLineCode = new ComboBox();
            tabDefinitions = new TabPage();
            pnlTabDefinitions = new Panel();
            dgvCodeDefinitions = new DataGridView();
            lblLineConfigTitle = new Label();
            tabExcel = new TabPage();
            pnlTabExcel = new Panel();
            tabAdmins = new TabPage();
            pnlTabAdmins = new Panel();
            tblsAdminsMain = new TableLayoutPanel();
            tabAdminsPanel2 = new Panel();
            tabAdminsPanel1 = new Panel();
            tabAdminsPanel0 = new Panel();
            dgvAdmins = new DataGridView();
            lblAdminsTitle = new Label();
            pnlFooter = new Panel();
            picLoadingGif = new PictureBox();
            btnSave = new Button();
            label1 = new Label();
            btnClose = new Button();
            pnlTopFrame = new Panel();
            lblFormTitle = new Label();
            pnlTopSideContainer = new Panel();
            picLogo = new PictureBox();
            pnlExcelTop = new Panel();
            lblWorkSheetTitle = new Label();
            panel2 = new Panel();
            dgvExcelConfig = new DataGridView();
            lblExcelConfigTitle = new Label();
            txtWorkSheetName = new TextBox();
            pnlMain.SuspendLayout();
            tabsConfigs.SuspendLayout();
            tabCodes.SuspendLayout();
            pnlTabCodes.SuspendLayout();
            tblCodesMain.SuspendLayout();
            tblCodesBottom.SuspendLayout();
            pnlCodesBot1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            pnlCodesBot0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlow).BeginInit();
            pnlCodesTop0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBranches).BeginInit();
            tabPositions.SuspendLayout();
            pnlTabPositions.SuspendLayout();
            pnlPositionsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEdiFieldValidationSettings).BeginInit();
            pnlPositionsTop.SuspendLayout();
            tabDefinitions.SuspendLayout();
            pnlTabDefinitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCodeDefinitions).BeginInit();
            tabExcel.SuspendLayout();
            pnlTabExcel.SuspendLayout();
            tabAdmins.SuspendLayout();
            pnlTabAdmins.SuspendLayout();
            tblsAdminsMain.SuspendLayout();
            tabAdminsPanel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoadingGif).BeginInit();
            pnlTopFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlExcelTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExcelConfig).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(tabsConfigs);
            pnlMain.Controls.Add(pnlFooter);
            pnlMain.Controls.Add(pnlTopFrame);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(8, 8);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1170, 679);
            pnlMain.TabIndex = 1;
            // 
            // tabsConfigs
            // 
            tabsConfigs.Controls.Add(tabCodes);
            tabsConfigs.Controls.Add(tabPositions);
            tabsConfigs.Controls.Add(tabDefinitions);
            tabsConfigs.Controls.Add(tabExcel);
            tabsConfigs.Controls.Add(tabAdmins);
            tabsConfigs.Dock = DockStyle.Fill;
            tabsConfigs.Location = new Point(0, 80);
            tabsConfigs.Name = "tabsConfigs";
            tabsConfigs.SelectedIndex = 0;
            tabsConfigs.Size = new Size(1170, 539);
            tabsConfigs.TabIndex = 8;
            // 
            // tabCodes
            // 
            tabCodes.BackColor = Color.FromArgb(46, 80, 159);
            tabCodes.Controls.Add(pnlTabCodes);
            tabCodes.Location = new Point(4, 29);
            tabCodes.Name = "tabCodes";
            tabCodes.Size = new Size(1162, 506);
            tabCodes.TabIndex = 0;
            tabCodes.Text = "Códigos";
            // 
            // pnlTabCodes
            // 
            pnlTabCodes.BackColor = Color.White;
            pnlTabCodes.Controls.Add(tblCodesMain);
            pnlTabCodes.Dock = DockStyle.Fill;
            pnlTabCodes.Location = new Point(0, 0);
            pnlTabCodes.Name = "pnlTabCodes";
            pnlTabCodes.Size = new Size(1162, 506);
            pnlTabCodes.TabIndex = 0;
            // 
            // tblCodesMain
            // 
            tblCodesMain.ColumnCount = 1;
            tblCodesMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCodesMain.Controls.Add(tblCodesBottom, 0, 1);
            tblCodesMain.Controls.Add(pnlCodesTop0, 0, 0);
            tblCodesMain.Dock = DockStyle.Fill;
            tblCodesMain.Location = new Point(0, 0);
            tblCodesMain.Margin = new Padding(0);
            tblCodesMain.Name = "tblCodesMain";
            tblCodesMain.RowCount = 2;
            tblCodesMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblCodesMain.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblCodesMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCodesMain.Size = new Size(1162, 506);
            tblCodesMain.TabIndex = 0;
            // 
            // tblCodesBottom
            // 
            tblCodesBottom.ColumnCount = 2;
            tblCodesBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCodesBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCodesBottom.Controls.Add(pnlCodesBot1, 1, 0);
            tblCodesBottom.Controls.Add(pnlCodesBot0, 0, 0);
            tblCodesBottom.Dock = DockStyle.Fill;
            tblCodesBottom.Location = new Point(0, 202);
            tblCodesBottom.Margin = new Padding(0);
            tblCodesBottom.Name = "tblCodesBottom";
            tblCodesBottom.RowCount = 1;
            tblCodesBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCodesBottom.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCodesBottom.Size = new Size(1162, 304);
            tblCodesBottom.TabIndex = 0;
            // 
            // pnlCodesBot1
            // 
            pnlCodesBot1.Controls.Add(dgvVehicles);
            pnlCodesBot1.Controls.Add(lblVehiclesTitle);
            pnlCodesBot1.Dock = DockStyle.Fill;
            pnlCodesBot1.Location = new Point(581, 0);
            pnlCodesBot1.Margin = new Padding(0);
            pnlCodesBot1.Name = "pnlCodesBot1";
            pnlCodesBot1.Padding = new Padding(6, 3, 6, 6);
            pnlCodesBot1.Size = new Size(581, 304);
            pnlCodesBot1.TabIndex = 3;
            // 
            // dgvVehicles
            // 
            dgvVehicles.BackgroundColor = SystemColors.Control;
            dgvVehicles.BorderStyle = BorderStyle.None;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Dock = DockStyle.Fill;
            dgvVehicles.Location = new Point(6, 33);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.RowHeadersWidth = 51;
            dgvVehicles.Size = new Size(569, 265);
            dgvVehicles.TabIndex = 5;
            // 
            // lblVehiclesTitle
            // 
            lblVehiclesTitle.Dock = DockStyle.Top;
            lblVehiclesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVehiclesTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblVehiclesTitle.Location = new Point(6, 3);
            lblVehiclesTitle.Margin = new Padding(0);
            lblVehiclesTitle.Name = "lblVehiclesTitle";
            lblVehiclesTitle.Size = new Size(569, 30);
            lblVehiclesTitle.TabIndex = 4;
            lblVehiclesTitle.Text = "Veículos:";
            lblVehiclesTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCodesBot0
            // 
            pnlCodesBot0.Controls.Add(dgvFlow);
            pnlCodesBot0.Controls.Add(lblFlowTitle);
            pnlCodesBot0.Dock = DockStyle.Fill;
            pnlCodesBot0.Location = new Point(0, 0);
            pnlCodesBot0.Margin = new Padding(0);
            pnlCodesBot0.Name = "pnlCodesBot0";
            pnlCodesBot0.Padding = new Padding(6, 3, 6, 6);
            pnlCodesBot0.Size = new Size(581, 304);
            pnlCodesBot0.TabIndex = 2;
            // 
            // dgvFlow
            // 
            dgvFlow.BackgroundColor = SystemColors.Control;
            dgvFlow.BorderStyle = BorderStyle.None;
            dgvFlow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlow.Dock = DockStyle.Fill;
            dgvFlow.Location = new Point(6, 33);
            dgvFlow.Name = "dgvFlow";
            dgvFlow.RowHeadersWidth = 51;
            dgvFlow.Size = new Size(569, 265);
            dgvFlow.TabIndex = 5;
            // 
            // lblFlowTitle
            // 
            lblFlowTitle.Dock = DockStyle.Top;
            lblFlowTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFlowTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblFlowTitle.Location = new Point(6, 3);
            lblFlowTitle.Margin = new Padding(0);
            lblFlowTitle.Name = "lblFlowTitle";
            lblFlowTitle.Size = new Size(569, 30);
            lblFlowTitle.TabIndex = 4;
            lblFlowTitle.Text = "Fluxo:";
            lblFlowTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCodesTop0
            // 
            pnlCodesTop0.Controls.Add(dgvBranches);
            pnlCodesTop0.Controls.Add(lblBranchTitle);
            pnlCodesTop0.Dock = DockStyle.Fill;
            pnlCodesTop0.Location = new Point(0, 0);
            pnlCodesTop0.Margin = new Padding(0);
            pnlCodesTop0.Name = "pnlCodesTop0";
            pnlCodesTop0.Padding = new Padding(6, 6, 6, 3);
            pnlCodesTop0.Size = new Size(1162, 202);
            pnlCodesTop0.TabIndex = 1;
            // 
            // dgvBranches
            // 
            dgvBranches.BackgroundColor = SystemColors.Control;
            dgvBranches.BorderStyle = BorderStyle.None;
            dgvBranches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBranches.Dock = DockStyle.Fill;
            dgvBranches.Location = new Point(6, 36);
            dgvBranches.Name = "dgvBranches";
            dgvBranches.RowHeadersWidth = 51;
            dgvBranches.Size = new Size(1150, 163);
            dgvBranches.TabIndex = 4;
            // 
            // lblBranchTitle
            // 
            lblBranchTitle.Dock = DockStyle.Top;
            lblBranchTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBranchTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblBranchTitle.Location = new Point(6, 6);
            lblBranchTitle.Margin = new Padding(0);
            lblBranchTitle.Name = "lblBranchTitle";
            lblBranchTitle.Size = new Size(1150, 30);
            lblBranchTitle.TabIndex = 3;
            lblBranchTitle.Text = "Filiais:";
            lblBranchTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPositions
            // 
            tabPositions.BackColor = Color.FromArgb(46, 80, 159);
            tabPositions.Controls.Add(pnlTabPositions);
            tabPositions.Location = new Point(4, 29);
            tabPositions.Name = "tabPositions";
            tabPositions.Size = new Size(1162, 506);
            tabPositions.TabIndex = 1;
            tabPositions.Text = "Posições";
            // 
            // pnlTabPositions
            // 
            pnlTabPositions.BackColor = Color.White;
            pnlTabPositions.Controls.Add(pnlPositionsMain);
            pnlTabPositions.Controls.Add(pnlPositionsTop);
            pnlTabPositions.Dock = DockStyle.Fill;
            pnlTabPositions.Location = new Point(0, 0);
            pnlTabPositions.Name = "pnlTabPositions";
            pnlTabPositions.Size = new Size(1162, 506);
            pnlTabPositions.TabIndex = 1;
            // 
            // pnlPositionsMain
            // 
            pnlPositionsMain.BackColor = Color.Transparent;
            pnlPositionsMain.Controls.Add(dgvEdiFieldValidationSettings);
            pnlPositionsMain.Dock = DockStyle.Fill;
            pnlPositionsMain.Location = new Point(0, 79);
            pnlPositionsMain.Margin = new Padding(0, 6, 0, 0);
            pnlPositionsMain.Name = "pnlPositionsMain";
            pnlPositionsMain.Padding = new Padding(6);
            pnlPositionsMain.Size = new Size(1162, 427);
            pnlPositionsMain.TabIndex = 1;
            // 
            // dgvEdiFieldValidationSettings
            // 
            dgvEdiFieldValidationSettings.AllowUserToAddRows = false;
            dgvEdiFieldValidationSettings.AllowUserToDeleteRows = false;
            dgvEdiFieldValidationSettings.BackgroundColor = SystemColors.Control;
            dgvEdiFieldValidationSettings.BorderStyle = BorderStyle.None;
            dgvEdiFieldValidationSettings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEdiFieldValidationSettings.Dock = DockStyle.Fill;
            dgvEdiFieldValidationSettings.Location = new Point(6, 6);
            dgvEdiFieldValidationSettings.Name = "dgvEdiFieldValidationSettings";
            dgvEdiFieldValidationSettings.RowHeadersWidth = 51;
            dgvEdiFieldValidationSettings.Size = new Size(1150, 415);
            dgvEdiFieldValidationSettings.TabIndex = 2;
            // 
            // pnlPositionsTop
            // 
            pnlPositionsTop.BackColor = Color.Transparent;
            pnlPositionsTop.Controls.Add(lblDataTypeTitle);
            pnlPositionsTop.Controls.Add(lblLineCodeTitle);
            pnlPositionsTop.Controls.Add(cmbDataType);
            pnlPositionsTop.Controls.Add(cmbLineCode);
            pnlPositionsTop.Dock = DockStyle.Top;
            pnlPositionsTop.Location = new Point(0, 0);
            pnlPositionsTop.Margin = new Padding(0);
            pnlPositionsTop.Name = "pnlPositionsTop";
            pnlPositionsTop.Size = new Size(1162, 79);
            pnlPositionsTop.TabIndex = 0;
            // 
            // lblDataTypeTitle
            // 
            lblDataTypeTitle.AutoSize = true;
            lblDataTypeTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDataTypeTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblDataTypeTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblDataTypeTitle.Location = new Point(297, 13);
            lblDataTypeTitle.Name = "lblDataTypeTitle";
            lblDataTypeTitle.Size = new Size(123, 23);
            lblDataTypeTitle.TabIndex = 3;
            lblDataTypeTitle.Text = "Tipo do dado:";
            // 
            // lblLineCodeTitle
            // 
            lblLineCodeTitle.AutoSize = true;
            lblLineCodeTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLineCodeTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblLineCodeTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblLineCodeTitle.Location = new Point(6, 13);
            lblLineCodeTitle.Name = "lblLineCodeTitle";
            lblLineCodeTitle.Size = new Size(142, 23);
            lblLineCodeTitle.TabIndex = 2;
            lblLineCodeTitle.Text = "Código da linha:";
            // 
            // cmbDataType
            // 
            cmbDataType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbDataType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDataType.Font = new Font("Segoe UI", 12F);
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Location = new Point(297, 39);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new Size(285, 36);
            cmbDataType.TabIndex = 1;
            cmbDataType.SelectedIndexChanged += cmbDataType_SelectedIndexChanged;
            // 
            // cmbLineCode
            // 
            cmbLineCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbLineCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLineCode.Font = new Font("Segoe UI", 12F);
            cmbLineCode.FormattingEnabled = true;
            cmbLineCode.Location = new Point(6, 39);
            cmbLineCode.Name = "cmbLineCode";
            cmbLineCode.Size = new Size(285, 36);
            cmbLineCode.TabIndex = 0;
            cmbLineCode.SelectedIndexChanged += cmbLineCode_SelectedIndexChanged;
            // 
            // tabDefinitions
            // 
            tabDefinitions.BackColor = Color.FromArgb(46, 80, 159);
            tabDefinitions.Controls.Add(pnlTabDefinitions);
            tabDefinitions.Location = new Point(4, 29);
            tabDefinitions.Name = "tabDefinitions";
            tabDefinitions.Size = new Size(1162, 506);
            tabDefinitions.TabIndex = 2;
            tabDefinitions.Text = "Definições";
            // 
            // pnlTabDefinitions
            // 
            pnlTabDefinitions.BackColor = Color.White;
            pnlTabDefinitions.Controls.Add(dgvCodeDefinitions);
            pnlTabDefinitions.Controls.Add(lblLineConfigTitle);
            pnlTabDefinitions.Dock = DockStyle.Fill;
            pnlTabDefinitions.Location = new Point(0, 0);
            pnlTabDefinitions.Margin = new Padding(0);
            pnlTabDefinitions.Name = "pnlTabDefinitions";
            pnlTabDefinitions.Padding = new Padding(6);
            pnlTabDefinitions.Size = new Size(1162, 506);
            pnlTabDefinitions.TabIndex = 1;
            // 
            // dgvCodeDefinitions
            // 
            dgvCodeDefinitions.AllowUserToAddRows = false;
            dgvCodeDefinitions.AllowUserToDeleteRows = false;
            dgvCodeDefinitions.BackgroundColor = SystemColors.Control;
            dgvCodeDefinitions.BorderStyle = BorderStyle.None;
            dgvCodeDefinitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCodeDefinitions.Dock = DockStyle.Fill;
            dgvCodeDefinitions.Location = new Point(6, 36);
            dgvCodeDefinitions.Name = "dgvCodeDefinitions";
            dgvCodeDefinitions.RowHeadersWidth = 51;
            dgvCodeDefinitions.Size = new Size(1150, 464);
            dgvCodeDefinitions.TabIndex = 7;
            // 
            // lblLineConfigTitle
            // 
            lblLineConfigTitle.Dock = DockStyle.Top;
            lblLineConfigTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLineConfigTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblLineConfigTitle.Location = new Point(6, 6);
            lblLineConfigTitle.Margin = new Padding(0);
            lblLineConfigTitle.Name = "lblLineConfigTitle";
            lblLineConfigTitle.Size = new Size(1150, 30);
            lblLineConfigTitle.TabIndex = 6;
            lblLineConfigTitle.Text = "Configurações das linhas:";
            lblLineConfigTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabExcel
            // 
            tabExcel.BackColor = Color.FromArgb(46, 80, 159);
            tabExcel.Controls.Add(pnlTabExcel);
            tabExcel.Location = new Point(4, 29);
            tabExcel.Name = "tabExcel";
            tabExcel.Size = new Size(1162, 506);
            tabExcel.TabIndex = 3;
            tabExcel.Text = "Excel";
            // 
            // pnlTabExcel
            // 
            pnlTabExcel.BackColor = Color.White;
            pnlTabExcel.Controls.Add(panel2);
            pnlTabExcel.Controls.Add(pnlExcelTop);
            pnlTabExcel.Dock = DockStyle.Fill;
            pnlTabExcel.Location = new Point(0, 0);
            pnlTabExcel.Margin = new Padding(0);
            pnlTabExcel.Name = "pnlTabExcel";
            pnlTabExcel.Size = new Size(1162, 506);
            pnlTabExcel.TabIndex = 1;
            // 
            // tabAdmins
            // 
            tabAdmins.BackColor = Color.White;
            tabAdmins.Controls.Add(pnlTabAdmins);
            tabAdmins.Location = new Point(4, 29);
            tabAdmins.Name = "tabAdmins";
            tabAdmins.Padding = new Padding(6);
            tabAdmins.Size = new Size(1162, 506);
            tabAdmins.TabIndex = 4;
            tabAdmins.Text = "Administradores";
            // 
            // pnlTabAdmins
            // 
            pnlTabAdmins.BackColor = Color.White;
            pnlTabAdmins.Controls.Add(tblsAdminsMain);
            pnlTabAdmins.Dock = DockStyle.Fill;
            pnlTabAdmins.Location = new Point(6, 6);
            pnlTabAdmins.Margin = new Padding(0);
            pnlTabAdmins.Name = "pnlTabAdmins";
            pnlTabAdmins.Size = new Size(1150, 494);
            pnlTabAdmins.TabIndex = 1;
            // 
            // tblsAdminsMain
            // 
            tblsAdminsMain.ColumnCount = 3;
            tblsAdminsMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblsAdminsMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblsAdminsMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblsAdminsMain.Controls.Add(tabAdminsPanel2, 2, 0);
            tblsAdminsMain.Controls.Add(tabAdminsPanel1, 1, 0);
            tblsAdminsMain.Controls.Add(tabAdminsPanel0, 0, 0);
            tblsAdminsMain.Dock = DockStyle.Fill;
            tblsAdminsMain.Location = new Point(0, 0);
            tblsAdminsMain.Margin = new Padding(0);
            tblsAdminsMain.Name = "tblsAdminsMain";
            tblsAdminsMain.RowCount = 1;
            tblsAdminsMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblsAdminsMain.Size = new Size(1150, 494);
            tblsAdminsMain.TabIndex = 0;
            // 
            // tabAdminsPanel2
            // 
            tabAdminsPanel2.Dock = DockStyle.Fill;
            tabAdminsPanel2.Location = new Point(805, 0);
            tabAdminsPanel2.Margin = new Padding(0);
            tabAdminsPanel2.Name = "tabAdminsPanel2";
            tabAdminsPanel2.Padding = new Padding(3, 0, 0, 0);
            tabAdminsPanel2.Size = new Size(345, 494);
            tabAdminsPanel2.TabIndex = 2;
            // 
            // tabAdminsPanel1
            // 
            tabAdminsPanel1.Dock = DockStyle.Fill;
            tabAdminsPanel1.Location = new Point(460, 0);
            tabAdminsPanel1.Margin = new Padding(0);
            tabAdminsPanel1.Name = "tabAdminsPanel1";
            tabAdminsPanel1.Padding = new Padding(3, 0, 3, 0);
            tabAdminsPanel1.Size = new Size(345, 494);
            tabAdminsPanel1.TabIndex = 1;
            // 
            // tabAdminsPanel0
            // 
            tabAdminsPanel0.Controls.Add(dgvAdmins);
            tabAdminsPanel0.Controls.Add(lblAdminsTitle);
            tabAdminsPanel0.Dock = DockStyle.Fill;
            tabAdminsPanel0.Location = new Point(0, 0);
            tabAdminsPanel0.Margin = new Padding(0);
            tabAdminsPanel0.Name = "tabAdminsPanel0";
            tabAdminsPanel0.Padding = new Padding(0, 0, 3, 0);
            tabAdminsPanel0.Size = new Size(460, 494);
            tabAdminsPanel0.TabIndex = 0;
            // 
            // dgvAdmins
            // 
            dgvAdmins.BackgroundColor = SystemColors.Control;
            dgvAdmins.BorderStyle = BorderStyle.None;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Dock = DockStyle.Fill;
            dgvAdmins.Location = new Point(0, 30);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.Size = new Size(457, 464);
            dgvAdmins.TabIndex = 7;
            // 
            // lblAdminsTitle
            // 
            lblAdminsTitle.Dock = DockStyle.Top;
            lblAdminsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdminsTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblAdminsTitle.Location = new Point(0, 0);
            lblAdminsTitle.Margin = new Padding(0);
            lblAdminsTitle.Name = "lblAdminsTitle";
            lblAdminsTitle.Size = new Size(457, 30);
            lblAdminsTitle.TabIndex = 6;
            lblAdminsTitle.Text = "Administradores:";
            lblAdminsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(picLoadingGif);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Controls.Add(label1);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 619);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(6);
            pnlFooter.Size = new Size(1170, 60);
            pnlFooter.TabIndex = 7;
            // 
            // picLoadingGif
            // 
            picLoadingGif.Dock = DockStyle.Right;
            picLoadingGif.Image = Properties.Resources.loading_35;
            picLoadingGif.Location = new Point(784, 6);
            picLoadingGif.Name = "picLoadingGif";
            picLoadingGif.Padding = new Padding(7);
            picLoadingGif.Size = new Size(52, 48);
            picLoadingGif.SizeMode = PictureBoxSizeMode.CenterImage;
            picLoadingGif.TabIndex = 17;
            picLoadingGif.TabStop = false;
            picLoadingGif.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Dock = DockStyle.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 126, 52);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 136, 56);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(836, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 48);
            btnSave.TabIndex = 14;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(996, 6);
            label1.Name = "label1";
            label1.Size = new Size(8, 48);
            label1.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(108, 117, 125);
            btnClose.Cursor = Cursors.Hand;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 91, 98);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 98, 104);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1004, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 48);
            btnClose.TabIndex = 12;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlTopFrame
            // 
            pnlTopFrame.BackColor = Color.WhiteSmoke;
            pnlTopFrame.Controls.Add(lblFormTitle);
            pnlTopFrame.Controls.Add(pnlTopSideContainer);
            pnlTopFrame.Controls.Add(picLogo);
            pnlTopFrame.Dock = DockStyle.Top;
            pnlTopFrame.Location = new Point(0, 0);
            pnlTopFrame.Name = "pnlTopFrame";
            pnlTopFrame.Padding = new Padding(8);
            pnlTopFrame.Size = new Size(1170, 80);
            pnlTopFrame.TabIndex = 6;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblFormTitle.Location = new Point(141, 8);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Padding = new Padding(16, 0, 0, 0);
            lblFormTitle.Size = new Size(771, 64);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "EDI AUDIT - Configurações";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSideContainer
            // 
            pnlTopSideContainer.Dock = DockStyle.Right;
            pnlTopSideContainer.Location = new Point(912, 8);
            pnlTopSideContainer.Name = "pnlTopSideContainer";
            pnlTopSideContainer.Size = new Size(250, 64);
            pnlTopSideContainer.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Left;
            picLogo.Image = Properties.Resources.logo_novo;
            picLogo.Location = new Point(8, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(133, 64);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlExcelTop
            // 
            pnlExcelTop.BackColor = Color.Transparent;
            pnlExcelTop.Controls.Add(txtWorkSheetName);
            pnlExcelTop.Controls.Add(lblWorkSheetTitle);
            pnlExcelTop.Dock = DockStyle.Top;
            pnlExcelTop.Location = new Point(0, 0);
            pnlExcelTop.Margin = new Padding(0);
            pnlExcelTop.Name = "pnlExcelTop";
            pnlExcelTop.Size = new Size(1162, 79);
            pnlExcelTop.TabIndex = 1;
            // 
            // lblWorkSheetTitle
            // 
            lblWorkSheetTitle.AutoSize = true;
            lblWorkSheetTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWorkSheetTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblWorkSheetTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblWorkSheetTitle.Location = new Point(6, 13);
            lblWorkSheetTitle.Name = "lblWorkSheetTitle";
            lblWorkSheetTitle.Size = new Size(122, 23);
            lblWorkSheetTitle.TabIndex = 2;
            lblWorkSheetTitle.Text = "Nome da aba:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvExcelConfig);
            panel2.Controls.Add(lblExcelConfigTitle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 79);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6);
            panel2.Size = new Size(1162, 427);
            panel2.TabIndex = 4;
            // 
            // dgvExcelConfig
            // 
            dgvExcelConfig.AllowUserToAddRows = false;
            dgvExcelConfig.AllowUserToDeleteRows = false;
            dgvExcelConfig.BackgroundColor = SystemColors.Control;
            dgvExcelConfig.BorderStyle = BorderStyle.None;
            dgvExcelConfig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcelConfig.Dock = DockStyle.Fill;
            dgvExcelConfig.Location = new Point(6, 36);
            dgvExcelConfig.Name = "dgvExcelConfig";
            dgvExcelConfig.RowHeadersWidth = 51;
            dgvExcelConfig.Size = new Size(1150, 385);
            dgvExcelConfig.TabIndex = 7;
            // 
            // lblExcelConfigTitle
            // 
            lblExcelConfigTitle.Dock = DockStyle.Top;
            lblExcelConfigTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblExcelConfigTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblExcelConfigTitle.Location = new Point(6, 6);
            lblExcelConfigTitle.Margin = new Padding(0);
            lblExcelConfigTitle.Name = "lblExcelConfigTitle";
            lblExcelConfigTitle.Size = new Size(1150, 30);
            lblExcelConfigTitle.TabIndex = 6;
            lblExcelConfigTitle.Text = "Configuração do Excel:";
            lblExcelConfigTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtWorkSheetName
            // 
            txtWorkSheetName.Font = new Font("Segoe UI", 12F);
            txtWorkSheetName.Location = new Point(6, 39);
            txtWorkSheetName.Name = "txtWorkSheetName";
            txtWorkSheetName.Size = new Size(519, 34);
            txtWorkSheetName.TabIndex = 4;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(46, 80, 159);
            ClientSize = new Size(1186, 695);
            Controls.Add(pnlMain);
            Name = "frmConfig";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDI AUDIT - Configurações";
            Load += frmConfig_Load;
            pnlMain.ResumeLayout(false);
            tabsConfigs.ResumeLayout(false);
            tabCodes.ResumeLayout(false);
            pnlTabCodes.ResumeLayout(false);
            tblCodesMain.ResumeLayout(false);
            tblCodesBottom.ResumeLayout(false);
            pnlCodesBot1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            pnlCodesBot0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFlow).EndInit();
            pnlCodesTop0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBranches).EndInit();
            tabPositions.ResumeLayout(false);
            pnlTabPositions.ResumeLayout(false);
            pnlPositionsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEdiFieldValidationSettings).EndInit();
            pnlPositionsTop.ResumeLayout(false);
            pnlPositionsTop.PerformLayout();
            tabDefinitions.ResumeLayout(false);
            pnlTabDefinitions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCodeDefinitions).EndInit();
            tabExcel.ResumeLayout(false);
            pnlTabExcel.ResumeLayout(false);
            tabAdmins.ResumeLayout(false);
            pnlTabAdmins.ResumeLayout(false);
            tblsAdminsMain.ResumeLayout(false);
            tabAdminsPanel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLoadingGif).EndInit();
            pnlTopFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlExcelTop.ResumeLayout(false);
            pnlExcelTop.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExcelConfig).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlTopFrame;
        private Label lblFormTitle;
        private Panel pnlTopSideContainer;
        private PictureBox picLogo;
        private TabControl tabsConfigs;
        private TabPage tabCodes;
        private Panel pnlTabCodes;
        private TableLayoutPanel tblCodesMain;
        private TableLayoutPanel tblCodesBottom;
        private TabPage tabPositions;
        private Panel pnlTabPositions;
        private TabPage tabDefinitions;
        private Panel pnlTabDefinitions;
        private TabPage tabExcel;
        private Panel pnlTabExcel;
        private TabPage tabAdmins;
        private Panel pnlTabAdmins;
        private Panel pnlFooter;
        private Button btnSave;
        private Label label1;
        private Button btnClose;
        private Panel pnlPositionsMain;
        private Panel pnlPositionsTop;
        private ComboBox cmbLineCode;
        private ComboBox cmbDataType;
        private Label lblLineCodeTitle;
        private Label lblDataTypeTitle;
        private DataGridView dgvEdiFieldValidationSettings;
        private Panel pnlCodesTop0;
        private Panel pnlCodesBot1;
        private Panel pnlCodesBot0;
        private DataGridView dgvVehicles;
        private Label lblVehiclesTitle;
        private DataGridView dgvFlow;
        private Label lblFlowTitle;
        private DataGridView dgvBranches;
        private Label lblBranchTitle;
        private DataGridView dgvCodeDefinitions;
        private Label lblLineConfigTitle;
        private TableLayoutPanel tblsAdminsMain;
        private Panel tabAdminsPanel2;
        private Panel tabAdminsPanel1;
        private Panel tabAdminsPanel0;
        private DataGridView dgvAdmins;
        private Label lblAdminsTitle;
        private PictureBox picLoadingGif;
        private Panel panel2;
        private DataGridView dgvExcelConfig;
        private Label lblExcelConfigTitle;
        private Panel pnlExcelTop;
        private Label lblWorkSheetTitle;
        private TextBox txtWorkSheetName;
    }
}