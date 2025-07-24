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
        public class ExcelSheetRawData
        {
            public string SheetName { get; set; } = string.Empty;
            public List<List<string>> DataRows { get; set; } = new List<List<string>>();
            public HeaderConfiguration MatchedHeader { get; set; } = new HeaderConfiguration();
        }

        public class ExcelSheetParsedResult
        {
            public string SheetName { get; set; } = string.Empty;
            public List<ExcelEntry> Entries { get; set; } = new List<ExcelEntry>();
        }

        public class HeaderMapping
        {
            public string HeaderName { get; set; }
            public string TargetProperty { get; set; }
            public int ColumnIndex { get; set; }

            public HeaderMapping(string headerName, string targetProperty, int columnIndex)
            {
                this.HeaderName = headerName;
                this.TargetProperty = targetProperty;
                this.ColumnIndex = columnIndex;
            }
        }

        public class HeaderConfiguration
        {
            public List<HeaderMapping> Columns { get; set; } = new List<HeaderMapping>();
        }


        private HeaderConfiguration? MatchHeaders(List<HeaderConfiguration> knownHeaders, List<string> sheetHeaders)
        {
            if (!knownHeaders.IsNullOrEmpty() && !sheetHeaders.IsNullOrEmpty())
            {
                foreach (var headerSet in knownHeaders)
                {
                    var expectedHeaders = headerSet.Columns.Select(c => c.HeaderName.NormalizeText()).ToList();
                    bool isMatch = sheetHeaders.Take(headerSet.Columns.Count).SequenceEqual(expectedHeaders);
                    if (isMatch)
                        return headerSet;
                }
            }

            return null;
        }

        public List<ExcelSheetParsedResult> ParseValidExcelSheets(string filePath)
        {
            var headerConfigurations = new List<HeaderConfiguration>();

            // Primeiro modelo de cabeçalho
            var headerSet1 = new List<HeaderMapping>
            {
                new("FLUXO", "Flow", 0),
                new("FORNECEDOR", "", 1),
                new("UF", "State", 2),
                new("FAIXA KM", "DistanceKm", 3),
                new("VEÍCULO PROGRAMADO", "ScheduledVehicle", 4),
                new("CVA", "Cva", 5),
                new("CTE EMBALAGEM", "CtePackage", 6),
                new("MINUTA", "MinutePackage", 7),
                new("CTE PEÇA", "CtePiece", 8),
                new("MINUTA", "MinutePiece", 9),
                new("RECEITA TOTAL", "TotalRevenue", 10),
                new("FATURA", "Invoice", 11),
                new("PROTOCOLO", "Protocol", 12),
            };
            headerConfigurations.Add(new HeaderConfiguration { Columns = headerSet1 });

            // Segundo modelo
            var headerSet2 = new List<HeaderMapping>
            {
                new("FLUXO", "Flow", 0),
                new("FORNECEDOR", "", 1),
                new("UF", "State", 2),
                new("FAIXA KM", "DistanceKm", 3),
                new("VEÍCULO PROGRAMADO", "ScheduledVehicle", 4),
                new("CVA", "Cva", 5),
                new("CTE EMBALAGEM", "CtePackage", 6),
                new("MINUTA", "MinutePackage", 7),
                new("CTE PEÇA", "CtePiece", 8),
                new("MINUTA", "MinutePiece", 9),
                new("RECEITA TOTAL", "TotalRevenue", 10),
                new("STATUS EMISSÕES", "", 11),
                new("FATURA", "Invoice", 12),
                new("PROTOCOLO", "Protocol", 13),
            };
            headerConfigurations.Add(new HeaderConfiguration { Columns = headerSet2 });

            // Terceiro modelo
            var headerSet3 = new List<HeaderMapping>
            {
                new("DATA COLETA", "", 0),
                new("ORIGEM", "", 1),
                new("UF", "State", 2),
                new("DESTINO", "", 3),
                new("UF", "", 4),
                new("STE", "", 5),
                new("CVA", "Cva", 6),
                new("COLETA", "Flow", 7),
                new("VEÍCULO SOLICITADO", "ScheduledVehicle", 8),
                new("KM", "DistanceKm", 9),
                new("CTE EMBALAGEM", "CtePackage", 10),
                new("MINUTA", "MinutePackage", 11),
                new("CTE PEÇA", "CtePiece", 12),
                new("MINUTA", "MinutePiece", 13),
                new("RECEITA TOTAL", "TotalRevenue", 14),
                new("STATUS EMISSÕES", "", 15),
                new("FATURA", "Invoice", 16),
                new("PROTOCOLO", "Protocol", 17),
            };
            headerConfigurations.Add(new HeaderConfiguration { Columns = headerSet3 });

            var parsedResults = new List<ExcelSheetParsedResult>();
            var validSheets = new List<ExcelSheetRawData>();

            using var workbook = new XLWorkbook(filePath);

            foreach (var sheet in workbook.Worksheets)
            {
                var range = sheet.RangeUsed();
                if (range == null) continue;

                var headerRow = range.Row(1);
                var sheetHeaders = headerRow.Cells().Select(c => c.GetString().NormalizeText(true, true)).ToList();

                var matchedHeader = MatchHeaders(headerConfigurations, sheetHeaders);
                if (matchedHeader == null) continue;

                var sheetData = new ExcelSheetRawData { SheetName = sheet.Name, MatchedHeader = matchedHeader };

                foreach (var row in range.RowsUsed().Skip(1))
                {
                    var rowValues = row.Cells(1, matchedHeader.Columns.Count)
                                       .Select(c => c.GetString().Trim())
                                       .ToList();

                    if (rowValues.All(string.IsNullOrWhiteSpace))
                        continue;

                    sheetData.DataRows.Add(rowValues);
                }

                validSheets.Add(sheetData);
            }

            foreach (var sheet in validSheets)
            {
                var sheetResult = new ExcelSheetParsedResult { SheetName = sheet.SheetName };

                foreach (var row in sheet.DataRows)
                {
                    var entry = new ExcelEntry();
                    foreach (var column in sheet.MatchedHeader.Columns)
                    {
                        ObjectExtensions.SetPropertyValueFromString(entry, column.TargetProperty, row[column.ColumnIndex]);
                    }
                    sheetResult.Entries.Add(entry);
                }

                parsedResults.Add(sheetResult);
            }

            return parsedResults;
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


    }
}
