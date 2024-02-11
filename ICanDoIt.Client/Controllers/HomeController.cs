using ICanDoIt.Client.Identity;
using ICanDoIt.Client.Models;
using ICanDoIt.Entity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly UserManager<User> _userManager;
        public HomeController(IProductService productService, UserManager<User> userManager)
        {
            _productService = productService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var products = await _productService.GetAllAsync();
            return View(new ProductListViewModel()
            {
                Products = products.OrderByDescending(i=>i.Id).Where(i=>i.isStock),
                UserId = userId
            });
        }
    }
}
