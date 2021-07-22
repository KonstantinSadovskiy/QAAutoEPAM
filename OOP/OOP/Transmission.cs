using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    [Serializable]
    public class Transmission
    {
        public string Type { get; set; }
        public int AmountOfGears { get; set; }
        public string Manufacturer { get; set; }

        public Transmission()
        { }

        public Transmission(string type, int amountOfGears, string manufacturer)
        {
            if (type == null)
            {
                throw new ArgumentNullException("Transmission type field can't be null");
            }
            this.Type = type;
            if(amountOfGears < 0)
            {
                throw new ArgumentException("Amount of gears can't be negative");
            }
            this.AmountOfGears = amountOfGears;
            if(manufacturer == null)
            {
                throw new ArgumentNullException("Manufacturer field can't be null");
            }    
            this.Manufacturer = manufacturer;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Transmission info\n" + 
                              "Transmission type: " + this.Type + "\n" +
                              "Amount of gears in transmission: " + this.AmountOfGears.ToString() + "\n" +
                              "Transmission manfacturer: " + this.Manufacturer + "\n");
        }


    }
}
