using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeTaskSerialization
{
    [XmlType(TypeName ="catalog")]
    [XmlRoot(Namespace = "http://library.by/catalog", ElementName = "catalog", DataType = "string", IsNullable = true)]
    public class Catalog
    {

        public Catalog()
        {
            Books = new List<Book>();
        }
        public Catalog(DateTime date): this()
        {
            this.Date = date;
        }

        [XmlAttribute(AttributeName ="date", DataType ="date")]
        public DateTime Date;

        [XmlElement(ElementName ="book")]
        public List<Book> Books;
    }
}
