﻿using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Classes
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == color;
        }
    }
}
