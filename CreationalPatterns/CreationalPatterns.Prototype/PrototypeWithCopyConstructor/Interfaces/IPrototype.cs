namespace CopyThroughSerialization.Interfaces
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
