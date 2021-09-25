using System;

namespace OOP
{
    /// <summary>
    /// Defines truck
    /// </summary>
    [Serializable]
    public class Truck : Transport
    {
        private string _currentAssignment;

        public string CurrentAssignment
        {
            get
            {
                return _currentAssignment;
            }

            set
            {
                if (value == null)
                {
                    throw new InitializationException("Current assigment field string can't be null.");
                }
                _currentAssignment = value;
            }
        }

        public Truck() : base()
        { }

        public Truck(Engine engine, Chassis chassis, Transmission transmission, string modelName, int id, string currentAssignment) : base(engine,chassis,transmission, modelName, id)
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
