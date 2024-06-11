using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASTMAN.Util
{
    public class LogHelper
    {
        public static string ToStringList<T>(List<T> values)
        {
            if(values == null)
            {
                return "";
            }
            string output = "";
            output += "{\n";
            for(int i = 0; i < values.Count; i++)
            {
                output += $"\t\t{values[i].ToString()}\n";
            }
            output += "\t}";
            return output;
        }
    }
}
