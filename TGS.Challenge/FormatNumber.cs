using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        private static readonly int S_UpperLimit = 1000000000;
        private static readonly int S_LowerLimit = 0;

        public string Format(int value)
        {
            //Input Validation
            if (value > S_UpperLimit || value < S_LowerLimit)
            {
                throw new ArgumentOutOfRangeException("value", "Value out of range.");
            }

            //If string length is less or equal to 3 return, else process
            var stringValue = value.ToString();
            if (stringValue.Length <= 3)
            {
                return stringValue;
            }
            else
            {
                //Reverse string and add commas
                var reversedString = StringReverse(stringValue);
                var formattedString = InsertCommas(reversedString);

                //Reverse string back to normal
                return StringReverse(formattedString);
            }
        }

        private string StringReverse(string inputString)
        {
            var charArray = inputString.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        private string InsertCommas(string formatString)
        {
            if (formatString.Length <= 6)
            {
                return formatString.Insert(3, ",");
            }
            else
            {
                var addSecondComma = formatString.Insert(3, ",");
                return addSecondComma.Insert(7, ",");
            }
        }
    }
}
