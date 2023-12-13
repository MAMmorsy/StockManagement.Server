using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.CORE.Helpers
{
    public static class Helper
    {
        public static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                return ((DescriptionAttribute)attributes[0]).Description;
            }
            return value.ToString();
        }

        public static decimal RandomDecimal()
        {
            int a = RandomNumber(1, 100);
            int b = RandomNumber(0, 99);

            string c = a + "." + b;
            decimal d = decimal.Parse(c);
            return d;
        }

        public static int RandomNumber(int min, int max)
        {
            Random _random = new Random();
            return _random.Next(min, max);
        }

    }
}
