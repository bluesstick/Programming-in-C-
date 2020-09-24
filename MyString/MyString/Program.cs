using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Odd Number");
                Console.Read();

                Console.ReadKey();
            }
        }    
    }
}
