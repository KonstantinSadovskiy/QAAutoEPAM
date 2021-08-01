using System;
using System.Xml.Serialization;

namespace OOP
{
    /// <summary>
    /// Abstract class that defines basic transport
    /// </summary>
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

        /// <summary>
        /// Virtual method that returns string with basic info about transport
        /// </summary>
        public virtual string Getinfo()
        {
            return ("Name: " + this.ModelName + "\n" +
                    this.Engine.Getinfo() +
                    this.Chassis.GetInfo() +
                    this.Transmission.GetInfo());
        }
    }
}
