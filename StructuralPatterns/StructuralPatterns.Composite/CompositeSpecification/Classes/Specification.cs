namespace CompositeSpecification.Classes
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfied(T t);
    }
}
