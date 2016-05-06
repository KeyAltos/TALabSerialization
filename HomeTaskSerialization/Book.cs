using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeTaskSerialization
{
    public class Book
    {
        [XmlAttribute("id")]
        public string ID;

        [XmlElement(ElementName = "isbn",Order=1)]
        public string ISBN;

        [XmlElement(ElementName = "author", Order = 2)]
        public string Author;

        [XmlElement(ElementName = "title", Order = 3)]
        public string Title;

        [XmlElement(ElementName = "genre", Order = 4)]
        public Genre Genre;

        [XmlElement(ElementName = "publisher", Order = 5)]
        public string Publisher;

        [XmlElement(ElementName = "publish_date", Order = 6, DataType = "date")]
        public DateTime PublishDate;

        [XmlElement(ElementName = "description", Order = 7)]
        public string Description;

        [XmlElement(ElementName = "registration_date", Order = 8, DataType = "date")]
        public DateTime RegistrationDate;
    }
}
