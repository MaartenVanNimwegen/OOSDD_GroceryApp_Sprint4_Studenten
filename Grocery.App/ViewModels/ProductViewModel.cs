using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductViewModel(IGrocaryListItems productService)
        {
            Products = new(productService.GetAll());
        }

    }
}
