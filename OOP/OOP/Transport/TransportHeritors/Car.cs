using System;

namespace OOP
{
    /// <summary>
    /// Defines car
    /// </summary>
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
