using System;

namespace ObjectOrientedDesignPrinciples.CommandOperations.Commands
{
    public class AddCommand : ICommand
    {
        private Car _car;

        public AddCommand(Car car)
        {
            this._car = car;
        }

        public void Execute()
        {
            CarManager.GetCarManager().AddCar(_car);
            Console.WriteLine("Successfully added a car.");
        }
    }
}
