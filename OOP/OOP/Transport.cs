using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP
{
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Scooter))]
    [Serializable]
    public abstract class Transport
    {
        public string ModelName { get; set; }
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }
        
        public Transport() 
        { }

        public Transport(Engine engine, Chassis chassis , Transmission transmission, string modelName)
        {
            this.Engine = engine;
            this.Chassis = chassis;
            this.Transmission = transmission;
            this.ModelName = modelName;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: " + this.ModelName);
            this.Engine.DisplayInfo();
            this.Chassis.DisplayInfo();
            this.Transmission.DisplayInfo();
        }
    }
}
