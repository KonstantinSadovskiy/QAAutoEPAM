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
        private string _modelName;
        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;
        private int _id;


        public string ModelName
        {
            get
            {
                return _modelName;
            }

            set
            {
                if (value == null)
                {
                    throw new InitializationException("Model name field can't be null.");
                }
                _modelName = value;
            }
        }

        public Engine Engine
        {
            get
            {
                return _engine;
            }

            set
            {
                if (value == null)
                {
                    throw new InitializationException("Engine field can't be null.");
                }
                _engine = value;
            }
        }
        
        public Chassis Chassis
        {
            get
            {
                return _chassis;
            }

            set
            {
                if (value == null)
                {
                    throw new InitializationException("Chassis field can't be null.");
                }
                _chassis = value;
            }
        }
        
        public Transmission Transmission
        {
            get
            {
                return _transmission;
            }

            set
            {
                if (value == null)
                {
                    throw new InitializationException("Transmission field can't be null.");
                }
                _transmission = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                if (value < 0)
                {
                    throw new InitializationException("Model name field can't be null.");
                }
                _id = value;
            }
        }

        public Transport() 
        { }

        public Transport(Engine engine, Chassis chassis , Transmission transmission, string modelName, int id)
        {
            this.Engine = engine;
            this.Chassis = chassis;
            this.Transmission = transmission;
            this.ModelName = modelName;
            this.Id = id;
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
