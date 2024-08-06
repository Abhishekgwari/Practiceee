using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    internal class Params
    {
        public static int Add(params int[] listnumbers)
        {
            int total = 0;
            foreach (int i in listnumbers)
            {
                total += i;
            }
            return total;
        }

        static void Main(string[] args) {
            int y = Add(5, 10, 15, 20,50,100);
                Console.WriteLine(y);
            Console.ReadLine(); 
        
        
        }

    }
}
