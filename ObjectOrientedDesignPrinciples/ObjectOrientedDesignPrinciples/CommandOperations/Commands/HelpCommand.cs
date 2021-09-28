using System;

namespace ObjectOrientedDesignPrinciples.CommandOperations.Commands
{
    class HelpCommand : ICommand
    {
        const string AddCarHelp = "AddCar - adds car with selected parameters to the list.\n" +
                                  "         Parameters:\n" +
                                  "         args[1] - string Brand\n" +
                                  "         args[2] - string Model\n" +
                                  "         args[3] - int Amount\n" +
                                  "         args[4] - double PricePerUnit\n";
        const string CountAllHelp = "CountAll - counts amount of cars.\n";
        const string CountTypesHelp = "CountTypes - counts amount of brands.\n";
        const string AveragePriceHelp = "AveragePrice - counts average price of all cars.\n";
        const string AveragePriceTypeHelp = "AveragePriceType - counts average price of all cars of certain brand.\n" +
                                            "                   Parameters:\n" +
                                            "                   args[1] - string Brand\n";
        const string ExitHelp = "Exit - shuts down the console window.\n";

        public void Execute()
        {
            Console.WriteLine("/+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++/\n" + 
                              AddCarHelp + CountAllHelp + CountTypesHelp + AveragePriceHelp + AveragePriceTypeHelp + ExitHelp + 
                              "/+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++/");
        }
    }
}
