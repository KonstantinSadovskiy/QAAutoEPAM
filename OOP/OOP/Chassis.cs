using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    [Serializable]
    public class Chassis
    {
        public int AmountOfWheels { get; set; }
        public string Number { get; set; }
        public double AllowedLoad { get; set; }

        public Chassis()
        { }

        public Chassis(int amountOfWheels, string number, double allowedLoad)
        {
            if(amountOfWheels < 0)
            {
                throw new ArgumentException("Amount of wheels can't be negative");
            }
            this.AmountOfWheels = amountOfWheels;
            if(number == null)
            {
                throw new ArgumentNullException("Chassis number can't be null");
            }
            this.Number = number;
            if(allowedLoad < 0)
            {
                throw new ArgumentException("Allowerd load can't be negative");
            }
            this.AllowedLoad = allowedLoad;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Chassis info\n" +
                              "Chassis allowed load: " + this.AllowedLoad.ToString() + "\n" +
                              "Chassis amount of wheels: " + this.AmountOfWheels.ToString() + "\n" +
                              "Chassis number: " + this.Number + "\n");           
        }
    }
}
