namespace DataStructure;

public class LinkedListStack<T> : IStack<T>
{
    private LinkedList<T> datas = new LinkedList<T>();

    public int GetCount() => this.datas.Count;

    public void Push(T value)
    {
        datas.AddFirst(new LinkedListNode<T>(value));
    }

    public T Pop()
    {
        if (datas.First is null)
        {
            throw new Exception();
        }
        T value = datas.First.Value;
        datas.RemoveFirst();
        return value;
    }

    public T Peek()
    {
        if (datas.First is null)
        {
            throw new ArgumentNullException();
        }
        return datas.First.Value;
    }
}