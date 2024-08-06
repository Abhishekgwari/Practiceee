using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    internal class ValueParameter
    {
        static public string addvalue(string s1, string s2)
    {
        return s1 + s2;
    }
        static void Main()
        {

            string str1 = "Abhishek";
            string str2 = "Gwari";
            string res = addvalue(str1, str2);
            Console.WriteLine(res);
        }
    }
}
