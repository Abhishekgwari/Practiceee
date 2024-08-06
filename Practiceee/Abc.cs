using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    internal class Abc
    {
        public void StudentAge()
        {
            int age = 0;
            age = age + 10;
            Console.WriteLine("student age " + age);

        }
        public static void Main()             
        {
            Abc obj = new Abc();               //Creating object
            obj.StudentAge();                // calling the function
        }
    }

    class Marks{

        int engMarks;
        int sciMarks;
        int matMarks;

        public static void Main()
        {
            Marks mks = new Marks();
            mks.sciMarks = 80;
            mks.engMarks = 50;
            mks.matMarks = 50;

            Marks mks2 = new Marks();
            mks2.sciMarks = 80;
            mks2.engMarks = 56;
            mks2.matMarks = 67;

            Console.WriteLine("Marks for first object:");
            Console.WriteLine(mks.sciMarks);
            Console.WriteLine(mks.engMarks);
            Console.WriteLine(mks.matMarks);

            // displaying marks for second object
            Console.WriteLine("Marks for second object:");
            Console.WriteLine(mks2.sciMarks);
            Console.WriteLine(mks2.engMarks);
            Console.WriteLine(mks2.matMarks);

        }
    
    
    }

    class Emp
    {
        static double salary;
        static string name = "Abhishek";

        public static void Main()
        {
            Emp.salary = 54000.00;
            Console.WriteLine(Emp.name +"Slaray is"+ Emp.salary);
            
        }

    }
}
