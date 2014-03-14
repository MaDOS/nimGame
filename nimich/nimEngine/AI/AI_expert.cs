using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine.AI
{
    public class AI_expert : Player
    {
		public override int Turn(int currentStickCount)
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
