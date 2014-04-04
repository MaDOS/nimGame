using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine.AI
{
    /*!
            * Experten AI;  bei Fehler eines Spielers keine Gewinnmöglichkeit 
            * 
            * es werden ganzzahlige Werte zurückgegeben, um currentStickCount (generische Liste) zu bestimmen
            */

    public class AI_expert : Player
    {
        public override string ToString()
        {
            return "Experte";
        }

		protected override int doTurn(int currentStickCount)
		{
			Random rnd = new Random();
            int n = 0;
            int temporary = 0;

            if (currentStickCount > 5)
            {
                for (int i = 1; i < 1000; i++)
                {

                    temporary = 5 + (4 * n);
                    n++;

                    if (temporary >= currentStickCount)
                    {
                        i = 1000;
                    }
                }

                if (temporary == currentStickCount)
                {
                    return 1;
                }

                else if (temporary > currentStickCount)
                {
                    temporary = temporary - currentStickCount;

                    if (temporary == 3)
                    {
                        return 1;
                    }

                    if (temporary == 2)
                    {
                        return 2;
                    }

                    else
                    {
                        return 3;
                    }

                }
                else
                {
                    return rnd.Next(1, 4);
                }
            }
            else if (currentStickCount == 4)
            {
                return 3;
            }
            else if (currentStickCount == 3)
            {
                return 2;
            }

            else if (currentStickCount == 2)
            {
                return 1;
            }
            else if (currentStickCount == 1)
            {
                return 1;
            }
            else
            {
                return rnd.Next(1, 4);
            }
		}
    }
}
