using System;

namespace BasicOfNETFrameworkAndCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args[0] == null || args[1] == null)
                {
                    throw new ArgumentNullException("No argument from command line");
                }
                int decimalNumber = Int32.Parse(args[0]);
                int newSystem = Int32.Parse(args[1]);
                Console.WriteLine(NumberSystemsOperations.ConvertDecimalToNewSystem(decimalNumber, newSystem));
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
