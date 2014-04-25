using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine
{
	public class Human : Player
    {
		/*!
		 * Nach setzen des AmountNextTurn gibt dieser die Rückgabe von doTurn() frei
		 */
		public bool ReadyForTurn = false;
		
		/*!
		 * Setzt die Rückgabe des nächsten Turns
		 */
		public int AmountNextTurn
		{
			set
			{
				this.amountNextTurn = value;
				this.ReadyForTurn = true;
			}
			get
			{
				return this.amountNextTurn;
			}
		}
		private int amountNextTurn;
		
		public Human(string ident)
		{
			this.ident = ident;
		}
        
		protected override int doTurn(int currentStickCount)
		{
			while(!this.ReadyForTurn)
			{
				
			}
			
			this.ReadyForTurn = false;
			
            
            return this.amountNextTurn;
		}
    }
}
