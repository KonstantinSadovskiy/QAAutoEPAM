using System;

namespace OOP
{
    /// <summary>
    /// Defines engine
    /// </summary>
    [Serializable]
    public class Engine
    {
        private double _power;
        private double _volume;
        private string _type;
        private string _serialNumber;

        public double Power
        {
            get
            {
                return _power;
            }

            set
            {
                if (value < 0)
                {
                    throw new InitializationException("Power field value can't be negative.");
                }
                _power = value;
            }
        }

        public double Volume
        {
            get
            {
                return _volume;
            }

            set
            {
                if (value < 0)
                {
                    throw new InitializationException("Volume filed value can't be negative.");
                }
                _volume = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (value == null)
                {
                    throw new InitializationException("Type field can't be null.");
                }
                _type = value;
            }
        }

        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }

            set
            {
                if (value == null)
                {
                    throw new InitializationException("Serial Number field can't be null.");
                }
                _serialNumber = value;
            }
        }

        public Engine()
        { }

        public Engine(double power, double volume, string type, string serialNumber)
        {
            this.Power = power;
            this.Volume = volume;
            this.Type = type;
            this.SerialNumber = serialNumber;
        }

        /// <summary>
        /// Returns string with information about engine
        /// </summary>
        public string Getinfo()
        {
            return ("Engine info\n" +
                    "Engine power: " + this.Power.ToString() + "\n" +
                    "Engine volume: " + this.Volume.ToString() + "\n" +
                    "Engine type: " + this.Type + "\n" +
                    "Engine serial number: " + this.SerialNumber + "\n");
        }
    }
}
