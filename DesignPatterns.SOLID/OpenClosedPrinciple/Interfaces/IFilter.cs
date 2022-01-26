using System.Collections.Generic;

namespace OpenClosedPrinciple.Interfaces
{
    // we introduce a new interface that is open for extension
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
