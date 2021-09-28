using System;

namespace ObjectOrientedDesignPrinciples.CommandOperations.Commands
{
    public class CountAveragePriceCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Car average price: " + CarManager.GetCarManager().CountAveragePrice());
        }
    }
}
