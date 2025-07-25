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
        
        public List<ExcelSheetParsedResult<T>> ExtractStructuredDataFromExcel<T>(string filePath, AppSettings settings) where T : new()
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}{Path.GetExtension(filePath)}");
            File.Copy(filePath, tempFilePath, overwrite: true);

            var headerConfigs = settings.ExcelHeaderProfiles.Select(p => new ExcelHeaderConfig
            {
                Columns = p.Columns.Select((c, i) => new ExcelColumnMapping(c.Header, c.Property, i)).ToList()
            }).ToList();

            if (headerConfigs.IsNullOrEmpty())
            {
                return new List<ExcelSheetParsedResult<T>>();
            }

            //var headerConfigs = GetPredefinedHeaders();
            var parsedResults = new List<ExcelSheetParsedResult<T>>();
            var validSheets = new List<ExcelSheetRawData>();

            try
            {
                using var workbook = new XLWorkbook(tempFilePath);

                foreach (var sheet in workbook.Worksheets)
                {
                    var range = sheet.RangeUsed();
                    if (range == null) continue;

                    var headers = range.Row(1).Cells().Select(c => c.GetString().NormalizeText(true, true)).ToList();
                    var matchedHeader = MatchHeaders(headerConfigs, headers);
                    if (matchedHeader == null) continue;

                    var sheetData = new ExcelSheetRawData { SheetName = sheet.Name, MatchedHeader = matchedHeader };

                    foreach (var row in range.RowsUsed().Skip(1))
                    {
                        var rowValues = row.Cells(1, matchedHeader.Columns.Count).Select(c => c.GetString().Trim()).ToList();
                        if (rowValues.All(string.IsNullOrWhiteSpace)) continue;
                        sheetData.DataRows.Add(rowValues);
                    }

                    validSheets.Add(sheetData);
                }

                foreach (var sheet in validSheets)
                {
                    var sheetResult = new ExcelSheetParsedResult<T> { SheetName = sheet.SheetName };
                    foreach (var row in sheet.DataRows)
                    {
                        var entry = ObjectExtensions.MapToObject<T>(row, sheet.MatchedHeader);
                        sheetResult.Entries.Add(entry);
                    }
                    parsedResults.Add(sheetResult);
                }
            }
            catch
            {

            }
            finally
            {
                try { File.Delete(tempFilePath); } catch { /* Ignore cleanup errors */ }
            }

            return parsedResults;
        }

        private ExcelHeaderConfig? MatchHeaders(List<ExcelHeaderConfig> knownHeaders, List<string> headers)
        {
            return knownHeaders.FirstOrDefault(cfg =>
                cfg.Columns.Select(c => c.HeaderName.NormalizeText()).SequenceEqual(headers.Take(cfg.Columns.Count)));
        }

        


        public List<ExcelEntry> Load(string filePath, AppSettings settings)
        {
            if (settings == null)
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


        //public static class HeaderProfileSeeder
        //{
        //    public static async Task<bool> SeedExcelHeaderProfiles(ConfigManagerService configManager)
        //    {
        //        var settings = await configManager.LoadSettingsFromCloud();
        //        if (settings == null) return false;

        //        settings.ExcelHeaderProfiles = new List<ExcelHeaderProfile>
        //{
        //    new ExcelHeaderProfile
        //    {
        //        ProfileName = "Padrão 1",
        //        Columns = new List<ExcelColumnMap>
        //        {
        //            new("FLUXO", "Flow"),
        //            new("FORNECEDOR", ""),
        //            new("UF", "State"),
        //            new("FAIXA KM", "DistanceKm"),
        //            new("VEÍCULO PROGRAMADO", "ScheduledVehicle"),
        //            new("CVA", "Cva"),
        //            new("CTE EMBALAGEM", "CtePackage"),
        //            new("MINUTA", "MinutePackage"),
        //            new("CTE PEÇA", "CtePiece"),
        //            new("MINUTA", "MinutePiece"),
        //            new("RECEITA TOTAL", "TotalRevenue"),
        //            new("FATURA", "Invoice"),
        //            new("PROTOCOLO", "Protocol")
        //        }
        //    },
        //    new ExcelHeaderProfile
        //    {
        //        ProfileName = "Padrão 2 (com status)",
        //        Columns = new List<ExcelColumnMap>
        //        {
        //            new("FLUXO", "Flow"),
        //            new("FORNECEDOR", ""),
        //            new("UF", "State"),
        //            new("FAIXA KM", "DistanceKm"),
        //            new("VEÍCULO PROGRAMADO", "ScheduledVehicle"),
        //            new("CVA", "Cva"),
        //            new("CTE EMBALAGEM", "CtePackage"),
        //            new("MINUTA", "MinutePackage"),
        //            new("CTE PEÇA", "CtePiece"),
        //            new("MINUTA", "MinutePiece"),
        //            new("RECEITA TOTAL", "TotalRevenue"),
        //            new("STATUS EMISSÕES", ""),
        //            new("FATURA", "Invoice"),
        //            new("PROTOCOLO", "Protocol")
        //        }
        //    },
        //    new ExcelHeaderProfile
        //    {
        //        ProfileName = "Coleta",
        //        Columns = new List<ExcelColumnMap>
        //        {
        //            new("DATA COLETA", ""),
        //            new("ORIGEM", ""),
        //            new("UF", "State"),
        //            new("DESTINO", ""),
        //            new("UF", ""),
        //            new("STE", ""),
        //            new("CVA", "Cva"),
        //            new("COLETA", "Flow"),
        //            new("VEÍCULO SOLICITADO", "ScheduledVehicle"),
        //            new("KM", "DistanceKm"),
        //            new("CTE EMBALAGEM", "CtePackage"),
        //            new("MINUTA", "MinutePackage"),
        //            new("CTE PEÇA", "CtePiece"),
        //            new("MINUTA", "MinutePiece"),
        //            new("RECEITA TOTAL", "TotalRevenue"),
        //            new("STATUS EMISSÕES", ""),
        //            new("FATURA", "Invoice"),
        //            new("PROTOCOLO", "Protocol")
        //        }
        //    }
        //};

        //        return await configManager.SaveSettingsToCloud(settings);
        //    }
        //}

    }
}
