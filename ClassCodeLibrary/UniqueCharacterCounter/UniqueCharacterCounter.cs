using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeLibrary.UniqueCharacterCounter
{
    public class UniqueCharacterCounter
    {
        #region Documentation
        /// <summary>
        /// Counts and displays unique characters and their respective counts from the input string.
        /// This method avoids using inbuilt C# collections or methods, instead utilizing an ASCII-based array approach.
        /// </summary>
        /// <param name="input">The input string whose unique characters and counts are to be calculated.</param>
        #endregion

        #region Implementation
        public static void CountUniqueCharacters(string input)
        {
            // Create a fixed-size array for ASCII values (256 for standard ASCII characters)
            int[] charCount = new int[256];

            // Step 1: Iterate over the input string and count occurrences of each character
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                charCount[currentChar]++; // Increment the count for the ASCII index of the character
            }

            Console.WriteLine("Unique characters and their counts:");

            // Step 2: Print each character and its count if it appeared in the string
            for (int i = 0; i < charCount.Length; i++)
            {
                if (charCount[i] > 0) // Only print characters that appeared at least once
                {
                    Console.WriteLine($"Character '{(char)i}': {charCount[i]} times");
                }
            }
        }
        #endregion
    }
}
