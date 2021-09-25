using System;

namespace OOP
{
    /// <summary>
    /// Defines car
    /// </summary>
    [Serializable]
    public class Car : Transport
    {
        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value < 0)
                {
                    throw new InitializationException("Price field value can't be negative.");
                }
                _price = value;
            }
        }

        public Car() : base()
        { }

        public Car(Engine engine, Chassis chassis, Transmission transmission, string modelName, int id, double price) : base(engine, chassis, transmission, modelName, id)
        {
            this.Price = price;
        }

        /// <summary>
        /// Returns string with information about car
        /// </summary>
        public override string Getinfo()
        {
            return (base.Getinfo()+
                    "Car price: " + this.Price.ToString() + "\n\n");
        }
    }
}
