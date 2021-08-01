using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace OOP
{
    /// <summary>
    /// Class for list serialization
    /// </summary>
    public static class ListSerialization
    {
        /// <summary>
        /// Serializes list of objects
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="objectList">List of objects</param>
        /// <param name="fileName">Name of XML file</param>
        public static void SerializeList<T>(List<T> objectList, string fileName)
        {
            //Deletes XML file with same file name
            File.Delete(fileName);
            //Creating formatter
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));

            //Creating and filling XML file
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, objectList);
            }
        }
    }
}
