using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace nimEngine
{
    [Serializable]
    /*!
     * Speichert relevante Highscoredaten eines Spielers
     */
    public class Highscoreprofile
    {
        /*!
         * "ident" oder auch Name des Spielers (Identifikationsname)
         */
        public string Playername
        {
            get;
            set;
        }

        /*!
         * Anzahl der Niederlagen
         */
        public int Losses
        {
            get;
            set;
        }

        /*!
         * Anzahl der Siege
         */
        public int Won
        {
            get;
            set;
        }

        /*!
         * "WPL" Durschnitt gewonnener pro verlorener Spiele
         */
        public float WonPerLost
        {
        	get
        	{
        		float val;
        		if(Losses == 0)
        		{
        			val = Won;
        		}
        		else
        		{
        			val = ((float)Won / (float)Losses);
        		}        			       
        		return val;
        	}
        }

        public Highscoreprofile()
        {
            this.Playername = "";
            this.Losses = 0;
            this.Won = 0;
        }
        
        public override string ToString()
		{
			return string.Format("[Highscoreprofile Playername={0}, Lost={1}, Won={2}]", Playername, Losses, Won); //War mal relevant zum debuggen wird der Übersichtlichkeit halber aber nicht entfernt
		}

    }
}
