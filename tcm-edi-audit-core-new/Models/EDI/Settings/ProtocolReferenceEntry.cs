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

    public class ExcelEntry
    {
        [Browsable(false)]
        public string WorkSheet { get; set; } = string.Empty;
        public string Flow { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public int DistanceKm { get; set; }
        public string ScheduledVehicle { get; set; } = string.Empty;
        public string RequestCode { get; set; } = string.Empty;
        public string Cva { get; set; } = string.Empty;
        public string CtePackage { get; set; } = string.Empty;
        public string MinutePackage { get; set; } = string.Empty;
        public string CtePiece { get; set; } = string.Empty;
        public string MinutePiece { get; set; } = string.Empty;
        public decimal TotalRevenue { get; set; }
        public string Invoice { get; set; } = string.Empty;
        public string Protocol { get; set; } = string.Empty;
    }

    public class ExcelSheetRawData
    {
        public string SheetName { get; set; } = string.Empty;
        public List<List<string>> DataRows { get; set; } = new();
        public ExcelHeaderConfig MatchedHeader { get; set; } = new();
    }

    public class ExcelSheetParsedResult<T>
    {
        public string SheetName { get; set; } = string.Empty;
        public List<T> Entries { get; set; } = new();
    }

    public class ExcelHeaderConfig
    {
        public List<ExcelColumnMapping> Columns { get; set; } = new();
    }

    public class ExcelColumnMapping
    {
        public string HeaderName { get; set; }
        public string TargetProperty { get; set; }
        public int ColumnIndex { get; set; }

        public ExcelColumnMapping(string header, string property, int index)
        {
            HeaderName = header;
            TargetProperty = property;
            ColumnIndex = index;
        }
    }

    public class ExcelHeaderProfile
    {
        public string ProfileName { get; set; } = string.Empty;

        public List<ExcelColumnMap> Columns { get; set; } = new();
    }

    public class ExcelColumnMap
    {
        public string Header { get; set; }
        public string Property { get; set; }

        public ExcelColumnMap(string header, string property)
        {
            this.Header = header;
            this.Property = property;
        }
    }
}
