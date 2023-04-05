namespace DataStructuresAndAlgorithms.LinkedList;

public class Node
{
    public Node(int value)
    {
        Value = value;
        Previous = null;
        Next = null;
    }

    public Node Previous { get; private set; }
    public Node Next { get; private set; }
    public int Value { get; private set; }
}
