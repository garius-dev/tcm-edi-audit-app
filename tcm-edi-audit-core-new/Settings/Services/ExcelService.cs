using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcm_edi_audit_core_new.Extensions;
using tcm_edi_audit_core_new.Models.EDI.Settings;
using tcm_edi_audit_core_new.Models.Settings;

namespace tcm_edi_audit_core_new.Settings.Services
{
    public class ExcelService
    {
        public List<ExcelEntry> Load(string filePath, AppSettings settings)
        {
            if(settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            if (settings.ExcelPatternColumnSettings.IsNullOrEmpty())
            {
                throw new ArgumentNullException("Configuração do formato do Excel");
            }

            var records = new List<ExcelEntry>();

            string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}{Path.GetExtension(filePath)}");
            File.Copy(filePath, tempFilePath, overwrite: true);

            try
            {
                using (var workbook = new XLWorkbook(tempFilePath))
                {
                    var worksheet = string.IsNullOrEmpty(settings.ExcelWorkSheetname) ? workbook.Worksheets.First() : workbook.Worksheet(settings.ExcelWorkSheetname);
                    var rows = worksheet.RangeUsed()?.RowsUsed().Skip(1) ?? throw new Exception($"Impossível decodificar a planilha '{worksheet.Name}'. Verifique se a planilha é válida.");

                    ExcelPatternColumnSettings FlowIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "Flow") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings StateIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "State") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings DistanceKmIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "DistanceKm") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings ScheduledVehicleIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "ScheduledVehicle") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings RequestCodeIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "RequestCode") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings CvaIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "Cva") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings CtePackageIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "CtePackage") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings MinutePackageIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "MinutePackage") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings CtePieceIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "CtePiece") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings MinutePieceIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "MinutePiece") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings TotalRevenueIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "TotalRevenue") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings InvoiceIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "Invoice") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));
                    ExcelPatternColumnSettings ProtocolIndex = settings.ExcelPatternColumnSettings.FirstOrDefault(c => c.Name == "Protocol") ?? throw new ArgumentNullException(nameof(ExcelPatternColumnSettings));

                    foreach (var row in rows)
                    {

                        records.Add(new ExcelEntry
                        {
                            Flow = row.ParseToExcelString(FlowIndex),
                            State = row.ParseToExcelString(StateIndex),
                            DistanceKm = row.ParseToExcelInt(DistanceKmIndex),
                            ScheduledVehicle = row.ParseToExcelString(ScheduledVehicleIndex),
                            RequestCode = row.ParseToExcelString(RequestCodeIndex),
                            Cva = row.ParseToExcelString(CvaIndex),
                            CtePackage = row.ParseToExcelString(CtePackageIndex),
                            MinutePackage = row.ParseToExcelString(MinutePackageIndex),
                            CtePiece = row.ParseToExcelString(CtePieceIndex),
                            MinutePiece = row.ParseToExcelString(MinutePieceIndex),
                            TotalRevenue = row.ParseToExcelCurrency(TotalRevenueIndex),
                            Invoice = row.ParseToExcelString(InvoiceIndex),
                            Protocol = row.ParseToExcelString(ProtocolIndex)
                        });
                    }
                }
            }
            finally
            {
                try { File.Delete(tempFilePath); } catch { /* Ignore cleanup errors */ }
            }

            return records;
        }

        
    }
}
