using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine
{
    public class Game
    {
        public delegate void gameOverEventHandler(GameOverEventArgs eventArgs);
        public event gameOverEventHandler gameOver;

        public int StickCount
        {
            get
            {
                return this.sticks.Count;
            }
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
        
        /*!
        * spiel wird gestartet
        */
        public void start()
        {
        	while(true)
        	{
        		this.takeSticks(player1.Turn(this.StickCount));
        		if(this.StickCount == 0)
        		{
        			//Player 1 lost
        			Console.WriteLine("Player 1 lost");

                    this.gameOver(new GameOverEventArgs(false));
        			break;
        		}
        		this.takeSticks(player2.Turn(this.StickCount));
        		if(this.StickCount == 0)
        		{
        			//Player 2 lost
        			Console.WriteLine("Player 2 lost");

                    this.gameOver(new GameOverEventArgs(true));
        			break;
        		}
        	}
        }
        
        private void takeSticks(int count)
        {
        	for(int i = 0; i < count; i++)
        	{
        		this.sticks.Pop();
        	}
        }
    }

    public class GameOverEventArgs : EventArgs
    {
        public bool player1Won = false;

        public GameOverEventArgs(bool player1Won)
        {
            this.player1Won = player1Won;
        }
    }
}
