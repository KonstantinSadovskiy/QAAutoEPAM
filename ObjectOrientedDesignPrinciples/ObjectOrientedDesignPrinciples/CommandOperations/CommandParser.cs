using System;
using ObjectOrientedDesignPrinciples.CommandOperations.Commands;

namespace ObjectOrientedDesignPrinciples.CommandOperations
{
    /// <summary>
    /// Class which defines command parser
    /// </summary>
    public static class CommandParser
    {
        /// <summary>
        /// Method which returns command resulting on input string
        /// </summary>
        /// <param name="args">Input string</param>
        /// <returns>ICommand command</returns>
        public static ICommand GetCommand(string[] args)
        {
            ICommand command;

            switch (args[0])
            {
                case "AddCar":
                    command = ExecAddCommand(args);
                    break;

                case "CountTypes":
                    command = ExecCountTypesCommand(args);
                    break;

                case "CountAll":
                    command = ExecCountAllCommand(args);
                    break;

                case "AveragePrice":
                    command = ExecCountAveragePriceCommand(args);
                    break;

                case "AveragePriceType":
                    command = ExecCountAveragePriceTypeCommand(args);
                    break;

                case "Exit":
                    command = ExecExitCommand(args);
                    break;

                case "Help":
                    command = ExecHelpCommand(args);
                    break;

                default:
                    command = null;
                    break;
            }

            if (command == null)
            {
                Console.WriteLine("Unrecognized command.");
            }

            return command;
        }

        private static ICommand ExecAddCommand(string[] args)
        {
            if (args.Length != 5)
            {
                Console.WriteLine("Incorrect amount of arguments for AddCar command.");
                return null;
            }

            return new AddCommand(new Car(args[1], args[2], Convert.ToInt32(args[3]), Convert.ToDouble(args[4])));
        }

        private static ICommand ExecCountTypesCommand(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect amount of arguments for CountTypes command.");
                return null;
            }

            return new CountTypesCommand();
        }

        private static ICommand ExecCountAllCommand(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect amount of arguments for CountAll command.");
                return null;
            }

            return new CountAllCommand();
        }

        private static ICommand ExecCountAveragePriceCommand(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect amount of arguments for AveragePrice command.");
                return null;
            }

            return new CountAveragePriceCommand();
        }

        private static ICommand ExecCountAveragePriceTypeCommand(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Incorrect amount of arguments for AveragePriceType command.");
                return null;
            }

            return new CountAveragePriceTypeCommand(args[1]);
        }

        private static ICommand ExecExitCommand(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect amount of arguments for Exit command.");
                return null;
            }

            return new ExitCommand();
        }

        private static ICommand ExecHelpCommand(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect amount of arguments for Help command.");
                return null;
            }

            return new HelpCommand();
        }
    }
}
