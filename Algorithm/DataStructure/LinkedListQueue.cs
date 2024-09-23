namespace DataStructure;

public class LinkedListQueue<T> : IQueue<T>
{
    private LinkedList<T> datas = new LinkedList<T>();

    public int GetCount() => this.datas.Count;

    public void Enqueue(T value)
    {
        datas.AddLast(value);
    }

    public T Dequeue()
    {
        if (datas.First is null)
        {
            throw new Exception();
        }
        T value = datas.First.Value;
        datas.RemoveLast();
        return value;
    }

    public T Peek()
    {
        if (datas.First is null)
        {
            throw new Exception();
        }
        return datas.First.Value;
    }
}