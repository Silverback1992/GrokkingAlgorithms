namespace GrokkingAlgorithms.Chapter7;

public class TreeBFS
{
    private readonly BinaryTree _tree;

    public TreeBFS(BinaryTree tree)
    {
        _tree = tree;
    }

    public void Search()
    {
        if (_tree.Root == null)
        {
            return;
        }

        var queue = new Queue<Node>();
        queue.Enqueue(_tree.Root);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current is File file)
            {
                Console.WriteLine(file.Name);
            }

            if (current.LeftNode != null)
            {
                queue.Enqueue(current.LeftNode);
            }

            if (current.RightNode != null)
            {
                queue.Enqueue(current.RightNode);
            }
        }
    }
}
