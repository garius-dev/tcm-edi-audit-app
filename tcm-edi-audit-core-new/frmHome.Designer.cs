namespace tcm_edi_audit_core_new
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            pnlMain = new Panel();
            pnlHomeMain = new Panel();
            pnlSeparator03 = new Panel();
            pnlHomeSectionTop03 = new Panel();
            pnlHomeFile01 = new Panel();
            txtExcelFilePath = new TextBox();
            lblSeparatorSection03 = new Label();
            btnExcelFile = new Button();
            lblExcelFilePathTitle = new Label();
            pnlSeparator02 = new Panel();
            pnlHomeSectionTop02 = new Panel();
            pnlHomeFolder02 = new Panel();
            txtOutputPath = new TextBox();
            lblSeparatorSection02 = new Label();
            btnOutputPath = new Button();
            lblOutputPathTitle = new Label();
            pnlSeparator01 = new Panel();
            pnlHomeSectionTop01 = new Panel();
            pnlHomeFolder01 = new Panel();
            txtFolderRootPath = new TextBox();
            lblSeparatorSection01 = new Label();
            btnRootFolderPath = new Button();
            lblFolderRootPathTitle = new Label();
            pnlHomeFooter = new Panel();
            picLoadingGif = new PictureBox();
            btnCheckFixFiles = new Button();
            btnAudit = new Button();
            pnlTopFrame = new Panel();
            lblFormTitle = new Label();
            pnlTopSideContainer = new Panel();
            btnConfig = new Button();
            picLogo = new PictureBox();
            pnlMain.SuspendLayout();
            pnlHomeMain.SuspendLayout();
            pnlHomeSectionTop03.SuspendLayout();
            pnlHomeFile01.SuspendLayout();
            pnlHomeSectionTop02.SuspendLayout();
            pnlHomeFolder02.SuspendLayout();
            pnlHomeSectionTop01.SuspendLayout();
            pnlHomeFolder01.SuspendLayout();
            pnlHomeFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoadingGif).BeginInit();
            pnlTopFrame.SuspendLayout();
            pnlTopSideContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(pnlHomeMain);
            pnlMain.Controls.Add(pnlHomeFooter);
            pnlMain.Controls.Add(pnlTopFrame);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(6, 6);
            pnlMain.Margin = new Padding(2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(631, 389);
            pnlMain.TabIndex = 1;
            // 
            // pnlHomeMain
            // 
            pnlHomeMain.Controls.Add(pnlSeparator03);
            pnlHomeMain.Controls.Add(pnlHomeSectionTop03);
            pnlHomeMain.Controls.Add(pnlSeparator02);
            pnlHomeMain.Controls.Add(pnlHomeSectionTop02);
            pnlHomeMain.Controls.Add(pnlSeparator01);
            pnlHomeMain.Controls.Add(pnlHomeSectionTop01);
            pnlHomeMain.Dock = DockStyle.Fill;
            pnlHomeMain.Location = new Point(0, 64);
            pnlHomeMain.Margin = new Padding(0);
            pnlHomeMain.Name = "pnlHomeMain";
            pnlHomeMain.Padding = new Padding(5, 5, 5, 0);
            pnlHomeMain.Size = new Size(631, 277);
            pnlHomeMain.TabIndex = 8;
            // 
            // pnlSeparator03
            // 
            pnlSeparator03.Dock = DockStyle.Top;
            pnlSeparator03.Location = new Point(5, 214);
            pnlSeparator03.Margin = new Padding(2);
            pnlSeparator03.Name = "pnlSeparator03";
            pnlSeparator03.Size = new Size(621, 13);
            pnlSeparator03.TabIndex = 6;
            // 
            // pnlHomeSectionTop03
            // 
            pnlHomeSectionTop03.Controls.Add(pnlHomeFile01);
            pnlHomeSectionTop03.Dock = DockStyle.Top;
            pnlHomeSectionTop03.Location = new Point(5, 153);
            pnlHomeSectionTop03.Margin = new Padding(0);
            pnlHomeSectionTop03.Name = "pnlHomeSectionTop03";
            pnlHomeSectionTop03.Padding = new Padding(5);
            pnlHomeSectionTop03.Size = new Size(621, 61);
            pnlHomeSectionTop03.TabIndex = 5;
            // 
            // pnlHomeFile01
            // 
            pnlHomeFile01.Controls.Add(txtExcelFilePath);
            pnlHomeFile01.Controls.Add(lblSeparatorSection03);
            pnlHomeFile01.Controls.Add(btnExcelFile);
            pnlHomeFile01.Controls.Add(lblExcelFilePathTitle);
            pnlHomeFile01.Dock = DockStyle.Fill;
            pnlHomeFile01.Location = new Point(5, 5);
            pnlHomeFile01.Margin = new Padding(0);
            pnlHomeFile01.Name = "pnlHomeFile01";
            pnlHomeFile01.Size = new Size(611, 51);
            pnlHomeFile01.TabIndex = 0;
            // 
            // txtExcelFilePath
            // 
            txtExcelFilePath.BackColor = Color.White;
            txtExcelFilePath.Dock = DockStyle.Fill;
            txtExcelFilePath.Font = new Font("Segoe UI", 12F);
            txtExcelFilePath.Location = new Point(0, 24);
            txtExcelFilePath.Margin = new Padding(0);
            txtExcelFilePath.Name = "txtExcelFilePath";
            txtExcelFilePath.ReadOnly = true;
            txtExcelFilePath.Size = new Size(565, 29);
            txtExcelFilePath.TabIndex = 15;
            // 
            // lblSeparatorSection03
            // 
            lblSeparatorSection03.Dock = DockStyle.Right;
            lblSeparatorSection03.Location = new Point(565, 24);
            lblSeparatorSection03.Margin = new Padding(2, 0, 2, 0);
            lblSeparatorSection03.Name = "lblSeparatorSection03";
            lblSeparatorSection03.Size = new Size(6, 27);
            lblSeparatorSection03.TabIndex = 14;
            // 
            // btnExcelFile
            // 
            btnExcelFile.Cursor = Cursors.Hand;
            btnExcelFile.Dock = DockStyle.Right;
            btnExcelFile.Image = Properties.Resources.excel_file_18_24;
            btnExcelFile.Location = new Point(571, 24);
            btnExcelFile.Margin = new Padding(0);
            btnExcelFile.Name = "btnExcelFile";
            btnExcelFile.Size = new Size(40, 27);
            btnExcelFile.TabIndex = 7;
            btnExcelFile.UseVisualStyleBackColor = true;
            btnExcelFile.Click += btnExcelFile_Click;
            // 
            // lblExcelFilePathTitle
            // 
            lblExcelFilePathTitle.Dock = DockStyle.Top;
            lblExcelFilePathTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblExcelFilePathTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblExcelFilePathTitle.Location = new Point(0, 0);
            lblExcelFilePathTitle.Margin = new Padding(0);
            lblExcelFilePathTitle.Name = "lblExcelFilePathTitle";
            lblExcelFilePathTitle.Size = new Size(611, 24);
            lblExcelFilePathTitle.TabIndex = 4;
            lblExcelFilePathTitle.Text = "Arquivo Excel:";
            lblExcelFilePathTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSeparator02
            // 
            pnlSeparator02.Dock = DockStyle.Top;
            pnlSeparator02.Location = new Point(5, 140);
            pnlSeparator02.Margin = new Padding(2);
            pnlSeparator02.Name = "pnlSeparator02";
            pnlSeparator02.Size = new Size(621, 13);
            pnlSeparator02.TabIndex = 4;
            // 
            // pnlHomeSectionTop02
            // 
            pnlHomeSectionTop02.Controls.Add(pnlHomeFolder02);
            pnlHomeSectionTop02.Dock = DockStyle.Top;
            pnlHomeSectionTop02.Location = new Point(5, 79);
            pnlHomeSectionTop02.Margin = new Padding(0);
            pnlHomeSectionTop02.Name = "pnlHomeSectionTop02";
            pnlHomeSectionTop02.Padding = new Padding(5);
            pnlHomeSectionTop02.Size = new Size(621, 61);
            pnlHomeSectionTop02.TabIndex = 3;
            // 
            // pnlHomeFolder02
            // 
            pnlHomeFolder02.Controls.Add(txtOutputPath);
            pnlHomeFolder02.Controls.Add(lblSeparatorSection02);
            pnlHomeFolder02.Controls.Add(btnOutputPath);
            pnlHomeFolder02.Controls.Add(lblOutputPathTitle);
            pnlHomeFolder02.Dock = DockStyle.Fill;
            pnlHomeFolder02.Location = new Point(5, 5);
            pnlHomeFolder02.Margin = new Padding(0);
            pnlHomeFolder02.Name = "pnlHomeFolder02";
            pnlHomeFolder02.Size = new Size(611, 51);
            pnlHomeFolder02.TabIndex = 0;
            // 
            // txtOutputPath
            // 
            txtOutputPath.BackColor = Color.White;
            txtOutputPath.Dock = DockStyle.Fill;
            txtOutputPath.Font = new Font("Segoe UI", 12F);
            txtOutputPath.Location = new Point(0, 24);
            txtOutputPath.Margin = new Padding(0);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.ReadOnly = true;
            txtOutputPath.Size = new Size(565, 29);
            txtOutputPath.TabIndex = 15;
            // 
            // lblSeparatorSection02
            // 
            lblSeparatorSection02.Dock = DockStyle.Right;
            lblSeparatorSection02.Location = new Point(565, 24);
            lblSeparatorSection02.Margin = new Padding(2, 0, 2, 0);
            lblSeparatorSection02.Name = "lblSeparatorSection02";
            lblSeparatorSection02.Size = new Size(6, 27);
            lblSeparatorSection02.TabIndex = 14;
            // 
            // btnOutputPath
            // 
            btnOutputPath.Cursor = Cursors.Hand;
            btnOutputPath.Dock = DockStyle.Right;
            btnOutputPath.Image = Properties.Resources.folder_icon;
            btnOutputPath.Location = new Point(571, 24);
            btnOutputPath.Margin = new Padding(0);
            btnOutputPath.Name = "btnOutputPath";
            btnOutputPath.Size = new Size(40, 27);
            btnOutputPath.TabIndex = 7;
            btnOutputPath.UseVisualStyleBackColor = true;
            btnOutputPath.Click += btnOutputPath_Click;
            // 
            // lblOutputPathTitle
            // 
            lblOutputPathTitle.Dock = DockStyle.Top;
            lblOutputPathTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOutputPathTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblOutputPathTitle.Location = new Point(0, 0);
            lblOutputPathTitle.Margin = new Padding(0);
            lblOutputPathTitle.Name = "lblOutputPathTitle";
            lblOutputPathTitle.Size = new Size(611, 24);
            lblOutputPathTitle.TabIndex = 4;
            lblOutputPathTitle.Text = "Pasta dos Resultados:";
            lblOutputPathTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSeparator01
            // 
            pnlSeparator01.Dock = DockStyle.Top;
            pnlSeparator01.Location = new Point(5, 66);
            pnlSeparator01.Margin = new Padding(2);
            pnlSeparator01.Name = "pnlSeparator01";
            pnlSeparator01.Size = new Size(621, 13);
            pnlSeparator01.TabIndex = 2;
            // 
            // pnlHomeSectionTop01
            // 
            pnlHomeSectionTop01.Controls.Add(pnlHomeFolder01);
            pnlHomeSectionTop01.Dock = DockStyle.Top;
            pnlHomeSectionTop01.Location = new Point(5, 5);
            pnlHomeSectionTop01.Margin = new Padding(0);
            pnlHomeSectionTop01.Name = "pnlHomeSectionTop01";
            pnlHomeSectionTop01.Padding = new Padding(5);
            pnlHomeSectionTop01.Size = new Size(621, 61);
            pnlHomeSectionTop01.TabIndex = 1;
            // 
            // pnlHomeFolder01
            // 
            pnlHomeFolder01.Controls.Add(txtFolderRootPath);
            pnlHomeFolder01.Controls.Add(lblSeparatorSection01);
            pnlHomeFolder01.Controls.Add(btnRootFolderPath);
            pnlHomeFolder01.Controls.Add(lblFolderRootPathTitle);
            pnlHomeFolder01.Dock = DockStyle.Fill;
            pnlHomeFolder01.Location = new Point(5, 5);
            pnlHomeFolder01.Margin = new Padding(0);
            pnlHomeFolder01.Name = "pnlHomeFolder01";
            pnlHomeFolder01.Size = new Size(611, 51);
            pnlHomeFolder01.TabIndex = 0;
            // 
            // txtFolderRootPath
            // 
            txtFolderRootPath.BackColor = Color.White;
            txtFolderRootPath.Dock = DockStyle.Fill;
            txtFolderRootPath.Font = new Font("Segoe UI", 12F);
            txtFolderRootPath.Location = new Point(0, 24);
            txtFolderRootPath.Margin = new Padding(0);
            txtFolderRootPath.Name = "txtFolderRootPath";
            txtFolderRootPath.ReadOnly = true;
            txtFolderRootPath.Size = new Size(565, 29);
            txtFolderRootPath.TabIndex = 15;
            // 
            // lblSeparatorSection01
            // 
            lblSeparatorSection01.Dock = DockStyle.Right;
            lblSeparatorSection01.Location = new Point(565, 24);
            lblSeparatorSection01.Margin = new Padding(2, 0, 2, 0);
            lblSeparatorSection01.Name = "lblSeparatorSection01";
            lblSeparatorSection01.Size = new Size(6, 27);
            lblSeparatorSection01.TabIndex = 14;
            // 
            // btnRootFolderPath
            // 
            btnRootFolderPath.Cursor = Cursors.Hand;
            btnRootFolderPath.Dock = DockStyle.Right;
            btnRootFolderPath.Image = Properties.Resources.folder_icon;
            btnRootFolderPath.Location = new Point(571, 24);
            btnRootFolderPath.Margin = new Padding(0);
            btnRootFolderPath.Name = "btnRootFolderPath";
            btnRootFolderPath.Size = new Size(40, 27);
            btnRootFolderPath.TabIndex = 7;
            btnRootFolderPath.UseVisualStyleBackColor = true;
            btnRootFolderPath.Click += btnRootFolderPath_Click;
            // 
            // lblFolderRootPathTitle
            // 
            lblFolderRootPathTitle.Dock = DockStyle.Top;
            lblFolderRootPathTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFolderRootPathTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblFolderRootPathTitle.Location = new Point(0, 0);
            lblFolderRootPathTitle.Margin = new Padding(0);
            lblFolderRootPathTitle.Name = "lblFolderRootPathTitle";
            lblFolderRootPathTitle.Size = new Size(611, 24);
            lblFolderRootPathTitle.TabIndex = 4;
            lblFolderRootPathTitle.Text = "Pasta Raiz:";
            lblFolderRootPathTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlHomeFooter
            // 
            pnlHomeFooter.Controls.Add(picLoadingGif);
            pnlHomeFooter.Controls.Add(btnCheckFixFiles);
            pnlHomeFooter.Controls.Add(btnAudit);
            pnlHomeFooter.Dock = DockStyle.Bottom;
            pnlHomeFooter.Location = new Point(0, 341);
            pnlHomeFooter.Margin = new Padding(0);
            pnlHomeFooter.Name = "pnlHomeFooter";
            pnlHomeFooter.Padding = new Padding(5);
            pnlHomeFooter.Size = new Size(631, 48);
            pnlHomeFooter.TabIndex = 7;
            // 
            // picLoadingGif
            // 
            picLoadingGif.Dock = DockStyle.Right;
            picLoadingGif.Image = Properties.Resources.loading_35;
            picLoadingGif.Location = new Point(384, 5);
            picLoadingGif.Margin = new Padding(2);
            picLoadingGif.Name = "picLoadingGif";
            picLoadingGif.Padding = new Padding(6);
            picLoadingGif.Size = new Size(42, 38);
            picLoadingGif.SizeMode = PictureBoxSizeMode.CenterImage;
            picLoadingGif.TabIndex = 16;
            picLoadingGif.TabStop = false;
            picLoadingGif.Visible = false;
            // 
            // btnCheckFixFiles
            // 
            btnCheckFixFiles.Cursor = Cursors.Hand;
            btnCheckFixFiles.FlatAppearance.BorderSize = 0;
            btnCheckFixFiles.FlatAppearance.MouseDownBackColor = Color.White;
            btnCheckFixFiles.FlatAppearance.MouseOverBackColor = Color.White;
            btnCheckFixFiles.FlatStyle = FlatStyle.Flat;
            btnCheckFixFiles.Font = new Font("Segoe UI", 12F);
            btnCheckFixFiles.Image = Properties.Resources.sqare_uncheck_icon_dark;
            btnCheckFixFiles.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckFixFiles.Location = new Point(6, 9);
            btnCheckFixFiles.Margin = new Padding(0);
            btnCheckFixFiles.Name = "btnCheckFixFiles";
            btnCheckFixFiles.Size = new Size(293, 31);
            btnCheckFixFiles.TabIndex = 1;
            btnCheckFixFiles.Tag = "";
            btnCheckFixFiles.Text = "  Corrigir arquivos automaticamente";
            btnCheckFixFiles.TextAlign = ContentAlignment.MiddleLeft;
            btnCheckFixFiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckFixFiles.UseVisualStyleBackColor = true;
            btnCheckFixFiles.Click += btnCheckFixFiles_Click;
            // 
            // btnAudit
            // 
            btnAudit.BackColor = Color.FromArgb(40, 167, 69);
            btnAudit.Cursor = Cursors.Hand;
            btnAudit.Dock = DockStyle.Right;
            btnAudit.FlatAppearance.BorderSize = 0;
            btnAudit.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 126, 52);
            btnAudit.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 136, 56);
            btnAudit.FlatStyle = FlatStyle.Flat;
            btnAudit.Font = new Font("Segoe UI", 13F);
            btnAudit.ForeColor = Color.White;
            btnAudit.Location = new Point(426, 5);
            btnAudit.Margin = new Padding(2);
            btnAudit.Name = "btnAudit";
            btnAudit.Size = new Size(200, 38);
            btnAudit.TabIndex = 15;
            btnAudit.Text = "Auditar";
            btnAudit.UseVisualStyleBackColor = false;
            btnAudit.Click += btnAudit_Click;
            // 
            // pnlTopFrame
            // 
            pnlTopFrame.BackColor = Color.WhiteSmoke;
            pnlTopFrame.Controls.Add(lblFormTitle);
            pnlTopFrame.Controls.Add(pnlTopSideContainer);
            pnlTopFrame.Controls.Add(picLogo);
            pnlTopFrame.Dock = DockStyle.Top;
            pnlTopFrame.Location = new Point(0, 0);
            pnlTopFrame.Margin = new Padding(2);
            pnlTopFrame.Name = "pnlTopFrame";
            pnlTopFrame.Padding = new Padding(6);
            pnlTopFrame.Size = new Size(631, 64);
            pnlTopFrame.TabIndex = 6;
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
            lblFormTitle.Size = new Size(361, 52);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "EDI AUDIT - Home";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSideContainer
            // 
            pnlTopSideContainer.Controls.Add(btnConfig);
            pnlTopSideContainer.Dock = DockStyle.Right;
            pnlTopSideContainer.Location = new Point(473, 6);
            pnlTopSideContainer.Margin = new Padding(0);
            pnlTopSideContainer.Name = "pnlTopSideContainer";
            pnlTopSideContainer.Padding = new Padding(6, 6, 5, 6);
            pnlTopSideContainer.Size = new Size(152, 52);
            pnlTopSideContainer.TabIndex = 2;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(46, 80, 159);
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.Dock = DockStyle.Right;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 98, 204);
            btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 105, 217);
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.ForeColor = Color.White;
            btnConfig.Image = Properties.Resources.cog_icon_24_24;
            btnConfig.Location = new Point(109, 6);
            btnConfig.Margin = new Padding(2);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(38, 40);
            btnConfig.TabIndex = 10;
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
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
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(46, 80, 159);
            ClientSize = new Size(643, 401);
            Controls.Add(pnlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimumSize = new Size(659, 440);
            Name = "frmHome";
            Padding = new Padding(6);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDI AUDIT - Home";
            Load += frmHome_Load;
            pnlMain.ResumeLayout(false);
            pnlHomeMain.ResumeLayout(false);
            pnlHomeSectionTop03.ResumeLayout(false);
            pnlHomeFile01.ResumeLayout(false);
            pnlHomeFile01.PerformLayout();
            pnlHomeSectionTop02.ResumeLayout(false);
            pnlHomeFolder02.ResumeLayout(false);
            pnlHomeFolder02.PerformLayout();
            pnlHomeSectionTop01.ResumeLayout(false);
            pnlHomeFolder01.ResumeLayout(false);
            pnlHomeFolder01.PerformLayout();
            pnlHomeFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLoadingGif).EndInit();
            pnlTopFrame.ResumeLayout(false);
            pnlTopSideContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlTopFrame;
        private Label lblFormTitle;
        private Panel pnlTopSideContainer;
        private PictureBox picLogo;
        private Panel pnlHomeMain;
        private Panel pnlHomeFooter;
        private Button btnAudit;
        private Button btnCheckFixFiles;
        private Panel pnlHomeFolder01;
        private Button btnRootFolderPath;
        private Label lblFolderRootPathTitle;
        private TextBox txtFolderRootPath;
        private Label lblSeparatorSection01;
        private Panel pnlHomeSectionTop01;
        private Panel pnlSeparator01;
        private Panel pnlSeparator02;
        private Panel pnlHomeSectionTop02;
        private Panel pnlHomeFolder02;
        private TextBox txtOutputPath;
        private Label lblSeparatorSection02;
        private Button btnOutputPath;
        private Label lblOutputPathTitle;
        private Panel pnlHomeSectionTop03;
        private Panel pnlHomeFile01;
        private TextBox txtExcelFilePath;
        private Label lblSeparatorSection03;
        private Button btnExcelFile;
        private Label lblExcelFilePathTitle;
        private Panel pnlSeparator03;
        private PictureBox picLoadingGif;
        private Button btnConfig;
    }
}