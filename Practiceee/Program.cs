using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    internal class Program
    {
        static void print()
        {
            Console.WriteLine("Hello world");
        }

        static void Circumference(int r)
        {
            Console.WriteLine("Circumference " + 2*(22 / 7) * r);
        }


        static void add(int n1, int n2)           // formal parameter (arguments) because they dont contain actual value
        {                                        // we use void return type when we use done with everything
            int sum = n1 + n2;

            Console.WriteLine(sum);
        }


        

        static int product()
        {
            int x = 7, y = 22,res;
            res = 22 * 7;
            return res;


        }
        static int factorial(int n)
        {
            int fact = 1;
           for(int i =1; i<=n; i++)
            {
                fact = fact * i;          // 1x1 =1// 1x2=2 //2x3=6 // 6*4 =24// 24*5=120 
            }
            return fact;
        }

        static int subtract(int n1, int n2) {            // if we use sub returntype so we can reuse it

            int sub = n1 - n2;
             return sub;
        }
        
       
        static void Main(string[] args)
        {
            int radius = 7, getres;
                 print();
            Circumference(radius);
           
            getres = product();
            Console.WriteLine(getres);

            Console.WriteLine(factorial(5));

            int num1 = 100, num2 = 200;

            add(400, 400);            // actual parameter (arguments)cauz they conatin actual value 

            int n1 = 34, n2 = 20;
       int sub =     subtract(n1, n2);

            Console.WriteLine(sub);
        }
    }
}
