namespace GrokkingAlgorithms.Chapter4;

public static class Quicksort
{
    // A shared helper method for all three algorithms
    private static void Swap(int[] arr, int i, int j)
    {
        (arr[j], arr[i]) = (arr[i], arr[j]);
    }

    // ====================================================================
    // 1. LOMUTO PARTITION SCHEME (The Book's Way)
    // - Pointers move the same direction.
    // - Locks the pivot in its final place.
    // ====================================================================
    public static void SortLomuto(int[] arr) 
        => SortLomuto(arr, 0, arr.Length - 1);

    private static void SortLomuto(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = PartitionLomuto(arr, low, high);
            // Clean split: The pivot is locked, so we exclude it from both sides
            SortLomuto(arr, low, pivotIndex - 1);
            SortLomuto(arr, pivotIndex + 1, high);
        }
    }

    private static int PartitionLomuto(int[] arr, int low, int high)
    {
        int pivot = arr[low];
        int swapIndex = low + 1; // The Gatekeeper

        // The Explorer (i) walks left-to-right
        for (int i = low + 1; i <= high; i++)
        {
            if (arr[i] <= pivot)
            {
                Swap(arr, i, swapIndex);
                swapIndex++;
            }
        }

        // Lock the pivot into its final resting place
        int pivotFinalPosition = swapIndex - 1;
        Swap(arr, low, pivotFinalPosition);

        return pivotFinalPosition;
    }

    // ====================================================================
    // 2. HOARE PARTITION SCHEME (The 1959 Original)
    // - Pointers move in opposite directions (outside-in).
    // - DOES NOT lock the pivot in its final place.
    // ====================================================================
    public static void SortHoare(int[] arr) 
        => SortHoare(arr, 0, arr.Length - 1);

    private static void SortHoare(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int splitIndex = PartitionHoare(arr, low, high);
            // Fuzzy split: The pivot is NOT locked, so splitIndex is included in the left half
            SortHoare(arr, low, splitIndex);
            SortHoare(arr, splitIndex + 1, high);
        }
    }

    private static int PartitionHoare(int[] arr, int low, int high)
    {
        // Grab the value of the middle element
        int pivotValue = arr[low + (high - low) / 2];

        int left = low - 1;
        int right = high + 1;

        while (true)
        {
            // Walk outside-in
            do
            { left++; } while (arr[left] < pivotValue);
            do
            { right--; } while (arr[right] > pivotValue);

            // If the pointers cross, the groups are separated. 
            // Return the dividing line (right).
            if (left >= right)
            {
                return right;
            }

            Swap(arr, left, right);
        }
    }

    // ====================================================================
    // 3. HYBRID / TWO-WAY PARTITION (The Production Way)
    // - Pointers move in opposite directions (like Hoare).
    // - Locks the pivot in its final place (like Lomuto).
    // ====================================================================
    public static void SortHybrid(int[] arr) 
        => SortHybrid(arr, 0, arr.Length - 1);

    private static void SortHybrid(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = PartitionHybrid(arr, low, high);
            // Clean split: Because we do the final swap, the pivot is locked!
            SortHybrid(arr, low, pivotIndex - 1);
            SortHybrid(arr, pivotIndex + 1, high);
        }
    }

    private static int PartitionHybrid(int[] arr, int low, int high)
    {
        // We can use the "Front Swap" trick here if we want a middle pivot, 
        // but for simplicity, we'll just use the first element as the pivot.
        int pivot = arr[low];

        int i = low + 1;
        int j = high;

        while (true)
        {
            // i moves right looking for big numbers
            while (i <= high && arr[i] <= pivot)
            {
                i++;
            }

            // j moves left looking for small numbers
            while (j >= low + 1 && arr[j] > pivot)
            {
                j--;
            }

            // If they crossed paths, stop looping
            if (i > j)
            {
                break;
            }

            Swap(arr, i, j);
        }

        // The Grand Finale: j is guaranteed to point to a number <= pivot.
        // Swap the pivot into its locked, perfect position.
        Swap(arr, low, j);

        return j;
    }
}