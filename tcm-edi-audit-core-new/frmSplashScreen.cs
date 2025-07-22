using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcm_edi_audit_core_new
{
    public partial class frmSplashScreen : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FormTitle
        {
            get => lblFormTitle.Text;
            set => lblFormTitle.Text = value;
        }

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
