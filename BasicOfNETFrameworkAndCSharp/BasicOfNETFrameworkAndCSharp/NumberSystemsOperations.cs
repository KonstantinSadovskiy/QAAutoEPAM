using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOfNETFrameworkAndCSharp
{
    /// <summary>
    /// Class for working with numeric systems
    /// </summary>
    public static class NumberSystemsOperations
    {
        private const int maxNewSystem = 20;
        private const int AmountOfLetters = 25;
        private const int ASCIICapLettersStart = 65;
        private const int FirstNonNumberDigit = 10;
        private const int ASCIIFirstDigit = 48;

        /// <summary>
        /// Converts decimal number into other system base number
        /// </summary>
        /// <param name="decimalNumber">Decimal number</param>
        /// <param name="newSystem">New system base value</param>
        /// <returns>String number in new system base</returns>
        public static string ConvertDecimalToNewSystem(int decimalNumber, int newSystem)
        {
            //Working only with natural numbers
            if (decimalNumber < 0)
            {
                throw new ArgumentException("Decimal number has to be natural");
            }
            if (newSystem > maxNewSystem || newSystem < 2)
            {
                throw new ArgumentException("New system value is not correct");
            }

            return GetNewSystemNumber(DisassembleDecimalNumber(decimalNumber, newSystem));
        }

        /// <summary>
        /// Disassambles decimal number into int digits of new system
        /// </summary>
        /// <param name="decimalNumber">Decimal number</param>
        /// <param name="newSystem">New system base value</param>
        /// <returns>Stack of int digits in new system base</returns>
        private static Stack<int> DisassembleDecimalNumber(int decimalNumber, int newSystem)
        {
            int newSystemDigit;

            Stack<int> newSystemNumberDigits = new Stack<int>();

            //Algorithm for converting decimal system base number into other system bases
            while (decimalNumber > newSystem)
            {
                newSystemDigit = decimalNumber % newSystem;
                decimalNumber = decimalNumber / newSystem;
                newSystemNumberDigits.Push(newSystemDigit);
            }
            newSystemNumberDigits.Push(decimalNumber);

            return newSystemNumberDigits;
        }

        /// <summary>
        /// Building new system number by matching int digits with their char equivalents
        /// </summary>
        /// <param name="newSystemNumberDigits">Stack of int digits</param>
        /// <returns>String number in new system</returns>
        private static string GetNewSystemNumber(Stack<int> newSystemNumberDigits)
        {
            StringBuilder newSystemNumber = new StringBuilder("");

            //Poping int digits from stack until it's empty
            while (!(newSystemNumberDigits.Count == 0))
            {
                newSystemNumber.Append(SeparateDigits(newSystemNumberDigits.Pop()));
            }

            return newSystemNumber.ToString();
        }

        /// <summary>
        /// Separates numbers so they matched their symbols in ASCII
        /// </summary>
        /// <param name="digit">Digit</param>
        /// <returns>Char digit</returns>
        private static char SeparateDigits(int digit)
        {
            //If not matching any digit chars, throw exception
            if (digit < 0 || digit > AmountOfLetters)
            {
                throw new ArgumentException();
            }
            //If int digit bigger than 9, return matching letter digit
            if (digit > 9)
            {
                return (char)(ASCIICapLettersStart - FirstNonNumberDigit + digit);
            }
            //Return char equivalent of int digit
            return (char)(ASCIIFirstDigit + digit);
        }
    }
}
