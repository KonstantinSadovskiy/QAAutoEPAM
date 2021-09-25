using System;

namespace OOP
{
    /// <summary>
    /// Defines scooter
    /// </summary>
    [Serializable]
    public class Scooter : Transport
    {
        private double _maxSpeed;

        public double MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }

            set
            {
                if (value < 0)
                {
                    throw new InitializationException("MaxSpeed field value can't be negative.");
                }
                _maxSpeed = value;
            }
        }

        public Scooter() : base()
        { }

        public Scooter(Engine engine, Chassis chassis, Transmission transmission, string modelName, int id, double maxSpeed) : base(engine, chassis, transmission, modelName, id)
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
