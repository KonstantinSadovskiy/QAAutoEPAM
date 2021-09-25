using System;

namespace OOP
{
    /// <summary>
    /// Defines bus
    /// </summary>
    [Serializable]
    public class Bus : Transport
    {
        private int _amountOfSeats;

        public int AmountOfSeats
        {
            get
            {
                return _amountOfSeats;
            }

            set
            {
                if (value < 0)
                {
                    throw new InitializationException("Amount of seats field value can't be negative.");
                }
                _amountOfSeats = value;
            }
        }

        public Bus() : base()
        { }

        public Bus(Engine engine, Chassis chassis, Transmission transmission, string modelName, int id, int amountOfSeats) : base(engine,chassis,transmission, modelName, id)
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
