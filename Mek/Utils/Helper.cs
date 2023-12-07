using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mek.Utils
{
    public static partial class Helper
    {
        public static decimal GetValueAsDecimal(XElement element)
        {
            var val = element?.Value;
            if (val != null)
                return Convert.ToDecimal(val.Replace('.', ','));
            return 0;
        }

        public static DateTime? GetValueAsDateTime(XElement element)
        {
            var val = element?.Value;
            if (val != null)
                return Convert.ToDateTime(val);
            return null;
        }

        public static int? GetValueAsInt(XElement element)
        {
            var val = element?.Value;
            if (val == null)
                return null;
            if (val.IndexOf('.') >= 0)
            {
                val = val.Replace('.', ',');
                return Convert.ToInt32((Convert.ToDouble(val)));
            }
            return Convert.ToInt32(val);

        }
        public static byte? GetValueAsByte(XElement element)
        {
            var val = element?.Value;
            if (val != null)
                return Convert.ToByte(val);
            return null;
        }

        public static double GetYearsDifference(DateTime startDate, DateTime endDate)
        {
            TimeSpan span = endDate - startDate;

            // Вычисляем разницу в годах с точностью до дня
            double yearsDifference = span.TotalDays / 365.2425;

            return yearsDifference;
        }
        public static int GetYearsDifference2(DateTime startDate, DateTime endDate)
        {
            int yearsDifference = endDate.Year - startDate.Year;

            // Проверяем, нужно ли скорректировать результат
            if (endDate.Month < startDate.Month || (endDate.Month == startDate.Month && endDate.Day < startDate.Day))
            {
                yearsDifference--;
            }

            return yearsDifference;
        }
    }
}
