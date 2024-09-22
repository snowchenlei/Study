namespace DataStructure;

public class LinkedListDs<T> : IListDs<T>
{
    private Node<T>? _header;

    public int GetLength()
    {
        if (_header is null)
        {
            return -1;
        }
        int i = 1;
        Node<T>? temp = _header;
        while (temp.Next is not null)
        {
            i++;
            temp = temp.Next;
        }

        return i;
    }

    public void Clear()
    {
        _header = null;
    }

    public bool IsEmpty() => _header is null;

    public void Add(T item)
    {
        if (_header is null)
        {
            _header = new Node<T>(item);
            return;
        }

        Node<T>? currentNode = _header;
        while (currentNode.Next is not null)
        {
            currentNode = currentNode.Next;
        }
        currentNode.Next = new Node<T>(item);
    }

    public void Insert(T item, int index)
    {
        Node<T> newNode = new Node<T>(item);
        if (index == 0)
        {
            newNode.Next = _header;
            _header = newNode;
            return;
        }

        Node<T>? temp = _header;
        for (int i = 0; i < index - 1; i++)
        {
            if (temp is null)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            temp = temp.Next;
        }
        if (temp is null)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public T Delete(int index)
    {
        if (index == -1)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        Node<T>? temp = _header;
        for (int i = 0; i < index - 1; i++)
        {
            if (temp is null)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            temp = temp.Next;
        }
        if (temp is null || temp.Next is null)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Node<T> deleteItem = temp.Next;
        temp.Next = temp.Next.Next;

        return deleteItem.Value;
    }

    public T this[int index] => GetElement(index);

    public T GetElement(int index)
    {
        if (index == -1)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Node<T>? temp = _header;
        for (int i = 0; i < index; i++)
        {
            if (temp is null)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            temp = temp.Next;
        }
        if (temp is null || temp.Next is null)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return temp.Value;
    }

    public int FindIndex(T value)
    {
        if (_header is null)
        {
            throw new ArgumentOutOfRangeException(nameof(value));
        }

        int i = 0;
        Node<T>? temp = _header;
        while (temp is not null)
        {
            if (temp.Value.Equals(value))
            {
                return i;
            }
            i++;
            temp = temp.Next;
        }

        return -1;
    }
}