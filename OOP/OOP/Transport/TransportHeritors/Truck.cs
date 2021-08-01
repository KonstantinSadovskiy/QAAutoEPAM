using System;

namespace OOP
{
    /// <summary>
    /// Defines truck
    /// </summary>
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

        /// <summary>
        /// Returns string with information about truck
        /// </summary>
        public override string Getinfo()
        {
            return (base.Getinfo() +
                    "Current assignment: " + this.CurrentAssignment + "\n\n");
        }
    }
}
