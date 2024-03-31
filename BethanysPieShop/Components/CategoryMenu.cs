using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;

namespace BethanysPieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepositoy;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepositoy = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepositoy.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
