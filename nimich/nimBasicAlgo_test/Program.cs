using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimBasicAlgo_test
{
    class Program
    {
        static Stack<bool> sticks = new Stack<bool>();

        static void Main(string[] args)
        {
            int stickCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < stickCount; i++)
            {
                sticks.Push(true);
            }

            while (sticks.Count > 0)
            {
                turn();
            }
            Console.ReadKey(true);
        }

        static void turn()
        {
            int remainingStickCount = sticks.Count;
            int amount = 0;

            while (amount < 1 || amount > 3)
            {
                Console.Write("Amount you want to take: ");
                amount = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < amount; i++)
            {
                sticks.Pop();
            }

            printSticks();
        }

        static void printSticks()
        {
            int remainingStickCount = sticks.Count;
            for (int i = 0; i < remainingStickCount; i++)
            {
                Console.Write("| ");
            }
            Console.WriteLine(System.Environment.NewLine + "There are " + remainingStickCount + " sticks left");
        }
    }
}
