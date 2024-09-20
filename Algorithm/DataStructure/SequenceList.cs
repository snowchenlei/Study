namespace DataStructure;

public class SequenceList<T> : IListDs<T>
{
    private T[] _items;
    private int _count;

    public SequenceList()
    {
        _items = [];
        _count = 0;
    }

    public SequenceList(int size)
    {
        if (size < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(size));
        }
        _items = new T[size];
        _count = 0;
    }

    public int GetLength()
    {
        return _count;
    }

    public void Clear()
    {
        _count = 0;
    }

    public bool IsEmpty()
    {
        return _count == 0;
    }

    public void Add(T item)
    {
        if (_count < _items.Length)
        {
            _items[_count] = item;
            _count++;
        }
        else
        {
            Resize();
            _items[_count] = item;
        }
    }

    private void Resize()
    {
        T[] temps = new T[_items.Length + 1];
        for (int i = 0; i < _items.Length; i++)
        {
            temps[i] = _items[i];
        }

        _items = temps;
    }

    private void CheckIndex(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }

    public void Insert(T item, int index)
    {
        if (_count < _items.Length)
        {
            for (int i = _count; i > index; i--)
            {
                _items[i] = _items[i - 1];
            }
            _items[index] = item;
            _count++;
        }
        else
        {
            Resize();
            for (int i = _count; i > index; i--)
            {
                _items[i] = _items[i - 1];
            }
            _items[index] = item;
            _count++;
        }
    }

    public T Delete(int index)
    {
        CheckIndex(index);
        T value = _items[index];
        for (int i = index; i < _items.Length - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _count--;
        return value;
    }

    public T this[int index] => GetElement(index);

    public T GetElement(int index)
    {
        CheckIndex(index);
        return _items[index];
    }

    public int FindIndex(T value)
    {
        for (int i = 0; i < _items.Length; i++)
        {
            if (_items[i]!.Equals(value))
            {
                return i;
            }
        }

        return -1;
    }
}