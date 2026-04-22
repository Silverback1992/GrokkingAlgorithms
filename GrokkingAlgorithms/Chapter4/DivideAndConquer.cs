namespace GrokkingAlgorithms.Chapter4;

public static class DivideAndConquer
{
    public static int SumArray(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }

        return nums[0] + SumArray(nums[1..]);
    }
}
