using System;

namespace ObjectOrientedDesignPrinciples.CommandOperations.Commands
{
    public class CountAllCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Amount of cars: " + CarManager.GetCarManager().CountCars());
        }
    }
}
