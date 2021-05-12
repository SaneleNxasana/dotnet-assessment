using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        private static readonly List<char> S_Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        public int Count(string value)
        {
            //Input Validation
            if (value == string.Empty)
            {
                throw new ArgumentException("value is empty.");
            }

            //Loop though the given value and count the number of vowels
            var vowelCount = 0;            
            foreach (char character in value.ToLower())
            {
                if (S_Vowels.Contains(character))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
