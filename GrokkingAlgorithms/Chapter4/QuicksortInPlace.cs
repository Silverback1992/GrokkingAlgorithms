namespace GrokkingAlgorithms.Chapter4;

public static class QuicksortInPlace
{
    // 1. The public method that users call. 
    // Notice it doesn't return a new array; it returns void because it sorts the original!
    public static void Sort(int[] arr)
    {
        // We start by drawing our imaginary boundary around the whole array
        Sort(arr, 0, arr.Length - 1);
    }

    // 2. The recursive engine
    private static void Sort(int[] arr, int low, int high)
    {
        // Base case: If the imaginary box has 1 or 0 elements, it's already sorted
        if (low < high)
        {
            // Find the pivot and move everything smaller to its left, larger to its right
            int pivotIndex = Partition(arr, low, high);

            // Recursively sort the "less than" side (skipping the pivot itself)
            Sort(arr, low, pivotIndex - 1);

            // Recursively sort the "greater than" side (skipping the pivot itself)
            Sort(arr, pivotIndex + 1, high);
        }
    }

    // 3. The magic "In-Place" worker
    private static int Partition(int[] arr, int low, int high)
    {
        // Sticking to the book: our pivot is always the first element in our current boundary
        int pivot = arr[arr.Length / 2];

        // This pointer keeps track of where the "less than" section ends
        int swapIndex = low;

        // Scan through the rest of our bounded area
        for (int i = low; i <= high; i++)
        {
            // If we find something smaller than the pivot, toss it into the "less than" section
            if (arr[i] <= pivot)
            {
                Swap(arr, i, swapIndex);
                swapIndex++; // Expand the "less than" section by one
            }
        }

        // Finally, move the pivot from the very beginning to its rightful spot in the middle
        int pivotFinalPosition = swapIndex - 1;
        Swap(arr, low, pivotFinalPosition);

        // Return where the pivot ended up so the next recursive calls know where to split
        return pivotFinalPosition;
    }

    // A simple helper to make the code above easier to read
    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}