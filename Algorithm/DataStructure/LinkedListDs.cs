namespace DataStructure;

public class LinkedListDs<T> : IListDs<T>
{
    private Node<T>? _node;

    public int GetLength()
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool IsEmpty()
    {
        throw new NotImplementedException();
    }

    public void Add(T item)
    {
        if (_node is null)
        {
            _node = new Node<T>(item);
            return;
        }

        Node<T>? currentNode = _node;
        while (currentNode.Next is not null)
        {
            currentNode = currentNode.Next;
        }
        currentNode.Next = new Node<T>(item);
    }

    public void Insert(T item, int index)
    {
        throw new NotImplementedException();
    }

    public T Delete(int index)
    {
        throw new NotImplementedException();
    }

    public T this[int index] => throw new NotImplementedException();

    public T GetElement(int index)
    {
        throw new NotImplementedException();
    }

    public int FindIndex(T value)
    {
        throw new NotImplementedException();
    }
}