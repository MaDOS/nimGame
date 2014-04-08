using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace serializer
{
    public class XMLserializer
    {
        public string Path
        {
            get;
            private set;
        }

        public XMLserializer(string path)
        {
            this.Path = path;
        }

        public void Serialize<T>(T thing)
        {
            //Neuer Serialisierer; typeof T = egal welcher Typ
            XmlSerializer serializer;
            serializer = new XmlSerializer(typeof(T));

            //Neuer Filestream; StartupPath = Projektpfad; \\Typ.xml = Name der Datei
            FileStream file = new FileStream(this.Path, FileMode.Create);

            serializer.Serialize(file, thing);
            file.Close();
        }

        public T Deserialize<T>()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream file = new FileStream(this.Path, FileMode.Open);
            T thing = (T)serializer.Deserialize(file);
            file.Close();

            return thing;
        }
    }
}