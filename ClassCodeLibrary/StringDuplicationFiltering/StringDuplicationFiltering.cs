using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeLibrary.StringDuplicationFiltering
{
    public static class StringDuplicationFiltering
    {
        public static void ExecuteCode()
        {
            string input = "sdfsdfasdgfd%^^%$.....}{}{:\"<><><,.,//.?" +
                        "|\\';';/:\":>?>?}||}{}<><><><><>,.,/,/';';'][]\\" +
                        "-=-=%$#@#@^%^*)*(*&*&^&@##!CGDGFDDDAGHGAG65465456314544544";

            // Example Usage
            Console.WriteLine("Original String:");
            Console.WriteLine(input);

            Console.WriteLine("\nRemove all duplicates:");
            Console.WriteLine(input.RemoveDuplicates());

            Console.WriteLine("\nRemove duplicate special chars:");
            Console.WriteLine(input.RemoveDuplicateSpecialChars());

            Console.WriteLine("\nRemove duplicate numbers:");
            Console.WriteLine(input.RemoveDuplicateNumbers());

            Console.WriteLine("\nRemove duplicate lowercase chars:");
            Console.WriteLine(input.RemoveDuplicateLowerChars());

            Console.WriteLine("\nRemove duplicate uppercase chars:");
            Console.WriteLine(input.RemoveDuplicateUpperChars());

            Console.WriteLine("\nRemove all special chars:");
            Console.WriteLine(input.RemoveSpecialChars());

            Console.WriteLine("\nRemove all numbers:");
            Console.WriteLine(input.RemoveNumbers());

            Console.WriteLine("\nRemove all lowercase chars:");
            Console.WriteLine(input.RemoveLowerChars());

            Console.WriteLine("\nRemove all uppercase chars:");
            Console.WriteLine(input.RemoveUpperChars());
        }

        // 1. Remove all duplicates from the string
        public static string RemoveDuplicates(this string input)
        {
            string result = "";
            foreach (char c in input)
            {
                bool exists = false;
                foreach (char r in result)
                {
                    if (c == r)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    result += c;
                }
            }
            return result;
        }

        // 1a. Remove duplicate special characters only
        public static string RemoveDuplicateSpecialChars(this string input)
        {
            string result = "";
            string specialChars = "";
            foreach (char c in input)
            {
                if (!IsLetterOrDigit(c)) // Check if the char is a special character
                {
                    bool exists = false;
                    foreach (char sc in specialChars)
                    {
                        if (sc == c)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        result += c;
                        specialChars += c; // Track special chars added so far
                    }
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        // 1b. Remove duplicate numbers only
        public static string RemoveDuplicateNumbers(this string input)
        {
            string result = "";
            string numbers = "";
            foreach (char c in input)
            {
                if (IsDigit(c)) // Check if it's a number
                {
                    bool exists = false;
                    foreach (char num in numbers)
                    {
                        if (num == c)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        result += c;
                        numbers += c; // Track numbers added so far
                    }
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        // 1c. Remove duplicate lowercase characters only
        public static string RemoveDuplicateLowerChars(this string input)
        {
            string result = "";
            string lowerChars = "";
            foreach (char c in input)
            {
                if (IsLower(c)) // Check if it's a lowercase character
                {
                    bool exists = false;
                    foreach (char lower in lowerChars)
                    {
                        if (lower == c)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        result += c;
                        lowerChars += c; // Track lowercase chars added so far
                    }
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        // 1d. Remove duplicate uppercase characters only
        public static string RemoveDuplicateUpperChars(this string input)
        {
            string result = "";
            string upperChars = "";
            foreach (char c in input)
            {
                if (IsUpper(c)) // Check if it's an uppercase character
                {
                    bool exists = false;
                    foreach (char upper in upperChars)
                    {
                        if (upper == c)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        result += c;
                        upperChars += c; // Track uppercase chars added so far
                    }
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        // 2. Remove all special characters from string
        public static string RemoveSpecialChars(this string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (IsLetterOrDigit(c)) // Only keep letters and digits
                {
                    result += c;
                }
            }
            return result;
        }

        // 3. Remove all numbers from string
        public static string RemoveNumbers(this string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (!IsDigit(c)) // Skip digits
                {
                    result += c;
                }
            }
            return result;
        }

        // 4. Remove all lowercase characters from string
        public static string RemoveLowerChars(this string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (!IsLower(c)) // Skip lowercase characters
                {
                    result += c;
                }
            }
            return result;
        }

        // 5. Remove all uppercase characters from string
        public static string RemoveUpperChars(this string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (!IsUpper(c)) // Skip uppercase characters
                {
                    result += c;
                }
            }
            return result;
        }

        // Custom method to check if a character is a letter or digit
        private static bool IsLetterOrDigit(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
        }

        // Custom method to check if a character is a digit
        private static bool IsDigit(char c)
        {
            return (c >= '0' && c <= '9');
        }

        // Custom method to check if a character is lowercase
        private static bool IsLower(char c)
        {
            return (c >= 'a' && c <= 'z');
        }

        // Custom method to check if a character is uppercase
        private static bool IsUpper(char c)
        {
            return (c >= 'A' && c <= 'Z');
        }
    }
}
