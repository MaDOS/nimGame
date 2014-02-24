using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine
{
    public class Game
    {
        public int StickCount
        {
            get
            {
                return this.sticks.Count;
            }
            private set;
        }
        
        private Stack<Stick> sticks;
        private Player player1;
        private Player player2;

        public Game(Player player1, Player player2, int stickCount)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.sticks = new Stack<Stick>();
            for(int i = 0; i < stickCount; i++)
            {
                this.sticks.Push(new Stick());
            }
        }
        
        public void start()
        {
        	while(true)
        	{
        		this.sticks.Pop(player1.Turn(this.StickCount));
        		if(this.StickCount == 0)
        		{
        			//Player 1 lost
        			Console.WriteLine("Player 1 lost");
        			break;
        		}
        		this.sticks.Pop(player2.Turn(this.StickCount));
        		if(this.StickCount == 0)
        		{
        			//Player 2 lost
        			Console.WriteLine("Player 2 lost");
        			break;
        		}
        	}
        }
    }
}
