using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    [Serializable]
    public class Truck : Transport
    {
        private string CurrentAssignment { get; }

        public Truck() : base()
        { }

        public Truck(Engine engine, Chassis chassis, Transmission transmission, string modelName, string currentAssignment) : base(engine,chassis,transmission, modelName)
        {
            this.CurrentAssignment = currentAssignment;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Current assignment: " + this.CurrentAssignment + "\n");
        }
    }
}
