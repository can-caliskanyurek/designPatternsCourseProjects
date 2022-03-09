namespace CompositeSpecification.Classes
{
    public class SizeSpecification : Specification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public override bool IsSatisfied(Product product)
        {
            return product.Size == size;
        }
    }
}
