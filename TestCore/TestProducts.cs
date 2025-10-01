using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Services;
using Grocery.UnitTests.Mocks;

namespace TestCore
{
    public class TestProducts
    {
        private IGrocaryListItems _productService;


        [SetUp]
        public void Setup()
        {
            IProductRepository productRepository = new MockProductRepository();
            IGrocaryListItems productService = new ProductService(productRepository);
            _productService = productService;
        }

        [Test]
        public void GetAll_ShouldReturnListOfProducts()
        {
            // Arrange
            int expectedCount = 6;
            // Act
            var products = _productService.GetAll();
            // Assert
            Assert.That(products, Is.Not.Null);
            Assert.That(products.Count(), Is.EqualTo(expectedCount));
        }
    }
}