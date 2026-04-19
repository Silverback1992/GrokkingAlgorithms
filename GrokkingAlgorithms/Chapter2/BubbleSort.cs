namespace GrokkingAlgorithms.Chapter2;

public static class BubbleSort
{
    public static void Sort(int[] myArray)
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            bool swapped = false;

            for (int j = 0; j < myArray.Length - i - 1; j++)
            {
                if (myArray[j] > myArray[j + 1])
                {
                    Swap(ref myArray[j], ref myArray[j + 1]);
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        (b, a) = (a, b);
    }
}
