using CompositeSpecification.Classes;
using System.Collections.Generic;

namespace CompositeSpecification.Interfaces
{
    // we introduce a new interface that is open for extension
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }
}
