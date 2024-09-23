namespace DataStructure;

public interface IQueue<T>
{
    int GetCount();

    void Enqueue(T value);

    T Dequeue();

    T Peek();
}