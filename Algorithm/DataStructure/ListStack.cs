namespace DataStructure;

public class ListStack<T> : IStack<T>
{
    private List<T> datas = new List<T>();

    public int GetCount() => this.datas.Count;

    public ListStack()
    {
    }

    public ListStack(IEnumerable<T> values)
    {
        var temps = values as T[] ?? values.ToArray();
        for (int i = temps.Count() - 1; i >= 0; i--)
        {
            Push(temps[i]);
        }
    }

    public void Push(T value)
    {
        datas.Insert(0, value);
    }

    public T Pop()
    {
        T temp = datas[0];
        datas.RemoveAt(0);
        return temp;
    }

    public T Peek()
    {
        return datas[0];
    }
}