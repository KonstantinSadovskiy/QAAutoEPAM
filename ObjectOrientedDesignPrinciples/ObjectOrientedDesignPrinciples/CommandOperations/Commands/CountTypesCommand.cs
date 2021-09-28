using System;

namespace ObjectOrientedDesignPrinciples.CommandOperations.Commands
{
    public class CountTypesCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Amount of car brands: " + CarManager.GetCarManager().CountCarTypes());
        }
    }
}
