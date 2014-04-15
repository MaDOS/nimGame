using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace nimEngine
{
    public static class Highscoremanager
    {
        private static string filePath = Environment.CurrentDirectory + @"\highscores.hsc";

        public static Dictionary<string, Highscoreprofile> highscoreProfiles = new Dictionary<string, Highscoreprofile>();

        public static void save()
        {
            serializer.XMLserializer serializer = new serializer.XMLserializer(filePath);
            
            serializer.Serialize<Highscoreprofile[]>(highscoreProfiles.Values.ToArray<Highscoreprofile>());
        }

        public static void load()
        {
        	serializer.XMLserializer serializer = new serializer.XMLserializer(filePath);
        	Highscoreprofile[] hsps = serializer.Deserialize<Highscoreprofile[]>();
        	foreach(Highscoreprofile hsp in hsps)
        	{
        		highscoreProfiles.Add(hsp.Playername, hsp);
        	}
        }

        public static void addWin(string playername)
        {
            if (!highscoreProfiles.ContainsKey(playername))
            {
                highscoreProfiles.Add(playername, new Highscoreprofile());
                highscoreProfiles[playername].Playername = playername; //workaround so it is Serializeable (constructor without parameters)
            }

            highscoreProfiles[playername].Won++;
        }

        public static void addLose(string playername)
        {
            if (!highscoreProfiles.ContainsKey(playername))
            {
                highscoreProfiles.Add(playername, new Highscoreprofile());
                highscoreProfiles[playername].Playername = playername;
            }

            highscoreProfiles[playername].Lost++;
        }
    }
}
