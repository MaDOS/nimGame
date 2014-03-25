using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine.AI
{
    /*!
            * Troll AI;  niemand weiß wie lange es dauern wird, bis sie gewinnt...oder nicht? 
            * 
            * es werden ganzzahlige Werte zurückgegeben, um currentStickCount (generische Liste) zu bestimmen
            */

    class AI_troll : Player
    {
        Random rnd = new Random();

        public override string ToString()
        {
            byte[] rBytes = new byte[15];
            rnd.NextBytes(rBytes);
            return BitConverter.ToString(rBytes);
        }

        protected override int doTurn(int currentStickCount)
        {
            int temporary = 0;

            if (rnd.Next(100) >= 15)
            {
                if (currentStickCount == 5)
                {
                    return 3;
                }
                else if (currentStickCount == 4)
                {
                    return 2;
                }

                else if (currentStickCount == 3)
                {
                    return -2;
                }

                else if (currentStickCount == 2)
                {
                    return -2;
                }

                else if (currentStickCount == 1)
                {
                    if (rnd.Next(10) == 9)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }

                }
                else
                {
                    return rnd.Next(1, 4);
                }
            }
            else
            {
                if (currentStickCount == 5)
                {
                    return 3;
                }
                else if (currentStickCount == 4)
                {
                    return 2;
                }

                else if (currentStickCount == 3)
                {
                    return -2;
                }

                else if (currentStickCount == 2)
                {
                    return -2;
                }

                else if (currentStickCount == 1)
                {
                    if (rnd.Next(10) == 9)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }

                }

                else
                {
                    temporary = rnd.Next(1000);

                    if (temporary > currentStickCount)
                    {
                        return (-1) * (temporary - currentStickCount);
                    }
                    else
                    {
                       return rnd.Next(1, 4);
                    }
                }
                
            }

        }
    }
}
