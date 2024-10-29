# Question
Write code to sort given C# array in ascending and descending order. 
- Example : ```public int[] intInputArray = { 24, 58, 99, 67, 75, 44, 73, 41, 74, 87 };``` 
- Implement the method logic using both ```with and without``` using inbuilt C# methods.
- The method should take parameters & signature as ```public static SortGivenArray<T>(T[] inputArray, bool sortOrder)```
- Here ```sortOrder``` true mean sort in ascending order.

Here's a solution that sorts the array using both inbuilt methods and custom logic without inbuilt sorting functions. We'll implement the ```SortGivenArray``` method with two approaches:

# Code Explanation

## 1. Parameters: 

- ```inputArray```: The array to sort.
- ```sortOrder```: A boolean where true represents ascending order, and false represents descending order.

## 2. Implementation:

- First example uses ```inbuilt methods``` for sorting.
- Second example uses ```custom Bubble Sort algorithm``` for both ascending and descending orders.

## A. Inbuilt Sorting Approach:

- If ```sortOrder is true, Array.Sort(inputArray);``` sorts in ascending order.
- If ```sortOrder is false, Array.Sort(inputArray, (x, y) => y.CompareTo(x));``` sorts in descending order.

## B. Custom Bubble Sort Logic:

CustomBubbleSort uses a Bubble Sort approach.

- It compares each adjacent pair and swaps them if needed, based on sortOrder.
- This algorithm has a time complexity of 

𝑂
(
𝑛
2
)
O(n 
2
), but it's useful for learning purposes.

## C. Helper Method ```PrintArray```:

- Displays the sorted array on the console.

## D. Example Output

	Sorting in Ascending Order ->

	Inbuilt Ascending Sort:
	24 41 44 58 67 73 74 75 87 99 
	
	Custom Ascending Sort:
	24 41 44 58 67 73 74 75 87 99 
	
	Sorting in Descending Order ->
	
	Inbuilt Descending Sort:
	99 87 75 74 73 67 58 44 41 24 
	
	Custom Descending Sort:
	99 87 75 74 73 67 58 44 41 24 

# Why Use IComparable<T>?

```IComparable<T>``` enables objects to be compared with each other in a generic way, making it easier to create sorting methods that work on any data type that supports ordering. Here are some benefits:

- Type Safety: ```IComparable<T>``` ensures that the CompareTo method is used, providing compile-time checking. It helps prevent runtime errors when comparing different data types.
- Code Reusability: By using ```IComparable<T>```, the sorting logic works with any type that implements IComparable, making it more flexible and reusable.
- Maintainability: Implementing ```IComparable<T>``` centralizes comparison logic in the data type itself, making code cleaner and reducing duplication.
- Without ```IComparable<T>```, you would need to ensure all elements in the array are comparable using custom logic, which can make the code less generic and reusable.

## Advantages of ```IComparable<T>```
If you want SortGivenArray to be generic and work with various data types (e.g., string, float, custom classes), implementing IComparable<T> in those types would make it adaptable to any data type that supports ordering. Without it, you need to create separate methods for each data type.
