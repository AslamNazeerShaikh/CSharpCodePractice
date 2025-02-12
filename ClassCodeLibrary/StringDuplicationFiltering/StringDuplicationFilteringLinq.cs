using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassCodeLibrary.StringDuplicationFiltering
{
    public static class StringDuplicationFilteringLinq
    {
        /// <summary>
        /// Entry point to execute various filtering operations on a sample input string.
        /// </summary>
        public static void ExecuteCode()
        {
            string input = "sdfsdfasdgfd%^^%$.....}{}{:\"<><><,.,//.?" +
                       "|\\';';/:\":>?>?}||}{}<><><><><>,.,/,/';';'][]\\" +
                       "-=-=%$#@#@^%^*)*(*&*&^&@##!CGDGFDDDAGHGAG65465456314544544";

            Console.WriteLine("Original String:");
            Console.WriteLine(input);

            Console.WriteLine("\nRemove all duplicates:");
            Console.WriteLine(input.RemoveDuplicatesLinq());

            Console.WriteLine("\nRemove duplicate special chars:");
            Console.WriteLine(input.RemoveDuplicateSpecialCharsLinq());

            Console.WriteLine("\nRemove duplicate numbers:");
            Console.WriteLine(input.RemoveDuplicateNumbersLinq());

            Console.WriteLine("\nRemove duplicate lowercase chars:");
            Console.WriteLine(input.RemoveDuplicateLowerCharsLinq());

            Console.WriteLine("\nRemove duplicate uppercase chars:");
            Console.WriteLine(input.RemoveDuplicateUpperCharsLinq());

            Console.WriteLine("\nRemove all special chars:");
            Console.WriteLine(input.RemoveSpecialCharsLinq());

            Console.WriteLine("\nRemove all numbers:");
            Console.WriteLine(input.RemoveNumbersLinq());

            Console.WriteLine("\nRemove all lowercase chars:");
            Console.WriteLine(input.RemoveLowerCharsLinq());

            Console.WriteLine("\nRemove all uppercase chars:");
            Console.WriteLine(input.RemoveUpperCharsLinq());
        }

        /// <summary>
        /// Removes duplicate characters while preserving the original order.
        /// </summary>
        public static string RemoveDuplicatesLinq(this string input) =>
            new string(input.Distinct().ToArray());

        /// <summary>
        /// Removes duplicate special characters while preserving others.
        /// </summary>
        public static string RemoveDuplicateSpecialCharsLinq(this string input) =>
            new string(input.GroupBy(c => c)
                            .Select(g => g.Key)
                            .Where(c => char.IsLetterOrDigit(c) || input.IndexOf(c) == input.LastIndexOf(c))
                            .ToArray());

        /// <summary>
        /// Removes duplicate numbers while preserving others.
        /// </summary>
        public static string RemoveDuplicateNumbersLinq(this string input) =>
            new string(input.GroupBy(c => c)
                            .Select(g => g.Key)
                            .Where(c => !char.IsDigit(c) || input.IndexOf(c) == input.LastIndexOf(c))
                            .ToArray());

        /// <summary>
        /// Removes duplicate lowercase characters while preserving others.
        /// </summary>
        public static string RemoveDuplicateLowerCharsLinq(this string input) =>
            new string(input.GroupBy(c => c)
                            .Select(g => g.Key)
                            .Where(c => !char.IsLower(c) || input.IndexOf(c) == input.LastIndexOf(c))
                            .ToArray());

        /// <summary>
        /// Removes duplicate uppercase characters while preserving others.
        /// </summary>
        public static string RemoveDuplicateUpperCharsLinq(this string input) =>
            new string(input.GroupBy(c => c)
                            .Select(g => g.Key)
                            .Where(c => !char.IsUpper(c) || input.IndexOf(c) == input.LastIndexOf(c))
                            .ToArray());

        /// <summary>
        /// Removes all special characters from the input string.
        /// </summary>
        public static string RemoveSpecialCharsLinq(this string input) =>
            new string(input.Where(char.IsLetterOrDigit).ToArray());

        /// <summary>
        /// Removes all numeric characters from the input string.
        /// </summary>
        public static string RemoveNumbersLinq(this string input) =>
            new string(input.Where(c => !char.IsDigit(c)).ToArray());

        /// <summary>
        /// Removes all lowercase characters from the input string.
        /// </summary>
        public static string RemoveLowerCharsLinq(this string input) =>
            new string(input.Where(c => !char.IsLower(c)).ToArray());

        /// <summary>
        /// Removes all uppercase characters from the input string.
        /// </summary>
        public static string RemoveUpperCharsLinq(this string input) =>
            new string(input.Where(c => !char.IsUpper(c)).ToArray());
    }
}
