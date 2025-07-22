using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tcm_edi_audit_core_new.Models.EDI.Settings;

namespace tcm_edi_audit_core_new.Extensions
{
    public static class TextExtensions
    {
        public static string ToEdiTotalValueString(this decimal value)
        {
            if (value % 1 != 0)
            {
                value = Math.Truncate(value * 100) / 100;
                return value.ToString("F2")
                            .Replace(".", string.Empty)
                            .Replace(",", string.Empty);
            }
            else
            {
                return value.ToString()
                            .Replace(".", string.Empty)
                            .Replace(",", string.Empty);
            }
        }

        public static bool ValidateStringBounds(this string text, int startPosition, int textLenght)
        {
            return startPosition >= 0 && startPosition + textLenght <= text.Length;
        }


        public static string ParseToExcelString(this IXLRangeRow cellRow, ExcelPatternColumnSettings rule)
        {
            string text = string.Empty;

            var cellValue = cellRow.Cell(rule.ColumnPosition);

            if (cellValue != null)
            {
                text = cellValue.GetString();

                if (rule.TrimColumn)
                {
                    text = text.Trim();
                }

                if (!string.IsNullOrEmpty(rule.RegexKey) && !string.IsNullOrEmpty(rule.RegexValue))
                {
                    text = Regex.Replace(text, rule.RegexKey, rule.RegexValue);
                }
            }

            return text;
        }

        public static int ParseToExcelInt(this IXLRangeRow cellRow, ExcelPatternColumnSettings rule)
        {            
            var cellValue = cellRow.Cell(rule.ColumnPosition);

            if (cellValue != null && cellValue.Value.IsNumber)
            {
                return int.TryParse(cellValue.GetString(), out var result) ? result : throw new NotImplementedException($"Impossível converter a célula {cellValue.Address.ToString()} para número.");
            }

            if(cellValue != null)
            {
                throw new NotImplementedException($"Impossível converter a célula {cellValue.Address.ToString()} para número.");
            }
            else
            {
                throw new NotImplementedException($"Erro ao tentar converter uma célula do Excel para número");
            }
        }

        public static decimal ParseToExcelCurrency(this IXLRangeRow cellRow, ExcelPatternColumnSettings rule)
        {
            var cellValue = cellRow.Cell(rule.ColumnPosition);

            if(cellValue != null)
            {
                if (string.IsNullOrWhiteSpace(cellValue.GetString())) return 0;

                string input = cellValue.GetString().Replace("R$", "").Trim();

                return decimal.TryParse(input, NumberStyles.Any, new CultureInfo("pt-BR"), out var result)
                    ? result
                    : 0;
            }

            throw new NotImplementedException($"Erro ao tentar converter uma célula do Excel para moeda");
        }

    }
}
