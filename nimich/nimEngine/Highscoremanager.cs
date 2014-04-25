using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace nimEngine
{
    /*!
     * Manager der das halten der Highscoredaten übernimmt und diese auch Serialisiert
     */
    public static class HighscoreManager
    {
        private static string filePath = Environment.CurrentDirectory + @"\highscores.hsc";

        /*!
         * Enthält alle Highscoreprofile und identifiziert diese anhand ihres "ident" den sie als "Player" hatten
         */
        public static Dictionary<string, HighscoreProfile> highscoreProfiles = new Dictionary<string, HighscoreProfile>();

        /*!
         * Serialisiert die Highscoreprofile und speichert sie
         */
        public static void save()
        {
            serializer.XMLserializer serializer = new serializer.XMLserializer(filePath);
            
            serializer.Serialize<HighscoreProfile[]>(highscoreProfiles.Values.ToArray<HighscoreProfile>()); //Dictionary ist generisch und daher nicht serialisierbar, deswegen wird ein Array erzeugt und dieses serialisiert
        }

        /*!
         * Liest die Highscoreprofile, deserialisiert diese wieder und füllt das highscoreProfiles-Dictionary
         */
        public static void load()
        {
            highscoreProfiles.Clear();

        	serializer.XMLserializer serializer = new serializer.XMLserializer(filePath);
        	HighscoreProfile[] hsps = serializer.Deserialize<HighscoreProfile[]>(); //temporäres Array zur Datenhaltung des Deserialiserten Highscoreprofil-Arrays

            if (hsps == null)
            { return; }

        	foreach(HighscoreProfile hsp in hsps) //HighscoreProfil-Dictionary mit den deserialisierten Daten füllen
        	{
        		highscoreProfiles.Add(hsp.Playername, hsp);
        	}
        }

        /*!
         * Fügt einen Sieg dem durch den "playername"-Parameter identifiziertem Highscoreprofil hinzu
         */
        public static void addWin(string playername)
        {
            if (!highscoreProfiles.ContainsKey(playername))
            {
                highscoreProfiles.Add(playername, new HighscoreProfile());
                highscoreProfiles[playername].Playername = playername; //workaround damit das Highscoreprofile serialisierbar ist (parameterloser Konstruktor)
            }

            highscoreProfiles[playername].Won++;
        }

        /*!
         * Fügt einen Niederlage dem durch den "playername"-Parameter identifiziertem Highscoreprofil hinzu
         */
        public static void addLoss(string playername)
        {
            if (!highscoreProfiles.ContainsKey(playername))
            {
                highscoreProfiles.Add(playername, new HighscoreProfile());
                highscoreProfiles[playername].Playername = playername;
            }

            highscoreProfiles[playername].Losses++;
        }
    }
}
