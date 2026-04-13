namespace GrokkingAlgorithms.Chapter6;

public class BFS
{
    private readonly Graph _graph;

    public BFS(Graph graph)
    {
        _graph = graph;
    }

    public bool Search(string name)
    {
        var searched = new HashSet<string>();
        var queue = new Queue<string>();

        foreach (var neighbor in _graph.Nodes[name])
        {
            queue.Enqueue(neighbor);
        }

        while (queue.Count > 0)
        {
            string person = queue.Dequeue();

            if (searched.Contains(person))
            {
                continue;
            }

            if (MangoSellerChecker.IsMangoSeller(person))
            {
                Console.WriteLine($"{person} is a mango seller!");
                return true;
            }

            searched.Add(person);

            foreach (var neighbor in _graph.Nodes[person])
            {
                queue.Enqueue(neighbor);
            }
        }

        return false;
    }
}
