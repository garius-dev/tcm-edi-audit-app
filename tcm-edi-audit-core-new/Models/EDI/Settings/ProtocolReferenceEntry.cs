using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcm_edi_audit_core_new.Models.EDI.Settings
{
    public class ExcelPatternColumnSettings
    {
        [DisplayName("Nome da Coluna")]
        public string Name { get; set; }

        [DisplayName("Posição da Coluna")]
        public int ColumnPosition { get; set; }

        [DisplayName("Trim?")]
        public bool TrimColumn { get; set; } = true;

        [DisplayName("Regex Pattern")]
        public string? RegexKey { get; set; }

        [DisplayName("Replace To")]
        public string? RegexValue { get; set; }
                
        public ExcelPatternColumnSettings(string name, int position, bool trimColumn = false, string? regexKey = null, string? regexValue = null)
        {
            this.Name = name;
            this.ColumnPosition = position;
            this.TrimColumn = trimColumn;
            this.RegexKey = regexKey;
            this.RegexValue = regexValue;
        }
    }

    //public class ExcelPatternSettings
    //{
    //    [Browsable(false)]
    //    public string? WorkSheetname { get; set; }

    //    [Browsable(false)]
    //    public bool SkipHeader { get; set; } = false;

    //    public List<ExcelPatternColumnSettings> ColumnSettings { get; set; } = new List<ExcelPatternColumnSettings>();
    //}

    public class ExcelEntry
    {
        public string Flow { get; set; }
        public string State { get; set; }
        public int DistanceKm { get; set; }
        public string ScheduledVehicle { get; set; }
        public string RequestCode { get; set; }
        public string Cva { get; set; }
        public string CtePackage { get; set; }
        public string MinutePackage { get; set; }
        public string CtePiece { get; set; }
        public string MinutePiece { get; set; }
        public decimal TotalRevenue { get; set; }
        public string Invoice { get; set; }
        public string Protocol { get; set; }
    }

    public class ExcelEntryIndex
    {
        public int Flow { get; set; }
        public int State { get; set; }
        public int DistanceKm { get; set; }
        public int ScheduledVehicle { get; set; }
        public int RequestCode { get; set; }
        public int Cva { get; set; }
        public int CtePackage { get; set; }
        public int MinutePackage { get; set; }
        public int CtePiece { get; set; }
        public int MinutePiece { get; set; }
        public int TotalRevenue { get; set; }
        public int Invoice { get; set; }
        public int Protocol { get; set; }
    }
}
