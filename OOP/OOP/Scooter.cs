using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    [Serializable]
    public class Scooter : Transport
    {
        private double MaxSpeed { get; }

        public Scooter() : base()
        { }

        public Scooter(Engine engine, Chassis chassis, Transmission transmission, string modelName, double maxSpeed) : base(engine, chassis, transmission, modelName)
        {
            this.MaxSpeed = maxSpeed;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Scooter maximum speed: " + this.MaxSpeed.ToString() + "\n");
        }
    }
}
