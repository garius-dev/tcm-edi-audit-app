using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcm_edi_audit_core_new.Models.EDI.Settings;

namespace tcm_edi_audit_core_new
{
    public partial class frmExcelEntries : Form
    {
        private List<ExcelEntry> _excelEntries;


        public frmExcelEntries(List<ExcelEntry> excelEntries)
        {
            InitializeComponent();

            _excelEntries = excelEntries;

        }

        private void frmExcelEntries_Load(object sender, EventArgs e)
        {
            dgvExcelView.DataSource = new BindingSource { DataSource = _excelEntries };
            dgvExcelView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExcelView.RowHeadersWidth = 35;
            dgvExcelView.ReadOnly = true;
            dgvExcelView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }
    }
}
