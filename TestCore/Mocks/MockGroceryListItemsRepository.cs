using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.UnitTests.Mocks
{
    internal class MockGroceryListItemsRepository : IGroceryListItemsRepository
    {
        private readonly List<GroceryListItem> groceryListItems;
        public MockGroceryListItemsRepository() 
        {
            groceryListItems = [
                new GroceryListItem(1, 1, 1, 3),
                new GroceryListItem(2, 1, 2, 1),
                new GroceryListItem(3, 1, 3, 4),
                new GroceryListItem(4, 1, 1, 2),
                new GroceryListItem(5, 1, 2, 5),
                new GroceryListItem(6, 1, 4, 1),
                new GroceryListItem(7, 1, 5, 1),
                new GroceryListItem(8, 1, 1, 2),
            ];
        }

        public GroceryListItem Add(GroceryListItem item)
        {
            int newId = groceryListItems.Max(g => g.Id) + 1;
            item.Id = newId;
            groceryListItems.Add(item);
            return Get(item.Id);
        }

        public GroceryListItem? Delete(GroceryListItem item)
        {
            bool removed = groceryListItems.Remove(item);
            return removed ? item : null;
        }

        public List<GroceryListItem> GetAllOnGroceryListId(int id)
        {
            return groceryListItems.Where(g => g.GroceryListId == id).ToList();
        }

        public GroceryListItem? Get(int id)
        {
            return groceryListItems.FirstOrDefault(g => g.Id == id);
        }

        public GroceryListItem? Update(GroceryListItem item)
        {
            GroceryListItem? listItem = groceryListItems.FirstOrDefault(i => i.Id == item.Id);
            listItem = item;
            return listItem;
        }

        public List<GroceryListItem> GetAll()
        {
            return groceryListItems;
        }
    }
}