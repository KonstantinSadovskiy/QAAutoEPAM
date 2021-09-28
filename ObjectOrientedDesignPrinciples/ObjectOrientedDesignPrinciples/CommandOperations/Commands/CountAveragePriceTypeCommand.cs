using System;

namespace ObjectOrientedDesignPrinciples.CommandOperations.Commands
{
    public class CountAveragePriceTypeCommand : ICommand
    {
        private string _brand;
        public CountAveragePriceTypeCommand(string brand)
        {
            _brand = brand;
        }

        public void Execute()
        {
            Console.WriteLine($"{_brand} car average price: " + CarManager.GetCarManager().CountAveragePriceType(_brand));
        }
    }
}
