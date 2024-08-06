using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    internal class Refparameter
    {
        static void changevalue(ref int count)
        {
            count = 50;

        }

        static void Main(string[] args)
        {
            int count = 10;        // if we write int count; and don't initialize it so it will give a error
            changevalue(ref count);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
