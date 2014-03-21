using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine.AI
{
    /*!
             * Schwere AI;  weniger hohe Gewinnchancen 
             * 
             * es werden ganzzahlige Werte zurückgegeben, um currentStickCount (generische Liste) zu bestimmen
             */

    public class AI_hard : Player
    {
<<<<<<< HEAD
		protected override int doTurn(int currentStickCount)
=======
        public override string ToString()
        {
            return "AI hard";
        }

		public override int Turn(int currentStickCount)
>>>>>>> refs/remotes/origin/ai
		{
            Random rnd = new Random();
            int n = 0;
            int temporary = 0;

            if (currentStickCount > 5)
            {
                if (rnd.Next(20) >= 2)
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
                else
                {
                    return rnd.Next(1, 4);
                }
            }

            else if (temporary == 5)
            {
                return 1;
            }

            else
            {
                return 1;
            }
                    
		}
    }
}
