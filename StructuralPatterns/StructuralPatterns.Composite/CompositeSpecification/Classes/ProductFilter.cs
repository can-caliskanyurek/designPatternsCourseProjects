using CompositeSpecification.Interfaces;
using System.Collections.Generic;

namespace CompositeSpecification.Classes
{
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, Specification<Product> specification)
        {
            foreach (Product product in products)
            {
                if (specification.IsSatisfied(product))
                    yield return product;
            }
        }
    }
}
