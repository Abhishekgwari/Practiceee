using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    internal class Outparameter
    {
        static void Changevalue(out int count)
        {
            count = 50;
        }

        static void Main(string[] args) {
            int count = 10;
            Changevalue(out count);
            Console.WriteLine(count);
            Console.ReadLine();
        
        
        }
    }
}
