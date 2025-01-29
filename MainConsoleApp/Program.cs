using ClassCodeLibrary.CustomArraySorter;
using ClassCodeLibrary.UniqueCharacterCounter;
using ClassCodeLibrary.SecondLargestNumber;
using ClassCodeLibrary.VowelsInUniqueCity;

namespace MainConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region VowelsInUniqueCity
            //VowelsInUniqueCity.ExecuteCode();
            #endregion

            #region UniqueCharacterCounter
            //string example = "AaaakkasklkdddekeooPOxOKMNNHHHDOBBBbbzhhsh";
            //UniqueCharacterCounter.CountUniqueCharacters(example);
            #endregion

            #region CustomArraySorter
            //int[] intInputArray = { 24, 58, 99, 67, 75, 44, 73, 41, 74, 87 };

            //// Test Ascending Order
            //Console.WriteLine("Sorting in Ascending Order:");
            //CustomArraySorter.SortGivenArray(intInputArray, true);

            //// Reset Array for Descending Order Test
            //intInputArray = new int[] { 24, 58, 99, 67, 75, 44, 73, 41, 74, 87 };

            //// Test Descending Order
            //Console.WriteLine("\nSorting in Descending Order:");
            //CustomArraySorter.SortGivenArray(intInputArray, false);
            #endregion

            #region FindSecondLargestNumber
            ////Test case: Array with duplicates
            //int[] array = [3, 1, 4, 4, 5, 2, 5];
            //try
            //{
            //    Console.WriteLine("Second Largest: " + SecondLargestNumber.FindSecondLargestNumber(array));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //// Test case: Array with fewer than 2 elements
            //int[] array2 = [1];
            //try
            //{
            //    Console.WriteLine("Second Largest: " + SecondLargestNumber.FindSecondLargestNumber(array2));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //// Test case: Array with all identical elements
            //int[] array3 = [5, 5, 5];
            //try
            //{
            //    Console.WriteLine("Second Largest: " + SecondLargestNumber.FindSecondLargestNumber(array3));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //Console.ReadKey();
            #endregion
        }
    }
}
