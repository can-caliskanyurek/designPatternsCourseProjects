namespace PrototypeCodingExercise.Interfaces
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
