namespace DataStructure;

public interface IStack<T>
{
    int GetCount();

    void Push(T value);

    T Pop();

    T Peek();
}