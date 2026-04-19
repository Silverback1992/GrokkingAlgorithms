namespace GrokkingAlgorithms.Chapter2;

public static class SelectionSort
{
    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Swap(ref arr[i], ref arr[minIndex]);
            }
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        (b, a) = (a, b);
    }
}
