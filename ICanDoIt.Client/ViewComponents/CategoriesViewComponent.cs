using System.Collections.Generic;
using System.Threading.Tasks;
using ICanDoIt.Entity.Services;
using Microsoft.AspNetCore.Mvc;

namespace ICanDoIt.Client.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
             if (RouteData.Values["category"]!=null)
                 ViewBag.SelectedCategory = RouteData?.Values["category"];
             var categories = await _categoryService.GetAllAsync();
             return View(categories);

        }
    }
}