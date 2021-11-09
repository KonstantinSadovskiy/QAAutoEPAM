using System;

namespace DevelopmentAndBuildTools
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = args[0];

            try 
            {
                Console.WriteLine(StringOperations.CountMaxConsecutiveAmount(inputString).ToString()); 
            }
            catch(ArgumentNullException ex)
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
