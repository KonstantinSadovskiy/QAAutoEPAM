using System;

namespace ObjectOrientedDesignPrinciples
{
    /// <summary>
    /// Class that defines car
    /// </summary>
    public class Car
    {
        public string _brand;
        public string _model;
        public int _amount;
        public double _pricePerUnit;

        public string Brand
        {
            get
            {
                return _brand;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Brand can't be null.");
                }
                _brand = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Model can't be null.");
                }
                _model = value;
            }
        }

        public int Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Amount can't be less than 0.");
                }
                _amount = value;
            }
        }

        public double PricePerUnit
        {
            get
            {
                return _pricePerUnit;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("PricePerUnit can't be less than 0.");
                }
                _pricePerUnit = value;
            }
        }


        public Car(string brand, string model, int amount, double pricePerUnit)
        {
            this.Brand = brand;
            this.Model = model;
            this.Amount = amount;
            this.PricePerUnit = pricePerUnit;
        }
    }
}
