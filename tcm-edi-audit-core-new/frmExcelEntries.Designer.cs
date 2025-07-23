namespace tcm_edi_audit_core_new
{
    partial class frmExcelEntries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcelEntries));
            pnlMain = new Panel();
            pnlTabDefinitions = new Panel();
            dgvExcelView = new DataGridView();
            lblExcelEntriesTitle = new Label();
            pnlTopFrame = new Panel();
            lblFormTitle = new Label();
            pnlTopSideContainer = new Panel();
            picLogo = new PictureBox();
            pnlMain.SuspendLayout();
            pnlTabDefinitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExcelView).BeginInit();
            pnlTopFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(pnlTabDefinitions);
            pnlMain.Controls.Add(pnlTopFrame);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(8, 8);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1131, 665);
            pnlMain.TabIndex = 1;
            // 
            // pnlTabDefinitions
            // 
            pnlTabDefinitions.BackColor = Color.White;
            pnlTabDefinitions.Controls.Add(dgvExcelView);
            pnlTabDefinitions.Controls.Add(lblExcelEntriesTitle);
            pnlTabDefinitions.Dock = DockStyle.Fill;
            pnlTabDefinitions.Location = new Point(0, 80);
            pnlTabDefinitions.Margin = new Padding(0);
            pnlTabDefinitions.Name = "pnlTabDefinitions";
            pnlTabDefinitions.Padding = new Padding(6);
            pnlTabDefinitions.Size = new Size(1131, 585);
            pnlTabDefinitions.TabIndex = 7;
            // 
            // dgvExcelView
            // 
            dgvExcelView.AllowUserToAddRows = false;
            dgvExcelView.AllowUserToDeleteRows = false;
            dgvExcelView.BackgroundColor = SystemColors.Control;
            dgvExcelView.BorderStyle = BorderStyle.None;
            dgvExcelView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcelView.Dock = DockStyle.Fill;
            dgvExcelView.Location = new Point(6, 36);
            dgvExcelView.Name = "dgvExcelView";
            dgvExcelView.RowHeadersWidth = 51;
            dgvExcelView.Size = new Size(1119, 543);
            dgvExcelView.TabIndex = 7;
            // 
            // lblExcelEntriesTitle
            // 
            lblExcelEntriesTitle.Dock = DockStyle.Top;
            lblExcelEntriesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblExcelEntriesTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblExcelEntriesTitle.Location = new Point(6, 6);
            lblExcelEntriesTitle.Margin = new Padding(0);
            lblExcelEntriesTitle.Name = "lblExcelEntriesTitle";
            lblExcelEntriesTitle.Size = new Size(1119, 30);
            lblExcelEntriesTitle.TabIndex = 6;
            lblExcelEntriesTitle.Text = "Conteúdo do Excel:";
            lblExcelEntriesTitle.TextAlign = ContentAlignment.MiddleLeft;
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
            pnlTopFrame.Size = new Size(1131, 80);
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
            lblFormTitle.Size = new Size(732, 64);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "EDI AUDIT - Excel";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSideContainer
            // 
            pnlTopSideContainer.Dock = DockStyle.Right;
            pnlTopSideContainer.Location = new Point(873, 8);
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
            // frmExcelEntries
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(46, 80, 159);
            ClientSize = new Size(1147, 681);
            Controls.Add(pnlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmExcelEntries";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDI AUDIT - Excel";
            Load += frmExcelEntries_Load;
            pnlMain.ResumeLayout(false);
            pnlTabDefinitions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExcelView).EndInit();
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
        private Panel pnlTabDefinitions;
        private DataGridView dgvExcelView;
        private Label lblExcelEntriesTitle;
    }
}