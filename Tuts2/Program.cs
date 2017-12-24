using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuts2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Enter two Integers");
            //int x = Convert.ToInt16(Console.ReadLine());
            //int y = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Please Enter a Operator Symbol like +, -, *, /, %");
            //string sym = Console.ReadLine();

            #region SwitchCase
            /*
            switch (sym)
            {
                case "+":
                    Console.WriteLine(x + y);
                    break;
                case "-":
                    Console.WriteLine(x - y);
                    break;
                case "*":
                    Console.WriteLine(x * y);
                    break;
                case "/":
                    Console.WriteLine(x / y);
                    break;
            }*/
            #endregion
            #region IfElseIfNestedIf
            /*
            if (sym == "+")
            {
                Console.WriteLine($"{x} + {y}", x + y);
            }
            else if (sym == "-")
            {
                Console.WriteLine($"{x} - {y}", x + y);
            }
            else if (sym == "*")
            {
                Console.WriteLine($"{x} * {y}", x + y);
            }
            else if (sym == "/")
            {
                Console.WriteLine($"{x} / {y}", x + y);
            }*/
            #endregion
            #region Incriment

           
           int i = 5;
           int y = (i++) * (i++);
           int x = (++i) * (++i);
           int z = (++i) * (i++);
           Console.WriteLine(y);
           Console.WriteLine(x);
           Console.WriteLine(z);
           

            #endregion
            #region AddDivMulInSame
            /*
            int a = 20;
            int b = 10;
            int c = 15;
            int d = 5;
            int f = 5;
            int e = (a + b) * c / d + f;
            Console.WriteLine(e);
            */
            #endregion

            Console.ReadLine();
        }
    }
}
