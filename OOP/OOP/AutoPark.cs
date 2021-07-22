using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP
{
    [Serializable]
    public class AutoPark
    {
        public List<Transport> TransportPark { get;  set; }

        public AutoPark() 
        { }

        public AutoPark(Transport[] transports)
        {
            this.TransportPark = transports.ToList();
        }

        public void DisplayInfo()
        {
            foreach(Transport transport in TransportPark)
            {
                transport.DisplayInfo();
            }
        }

        public XmlSerializer CreateSerializerForEngine()
        {
            XmlAttributeOverrides xOver = new XmlAttributeOverrides();
            XmlAttributes attrs = new XmlAttributes();

            attrs.XmlIgnore = false;
            xOver.Add(typeof(AutoPark), "Engine", attrs);

            attrs.XmlIgnore = true;
            xOver.Add(typeof(AutoPark), "Transmission", attrs);

            attrs.XmlIgnore = true;
            xOver.Add(typeof(AutoPark), "Chassis", attrs);

            XmlSerializer xSer = new XmlSerializer(typeof(AutoPark), xOver);
            return xSer;
        }
    }
}
