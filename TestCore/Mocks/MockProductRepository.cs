using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.UnitTests.Mocks
{
    internal class MockProductRepository : IProductRepository
    {
        private readonly List<Product> productList;
        public MockProductRepository() 
        { 
            productList = [
                new Product(1, "Melk", 300),
                new Product(2, "Kaas", 100),
                new Product(3, "Brood", 400),
                new Product(4, "Cornflakes", 0),
                new Product(5, "Yoghurt", 50),
                new Product(6, "Boter", 200),
            ];
        }

        public Product Add(Product item)
        {
            productList.Add(item);
            return item;
        }

        public Product? Delete(Product item)
        {
            bool removed = productList.Remove(item);
            return removed ? item : null;
        }

        public Product? Get(int id)
        {
            return productList.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return productList;
        }

        public Product? Update(Product item)
        {
            Product? product = productList.FirstOrDefault(p => p.Id == item.Id);
            if (product == null) return null;
            product.Id = item.Id;
            return product;
        }
    }
}