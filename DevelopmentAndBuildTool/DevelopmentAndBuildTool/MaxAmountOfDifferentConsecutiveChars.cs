using System;

namespace DevelopmentAndBuildTools
{
    public static class MaxAmountOfDifferentConsecutiveChars
    {
        static void Main(string[] args)
        {
            string inputString = args[0];

            try 
            {
                Console.WriteLine(CountMaxAmountOfDifferentConsecutiveChars(inputString).ToString()); 
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static bool IsSameToPreviousChar(string sequenceOfChars, int index)
        {
            return sequenceOfChars[index] == sequenceOfChars[index - 1];
        }

        public static int CountMaxAmountOfDifferentConsecutiveChars(string sequenceOfChars)
        {
            sequenceOfChars = sequenceOfChars.ToLower();
            if (sequenceOfChars.Length == 0)
            {
                throw new ArgumentNullException("Empty string");
            }

            if (sequenceOfChars.Length == 1)
            {
                return 1;
            }

            int maxCount = 0;

            for (int index = 1; index < sequenceOfChars.Length; index++)
            {
                int currentCount = 1;
                while (!IsSameToPreviousChar(sequenceOfChars, index))
                {
                    currentCount++;
                    index++;
                    if (index == sequenceOfChars.Length)
                    {
                        break;
                    }
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            return maxCount;
        }
    }
}
