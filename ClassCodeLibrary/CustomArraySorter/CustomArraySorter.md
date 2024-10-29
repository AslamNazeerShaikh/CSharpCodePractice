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

# Note: 

So here they are not returning anything so how can the actual array got modified ? and in C# the passed parameter is normally a pass value type & in C# the method parameter data and its lifecycle are local to that method scope so how the actual array got sorted here ?

```In C#, the behavior you're observing is due to reference types and how they differ from value types. Let’s break down the key points around how arrays and reference types are treated in method calls and why the actual array gets modified in this code:```

## 1. Arrays as Reference Types

In C#, arrays are reference types, meaning that when an array (e.g., int[]) is passed to a method, a reference to the original array is passed—not a copy.
This means that if the array is modified within the method (like sorting its elements), those modifications will affect the original array outside the method.

## 2. Pass-by-Value with Reference Types
When you pass an array to a method, it’s still technically pass-by-value, but what is passed by value is a reference (or pointer) to the actual array in memory.
Therefore, while the method receives a copy of the reference, both the method and the caller refer to the same array in memory.
Any changes to the array elements within the method affect the original array because the reference points to the same memory location.

## 3. How This Works in Your Code
In your code, the array inputArray is passed to SortGivenArray, which then sorts it in ascending or descending order. The sorting methods (inbuilt Array.Sort or custom CustomBubbleSort) operate directly on this array.
Because inputArray and the array in SortGivenArray point to the same memory location, changes made in SortGivenArray are directly reflected in intInputArray, the original array.
This is why, despite the void return type, the sorting has a visible effect on intInputArray in the calling method.

## 4. Local Variable Scope and Reference Types
When you modify inputArray (a local variable within the SortGivenArray method), you’re modifying the data at the memory location that inputArray points to, not inputArray itself as an independent object.
This distinction between modifying the contents of a reference versus modifying the reference itself is why changes persist outside the method.

## 5. Summary of Key Points
- Arrays are reference types: When passed to a method, a reference to the original array is passed, so modifications affect the original array.
- Pass-by-value with reference types: Although a reference is passed by value, it still points to the original memory location, allowing for in-place modifications.
- Local variable scope applies to the reference, not the object: The inputArray variable in SortGivenArray is local, but the data it points to is not; hence, changes are reflected outside the method.
