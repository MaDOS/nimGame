﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine.AI
{
    /*!
         * Mittelschwere AI; gemäßigte Gewinnchancen 
         * 
         * es werden ganzzahlige Werte zurückgegeben, um currentStickCount (generische Liste) zu bestimmen
         */

    public class AI_intermediate : Player
    {
        private string name = "Mittel";

        public AI_intermediate()
        {
            this.ident = name;
        }

        public override string ToString()
        {
            return name;
        }

		protected override int doTurn(int currentStickCount)
		{
            Random rnd = new Random();
            int n = 0;
            int temporary = 0;

            if (currentStickCount > 5)
            {
                if (rnd.Next(10) >= 5)
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
                        return rnd.Next(1, 4);
                    }

                    else if (temporary > currentStickCount)
                    {
                        if (rnd.Next(10) > 7)
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
                else
                {
                    return rnd.Next(1, 4);
                }
            }

            else if (currentStickCount == 3)
            {
                return rnd.Next(1,3);
            }

            else if (currentStickCount < 3)
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
