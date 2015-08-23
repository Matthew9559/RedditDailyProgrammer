using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Helpers
{
    public static class ParseHelper
    {
        public static bool ParseBoolValue(this string data)
        {
            var result = false;

            bool.TryParse(data, out result);

            return result;
        }
    }
}
