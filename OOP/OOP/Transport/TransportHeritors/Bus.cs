using System;

namespace OOP
{
    /// <summary>
    /// Defines bus
    /// </summary>
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

        /// <summary>
        /// Returns string with information about bus
        /// </summary>
        public override string Getinfo()
        {
            return (base.Getinfo() +
                    "Amount of seats in bus: " + this.AmountOfSeats.ToString() + "\n\n");
        }
    }
}
