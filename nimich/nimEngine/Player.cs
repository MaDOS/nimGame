using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine
{
    public abstract class Player
    {
    	/*! 
    	 * Sollte Funktionalität implementieren welche als Rückgabe die gezogenen Hölzchen angibt
    	 */
        public abstract int Turn(int currentStickCount);
        
        /*!
         * Genutzt um in späterer Verarbeitung Spieler von anderen unterscheiden zu können
         */
        public string ident
        {
        	internal set;
        	get;
        }
    }
}
