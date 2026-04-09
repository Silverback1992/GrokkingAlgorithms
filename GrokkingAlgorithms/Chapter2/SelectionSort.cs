namespace GrokkingAlgorithms.Chapter2;

public static class SelectionSort
{
    public static int[] Sort(int[] arr)
    {
        int[] sort = new int[arr.Length];
        var copied = new List<int>(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            int smallestIndex = FindSmallestIndex(copied);
            sort[i] = copied[smallestIndex];
            copied.RemoveAt(smallestIndex);
        }

        return sort;
    }

    private static int FindSmallestIndex(List<int> list)
    {
        int smallestValue = list[0];
        int smallestIndex = 0;

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] < smallestValue)
            {
                smallestValue = list[i];
                smallestIndex = i;
            }
        }

        return smallestIndex;
    }
}
