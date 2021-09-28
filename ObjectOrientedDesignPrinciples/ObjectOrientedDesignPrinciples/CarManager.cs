using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedDesignPrinciples
{
    /// <summary>
    /// Class that operates with cars by Singleton principle
    /// </summary>
    public class CarManager
    {
        private List<Car> _carList = new List<Car>();
        /// <summary>
        /// Current object of CarManager
        /// </summary>
        private static CarManager _carManager = null;

        /// <summary>
        /// Returns current CarManager object
        /// </summary>
        /// <returns></returns>
        public static CarManager GetCarManager()
        {

            if (_carManager == null)
            {
                _carManager = new CarManager();
            }
            return _carManager;
        }

        private CarManager() { }
        
        /// <summary>
        /// Add car to a carList
        /// </summary>
        /// <param name="car">Added car</param>
        public void AddCar(Car car)
        {
            this._carList.Add(car);
        }

        /// <summary>
        /// Counts amount of car types
        /// </summary>
        /// <returns></returns>
        public int CountCarTypes()
        {
            return _carList.GroupBy(x => x.Brand).Count();
        }

        /// <summary>
        /// Counts amount of cars
        /// </summary>
        /// <returns>Int value of cars</returns>
        public int CountCars()
        {
            return _carList.Sum(x => x.Amount);
        }

        /// <summary>
        /// Counts average price of all cars
        /// </summary>
        /// <returns>Double value of average price</returns>
        public double CountAveragePrice()
        {
            double priceSum = _carList.Sum(x => x.PricePerUnit * x.Amount);

            return Math.Round(priceSum / _carList.Sum(x => x.Amount), 2);
        }

        /// <summary>
        /// Counts average price of all cars of certain type
        /// </summary>
        /// <param name="brand">String brand</param>
        /// <returns>Double value of average price</returns>
        public double CountAveragePriceType(string brand)
        {
            double priceSum = _carList.Where(x => x.Brand == brand).Sum(x => x.PricePerUnit * x.Amount);

            return Math.Round(priceSum / _carList.Where(x => x.Brand == brand).Sum(x => x.Amount), 2);
        }
    }
}
