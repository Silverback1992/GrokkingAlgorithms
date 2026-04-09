using GrokkingAlgorithms.Chapter1;
using GrokkingAlgorithms.Chapter2;

#region Chapter 1

Console.WriteLine("Chapter 1");

Console.WriteLine("Binary search test:");

var myList = new int[] { 1, 3, 5, 7, 9 };
Console.WriteLine(BinarySearch.Search(myList, 3));
Console.WriteLine(BinarySearch.Search(myList, -1));

#endregion

#region Chapter 2

Console.WriteLine("Chapter 2");

Console.WriteLine("Selection sort test:");

var myArray = new int[] { 64, 25, 12, 22, 11 };
var sortedArray = SelectionSort.Sort(myArray);
Console.WriteLine(string.Join(", ", sortedArray));

#endregion