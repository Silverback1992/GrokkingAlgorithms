namespace GrokkingAlgorithms.Chapter7;

public class TreeDFS
{
    public void Search(Node? node)
    {
        if (node == null)
        {
            return;
        }

        if (node is File file)
        {
            Console.WriteLine(file.Name);
            return;
        }

        Search(node.LeftNode);
        Search(node.RightNode);
    }
}
