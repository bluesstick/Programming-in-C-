using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplies_and_adds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, operation;
            

            Console.Write("If you want to Multiplay please press 1 or 2 if you want to Add: "); 
            operation = Convert.ToInt32(Console.ReadLine()); 
            
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {

                Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            }   Console.ReadKey();
        }
    }
}
