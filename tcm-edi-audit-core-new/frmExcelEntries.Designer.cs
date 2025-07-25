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
            pnlTableContainer = new Panel();
            tabExcelContainer = new TabControl();
            pnlTopFrame = new Panel();
            lblFormTitle = new Label();
            pnlTopSideContainer = new Panel();
            pnlTabDefinitions = new Panel();
            dgvExcelView = new DataGridView();
            lblExcelEntriesTitle = new Label();
            picLogo = new PictureBox();
            pnlMain.SuspendLayout();
            pnlTableContainer.SuspendLayout();
            pnlTopFrame.SuspendLayout();
            pnlTabDefinitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExcelView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(pnlTableContainer);
            pnlMain.Controls.Add(pnlTopFrame);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(6, 6);
            pnlMain.Margin = new Padding(2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(906, 533);
            pnlMain.TabIndex = 1;
            // 
            // pnlTableContainer
            // 
            pnlTableContainer.Controls.Add(tabExcelContainer);
            pnlTableContainer.Dock = DockStyle.Fill;
            pnlTableContainer.Location = new Point(0, 64);
            pnlTableContainer.Name = "pnlTableContainer";
            pnlTableContainer.Padding = new Padding(6);
            pnlTableContainer.Size = new Size(906, 469);
            pnlTableContainer.TabIndex = 7;
            // 
            // tabExcelContainer
            // 
            tabExcelContainer.Dock = DockStyle.Fill;
            tabExcelContainer.Location = new Point(6, 6);
            tabExcelContainer.Name = "tabExcelContainer";
            tabExcelContainer.SelectedIndex = 0;
            tabExcelContainer.Size = new Size(894, 457);
            tabExcelContainer.TabIndex = 0;
            // 
            // pnlTopFrame
            // 
            pnlTopFrame.BackColor = Color.WhiteSmoke;
            pnlTopFrame.Controls.Add(pnlTabDefinitions);
            pnlTopFrame.Controls.Add(lblFormTitle);
            pnlTopFrame.Controls.Add(pnlTopSideContainer);
            pnlTopFrame.Controls.Add(picLogo);
            pnlTopFrame.Dock = DockStyle.Top;
            pnlTopFrame.Location = new Point(0, 0);
            pnlTopFrame.Margin = new Padding(2);
            pnlTopFrame.Name = "pnlTopFrame";
            pnlTopFrame.Padding = new Padding(6);
            pnlTopFrame.Size = new Size(906, 64);
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
            lblFormTitle.Size = new Size(588, 52);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "EDI AUDIT - Excel";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSideContainer
            // 
            pnlTopSideContainer.Dock = DockStyle.Right;
            pnlTopSideContainer.Location = new Point(700, 6);
            pnlTopSideContainer.Margin = new Padding(2);
            pnlTopSideContainer.Name = "pnlTopSideContainer";
            pnlTopSideContainer.Size = new Size(200, 52);
            pnlTopSideContainer.TabIndex = 2;
            // 
            // pnlTabDefinitions
            // 
            pnlTabDefinitions.BackColor = Color.White;
            pnlTabDefinitions.Controls.Add(dgvExcelView);
            pnlTabDefinitions.Controls.Add(lblExcelEntriesTitle);
            pnlTabDefinitions.Enabled = false;
            pnlTabDefinitions.Location = new Point(601, 6);
            pnlTabDefinitions.Margin = new Padding(0);
            pnlTabDefinitions.Name = "pnlTabDefinitions";
            pnlTabDefinitions.Padding = new Padding(5);
            pnlTabDefinitions.Size = new Size(69, 35);
            pnlTabDefinitions.TabIndex = 7;
            pnlTabDefinitions.Visible = false;
            // 
            // dgvExcelView
            // 
            dgvExcelView.AllowUserToAddRows = false;
            dgvExcelView.AllowUserToDeleteRows = false;
            dgvExcelView.BackgroundColor = SystemColors.Control;
            dgvExcelView.BorderStyle = BorderStyle.None;
            dgvExcelView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcelView.Dock = DockStyle.Fill;
            dgvExcelView.Location = new Point(5, 29);
            dgvExcelView.Margin = new Padding(2);
            dgvExcelView.Name = "dgvExcelView";
            dgvExcelView.RowHeadersWidth = 51;
            dgvExcelView.Size = new Size(59, 1);
            dgvExcelView.TabIndex = 7;
            // 
            // lblExcelEntriesTitle
            // 
            lblExcelEntriesTitle.Dock = DockStyle.Top;
            lblExcelEntriesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblExcelEntriesTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblExcelEntriesTitle.Location = new Point(5, 5);
            lblExcelEntriesTitle.Margin = new Padding(0);
            lblExcelEntriesTitle.Name = "lblExcelEntriesTitle";
            lblExcelEntriesTitle.Size = new Size(59, 24);
            lblExcelEntriesTitle.TabIndex = 6;
            lblExcelEntriesTitle.Text = "Conteúdo do Excel:";
            lblExcelEntriesTitle.TextAlign = ContentAlignment.MiddleLeft;
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
            // frmExcelEntries
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(46, 80, 159);
            ClientSize = new Size(918, 545);
            Controls.Add(pnlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmExcelEntries";
            Padding = new Padding(6);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDI AUDIT - Excel";
            Load += frmExcelEntries_Load;
            pnlMain.ResumeLayout(false);
            pnlTableContainer.ResumeLayout(false);
            pnlTopFrame.ResumeLayout(false);
            pnlTabDefinitions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExcelView).EndInit();
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
        private Panel pnlTableContainer;
        private TabControl tabExcelContainer;
    }
}