using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace OOP
{
    public static class ListSerialization
    {

        public static void SerializeList<T>(List<T> transportList, string fileName)
        {
            File.Delete(fileName);
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, transportList);
            }
        }
    }
}
