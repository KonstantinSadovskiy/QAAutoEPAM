using System;

namespace OOP
{
    /// <summary>
    /// Defines scooter
    /// </summary>
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

        /// <summary>
        /// Returns string with information about scooter
        /// </summary>
        public override string Getinfo()
        {
            return (base.Getinfo() +
                    "Scooter maximum speed: " + this.MaxSpeed.ToString() + "\n\n");
        }
    }
}
