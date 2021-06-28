using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace BasicOfNETFrameworkAndCSharp
{
    public static class ConversionFromDecimalToAnyFrom2To20
    {
        private const string digits = "0123456789ABCDEFGHIJ";

        static void Main(string[] args)
        {
            string decimalNumber = args[0];
            int newSystem = Int32.Parse(args[1]);
            try
            {
                Console.WriteLine(ConvertDecimalToNewSystem(decimalNumber, newSystem));
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string ConvertDecimalToNewSystem(string decimalNumberString, int newSystem)
        {
            if (decimalNumberString == null || !decimalNumberString.Any(char.IsDigit) || Int32.Parse(decimalNumberString) < 0)
            {
                throw new ArgumentException("Decimal number has to be natural");
            }
            if (newSystem > 20 || newSystem < 2)
            {
                throw new ArgumentException("New system value is not correct");
            }
            
            return ReassembleNewSystemNumber(DisassembleDecimalNumberIntoDigitsOfNewSystem(decimalNumberString, newSystem));
        }

        private static Stack<int> DisassembleDecimalNumberIntoDigitsOfNewSystem(string decimalNumberString, int newSystem)
        {
            int decimalNumber = Int32.Parse(decimalNumberString);
            int newSystemDigit;

            Stack<int> newSystemNumberDigits = new Stack<int>();
            while (decimalNumber > newSystem)
            {
                newSystemDigit = decimalNumber % newSystem;
                decimalNumber = decimalNumber / newSystem;
                newSystemNumberDigits.Push(newSystemDigit);
            }
            newSystemNumberDigits.Push(decimalNumber);

            return newSystemNumberDigits;
        }

        private static string ReassembleNewSystemNumber(Stack<int> newSystemNumberDigits)
        {
            StringBuilder newSystemNumber = new StringBuilder("");

            while (!(newSystemNumberDigits.Count == 0))
            {
                newSystemNumber.Append(digits[newSystemNumberDigits.Pop()]);
            }

            return newSystemNumber.ToString();
        }
    }
}
