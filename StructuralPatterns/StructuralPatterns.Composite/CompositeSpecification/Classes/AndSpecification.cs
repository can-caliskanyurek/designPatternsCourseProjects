using System.Linq;

namespace CompositeSpecification.Classes
{
    // combinator
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(params Specification<T>[] items) : base(items)
        {

        }

        public override bool IsSatisfied(T t)
        {
            return items.All(item => item.IsSatisfied(t));
        }
    }
}
