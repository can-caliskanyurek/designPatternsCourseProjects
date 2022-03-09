namespace CompositeSpecification.Classes
{
    public class ColorSpecification : Specification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public override bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }
}
