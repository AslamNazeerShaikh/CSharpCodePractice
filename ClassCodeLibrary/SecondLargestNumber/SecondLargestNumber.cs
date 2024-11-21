using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeLibrary.SecondLargestNumber
{
    public class SecondLargestNumber
    {
        /// <summary>
        /// Finds the second largest number in a given array of integers.
        /// </summary>
        /// <param name="nums">The array of integers to process.</param>
        /// <returns>The second largest integer in the array.</returns>
        /// <exception cref="ArgumentException">Thrown when the array has fewer than two elements.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the array does not contain enough distinct elements.</exception>
        public static int FindSecondLargestNumber(int[] nums)
        {
            // Check if the array has at least two elements
            if (nums.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two distinct elements.");
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            // Iterate through the array to find the largest and second largest numbers
            foreach (var num in nums)
            {
                if (num > largest)
                {
                    secondLargest = largest; // Update second largest
                    largest = num; // Update largest
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num; // Update second largest
                }
            }

            // Check if a valid second largest number exists
            if (secondLargest == int.MinValue)
            {
                throw new InvalidOperationException("Array does not contain enough distinct elements.");
            }

            return secondLargest;
        }
    }
}
