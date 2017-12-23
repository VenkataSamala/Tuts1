using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuts1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter your Age: ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Your Name is {name}");
            Console.WriteLine($"Your Age is: {age}");
            Console.ReadLine();
        }
    }
}
