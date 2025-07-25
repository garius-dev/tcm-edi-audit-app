﻿using KellermanSoftware.CompareNetObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public static T MapToObject<T>(List<string> row, ExcelHeaderConfig config) where T : new()
        {
            var obj = new T();

            foreach (var map in config.Columns)
            {
                if (!string.IsNullOrWhiteSpace(map.TargetProperty))
                {
                    var value = row.ElementAtOrDefault(map.ColumnIndex);
                    if (value == null) { continue; }
                    ObjectExtensions.SetPropertyValueFromString(obj, map.TargetProperty, value);
                }
            }

            return obj;
        }

        public static bool SetPropertyValueFromString(object obj, string propertyName, string value)
        {
            if (obj == null || string.IsNullOrWhiteSpace(propertyName))
                return false;

            var prop = obj.GetType().GetProperty(propertyName);
            if (prop == null || !prop.CanWrite)
                return false;

            var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

            try
            {
                object? convertedValue = ParseFromString(value, targetType);
                prop.SetValue(obj, convertedValue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static object? ParseFromString(string value, Type targetType)
        {
            if (string.IsNullOrWhiteSpace(value)) return null;

            if (targetType == typeof(string))
                return value;

            if (targetType == typeof(int) && int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var i))
                return i;

            if (targetType == typeof(decimal) && decimal.TryParse(value.Replace("R$", "").Trim(), NumberStyles.Any, new CultureInfo("pt-BR"), out var dec))
                return dec;

            if (targetType == typeof(double) && double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var d))
                return d;

            if (targetType == typeof(float) && float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var f))
                return f;

            if (targetType == typeof(bool) && bool.TryParse(value, out var b))
                return b;

            if (targetType == typeof(DateTime) && DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dt))
                return dt;

            if (targetType == typeof(Guid) && Guid.TryParse(value, out var g))
                return g;

            if (targetType.IsEnum)
                return Enum.Parse(targetType, value, ignoreCase: true);

            if (targetType == typeof(string[]))
                return value.Split(',').Select(s => s.Trim()).ToArray();

            throw new NotSupportedException($"Tipo não suportado: {targetType.Name}");
        }

        public static bool SetPropertyValueFromString2(object obj, string propertyName, string value)
        {
            if (obj == null || string.IsNullOrWhiteSpace(propertyName))
                return false;

            var prop = obj.GetType().GetProperty(propertyName);
            if (prop == null || !prop.CanWrite)
                return false;

            try
            {
                var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                object? convertedValue;

                if (targetType == typeof(decimal))
                {
                    // Usa ponto como separador decimal, independente da cultura do sistema
                    convertedValue = decimal.Parse(value, CultureInfo.InvariantCulture);
                }
                else if (targetType.IsEnum)
                {
                    convertedValue = Enum.Parse(targetType, value, ignoreCase: true);
                }
                else
                {
                    convertedValue = Convert.ChangeType(value, targetType, CultureInfo.InvariantCulture);
                }

                prop.SetValue(obj, convertedValue);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
