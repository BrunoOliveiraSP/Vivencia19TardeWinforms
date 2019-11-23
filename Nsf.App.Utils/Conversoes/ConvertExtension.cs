using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.UI
{
    public static class ConvertExtension
    {
        public static int Int(this object obj, int @default = 0)
        {
            if (obj == null || obj.ToString() == string.Empty)
                return @default;

            return Convert.ToInt32(obj);
        }

        public static String Text(this object obj, string @default = "")
        {
            if (obj == null)
                return @default;

               return obj.ToString();
        }

        public static decimal Decimal(this object obj)
        {
            return Convert.ToDecimal(obj);
        }

        public static DateTime Date(this object obj)
        {
            return Convert.ToDateTime(obj);
        }

        public static bool Bool(this object obj)
        {
            return Convert.ToBoolean(obj);
        }

    }
}
