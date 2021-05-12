using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            //Input Validation
            if ((word1 == string.Empty) || (word2 == string.Empty))
            {
                throw new ArgumentException("Words cannot be null or empty");
            }

            var a = WordProcessor(word1);
            var b = WordProcessor(word2);

            //Compare strings to check if words are Anagram or not
            return a == b;
        }

        private string WordProcessor(string word)
        {
            //Remove white/blank spaces; Convert word to lowercase; Convert to char array for sorting
            var wordFormatted = word.Replace(" ", "").ToLower().ToCharArray();

            //Sort characters in array
            Array.Sort(wordFormatted);
            var newWord = new string(wordFormatted);

            //Remove punctuation
            var sb = new StringBuilder();
            foreach (char c in newWord)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}