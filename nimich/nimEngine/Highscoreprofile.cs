using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine
{
    [Serializable]
    public class Highscoreprofile
    {
        public string Playername
        {
            get;
            set;
        }

        public int Lost
        {
            get;
            set;
        }

        public int Won
        {
            get;
            set;
        }
        
        public float WonPerLost
        {
        	get
        	{
        		if(Lost == 0)
        		{
        			return Won;
        		}
        		return Won / Lost;
        	}
        }

        public Highscoreprofile()
        {
            this.Playername = "";
            this.Lost = 0;
            this.Won = 0;
        }
        
        public override string ToString()
		{
			return string.Format("[Highscoreprofile Playername={0}, Lost={1}, Won={2}]", Playername, Lost, Won);
		}

    }
}
