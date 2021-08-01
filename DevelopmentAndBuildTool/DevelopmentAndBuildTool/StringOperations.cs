namespace DevelopmentAndBuildTools
{
    public static class StringOperations
    {
        /// <summary>
        /// Counts maximum amount of consecutive different chars.
        /// </summary>
        /// <param name="sequenceOfChars">String with sequence of chars</param>
        /// <returns>Amount of consecutive chars</returns>
        public static int CountMaxConsecutiveAmount(string sequenceOfChars)
        {
            if (sequenceOfChars == null)
            {
                return 0;
            }
            //If string has only 1 char return 1
            if (sequenceOfChars.Length == 1)
            {
                return 1;
            }

            //Different consecutive char counter
            int maxCount = 0;

            //Cycle to start from last repeating char
            for (int index = 1; index < sequenceOfChars.Length; index++)
            {
                //Current streak counter
                int currentCount = 1;
                //Cycle that count amount of conecutive different chars
                while (!(sequenceOfChars[index] == sequenceOfChars[index - 1]))
                {
                    currentCount++;
                    index++;
                    //If encounter repeating chars, break
                    if (index == sequenceOfChars.Length)
                    {
                        break;
                    }
                }

                //If current streak bigger than previos, make current maxCount
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            return maxCount;
        }
    }
}
