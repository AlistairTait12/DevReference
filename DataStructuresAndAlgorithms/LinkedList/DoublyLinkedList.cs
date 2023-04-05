using System.Collections;

namespace DataStructuresAndAlgorithms.LinkedList;

public class DoublyLinkedList<T> : ICollection<T>
{
    public DoublyLinkedListNode<T> Head { get; private set; }

    public DoublyLinkedListNode<T> Tail { get; private set; }

    public bool GetHead(out T value)
    {
    }

    public bool GetTail(out T value)
    {
    }

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
