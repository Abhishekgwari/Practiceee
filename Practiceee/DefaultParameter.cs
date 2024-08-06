using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    internal class DefaultParameter
    {
        static public void EmpDetails(string name, int Empid, string Blg = "O+", string Dep = "ReviewDep")
        {
            Console.WriteLine("Name" + " " + name);
            Console.WriteLine("Employee Id"+ " "+ Empid);
            Console.WriteLine("Blood group"+" " + Blg);
            Console.WriteLine("Department"+ " "+ Dep);


        }
        static void Main(string[] args)
        {
            EmpDetails("Abhishek", 1001);
            EmpDetails("Aman", 1002, "O-");
            EmpDetails("Lokesh", 1003, "B+", "Sowtware devloper");
        }

    }
}
