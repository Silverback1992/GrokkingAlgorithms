namespace GrokkingAlgorithms.Chapter5;

public static class Voting
{
    private static readonly Dictionary<string, int> _voters = [];

    public static void CheckVoter(string name)
    {
        if (_voters.ContainsKey(name))
        {
            Console.WriteLine("Kick them out!");
            return;
        }

        Console.WriteLine("Let them vote.");
        _voters.Add(name, _voters.Count);
    }
}
