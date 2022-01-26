namespace OpenClosedPrinciple.Interfaces
{
    // we introduce a new interface that is open for extension
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
