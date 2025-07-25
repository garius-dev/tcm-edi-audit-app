using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcm_edi_audit_core_new.Models.DTOs
{
    public class ExcelPreviewDisplayModel
    {
        //public string Planilha { get; set; }
        //public string Campo { get; set; }
        //public string Valor { get; set; }

        [DisplayName("Planilha")]
        public string Worksheet { get; set; } = string.Empty;

        [DisplayName("Campo")]
        public string Field { get; set; } = string.Empty;

        [DisplayName("Valor")]
        public string CellValue { get; set; } = string.Empty;
    }
}
