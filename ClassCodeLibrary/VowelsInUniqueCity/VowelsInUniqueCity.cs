using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassCodeLibrary.VowelsInUniqueCity
{
    public static class VowelsInUniqueCity
    {
        public static void ExecuteCode()
        {
            // Declare an array of cities with duplicate entries
            string[] cities = { "Pune", "Mumbai", "Kolkata", "Munbai", "Kolkata", "Pune" };

            // Step 1: Remove duplicate city names
            string[] uniqueCities = RemoveDuplicates(cities);

            // Step 2: Find vowels for each unique city and display them
            foreach (string city in uniqueCities)
            {
                char[] vowels = FindVowels(city);
                Console.WriteLine($"City: {city}, Vowels: {new string(vowels)}");
            }
        }

        // Method to remove duplicate elements from an array manually
        public static string[] RemoveDuplicates(string[] arr)
        {
            string[] temp = new string[arr.Length]; // Temporary array to store unique values
            int count = 0; // Counter for unique elements

            for (int i = 0; i < arr.Length; i++) // Iterate through the original array
            {
                bool isDuplicate = false;

                // Check if the current city already exists in the temporary array
                for (int j = 0; j < count; j++)
                {
                    if (arr[i] == temp[j]) // If found, mark it as a duplicate
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // If not a duplicate, add it to the temp array
                if (!isDuplicate)
                {
                    temp[count] = arr[i];
                    count++; // Increase the count of unique elements
                }
            }

            // Create a new array of the exact size of unique elements
            string[] uniqueArray = new string[count];

            // Copy unique elements from temp array to the new array
            for (int i = 0; i < count; i++)
            {
                uniqueArray[i] = temp[i];
            }

            return uniqueArray; // Return the array with unique city names
        }

        // Method to find vowels in a given city name
        public static char[] FindVowels(string word)
        {
            char[] vowels = new char[word.Length]; // Array to store vowels found
            int count = 0; // Counter for vowels

            for (int i = 0; i < word.Length; i++) // Iterate through each character in the word
            {
                char ch = char.ToLower(word[i]); // Convert to lowercase for uniform comparison

                // Check if the character is a vowel (a, e, i, o, u)
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    // Ensure we don't add duplicate vowels
                    bool alreadyExists = false;
                    for (int j = 0; j < count; j++)
                    {
                        if (vowels[j] == ch) // If vowel already exists, mark it
                        {
                            alreadyExists = true;
                            break;
                        }
                    }

                    if (!alreadyExists) // Add vowel if it is not already in the list
                    {
                        vowels[count] = ch;
                        count++; // Increase vowel count
                    }
                }
            }

            // Create a new array with only found vowels (without empty spaces)
            char[] result = new char[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = vowels[i];
            }

            return result; // Return the array containing vowels found in the word
        }
    }
}
