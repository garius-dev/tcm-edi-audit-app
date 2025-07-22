using KellermanSoftware.CompareNetObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcm_edi_audit_core_new.Models.EDI.Settings;

namespace tcm_edi_audit_core_new.Extensions
{
    public static class ObjectExtensions
    {
        public static T? DeepClone<T>(this T source)
        {
            if (source == null)
                return default;

            try
            {
                var json = JsonConvert.SerializeObject(source,
                    new JsonSerializerSettings
                    {
                        PreserveReferencesHandling = PreserveReferencesHandling.None,
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        TypeNameHandling = TypeNameHandling.Auto
                    });

                return JsonConvert.DeserializeObject<T>(json,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao clonar objeto: {ex.Message}");
                return default;
            }
        }

        public static bool IsDifferentTo<T>(this T obj1, T obj2)
        {
            var comparer = new CompareLogic();
            var result = comparer.Compare(obj1, obj2);

            return !result.AreEqual;
        }

        public static List<ExcelPatternColumnSettings> LoadDefaultExcelColumns()
        {
            List<ExcelPatternColumnSettings> excelPatternColumnSettings = new List<ExcelPatternColumnSettings>();

            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("Flow", 1, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("State", 2, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("DistanceKm", 3, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("ScheduledVehicle", 4, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("RequestCode", 5, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("Cva", 6, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("CtePackage", 7, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("MinutePackage", 8, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("CtePiece", 9, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("MinutePiece", 10, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("TotalRevenue", 11, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("Invoice", 12, true));
            excelPatternColumnSettings.Add(new ExcelPatternColumnSettings("Protocol", 13, true));

            return excelPatternColumnSettings;
        }
    }
}
