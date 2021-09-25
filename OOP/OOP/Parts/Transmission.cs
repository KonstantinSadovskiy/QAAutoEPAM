using System;

namespace OOP
{
    /// <summary>
    /// Defines transmission
    /// </summary>
    [Serializable]
    public class Transmission
    {
        private string _type;
        private int _amountOfGears;
        private string _manufacturer;

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (value == null)
                {
                    throw new InitializationException("Transmission type field can't be null.");
                }
                _type = value;
            }
        }

        public int AmountOfGears
        {
            get
            {
                return _amountOfGears;
            }

            set
            {
                if (value < 0)
                {
                    throw new InitializationException("Amount of gears field value can't be negative.");
                }
                _amountOfGears = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }

            set
            {
                if (value == null)
                {
                    throw new InitializationException("Manufacturer field can't be null.");
                }
                _manufacturer = value;
            }
        }

        public Transmission()
        { }

        public Transmission(string type, int amountOfGears, string manufacturer)
        {
            this.Type = type;
            this.AmountOfGears = amountOfGears;
            this.Manufacturer = manufacturer;
        }

        /// <summary>
        /// Returns string with information about transmission
        /// </summary>
        public string GetInfo()
        {
            return ("Transmission info\n" + 
                    "Transmission type: " + this.Type + "\n" +
                    "Amount of gears in transmission: " + this.AmountOfGears.ToString() + "\n" +
                    "Transmission manfacturer: " + this.Manufacturer + "\n");
        }


    }
}
