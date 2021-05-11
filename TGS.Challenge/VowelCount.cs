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
        public int Count(string value)
        {
            if (value == null || value == "")
            {
                throw new ArgumentException("value is empty.");
            }

            var S_Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            var vowelCount = 0;
            
            foreach (char c in value.ToLower())
            {
                if (S_Vowels.Contains(c))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
