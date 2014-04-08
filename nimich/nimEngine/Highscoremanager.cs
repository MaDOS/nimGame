using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace nimEngine
{
    public static class Highscoremanager
    {
        private static string filePath = Environment.SpecialFolder.Desktop + @"\highscores.hsc";

        public static Dictionary<string, Highscoreprofile> highscoreProfiles = new Dictionary<string, Highscoreprofile>();

        public static void save()
        {
            serializer.XMLserializer serializer = new serializer.XMLserializer(filePath);
            serializer.Serialize<Dictionary<string, Highscoreprofile>>(highscoreProfiles);
        }

        public static void load()
        {
            serializer.XMLserializer serializer = new serializer.XMLserializer(filePath);
            highscoreProfiles = serializer.Deserialize<Dictionary<string, Highscoreprofile>>();
        }

        public static void addWin(string playername)
        {
            if (!highscoreProfiles.ContainsKey(playername))
            {
                highscoreProfiles.Add(playername, new Highscoreprofile(playername));
            }

            highscoreProfiles[playername].Won++;
        }

        public static void addLose(string playername)
        {
            if (!highscoreProfiles.ContainsKey(playername))
            {
                highscoreProfiles.Add(playername, new Highscoreprofile(playername));
            }

            highscoreProfiles[playername].Lost++;
        }
    }
}
