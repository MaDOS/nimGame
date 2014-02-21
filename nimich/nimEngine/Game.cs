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
    }
}
