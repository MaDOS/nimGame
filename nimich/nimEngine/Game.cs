using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace nimEngine
{
    public class Game
    {
    	/*!
 		 *	Ausgelöst wenn ein Spieler das letzte Holz gezogen hat
    	 */
        public delegate void gameOverEventHandler(GameOverEventArgs eventArgs);
        public event gameOverEventHandler gameOver;

        /*! 
         * Gibt den momentanen Stand der übrigen Hölzchen zurück
         */
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
        * Startet das Spiel
        */
        public void start()
        {
        	Thread gameThread = new Thread(new ThreadStart(run));
        	gameThread.Start();
        }
        
        /*!
         * Eigentliche Methode in der das Spiel ausgeführt wird
         * 
         * Diese wird allerdings in einem neuen Thread von start() aufgerufen um den Hauptthread nicht zu blockieren
         */
        private void run()
        {
        	while(true)
        	{
        		this.takeSticks(player1.Turn(this.StickCount));
        		if(this.StickCount == 0)
        		{
        			//Player 1 lost
        			Console.WriteLine("Player 1 lost");

                    this.gameOver(new GameOverEventArgs(this.player2, this.player1));
        			break;
        		}
        		
        		this.takeSticks(player2.Turn(this.StickCount));
        		if(this.StickCount == 0)
        		{
        			//Player 2 lost
        			Console.WriteLine("Player 2 lost");

                    this.gameOver(new GameOverEventArgs(this.player1, this.player2));
        			break;
        		}
        	}
        }
        
        private void takeSticks(int count)
        {
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    this.sticks.Pop();
                }
            }
            else
            {
                for (int i = 0; i > count; i--)
                {
                    this.sticks.Push(new Stick());
                }
            }
        }
    }

    /*!
     * Enthält Referenzen auf Gewinner und Verlierer
     */
    public class GameOverEventArgs : EventArgs
    {
        public Player winner;
        public Player loser;

        public GameOverEventArgs(Player winner, Player loser)
        {
            this.winner = winner;
            this.loser = loser;
        }
    }
    
   
}
