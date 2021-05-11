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
        public string Format(int value)
        {
            const int limit = 1000000000;
            if (value > limit || value < 0)
            {
                throw new ArgumentOutOfRangeException("value", "Value out of range.");
            }

            var stringValue = value.ToString();
            if (stringValue.Length <= 3)
            {
                return stringValue;
            }
            else
            {
                var reversed = StringReverse(stringValue);
                var x = InsertCommas(reversed);
                return StringReverse(x);
            }
        }

        private string StringReverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private string InsertCommas(string commas)
        {
            if (commas.Length <= 6)
            {
                return commas.Insert(3, ",");
            }
            else
            {
                var x = commas.Insert(3, ",");
                return x.Insert(7, ",");
            }
        }
    }
}
