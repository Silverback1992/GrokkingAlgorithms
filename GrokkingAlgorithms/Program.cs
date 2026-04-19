using GrokkingAlgorithms.Chapter1;
using GrokkingAlgorithms.Chapter10;
using GrokkingAlgorithms.Chapter2;
using GrokkingAlgorithms.Chapter3;
using GrokkingAlgorithms.Chapter4;
using GrokkingAlgorithms.Chapter5;
using GrokkingAlgorithms.Chapter6;
using GrokkingAlgorithms.Chapter7;
using File = GrokkingAlgorithms.Chapter7.File;

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

var exampleArr1 = new int[] { 64, 25, 12, 22, 11 };
SelectionSort.Sort(exampleArr1);
Console.WriteLine(string.Join(", ", exampleArr1));

var exampleArr2 = new int[] { 64, 25, 12, 22, 11 };
BubbleSort.Sort(exampleArr2);
Console.WriteLine(string.Join(", ", exampleArr2));

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

var exampleArr3 = new int[] { 64, 25, 12, 22, 11 };
QuicksortVariations.SortHoare(exampleArr3);
Console.WriteLine(string.Join(", ", exampleArr3));

//var myList2 = new List<int> { 64, 25, 12, 22, 11 };
//var sortedList = Quicksort.SortWithPivotAlwaysAtIndexZero(myList2);
//Console.WriteLine(string.Join(", ", sortedList));
//var sortedList2 = Quicksort.Sort(myList2);
//Console.WriteLine(string.Join(", ", sortedList2));
//var arr = new int[] { 64, 25, 12, 22, 11 };
//QuicksortInPlace.Sort(arr);
//Console.WriteLine(string.Join(", ", arr));

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

Console.WriteLine();

#endregion

#region Chapter 7

Console.WriteLine("Chapter 7");

var tree = new BinaryTree()
{
    Root = new Folder()
    {
        Name = "Pics",

        LeftNode = new Folder()
        {
            Name = "2001",
            LeftNode = new File() { Name = "a.png" },
            RightNode = new File() { Name = "space.png" }
        },

        RightNode = new File()
        {
            Name = "odessey.png"
        }
    }
};

Console.WriteLine("Tree BFS test:");
var treeBFS = new TreeBFS(tree);
treeBFS.Search();

Console.WriteLine();

Console.WriteLine("Tree DFS test:");
var treeDFS = new TreeDFS();
treeDFS.Search(tree.Root);

Console.WriteLine();

#endregion

#region Chapter 10

Console.WriteLine("Chapter 10");

var statesNeeded = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };

var stations = new Dictionary<string, HashSet<string>>
{
    { "kone", new HashSet<string> { "id", "nv", "ut" } },
    { "ktwo", new HashSet<string> { "wa", "id", "mt" } },
    { "kthree", new HashSet<string> { "or", "nv", "ca" } },
    { "kfour", new HashSet<string> { "nv", "ut" } },
    { "kfive", new HashSet<string> { "ca", "az" } }
};

Console.WriteLine("Greedy Algorithm test:");
var finalStations = GreedyAlgorithm.GetStations(statesNeeded, stations);
Console.WriteLine($"Selected stations: {string.Join(", ", finalStations)}");

#endregion