namespace DataStructure;

public class ListQueue<T> : IQueue<T>
{
    private List<T> datas = new List<T>();

    public int GetCount() => this.datas.Count;

    public void Enqueue(T value)
    {
        datas.Insert(0, value);
    }

    public T Dequeue()
    {
        T data = datas.Last();
        datas.RemoveAt(datas.Count - 1);
        return data;
    }

    public T Peek()
    {
        return datas.Last();
    }
}