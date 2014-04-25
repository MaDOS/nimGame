using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimGUI
{
    [Serializable]
    public class SettingsProfile
    {
        public int StickCount
        {
            get;
            set;
        }

        public SettingsProfile()
        {
            this.StickCount = 13;
        }

        public override string ToString()
        {
            return string.Format("[SettingsProfile StickCount={0}]", StickCount); //War mal relevant zum debuggen wird der Übersichtlichkeit halber aber nicht entfernt
        }
    }
}
