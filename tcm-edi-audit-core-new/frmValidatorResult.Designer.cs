namespace tcm_edi_audit_core_new
{
    partial class frmValidatorResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidatorResult));
            pnlMain = new Panel();
            pnlPositionsMain = new Panel();
            dgvValidatorResult = new DataGridView();
            pnlValidatorResultTop = new Panel();
            lblFileTitle = new Label();
            lblStatusTitle = new Label();
            cmbFiles = new ComboBox();
            cmbStatus = new ComboBox();
            pnlValidatorResultFooter = new Panel();
            picLoadingGif = new PictureBox();
            btnExpandSelection = new Button();
            btnSaveFiles = new Button();
            pnlTopFrame = new Panel();
            lblFormTitle = new Label();
            pnlTopSideContainer = new Panel();
            picLogo = new PictureBox();
            pnlMain.SuspendLayout();
            pnlPositionsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvValidatorResult).BeginInit();
            pnlValidatorResultTop.SuspendLayout();
            pnlValidatorResultFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoadingGif).BeginInit();
            pnlTopFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(pnlPositionsMain);
            pnlMain.Controls.Add(pnlValidatorResultTop);
            pnlMain.Controls.Add(pnlValidatorResultFooter);
            pnlMain.Controls.Add(pnlTopFrame);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(8, 8);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(879, 679);
            pnlMain.TabIndex = 1;
            // 
            // pnlPositionsMain
            // 
            pnlPositionsMain.BackColor = Color.Transparent;
            pnlPositionsMain.Controls.Add(dgvValidatorResult);
            pnlPositionsMain.Dock = DockStyle.Fill;
            pnlPositionsMain.Location = new Point(0, 159);
            pnlPositionsMain.Margin = new Padding(0, 6, 0, 0);
            pnlPositionsMain.Name = "pnlPositionsMain";
            pnlPositionsMain.Padding = new Padding(6);
            pnlPositionsMain.Size = new Size(879, 460);
            pnlPositionsMain.TabIndex = 10;
            // 
            // dgvValidatorResult
            // 
            dgvValidatorResult.AllowUserToAddRows = false;
            dgvValidatorResult.AllowUserToDeleteRows = false;
            dgvValidatorResult.BackgroundColor = SystemColors.Control;
            dgvValidatorResult.BorderStyle = BorderStyle.None;
            dgvValidatorResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValidatorResult.Dock = DockStyle.Fill;
            dgvValidatorResult.Location = new Point(6, 6);
            dgvValidatorResult.Name = "dgvValidatorResult";
            dgvValidatorResult.RowHeadersWidth = 51;
            dgvValidatorResult.Size = new Size(867, 448);
            dgvValidatorResult.TabIndex = 2;
            // 
            // pnlValidatorResultTop
            // 
            pnlValidatorResultTop.BackColor = Color.Transparent;
            pnlValidatorResultTop.Controls.Add(lblFileTitle);
            pnlValidatorResultTop.Controls.Add(lblStatusTitle);
            pnlValidatorResultTop.Controls.Add(cmbFiles);
            pnlValidatorResultTop.Controls.Add(cmbStatus);
            pnlValidatorResultTop.Dock = DockStyle.Top;
            pnlValidatorResultTop.Location = new Point(0, 80);
            pnlValidatorResultTop.Margin = new Padding(0);
            pnlValidatorResultTop.Name = "pnlValidatorResultTop";
            pnlValidatorResultTop.Size = new Size(879, 79);
            pnlValidatorResultTop.TabIndex = 9;
            // 
            // lblFileTitle
            // 
            lblFileTitle.AutoSize = true;
            lblFileTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFileTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblFileTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblFileTitle.Location = new Point(297, 13);
            lblFileTitle.Name = "lblFileTitle";
            lblFileTitle.Size = new Size(79, 23);
            lblFileTitle.TabIndex = 3;
            lblFileTitle.Text = "Arquivo:";
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatusTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblStatusTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblStatusTitle.Location = new Point(6, 13);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(65, 23);
            lblStatusTitle.TabIndex = 2;
            lblStatusTitle.Text = "Status:";
            // 
            // cmbFiles
            // 
            cmbFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbFiles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiles.Font = new Font("Segoe UI", 12F);
            cmbFiles.FormattingEnabled = true;
            cmbFiles.Location = new Point(297, 39);
            cmbFiles.Name = "cmbFiles";
            cmbFiles.Size = new Size(285, 36);
            cmbFiles.TabIndex = 1;
            cmbFiles.SelectedIndexChanged += cmbFiles_SelectedIndexChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 12F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(6, 39);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(285, 36);
            cmbStatus.TabIndex = 0;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // pnlValidatorResultFooter
            // 
            pnlValidatorResultFooter.Controls.Add(picLoadingGif);
            pnlValidatorResultFooter.Controls.Add(btnExpandSelection);
            pnlValidatorResultFooter.Controls.Add(btnSaveFiles);
            pnlValidatorResultFooter.Dock = DockStyle.Bottom;
            pnlValidatorResultFooter.Location = new Point(0, 619);
            pnlValidatorResultFooter.Margin = new Padding(0);
            pnlValidatorResultFooter.Name = "pnlValidatorResultFooter";
            pnlValidatorResultFooter.Padding = new Padding(6, 6, 8, 6);
            pnlValidatorResultFooter.Size = new Size(879, 60);
            pnlValidatorResultFooter.TabIndex = 8;
            // 
            // picLoadingGif
            // 
            picLoadingGif.Dock = DockStyle.Right;
            picLoadingGif.Image = Properties.Resources.loading_35;
            picLoadingGif.Location = new Point(569, 6);
            picLoadingGif.Name = "picLoadingGif";
            picLoadingGif.Padding = new Padding(7);
            picLoadingGif.Size = new Size(52, 48);
            picLoadingGif.SizeMode = PictureBoxSizeMode.CenterImage;
            picLoadingGif.TabIndex = 17;
            picLoadingGif.TabStop = false;
            picLoadingGif.Visible = false;
            // 
            // btnExpandSelection
            // 
            btnExpandSelection.Cursor = Cursors.Hand;
            btnExpandSelection.FlatAppearance.BorderSize = 0;
            btnExpandSelection.FlatAppearance.MouseDownBackColor = Color.White;
            btnExpandSelection.FlatAppearance.MouseOverBackColor = Color.White;
            btnExpandSelection.FlatStyle = FlatStyle.Flat;
            btnExpandSelection.Font = new Font("Segoe UI", 12F);
            btnExpandSelection.Image = Properties.Resources.sqare_uncheck_icon_dark;
            btnExpandSelection.ImageAlign = ContentAlignment.MiddleLeft;
            btnExpandSelection.Location = new Point(8, 11);
            btnExpandSelection.Margin = new Padding(0);
            btnExpandSelection.Name = "btnExpandSelection";
            btnExpandSelection.Size = new Size(206, 39);
            btnExpandSelection.TabIndex = 1;
            btnExpandSelection.Tag = "";
            btnExpandSelection.Text = "  Expandir seleção";
            btnExpandSelection.TextAlign = ContentAlignment.MiddleLeft;
            btnExpandSelection.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExpandSelection.UseVisualStyleBackColor = true;
            btnExpandSelection.Click += btnExpandSelection_Click;
            // 
            // btnSaveFiles
            // 
            btnSaveFiles.BackColor = Color.FromArgb(40, 167, 69);
            btnSaveFiles.Cursor = Cursors.Hand;
            btnSaveFiles.Dock = DockStyle.Right;
            btnSaveFiles.FlatAppearance.BorderSize = 0;
            btnSaveFiles.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 126, 52);
            btnSaveFiles.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 136, 56);
            btnSaveFiles.FlatStyle = FlatStyle.Flat;
            btnSaveFiles.Font = new Font("Segoe UI", 13F);
            btnSaveFiles.ForeColor = Color.White;
            btnSaveFiles.Location = new Point(621, 6);
            btnSaveFiles.Name = "btnSaveFiles";
            btnSaveFiles.Size = new Size(250, 48);
            btnSaveFiles.TabIndex = 16;
            btnSaveFiles.Text = "Salvar Arquivos";
            btnSaveFiles.UseVisualStyleBackColor = false;
            btnSaveFiles.Click += btnSaveFiles_Click;
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
            pnlTopFrame.Size = new Size(879, 80);
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
            lblFormTitle.Size = new Size(502, 64);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "EDI AUDIT - Resultado";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSideContainer
            // 
            pnlTopSideContainer.Dock = DockStyle.Right;
            pnlTopSideContainer.Location = new Point(643, 8);
            pnlTopSideContainer.Name = "pnlTopSideContainer";
            pnlTopSideContainer.Size = new Size(228, 64);
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
            // frmValidatorResult
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(46, 80, 159);
            ClientSize = new Size(895, 695);
            Controls.Add(pnlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmValidatorResult";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDI AUDIT - Resultado";
            Load += frmValidatorResult_Load;
            pnlMain.ResumeLayout(false);
            pnlPositionsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvValidatorResult).EndInit();
            pnlValidatorResultTop.ResumeLayout(false);
            pnlValidatorResultTop.PerformLayout();
            pnlValidatorResultFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLoadingGif).EndInit();
            pnlTopFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlTopFrame;
        private Label lblFormTitle;
        private Panel pnlTopSideContainer;
        private PictureBox picLogo;
        private Panel pnlValidatorResultFooter;
        private Button btnExpandSelection;
        private Panel pnlValidatorResultTop;
        private Label lblFileTitle;
        private Label lblStatusTitle;
        private ComboBox cmbFiles;
        private ComboBox cmbStatus;
        private Panel pnlPositionsMain;
        private DataGridView dgvValidatorResult;
        private Button btnSaveFiles;
        private PictureBox picLoadingGif;
    }
}