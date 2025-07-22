namespace tcm_edi_audit_core_new
{
    partial class frmBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            pnlMain.Controls.Add(button4);
            pnlMain.Controls.Add(button3);
            pnlMain.Controls.Add(button2);
            pnlMain.Controls.Add(button1);
            pnlMain.Controls.Add(pnlTopFrame);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(8, 8);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(784, 434);
            pnlMain.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 123, 255);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 98, 204);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 105, 217);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(215, 211);
            button4.Name = "button4";
            button4.Size = new Size(140, 65);
            button4.TabIndex = 9;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(108, 117, 125);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 91, 98);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 98, 104);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(22, 211);
            button3.Name = "button3";
            button3.Size = new Size(140, 65);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(220, 53, 69);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(189, 33, 48);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(215, 100);
            button2.Name = "button2";
            button2.Size = new Size(140, 65);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 167, 69);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 126, 52);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 136, 56);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 100);
            button1.Name = "button1";
            button1.Size = new Size(140, 65);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
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
            pnlTopFrame.Size = new Size(784, 80);
            pnlTopFrame.TabIndex = 5;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblFormTitle.Location = new Point(141, 8);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Padding = new Padding(16, 0, 0, 0);
            lblFormTitle.Size = new Size(385, 64);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "EDI AUDIT";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSideContainer
            // 
            pnlTopSideContainer.Dock = DockStyle.Right;
            pnlTopSideContainer.Location = new Point(526, 8);
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
            // frmBase
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(46, 80, 159);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Name = "frmBase";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDI AUDIT - Home";
            Load += frmBase_Load;
            pnlMain.ResumeLayout(false);
            pnlTopFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlTopFrame;
        private PictureBox picLogo;
        private Label lblFormTitle;
        private Panel pnlTopSideContainer;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
