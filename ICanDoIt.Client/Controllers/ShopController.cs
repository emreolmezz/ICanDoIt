using ICanDoIt.Client.Models;
using ICanDoIt.Entity.Entities;
using ICanDoIt.Entity.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductImagesService _productImagesService;
        public ShopController(IProductImagesService productImagesService, IProductService productService)
        {
            _productService = productService;
            _productImagesService = productImagesService;
        }
        public async Task<IActionResult> List(string category, int page=1)
        {
            const int pageSize = 10;
            var products = await _productService.GetProductsByCategory(category,page,pageSize);
            var productsCount = _productService.GetCountByCategory(category);
            return View(new ProductListViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = productsCount,
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
                Products = products
            });
        }
        public async Task<IActionResult> Details(string url)
        {
            if (url == null)
            {
                return NotFound();
            }
            Product product = await _productService.GetWithCategoryByIdAsync(url);
            if (product == null)
            {
                return NotFound();
            }
            var images = await _productImagesService.GetImagesByProductId(product.Id);

            return View(new ProductDetailModel()
            {
                Product = product,
                Category = product.Category,
                ProductImages = images
            });
        }
        public async Task<IActionResult> Search(string q)
        {
            return View(new ProductListViewModel() { 
            
                Products = await _productService.GetSearchResult(q)
            });
        }
    }
}
