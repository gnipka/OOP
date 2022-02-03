using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson2
{
    class WorkWithString
    {
        public static string ReverseString(string str)
        {
            var sb = new StringBuilder();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
