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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
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
            pnlExcelContainer = new Panel();
            tabControlExcelContainer = new TabControl();
            panel1 = new Panel();
            button4 = new Button();
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
            pnlExcelTop = new Panel();
            txtWorkSheetName = new TextBox();
            lblWorkSheetTitle = new Label();
            panel2 = new Panel();
            dgvExcelConfig = new DataGridView();
            lblExcelConfigTitle = new Label();
            lblFormTitle = new Label();
            pnlTopSideContainer = new Panel();
            picLogo = new PictureBox();
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
            pnlExcelContainer.SuspendLayout();
            panel1.SuspendLayout();
            tabAdmins.SuspendLayout();
            pnlTabAdmins.SuspendLayout();
            tblsAdminsMain.SuspendLayout();
            tabAdminsPanel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoadingGif).BeginInit();
            pnlTopFrame.SuspendLayout();
            pnlExcelTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExcelConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(tabsConfigs);
            pnlMain.Controls.Add(pnlFooter);
            pnlMain.Controls.Add(pnlTopFrame);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(6, 6);
            pnlMain.Margin = new Padding(2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(937, 544);
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
            tabsConfigs.Location = new Point(0, 64);
            tabsConfigs.Margin = new Padding(2);
            tabsConfigs.Name = "tabsConfigs";
            tabsConfigs.SelectedIndex = 0;
            tabsConfigs.Size = new Size(937, 432);
            tabsConfigs.TabIndex = 8;
            // 
            // tabCodes
            // 
            tabCodes.BackColor = Color.FromArgb(46, 80, 159);
            tabCodes.Controls.Add(pnlTabCodes);
            tabCodes.Location = new Point(4, 24);
            tabCodes.Margin = new Padding(2);
            tabCodes.Name = "tabCodes";
            tabCodes.Size = new Size(929, 404);
            tabCodes.TabIndex = 0;
            tabCodes.Text = "Códigos";
            // 
            // pnlTabCodes
            // 
            pnlTabCodes.BackColor = Color.White;
            pnlTabCodes.Controls.Add(tblCodesMain);
            pnlTabCodes.Dock = DockStyle.Fill;
            pnlTabCodes.Location = new Point(0, 0);
            pnlTabCodes.Margin = new Padding(2);
            pnlTabCodes.Name = "pnlTabCodes";
            pnlTabCodes.Size = new Size(929, 404);
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
            tblCodesMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tblCodesMain.Size = new Size(929, 404);
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
            tblCodesBottom.Location = new Point(0, 161);
            tblCodesBottom.Margin = new Padding(0);
            tblCodesBottom.Name = "tblCodesBottom";
            tblCodesBottom.RowCount = 1;
            tblCodesBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCodesBottom.RowStyles.Add(new RowStyle(SizeType.Absolute, 243F));
            tblCodesBottom.Size = new Size(929, 243);
            tblCodesBottom.TabIndex = 0;
            // 
            // pnlCodesBot1
            // 
            pnlCodesBot1.Controls.Add(dgvVehicles);
            pnlCodesBot1.Controls.Add(lblVehiclesTitle);
            pnlCodesBot1.Dock = DockStyle.Fill;
            pnlCodesBot1.Location = new Point(464, 0);
            pnlCodesBot1.Margin = new Padding(0);
            pnlCodesBot1.Name = "pnlCodesBot1";
            pnlCodesBot1.Padding = new Padding(5, 2, 5, 5);
            pnlCodesBot1.Size = new Size(465, 243);
            pnlCodesBot1.TabIndex = 3;
            // 
            // dgvVehicles
            // 
            dgvVehicles.BackgroundColor = SystemColors.Control;
            dgvVehicles.BorderStyle = BorderStyle.None;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Dock = DockStyle.Fill;
            dgvVehicles.Location = new Point(5, 26);
            dgvVehicles.Margin = new Padding(2);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.RowHeadersWidth = 51;
            dgvVehicles.Size = new Size(455, 212);
            dgvVehicles.TabIndex = 5;
            // 
            // lblVehiclesTitle
            // 
            lblVehiclesTitle.Dock = DockStyle.Top;
            lblVehiclesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVehiclesTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblVehiclesTitle.Location = new Point(5, 2);
            lblVehiclesTitle.Margin = new Padding(0);
            lblVehiclesTitle.Name = "lblVehiclesTitle";
            lblVehiclesTitle.Size = new Size(455, 24);
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
            pnlCodesBot0.Padding = new Padding(5, 2, 5, 5);
            pnlCodesBot0.Size = new Size(464, 243);
            pnlCodesBot0.TabIndex = 2;
            // 
            // dgvFlow
            // 
            dgvFlow.BackgroundColor = SystemColors.Control;
            dgvFlow.BorderStyle = BorderStyle.None;
            dgvFlow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlow.Dock = DockStyle.Fill;
            dgvFlow.Location = new Point(5, 26);
            dgvFlow.Margin = new Padding(2);
            dgvFlow.Name = "dgvFlow";
            dgvFlow.RowHeadersWidth = 51;
            dgvFlow.Size = new Size(454, 212);
            dgvFlow.TabIndex = 5;
            // 
            // lblFlowTitle
            // 
            lblFlowTitle.Dock = DockStyle.Top;
            lblFlowTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFlowTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblFlowTitle.Location = new Point(5, 2);
            lblFlowTitle.Margin = new Padding(0);
            lblFlowTitle.Name = "lblFlowTitle";
            lblFlowTitle.Size = new Size(454, 24);
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
            pnlCodesTop0.Padding = new Padding(5, 5, 5, 2);
            pnlCodesTop0.Size = new Size(929, 161);
            pnlCodesTop0.TabIndex = 1;
            // 
            // dgvBranches
            // 
            dgvBranches.BackgroundColor = SystemColors.Control;
            dgvBranches.BorderStyle = BorderStyle.None;
            dgvBranches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBranches.Dock = DockStyle.Fill;
            dgvBranches.Location = new Point(5, 29);
            dgvBranches.Margin = new Padding(2);
            dgvBranches.Name = "dgvBranches";
            dgvBranches.RowHeadersWidth = 51;
            dgvBranches.Size = new Size(919, 130);
            dgvBranches.TabIndex = 4;
            // 
            // lblBranchTitle
            // 
            lblBranchTitle.Dock = DockStyle.Top;
            lblBranchTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBranchTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblBranchTitle.Location = new Point(5, 5);
            lblBranchTitle.Margin = new Padding(0);
            lblBranchTitle.Name = "lblBranchTitle";
            lblBranchTitle.Size = new Size(919, 24);
            lblBranchTitle.TabIndex = 3;
            lblBranchTitle.Text = "Filiais:";
            lblBranchTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPositions
            // 
            tabPositions.BackColor = Color.FromArgb(46, 80, 159);
            tabPositions.Controls.Add(pnlTabPositions);
            tabPositions.Location = new Point(4, 24);
            tabPositions.Margin = new Padding(2);
            tabPositions.Name = "tabPositions";
            tabPositions.Size = new Size(929, 404);
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
            pnlTabPositions.Margin = new Padding(2);
            pnlTabPositions.Name = "pnlTabPositions";
            pnlTabPositions.Size = new Size(929, 404);
            pnlTabPositions.TabIndex = 1;
            // 
            // pnlPositionsMain
            // 
            pnlPositionsMain.BackColor = Color.Transparent;
            pnlPositionsMain.Controls.Add(dgvEdiFieldValidationSettings);
            pnlPositionsMain.Dock = DockStyle.Fill;
            pnlPositionsMain.Location = new Point(0, 63);
            pnlPositionsMain.Margin = new Padding(0, 5, 0, 0);
            pnlPositionsMain.Name = "pnlPositionsMain";
            pnlPositionsMain.Padding = new Padding(5);
            pnlPositionsMain.Size = new Size(929, 341);
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
            dgvEdiFieldValidationSettings.Location = new Point(5, 5);
            dgvEdiFieldValidationSettings.Margin = new Padding(2);
            dgvEdiFieldValidationSettings.Name = "dgvEdiFieldValidationSettings";
            dgvEdiFieldValidationSettings.RowHeadersWidth = 51;
            dgvEdiFieldValidationSettings.Size = new Size(919, 331);
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
            pnlPositionsTop.Size = new Size(929, 63);
            pnlPositionsTop.TabIndex = 0;
            // 
            // lblDataTypeTitle
            // 
            lblDataTypeTitle.AutoSize = true;
            lblDataTypeTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDataTypeTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblDataTypeTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblDataTypeTitle.Location = new Point(238, 10);
            lblDataTypeTitle.Margin = new Padding(2, 0, 2, 0);
            lblDataTypeTitle.Name = "lblDataTypeTitle";
            lblDataTypeTitle.Size = new Size(104, 19);
            lblDataTypeTitle.TabIndex = 3;
            lblDataTypeTitle.Text = "Tipo do dado:";
            // 
            // lblLineCodeTitle
            // 
            lblLineCodeTitle.AutoSize = true;
            lblLineCodeTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLineCodeTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblLineCodeTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblLineCodeTitle.Location = new Point(5, 10);
            lblLineCodeTitle.Margin = new Padding(2, 0, 2, 0);
            lblLineCodeTitle.Name = "lblLineCodeTitle";
            lblLineCodeTitle.Size = new Size(119, 19);
            lblLineCodeTitle.TabIndex = 2;
            lblLineCodeTitle.Text = "Código da linha:";
            // 
            // cmbDataType
            // 
            cmbDataType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbDataType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDataType.Font = new Font("Segoe UI", 12F);
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Location = new Point(238, 31);
            cmbDataType.Margin = new Padding(2);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new Size(229, 29);
            cmbDataType.TabIndex = 1;
            cmbDataType.SelectedIndexChanged += cmbDataType_SelectedIndexChanged;
            // 
            // cmbLineCode
            // 
            cmbLineCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbLineCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLineCode.Font = new Font("Segoe UI", 12F);
            cmbLineCode.FormattingEnabled = true;
            cmbLineCode.Location = new Point(5, 31);
            cmbLineCode.Margin = new Padding(2);
            cmbLineCode.Name = "cmbLineCode";
            cmbLineCode.Size = new Size(229, 29);
            cmbLineCode.TabIndex = 0;
            cmbLineCode.SelectedIndexChanged += cmbLineCode_SelectedIndexChanged;
            // 
            // tabDefinitions
            // 
            tabDefinitions.BackColor = Color.FromArgb(46, 80, 159);
            tabDefinitions.Controls.Add(pnlTabDefinitions);
            tabDefinitions.Location = new Point(4, 24);
            tabDefinitions.Margin = new Padding(2);
            tabDefinitions.Name = "tabDefinitions";
            tabDefinitions.Size = new Size(929, 404);
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
            pnlTabDefinitions.Padding = new Padding(5);
            pnlTabDefinitions.Size = new Size(929, 404);
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
            dgvCodeDefinitions.Location = new Point(5, 29);
            dgvCodeDefinitions.Margin = new Padding(2);
            dgvCodeDefinitions.Name = "dgvCodeDefinitions";
            dgvCodeDefinitions.RowHeadersWidth = 51;
            dgvCodeDefinitions.Size = new Size(919, 370);
            dgvCodeDefinitions.TabIndex = 7;
            // 
            // lblLineConfigTitle
            // 
            lblLineConfigTitle.Dock = DockStyle.Top;
            lblLineConfigTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLineConfigTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblLineConfigTitle.Location = new Point(5, 5);
            lblLineConfigTitle.Margin = new Padding(0);
            lblLineConfigTitle.Name = "lblLineConfigTitle";
            lblLineConfigTitle.Size = new Size(919, 24);
            lblLineConfigTitle.TabIndex = 6;
            lblLineConfigTitle.Text = "Configurações das linhas:";
            lblLineConfigTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabExcel
            // 
            tabExcel.BackColor = Color.FromArgb(46, 80, 159);
            tabExcel.Controls.Add(pnlTabExcel);
            tabExcel.Location = new Point(4, 24);
            tabExcel.Margin = new Padding(2);
            tabExcel.Name = "tabExcel";
            tabExcel.Size = new Size(929, 404);
            tabExcel.TabIndex = 3;
            tabExcel.Text = "Excel";
            // 
            // pnlTabExcel
            // 
            pnlTabExcel.BackColor = Color.White;
            pnlTabExcel.Controls.Add(pnlExcelContainer);
            pnlTabExcel.Dock = DockStyle.Fill;
            pnlTabExcel.Location = new Point(0, 0);
            pnlTabExcel.Margin = new Padding(0);
            pnlTabExcel.Name = "pnlTabExcel";
            pnlTabExcel.Size = new Size(929, 404);
            pnlTabExcel.TabIndex = 1;
            // 
            // pnlExcelContainer
            // 
            pnlExcelContainer.Controls.Add(tabControlExcelContainer);
            pnlExcelContainer.Controls.Add(panel1);
            pnlExcelContainer.Dock = DockStyle.Fill;
            pnlExcelContainer.Location = new Point(0, 0);
            pnlExcelContainer.Name = "pnlExcelContainer";
            pnlExcelContainer.Padding = new Padding(6);
            pnlExcelContainer.Size = new Size(929, 404);
            pnlExcelContainer.TabIndex = 0;
            // 
            // tabControlExcelContainer
            // 
            tabControlExcelContainer.Dock = DockStyle.Fill;
            tabControlExcelContainer.Location = new Point(6, 51);
            tabControlExcelContainer.Margin = new Padding(0);
            tabControlExcelContainer.Name = "tabControlExcelContainer";
            tabControlExcelContainer.SelectedIndex = 0;
            tabControlExcelContainer.Size = new Size(917, 347);
            tabControlExcelContainer.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 45);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 123, 255);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 98, 204);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 105, 217);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.plus_icon_24_24;
            button4.Location = new Point(2, 6);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(139, 33);
            button4.TabIndex = 10;
            button4.Text = "Adicionar Perfil";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // tabAdmins
            // 
            tabAdmins.BackColor = Color.White;
            tabAdmins.Controls.Add(pnlTabAdmins);
            tabAdmins.Location = new Point(4, 24);
            tabAdmins.Margin = new Padding(2);
            tabAdmins.Name = "tabAdmins";
            tabAdmins.Padding = new Padding(5);
            tabAdmins.Size = new Size(929, 404);
            tabAdmins.TabIndex = 4;
            tabAdmins.Text = "Administradores";
            // 
            // pnlTabAdmins
            // 
            pnlTabAdmins.BackColor = Color.White;
            pnlTabAdmins.Controls.Add(tblsAdminsMain);
            pnlTabAdmins.Dock = DockStyle.Fill;
            pnlTabAdmins.Location = new Point(5, 5);
            pnlTabAdmins.Margin = new Padding(0);
            pnlTabAdmins.Name = "pnlTabAdmins";
            pnlTabAdmins.Size = new Size(919, 394);
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
            tblsAdminsMain.Size = new Size(919, 394);
            tblsAdminsMain.TabIndex = 0;
            // 
            // tabAdminsPanel2
            // 
            tabAdminsPanel2.Dock = DockStyle.Fill;
            tabAdminsPanel2.Location = new Point(642, 0);
            tabAdminsPanel2.Margin = new Padding(0);
            tabAdminsPanel2.Name = "tabAdminsPanel2";
            tabAdminsPanel2.Padding = new Padding(2, 0, 0, 0);
            tabAdminsPanel2.Size = new Size(277, 394);
            tabAdminsPanel2.TabIndex = 2;
            // 
            // tabAdminsPanel1
            // 
            tabAdminsPanel1.Dock = DockStyle.Fill;
            tabAdminsPanel1.Location = new Point(367, 0);
            tabAdminsPanel1.Margin = new Padding(0);
            tabAdminsPanel1.Name = "tabAdminsPanel1";
            tabAdminsPanel1.Padding = new Padding(2, 0, 2, 0);
            tabAdminsPanel1.Size = new Size(275, 394);
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
            tabAdminsPanel0.Padding = new Padding(0, 0, 2, 0);
            tabAdminsPanel0.Size = new Size(367, 394);
            tabAdminsPanel0.TabIndex = 0;
            // 
            // dgvAdmins
            // 
            dgvAdmins.BackgroundColor = SystemColors.Control;
            dgvAdmins.BorderStyle = BorderStyle.None;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Dock = DockStyle.Fill;
            dgvAdmins.Location = new Point(0, 24);
            dgvAdmins.Margin = new Padding(2);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.Size = new Size(365, 370);
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
            lblAdminsTitle.Size = new Size(365, 24);
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
            pnlFooter.Location = new Point(0, 496);
            pnlFooter.Margin = new Padding(2);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(5);
            pnlFooter.Size = new Size(937, 48);
            pnlFooter.TabIndex = 7;
            // 
            // picLoadingGif
            // 
            picLoadingGif.Dock = DockStyle.Right;
            picLoadingGif.Image = Properties.Resources.loading_35;
            picLoadingGif.Location = new Point(628, 5);
            picLoadingGif.Margin = new Padding(2);
            picLoadingGif.Name = "picLoadingGif";
            picLoadingGif.Padding = new Padding(6);
            picLoadingGif.Size = new Size(42, 38);
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
            btnSave.Location = new Point(670, 5);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 38);
            btnSave.TabIndex = 14;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(798, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(6, 38);
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
            btnClose.Location = new Point(804, 5);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 38);
            btnClose.TabIndex = 12;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlTopFrame
            // 
            pnlTopFrame.BackColor = Color.WhiteSmoke;
            pnlTopFrame.Controls.Add(pnlExcelTop);
            pnlTopFrame.Controls.Add(panel2);
            pnlTopFrame.Controls.Add(lblFormTitle);
            pnlTopFrame.Controls.Add(pnlTopSideContainer);
            pnlTopFrame.Controls.Add(picLogo);
            pnlTopFrame.Dock = DockStyle.Top;
            pnlTopFrame.Location = new Point(0, 0);
            pnlTopFrame.Margin = new Padding(2);
            pnlTopFrame.Name = "pnlTopFrame";
            pnlTopFrame.Padding = new Padding(6);
            pnlTopFrame.Size = new Size(937, 64);
            pnlTopFrame.TabIndex = 6;
            // 
            // pnlExcelTop
            // 
            pnlExcelTop.BackColor = Color.Transparent;
            pnlExcelTop.Controls.Add(txtWorkSheetName);
            pnlExcelTop.Controls.Add(lblWorkSheetTitle);
            pnlExcelTop.Enabled = false;
            pnlExcelTop.Location = new Point(547, 11);
            pnlExcelTop.Margin = new Padding(0);
            pnlExcelTop.Name = "pnlExcelTop";
            pnlExcelTop.Size = new Size(74, 38);
            pnlExcelTop.TabIndex = 1;
            pnlExcelTop.Visible = false;
            // 
            // txtWorkSheetName
            // 
            txtWorkSheetName.Font = new Font("Segoe UI", 12F);
            txtWorkSheetName.Location = new Point(5, 31);
            txtWorkSheetName.Margin = new Padding(2);
            txtWorkSheetName.Name = "txtWorkSheetName";
            txtWorkSheetName.Size = new Size(416, 29);
            txtWorkSheetName.TabIndex = 4;
            // 
            // lblWorkSheetTitle
            // 
            lblWorkSheetTitle.AutoSize = true;
            lblWorkSheetTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWorkSheetTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblWorkSheetTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblWorkSheetTitle.Location = new Point(5, 10);
            lblWorkSheetTitle.Margin = new Padding(2, 0, 2, 0);
            lblWorkSheetTitle.Name = "lblWorkSheetTitle";
            lblWorkSheetTitle.Size = new Size(104, 19);
            lblWorkSheetTitle.TabIndex = 2;
            lblWorkSheetTitle.Text = "Nome da aba:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvExcelConfig);
            panel2.Controls.Add(lblExcelConfigTitle);
            panel2.Enabled = false;
            panel2.Location = new Point(457, 20);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(78, 29);
            panel2.TabIndex = 4;
            panel2.Visible = false;
            // 
            // dgvExcelConfig
            // 
            dgvExcelConfig.AllowUserToAddRows = false;
            dgvExcelConfig.AllowUserToDeleteRows = false;
            dgvExcelConfig.BackgroundColor = SystemColors.Control;
            dgvExcelConfig.BorderStyle = BorderStyle.None;
            dgvExcelConfig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcelConfig.Dock = DockStyle.Fill;
            dgvExcelConfig.Location = new Point(5, 29);
            dgvExcelConfig.Margin = new Padding(2);
            dgvExcelConfig.Name = "dgvExcelConfig";
            dgvExcelConfig.RowHeadersWidth = 51;
            dgvExcelConfig.Size = new Size(68, 0);
            dgvExcelConfig.TabIndex = 7;
            // 
            // lblExcelConfigTitle
            // 
            lblExcelConfigTitle.Dock = DockStyle.Top;
            lblExcelConfigTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblExcelConfigTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblExcelConfigTitle.Location = new Point(5, 5);
            lblExcelConfigTitle.Margin = new Padding(0);
            lblExcelConfigTitle.Name = "lblExcelConfigTitle";
            lblExcelConfigTitle.Size = new Size(68, 24);
            lblExcelConfigTitle.TabIndex = 6;
            lblExcelConfigTitle.Text = "Configuração do Excel:";
            lblExcelConfigTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblFormTitle.Location = new Point(112, 6);
            lblFormTitle.Margin = new Padding(2, 0, 2, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Padding = new Padding(13, 0, 0, 0);
            lblFormTitle.Size = new Size(619, 52);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "EDI AUDIT - Configurações";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSideContainer
            // 
            pnlTopSideContainer.Dock = DockStyle.Right;
            pnlTopSideContainer.Location = new Point(731, 6);
            pnlTopSideContainer.Margin = new Padding(2);
            pnlTopSideContainer.Name = "pnlTopSideContainer";
            pnlTopSideContainer.Size = new Size(200, 52);
            pnlTopSideContainer.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Left;
            picLogo.Image = Properties.Resources.logo_novo;
            picLogo.Location = new Point(6, 6);
            picLogo.Margin = new Padding(2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(106, 52);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(46, 80, 159);
            ClientSize = new Size(949, 556);
            Controls.Add(pnlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmConfig";
            Padding = new Padding(6);
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
            pnlExcelContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabAdmins.ResumeLayout(false);
            pnlTabAdmins.ResumeLayout(false);
            tblsAdminsMain.ResumeLayout(false);
            tabAdminsPanel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLoadingGif).EndInit();
            pnlTopFrame.ResumeLayout(false);
            pnlExcelTop.ResumeLayout(false);
            pnlExcelTop.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExcelConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
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
        private Panel pnlExcelContainer;
        private TabControl tabControlExcelContainer;
        private Panel panel1;
        private Button button4;
    }
}