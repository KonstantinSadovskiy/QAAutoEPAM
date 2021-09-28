using System;
using ObjectOrientedDesignPrinciples.CommandOperations;

namespace ObjectOrientedDesignPrinciples
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Invoker invoker = new Invoker();
                Console.WriteLine("Write *Help* to see the list of commands");

                while (true)
                {
                    Console.WriteLine("Enter your command: ");
                    ICommand command = CommandParser.GetCommand(Console.ReadLine().Split(' '));
                    invoker.ExecuteCommand(command);
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
