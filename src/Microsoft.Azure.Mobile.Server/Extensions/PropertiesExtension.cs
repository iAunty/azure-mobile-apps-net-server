using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Mobile.Server.Extensions
{
    public static class PropertiesExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="formatForUser"></param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static string FormatForUser(this string formatForUser ,string value1,string value2 = null)
        {
            return "FormatForUser : " + formatForUser + " : " + value1 + " , " + value2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formatForUser"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FormatInvariant(this string formatInvariant, Type type)
        {
            return "FormatInvariant : " + formatInvariant + " : " + type.ToString();
        }
    }
}
