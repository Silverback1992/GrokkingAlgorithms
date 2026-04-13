namespace GrokkingAlgorithms.Chapter4;

public static class Quicksort
{
    public static List<int> SortWithPivotAlwaysAtIndexZero(List<int> list)
    {
        if (list.Count < 2)
        {
            return list;
        }

        var pivot = list[0];
        var less = list.Skip(1).Where(x => x <= pivot).ToList();
        var greater = list.Skip(1).Where(x => x > pivot).ToList();

        return [.. SortWithPivotAlwaysAtIndexZero(less), pivot, .. SortWithPivotAlwaysAtIndexZero(greater)];
    }

    public static List<int> Sort(List<int> list)
    {
        if (list.Count < 2)
        {
            return list;
        }

        int pivotIndex = list.Count / 2;
        int pivot = list[pivotIndex];

        var less = list.Where((x, i) => i != pivotIndex && x <= pivot).ToList();
        var greater = list.Where((x, i) => i != pivotIndex && x > pivot).ToList();

        return [.. Sort(less), pivot, .. Sort(greater)];
    }
}
