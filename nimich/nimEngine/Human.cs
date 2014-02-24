using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine
{
	public class Human : Player
    {
		public override int Turn(int currentStickCount)
		{
            int amount = 0;

            while (amount < 1 || amount > currentStickCount)
            {
                Console.Write("Amount you want to take: ");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            
            return amount;
		}
    }
}
