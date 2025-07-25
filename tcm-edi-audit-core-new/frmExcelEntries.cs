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
        //private List<ExcelEntry> _excelEntries;
        private List<ExcelSheetParsedResult<ExcelEntry>> _worksheets;
        private string? _defaultWorksheet;

        public frmExcelEntries(List<ExcelSheetParsedResult<ExcelEntry>> worksheets, string? defaultWorksheet = null)
        {
            InitializeComponent();

            //_excelEntries = excelEntries;
            _worksheets = worksheets;
            _defaultWorksheet = defaultWorksheet;
        }

        private List<ExcelEntry>? FlattenWorkSheets()
        {
            if (_worksheets == null)
            {
                return null;
            }

            List<ExcelEntry> flattenExcelEntries = new List<ExcelEntry>();

            foreach (var item in _worksheets)
            {
                foreach (var entry in item.Entries)
                {
                    entry.WorkSheet = item.SheetName;
                    flattenExcelEntries.Add(entry);
                }
            }

            return flattenExcelEntries;
        }

        private void frmExcelEntries_Load(object sender, EventArgs e)
        {
            _defaultWorksheet = _defaultWorksheet == "Todos" ? null : _defaultWorksheet;
            if (_worksheets != null)
            {
                foreach (var worksheet in _worksheets)
                {
                    if(_defaultWorksheet != null && _defaultWorksheet != worksheet.SheetName)
                    {
                        continue;
                    }

                    TabPage tabPage = new TabPage(worksheet.SheetName);
                    tabPage.Padding = new Padding(6);

                    DataGridView dgv = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        BorderStyle = BorderStyle.None,
                        BackgroundColor = Color.White,  // Ajuste conforme seu design
                        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                        RowHeadersWidth = 35,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
                        ReadOnly = true,
                        DataSource = worksheet.Entries
                    };

                    tabPage.Controls.Add(dgv);


                    tabExcelContainer.Controls.Add(tabPage);
                }
            }

            //dgvExcelView.DataSource = new BindingSource { DataSource = _excelEntries };
            //dgvExcelView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvExcelView.RowHeadersWidth = 35;
            //dgvExcelView.ReadOnly = true;
            //dgvExcelView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }
    }
}
