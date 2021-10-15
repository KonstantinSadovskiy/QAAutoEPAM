using System;

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
                throw new ArgumentNullException("Can't accept null string");
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
                //Cycle that counts amount of conecutive different chars
                while (!(sequenceOfChars[index] == sequenceOfChars[index - 1]))
                {
                    currentCount++;
                    index++;
                    if (index == sequenceOfChars.Length)
                    {
                        break;
                    }
                }

                //If current streak bigger than previous, make current maxCount
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            return maxCount;
        }

        public static int CountMaxSameLetters(string sequenceOfChars)
        {
            if (sequenceOfChars == null)
            {
                throw new ArgumentNullException("Can't accept null string");
            }

            int length = sequenceOfChars.Length;
            int maxCount = 0;

            for (int i = 0; i < length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (sequenceOfChars[i] != sequenceOfChars[j])
                        break;
                    count++;
                }

                if (count > maxCount &&
                   ((sequenceOfChars[i] >= 'a' && sequenceOfChars[i] <= 'z') || (sequenceOfChars[i] >= 'A' && sequenceOfChars[i] <= 'Z')))
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }

        public static int CountMaxSameDigits(string sequenceOfChars)
        {
            if (sequenceOfChars == null)
            {
                throw new ArgumentNullException("Can't accept null string");
            }

            int length = sequenceOfChars.Length;
            int maxCount = 0;

            for (int i = 0; i < length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (sequenceOfChars[i] != sequenceOfChars[j])
                        break;
                    count++;
                }

                // Update result if required
                if (count > maxCount && 
                   (sequenceOfChars[i] >= '0' && sequenceOfChars[i] <= '9'))
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }
    }
}
