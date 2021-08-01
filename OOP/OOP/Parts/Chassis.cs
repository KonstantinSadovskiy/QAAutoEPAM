using System;

namespace OOP
{
    /// <summary>
    /// Defines chassis
    /// </summary>
    [Serializable]
    public class Chassis
    {
        public int _amountOfWheels;
        public string _number;
        public double _allowedLoad;

        public int AmountOfWheels
        {
            get
            {
                return _amountOfWheels;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Amount of wheels can't be negative");
                }
                _amountOfWheels = value;
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Chassis number can't be null");
                }
                _number = value;
            }
        }

        public double AllowedLoad
        {
            get
            {
                return _allowedLoad;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Allowerd load can't be negative");
                }
                _allowedLoad = value;
            }
        }

        public Chassis()
        { }

        public Chassis(int amountOfWheels, string number, double allowedLoad)
        {
            this.AmountOfWheels = amountOfWheels;
            this.Number = number;
            this.AllowedLoad = allowedLoad;
        }

        /// <summary>
        /// Returns string with information about chassis
        /// </summary>
        public string GetInfo()
        {
            return ("Chassis info\n" +
                    "Chassis allowed load: " + this.AllowedLoad.ToString() + "\n" +
                    "Chassis amount of wheels: " + this.AmountOfWheels.ToString() + "\n" +
                    "Chassis number: " + this.Number + "\n");           
        }
    }
}
