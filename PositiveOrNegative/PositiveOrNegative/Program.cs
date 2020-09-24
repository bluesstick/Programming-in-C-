using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.Write("Wich number do you want to verify?: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("{0} is a positive number. ", num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number. ", num);
            }
            Console.ReadKey();
        }
    }
}
