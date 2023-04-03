using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation.Helper
{
    internal static class CobDateHelper
    {
        public static string GetPreviousCobDate(string cobDate)
        {
            var cobDateToDateTimeMinusOne = DateTime.ParseExact(cobDate, "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(-1);

            return cobDateToDateTimeMinusOne.ToString("yyyyMMdd");
        }
    }
}
