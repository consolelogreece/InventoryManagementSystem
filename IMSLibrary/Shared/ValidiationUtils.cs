using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary.Shared
{
    public static class ValidiationUtils
    {
        /// <summary>
        /// Check if string is valid decimal type.
        /// </summary>
        /// <param name="val">String to check</param>
        /// <returns>True/False depending if valid decimal</returns>
        public static bool IsValidDecimal(string val)
        {
            return Decimal.TryParse(val, out var x);
        }

        /// <summary>
        /// Check if string is valid int type.
        /// </summary>
        /// <param name="val">String to check</param>
        /// <returns>True/False depending if valid int</returns>
        public static bool IsValidInt(string val)
        {
            return int.TryParse(val, out var x);        
        }

        /// <summary>
        /// Check if string is valid DateTime type.
        /// </summary>
        /// <param name="val">String to check</param>
        /// <returns>True/False depending if valid DateTime</returns>
        public static bool IsValidDate(string val)
        {
            return DateTime.TryParse(val, out var x);
        }
    }
}
