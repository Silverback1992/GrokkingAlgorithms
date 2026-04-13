using GrokkingAlgorithms.Chapter1;
using GrokkingAlgorithms.Chapter2;
using GrokkingAlgorithms.Chapter3;
using GrokkingAlgorithms.Chapter4;
using GrokkingAlgorithms.Chapter5;
using GrokkingAlgorithms.Chapter6;

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

Console.WriteLine();

#endregion

#region Chapter 3

Console.WriteLine("Chapter 3");

Console.WriteLine("Recursion test:");

Box box = new()
{
    Items =
            [
                new Box { Items = [] },
                new Box
                {
                    Items =
                    [
                        new Box { Items = null },
                        new Box
                        {
                            Items =
                            [
                                new Box
                                {
                                    Items =
                                    [
                                        new Box { Items = [] },
                                        new Key(),
                                        new Box { Items = null }
                                    ]
                                }
                            ]
                        },
                        new Box { Items = [] }
                    ]
                },
                new Box
                {
                    Items =
                    [
                        new Box { Items = [] },
                        new Box
                        {
                            Items =
                            [
                                new Box { Items = [] }
                            ]
                        }
                    ]
                }
            ]
};

Recursion.LookForKey(box);
Recursion.LookForKeyRecursively(box);

Console.WriteLine();
Console.WriteLine("Recursion without base case:");
//Recursion.RecursionWithoutBaseCase(10); // Uncommenting the above line will cause a StackOverflowException due to infinite recursion.

Console.WriteLine("Factorial:");
Console.WriteLine(Recursion.Factorial(5));

#endregion

#region Chapter 4

Console.WriteLine("Chapter 4");

Console.WriteLine("Quicksort test:");

var myList2 = new List<int> { 64, 25, 12, 22, 11 };
var sortedList = Quicksort.SortWithPivotAlwaysAtIndexZero(myList2);
Console.WriteLine(string.Join(", ", sortedList));
var sortedList2 = Quicksort.Sort(myList2);
Console.WriteLine(string.Join(", ", sortedList2));
var arr = new int[] { 64, 25, 12, 22, 11 };
QuicksortInPlace.Sort(arr);
Console.WriteLine(string.Join(", ", arr));

Console.WriteLine();

#endregion

#region Chapter 5

Console.WriteLine("Chapter 5");

Console.WriteLine("Voting test:");

Voting.CheckVoter("Dave");
Voting.CheckVoter("Bob");
Voting.CheckVoter("Dave");

Console.WriteLine();

#endregion

#region Chapter 6

Console.WriteLine("Chapter 6");

var friends = new Graph()
{
    Nodes = new Dictionary<string, string[]>
    {
        { "you", new[] { "alice", "bob", "claire" } },
        { "bob", new[] { "anuj", "peggy"} },
        { "alice", new[] { "peggy" } },
        { "claire", new[] { "thom", "jonny" } },
        { "anuj", []  },
        { "peggy", [] },
        { "thom", [] },
        { "jonny", new [] { "maggie" } },
        { "maggie", [] }
    }
};

var bfs = new BFS(friends);
bfs.Search("you");

#endregion