using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nimEngine.AI
{
    /*!
         * Leichte AI; hohe Gewinnchancen 
         * 
         * es werden ganzzahlige Werte zurückgegeben, um currentStickCount (generische Liste) zu bestimmen
         */

    public class AI_easy : Player
    {
    	Random rnd = new Random();

		public override int Turn(int currentStickCount)
		{
            if (currentStickCount > 5)
            {
                return rnd.Next(1, 4);
            }
            else if (currentStickCount == 5)
            {
                return rnd.Next(1, 4);
            }

            else if (currentStickCount == 4)
            {
                return rnd.Next(1, 3);
            }
            else if (currentStickCount == 3)
            {
                if (rnd.Next(10) >= 2)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            else if (currentStickCount == 2)
            {
                if (rnd.Next(10) > 1)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
		}
    }
}
