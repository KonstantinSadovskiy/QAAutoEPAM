using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    [Serializable]
    public class Engine
    {
        public double Power { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        

        public Engine()
        { }

        public Engine(double power, double volume, string type, string serialNumber)
        {
            if (power < 0)
            {
                throw new ArgumentException("Power can't be negative");
            }
            this.Power = power;
            if(volume < 0)
            {
                throw new ArgumentException("Volume can't be negative");
            }
            this.Volume = volume;
            if (type == null)
            {
                throw new ArgumentNullException("Type field can't be null");
            }
            this.Type = type;
            if(serialNumber == null)
            {
                throw new ArgumentNullException("Serial Number field can't be null");
            }
            this.SerialNumber = serialNumber;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Engine info\n" +
                              "Engine power: " + this.Power.ToString() + "\n" +
                              "Engine volume: " + this.Volume.ToString() + "\n" +
                              "Engine type: " + this.Type + "\n" +
                              "Engine serial number: " + this.SerialNumber + "\n");
        }
    }
}
