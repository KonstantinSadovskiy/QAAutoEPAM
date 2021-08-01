using System;

namespace DevelopmentAndBuildTools
{
    class MaxAmountOfDifferentConsecutiveChars
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
        }
    }
}
