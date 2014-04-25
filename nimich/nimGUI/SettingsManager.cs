using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serializer;

namespace nimGUI
{
    public static class SettingsManager
    {
        private static string filePath = Environment.CurrentDirectory + @"\settings.nimsp";

        public static SettingsProfile settingsProfile = new SettingsProfile();

        public static void save()
        {
            serializer.XMLserializer serializer = new serializer.XMLserializer(filePath);
            serializer.Serialize<SettingsProfile>(settingsProfile);
        }

        public static void load()
        {
            serializer.XMLserializer serializer = new serializer.XMLserializer(filePath);
            settingsProfile = serializer.Deserialize<SettingsProfile>();

            if (settingsProfile == null)
            { settingsProfile = new SettingsProfile(); }
        }
    }
}
