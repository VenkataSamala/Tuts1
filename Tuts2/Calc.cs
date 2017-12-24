using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tuts2
{
    class Calc
    {
        public void Calculator(int x, int y)
        {
            Console.WriteLine("Please Enter two Integers");
            x = Convert.ToInt16(Console.ReadLine());
            y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please Enter a Operator Symbol like +, -, *, /, %");
            string sym = Console.ReadLine();
            switch (sym)
            {
                case "+":
                    Console.WriteLine(x + y);
                    break;
                case "-":
                    Console.WriteLine(x - y);
                    break;
                case "*":
                    Console.WriteLine(x - y);
                    break;
                case "/":
                    Console.WriteLine(x - y);
                    break;
            }
        }
    }
}
