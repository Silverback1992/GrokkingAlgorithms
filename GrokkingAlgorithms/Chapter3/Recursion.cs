namespace GrokkingAlgorithms.Chapter3;

public static class Recursion
{
    public static void LookForKey(Box box)
    {
        var pile = new List<Box> { box };

        while (pile.Count > 0)
        {
            var currentBox = pile[0];

            if (currentBox.Items == null)
            {
                pile.RemoveAt(0);
                continue;
            }

            foreach (var item in currentBox.Items)
            {
                if (item is Key)
                {
                    Console.WriteLine("Found the key!");
                    return;
                }

                if (item is Box b)
                {
                    pile.Add(b);
                }
            }

            // The Hidden O(n) Trap
            pile.RemoveAt(0);
        }
    }

    public static void LookForKeyRecursively(Box box)
    {
        if (box.Items == null)
        {
            return;
        }

        foreach (var item in box.Items)
        {
            if (item is Key)
            {
                Console.WriteLine("Found the key!");
                return;
            }

            if (item is Box b)
            {
                LookForKeyRecursively(b);
            }
        }
    }

    public static void RecursionWithoutBaseCase(int n)
    {
        Console.WriteLine(n);
        RecursionWithoutBaseCase(n + 1);
    }

    public static int Factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}
