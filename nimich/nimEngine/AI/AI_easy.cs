using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine.AI
{
    public class AI_easy : Player
    {
    	Random rnd = new Random();
    	
		public override int Turn(int currentStickCount)
		{
			if(currentStickCount > 5)
			{
				return rnd.Next(1,3); 
			}
			else
			{
				if(currentStickCount < 4)
				{
					rnd.Next(1,(currentStickCount + 1));
				}
				else
				{
					rnd.Next(1,4);
				}
			}
		}
    }
}
