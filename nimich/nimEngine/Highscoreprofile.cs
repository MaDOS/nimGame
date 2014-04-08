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

        public Highscoreprofile(string playername)
        {
            this.Playername = playername;
            this.Lost = 0;
            this.Won = 0;
        }
    }
}
