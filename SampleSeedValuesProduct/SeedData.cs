using SampleSeedValuesProduct.Models;

namespace SampleSeedValuesProduct
{
    public class SeedData
    {
        public static List<Product> Products()
        {
            return new List<Product>
            {
                new Product { ProductId = 1, Name = "Mobile", Description = "Iphone 16", Quantity = 1 },
                new Product { ProductId = 2, Name = "Laptop", Description = "i7 , 16GB Ram, 512GB SSD", Quantity = 3 },
                new Product { ProductId = 3, Name = "Moniter", Description = "Samsung 24 inch", Quantity = 5 }
            };
        }
    }
}
