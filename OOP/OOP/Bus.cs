using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    [Serializable]
    public class Bus : Transport
    {
        private int AmountOfSeats { get; }

        public Bus() : base()
        { }

        public Bus(Engine engine, Chassis chassis, Transmission transmission, string modelName, int amountOfSeats) : base(engine,chassis,transmission, modelName)
        {
            this.AmountOfSeats = amountOfSeats;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Amount of seats in bus: " + this.AmountOfSeats.ToString() + "\n");
        }
    }
}
