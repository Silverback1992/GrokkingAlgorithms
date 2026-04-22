namespace GrokkingAlgorithms.Chapter4;

public static class QuicksortNaive
{
    public static int[] Sort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }

        int pivot = arr[0];

        var left = arr[1..].Where(x => x <= pivot).ToArray();
        var right = arr[1..].Where(x => x > pivot).ToArray();

        return [.. Sort(left), pivot, .. Sort(right)];
    }
}
