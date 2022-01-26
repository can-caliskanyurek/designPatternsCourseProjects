using OpenClosedPrinciple.Interfaces;
using System.Collections.Generic;

namespace OpenClosedPrinciple.Classes
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> specification)
        {
            foreach (Product product in products)
            {
                if (specification.IsSatisfied(product))
                    yield return product;
            }
        }
    }
}
