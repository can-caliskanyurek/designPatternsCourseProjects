using CompositeSpecification.Classes;
using System;

namespace CompositeSpecification
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, XLarge
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            ProductFilter pf = new ProductFilter();

            Console.WriteLine("Green products (new)");
            foreach (Product product in pf.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine($" - {product.Name} is green");

            Console.WriteLine("Large products");
            foreach (Product product in pf.Filter(products, new SizeSpecification(Size.Large)))
                Console.WriteLine($" - {product.Name} is large");

            Console.WriteLine("Large blue products (new)");
            foreach (Product product in pf.Filter(products,
                new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
                Console.WriteLine($" - {product.Name} is large and blue");
        }
    }
}
