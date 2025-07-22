namespace tcm_edi_audit_core_new
{
    partial class frmSplashScreen
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
            pnlTopFrame = new Panel();
            lblFormTitle = new Label();
            pnlTopSideContainer = new Panel();
            picLogo = new PictureBox();
            pnlMain.SuspendLayout();
            pnlTopFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(pnlTopFrame);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(8, 8);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1044, 80);
            pnlMain.TabIndex = 1;
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
            pnlTopFrame.Size = new Size(1044, 80);
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
            lblFormTitle.Size = new Size(692, 64);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "INICIANDO APLICAÇÃO...";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSideContainer
            // 
            pnlTopSideContainer.Dock = DockStyle.Right;
            pnlTopSideContainer.Location = new Point(833, 8);
            pnlTopSideContainer.Name = "pnlTopSideContainer";
            pnlTopSideContainer.Size = new Size(203, 64);
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
            // frmSplashScreen
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(46, 80, 159);
            ClientSize = new Size(1060, 96);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmSplashScreen";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDI AUDIT";
            TopMost = true;
            Load += frmSplashScreen_Load;
            pnlMain.ResumeLayout(false);
            pnlTopFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlTopFrame;
        private Label lblFormTitle;
        private PictureBox picLogo;
        private Panel pnlTopSideContainer;
    }
}