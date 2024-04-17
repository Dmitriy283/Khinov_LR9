using Microsoft.AspNetCore.Mvc;
using Khinov_LR9.Models;

namespace Khinov_LR9.Components
{
    public class ProductListViewComponent : ViewComponent
    {
        List<ProductModel> productList = new List<ProductModel>
        {
              new ProductModel(1, "Картридж Voopoo PnP Pod Cartridge", 180),
            new ProductModel(2, "Випарник Voopoo Drag S 2", 120),
            new ProductModel(3, "Випарник Voopoo Drag X Plus", 120),
            new ProductModel(4, "Картридж Voopoo PnP Pod Tank", 499),
        };
        public IViewComponentResult Invoke()
        {
            return View(productList);
        }
    }
}
