using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine
{
    public abstract class Player
    {
        /*!
 		 *	Ausgelöst wenn der Zug vom Player beginnt
    	 */
        public delegate void playerStartedTurnEventHandler(PlayerStartedTurnEventArgs eventArgs);
        public event playerStartedTurnEventHandler playerStartedTurn;

        /*!
         * Von Game aufgerufene Methode welche (möglicherweise) wartet bis der Spieler seinen Zug gemacht hat und Game die gezogene Hölzchenanzahl übermittelt
         */
        public int Turn(int currentStickCount)
        {
            this.playerStartedTurn(new PlayerStartedTurnEventArgs(this));
            return doTurn(currentStickCount);
        }

        /*! 
    	 * Sollte Funktionalität implementieren welche als Rückgabe die gezogenen Hölzchenanzahl angibt
    	 */
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
