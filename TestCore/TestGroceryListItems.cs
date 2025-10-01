using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Services;
using Grocery.UnitTests.Mocks;

namespace TestCore
{
    public class TestGroceryListItemsService
    {
        private IGroceryListItemsService _groceryListItemsService;

        
        [SetUp]
        public void Setup()
        {
            IGroceryListItemsRepository groceryListItemsRepository = new MockGroceryListItemsRepository();
            IProductRepository productService = new MockProductRepository();
            IGroceryListItemsService groceryListItems = new GroceryListItemsService(groceryListItemsRepository, productService);
            _groceryListItemsService = groceryListItems;
        }

        [Test]
        public void GetAll_ShouldReturnListOfProducts()
        {
            // Arrange
            int expectedCount = 5;
            // Act
            var products = _groceryListItemsService.GetBestSellingProducts();
            // Assert
            Assert.That(products, Is.Not.Null);
            Assert.That(products.Count(), Is.EqualTo(expectedCount));
        }
    }
}