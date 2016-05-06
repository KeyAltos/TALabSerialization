using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace HomeTaskSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var serializer = new XmlSerializer(typeof(Catalog));
            Catalog catalogFromDeserelization = null;


            #region desializing
            var fileNameSrc = Path.Combine(Environment.CurrentDirectory, "books.xml");
            using (FileStream fs = new FileStream(fileNameSrc, FileMode.OpenOrCreate))
            {
                catalogFromDeserelization = (Catalog)serializer.Deserialize(fs);                
            }
            Console.ReadLine();
            #endregion

            #region serializing

            // set atrributes for namespace.            
            XmlSerializerNamespaces nameSpaces = new XmlSerializerNamespaces();
            nameSpaces.Add(string.Empty, @"http://library.by/catalog");            

            // set filename and type of encoding
            var fileNameDest = Path.Combine(Environment.CurrentDirectory, "booksTestDest.xml");
            var appendMode = false;
            var encoding = Encoding.GetEncoding("UTF-8");

            using (StreamWriter stream = new StreamWriter(fileNameDest, appendMode, encoding))
            {
                serializer.Serialize(stream, catalogFromDeserelization, nameSpaces);
            }
            #endregion
        }
    }
}
