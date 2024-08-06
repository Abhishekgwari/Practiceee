using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    internal class Nmaedparameter
    {
        public static void addstr(string name , int  age,string  address)
        {
            Console.WriteLine("Name" + name);
            Console.WriteLine("Age" + age);
            Console.WriteLine("Address" + address);

        }
        public static void Main()
        {
            //addstr(14,"abhishek","Delhi");
            addstr(age:15,name:"Abhishek",address:"delhi");
        }
    }
}
