using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeLibrary.CustomArraySorter
{
    public class CustomArraySorter
    {
        #region Documentation
        /// <summary>
        /// Sorts the given array either in ascending or descending order using both inbuilt 
        /// and custom sorting logic.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array, must implement IComparable&lt;T&gt;.</typeparam>
        /// <param name="inputArray">The array of elements to be sorted.</param>
        /// <param name="sortOrder">A boolean value specifying the sort order:
        /// true for ascending, false for descending.</param>
        #endregion

        #region Implementation
        public static void SortGivenArray<T>(T[] inputArray, bool sortOrder) where T : IComparable<T>
        {
            // Check if the input array is null or empty to avoid unnecessary operations.
            if (inputArray == null || inputArray.Length == 0)
                return;

            // Inbuilt Sorting (Ascending or Descending)
            if (sortOrder)
            {
                // Uses Array.Sort to sort the array in ascending order.
                Array.Sort(inputArray); // Ascending order
            }
            else
            {
                // Uses Array.Sort with a custom comparator for descending order.
                Array.Sort(inputArray, (x, y) => y.CompareTo(x)); // Descending order
            }

            // Display the sorted array using inbuilt methods for demonstration.
            Console.WriteLine(sortOrder ? "Inbuilt Ascending Sort:" : "Inbuilt Descending Sort:");
            PrintArray(inputArray);

            // Perform custom sorting without using inbuilt sorting methods.
            CustomBubbleSort(inputArray, sortOrder);

            // Display the sorted array using custom sorting logic.
            Console.WriteLine(sortOrder ? "Custom Ascending Sort:" : "Custom Descending Sort:");
            PrintArray(inputArray);
        }
        #endregion

        #region Documentation
        /// <summary>
        /// Sorts the array using a custom bubble sort algorithm. Sorts in ascending or descending 
        /// order based on the <paramref name="sortOrder"/> parameter.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array, must implement IComparable&lt;T&gt;.</typeparam>
        /// <param name="array">The array of elements to be sorted.</param>
        /// <param name="sortOrder">A boolean value specifying the sort order:
        /// true for ascending, false for descending.</param>
        #endregion

        #region Implementation
        private static void CustomBubbleSort<T>(T[] array, bool sortOrder) where T : IComparable<T>
        {
            // Get the length of the array to set up for bubble sort.
            int n = array.Length;

            // Outer loop for each element in the array.
            for (int i = 0; i < n - 1; i++)
            {
                // Inner loop to compare adjacent elements.
                for (int j = 0; j < n - i - 1; j++)
                {
                    // For ascending order, swap if the current element is greater than the next.
                    // For descending order, swap if the current element is less than the next.
                    if ((sortOrder && array[j].CompareTo(array[j + 1]) > 0) ||
                        (!sortOrder && array[j].CompareTo(array[j + 1]) < 0))
                    {
                        // Swap the elements.
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        #endregion

        #region Documentation
        /// <summary>
        /// Prints the elements of the array in a single line.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="array">The array of elements to be printed.</param>
        #endregion

        #region Implementation
        private static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); // Move to the next line after printing all elements.
        }
        #endregion
    }
}
