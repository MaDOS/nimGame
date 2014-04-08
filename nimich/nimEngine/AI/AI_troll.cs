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

    public class AI_troll : Player
    {
        Random rnd = new Random();

        private string name;

        public AI_troll()
        {
            this.name = genName();
            this.ident = name;
        }

        private string genName()
        {
            byte[] rBytes = new byte[15];
            rnd.NextBytes(rBytes);
            return BitConverter.ToString(rBytes);
        }

        public override string ToString()
        {
            return name;
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
                    if (rnd.Next(10) >= 5)
                    {
                        return 3;
                    }
                    else
                    {
                        return -2;
                    }
                    
                }
                else if (currentStickCount == 4)
                {
                    if (rnd.Next(10) >= 5)
                    {
                        return 2;
                    }

                    else
                    {
                        return -3;
                    }
                }

                else if (currentStickCount == 3)
                {
                    return -2;
                }

                else if (currentStickCount == 2)
                {
                    if (rnd.Next(10) >= 5)
                    {
                        return -1;
                    }

                    else
                    {
                        return -3;
                    }
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
