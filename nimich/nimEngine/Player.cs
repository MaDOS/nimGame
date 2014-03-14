using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine
{
    public abstract class Player
    {
        /*!
 		 *	Ausgelöst wenn der Zug von Player beginnt
    	 */
        public delegate void playerStartedTurnEventHandler(PlayerStartedTurnEventArgs eventArgs);
        public event playerStartedTurnEventHandler playerStartedTurn;

    	/*! 
    	 * Sollte Funktionalität implementieren welche als Rückgabe die gezogenen Hölzchen angibt
    	 */
        public int Turn(int currentStickCount)
        {
            this.playerStartedTurn(new PlayerStartedTurnEventArgs(this));
            return doTurn(currentStickCount);
        }

        protected abstract int doTurn(int currentStickCount);
        
        /*!
         * Genutzt um in späterer Verarbeitung Spieler von anderen unterscheiden zu können
         */
        public string ident
        {
        	internal set;
        	get;
        }
    }

    /*!
    * Enthält Referenz auf den Spieler der gerade zieht
    */
    public class PlayerStartedTurnEventArgs : EventArgs
    {
        public Player player;

        public PlayerStartedTurnEventArgs(Player player)
        {
            this.player = player;
        }
    }
}
