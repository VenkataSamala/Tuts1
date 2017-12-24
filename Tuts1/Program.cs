using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tuts1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter your name: ");
            string name = Console.ReadLine();
            int age = 0;
            do
            {
                Console.WriteLine("Please Enter your Age: ");
                age = Convert.ToInt16(Console.ReadLine());
            } while (age > 100);
            

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Your Name is {name}");
            Console.WriteLine($"Your Age is: {age}");
            Console.ReadLine();
        }
    }
}
