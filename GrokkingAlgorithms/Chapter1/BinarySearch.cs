namespace GrokkingAlgorithms.Chapter1;

public static class BinarySearch
{
    public static int? Search(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int guess = array[mid];

            if (target == guess)
            {
                return mid;
            }

            if (guess > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return null;
    }
}
