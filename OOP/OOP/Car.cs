using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    [Serializable]
    public class Car : Transport
    {
        private double Price { get; }

        public Car() : base()
        { }

        public Car(Engine engine, Chassis chassis, Transmission transmission, string modelName, double price) : base(engine, chassis, transmission, modelName)
        {
            this.Price = price;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Car price: " + this.Price.ToString() + "\n");
        }
    }
}
