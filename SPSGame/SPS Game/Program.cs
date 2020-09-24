using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int Player = 1, Playerone;
            string Move, Machine;
            string[] Games = { "Stone", "Paper", "Scissors" };

            while (Player == 1)
            {
                Console.Write("Please make your choise: [1.Paper;2.Scissors;3.Stone]:");
                Playerone = int.Parse(Console.ReadLine());
                Machine = Games[rnd.Next(0, 2)];
                Move = Games[Playerone - 1];

                if ((Move == "Paper") && (Machine == "Stone"))
                    Console.WriteLine("Player one win");
                    else if ((Move == "Scissors") && (Machine == "Paper"))
                    Console.WriteLine("Player one win");
                    else if ((Move == "Stone") && (Machine == "Scissors"))
                    Console.WriteLine("Player one win");

                if ((Machine == "Scissors") && (Move == "Scissors"))
                    Console.WriteLine("Tie");
                else if ((Machine == "Stone") && (Move == "Stone"))
                    Console.WriteLine("Tie");
                else if ((Machine == "Paper") && (Move == "Paper"))
                    Console.WriteLine("Tie");

                if ((Machine == "Paper") && (Move == "Stone"))
                    Console.WriteLine("Machine win");
                else if ((Machine == "Scissors") && (Move == "Paper"))
                    Console.WriteLine("Machine win");
                else if ((Machine == "Stone") && (Move == "Scissors"))
                    Console.WriteLine("Machine win");


            }
            Console.Write("Do you want to play more?  1: Yes  0: No");
            Player = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
