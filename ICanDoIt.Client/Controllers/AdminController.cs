using ICanDoIt.Client.Helpers;
using ICanDoIt.Client.Identity;
using ICanDoIt.Client.Models;
using ICanDoIt.Entity.Entities;
using ICanDoIt.Entity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IUrlConventer _urlConventer;
        private readonly IOrderService _orderService;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly IService<cargoStatus> _cargoStatus;
        private readonly IService<ProductImages> _imageCreate;
        private readonly IProductImagesService _productImagesService;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public AdminController(IService<ProductImages> imageCreate, IWebHostEnvironment hostingEnvironment, IProductImagesService productImagesService,IService<cargoStatus> cargoStatus, IOrderService orderService, IProductService productService, ICategoryService categoryService, IUrlConventer urlConventer, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _productService = productService;
            _categoryService = categoryService;
            _urlConventer = urlConventer;
            _roleManager = roleManager;
            _userManager = userManager;
            _orderService = orderService;
            _cargoStatus = cargoStatus;
            _productImagesService = productImagesService;
            _hostingEnvironment = hostingEnvironment;
            _imageCreate = imageCreate;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonmembers = new List<User>();

            foreach (var user in _userManager.Users)
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name)
                                ? members : nonmembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonmembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditRole(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            /*foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }*/
                            return View(model);
                        }
                    }
                }

                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            /*foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }*/
                            return View(model);
                        }
                    }
                }
            }
            return RedirectToAction("Roles", "Admin");
        }
        public async Task<IActionResult> DeleteRole(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
            return RedirectToAction("Roles","Admin");
        }
       
        public IActionResult Roles()
        {
            return View(_roleManager.Roles);
        }

        [HttpGet]
        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.roleName));
                if (result.Succeeded)
                {
                    return RedirectToAction("Roles");
                }
            }
            return View(model);
        }


        public IActionResult Users()
        {
            
            return View( _userManager.Users);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user!=null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;
                return View(new UserDetailModel()
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    SelectedRoles = selectedRoles
                });
            }
            return RedirectToAction("Users","Admin");
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(UserDetailModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;

                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] { };
                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles).ToArray<string>());

                        return Redirect("/admin/users");
                    }
                }
                return Redirect("/admin/users");
            }

            return View(model);

        }
        public async Task<IActionResult>Products()
        {
            var products = await _productService.GetAllAsync();
            return View(new ProductListViewModel()
            {
                Products = products.OrderByDescending(i => i.Id)
            });
        }
        public async Task<IActionResult> Categories()
        {
            var categories = await _categoryService.GetAllAsync();
            return View(new CategoryListViewModel()
            {
                Categories = categories
            });
        }
        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var categories = await _categoryService.GetAllAsync();
            ViewBag.categories = categories;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductModel product)
        {
            
            
            if (ModelState.IsValid)
            {
                var entity = new Product()
                {
                    Name = product.Name,
                    Url = _urlConventer.GetProductUrlWithName(product.Name),
                    Price = product.Price,
                    Description = product.Description,
                    CategoryId = product.CategoryId,
                    isStock = product.isStock,
                    productImages = new List<ProductImages> { }
                };
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    foreach (var item in files)
                    {
                        var uploads = Path.Combine(webRootPath, "Images");
                        var extension = Path.GetExtension(item.FileName);
                        var dynamicFileName = Guid.NewGuid().ToString() + "_" + entity.Id + extension;
                        entity.ImageUrl = dynamicFileName;
                        using (var filesStream = new FileStream(Path.Combine(uploads, dynamicFileName), FileMode.Create))
                        {
                            item.CopyTo(filesStream);
                        }
                        entity.productImages.Add(new ProductImages { ImageUrl = dynamicFileName });
                    }     
                }

                await _productService.AddAsync(entity);

                var msg = new AlertMessage()
                {
                    Message = $"{entity.Name} isimli ürün başarıyla eklendi.",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);


                return RedirectToAction("Products");
            }
            var categories = await _categoryService.GetAllAsync();
            ViewBag.categories = categories;
            return View(product);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category()
                {
                    Name = category.Name,
                    Url = _urlConventer.GetCategoryUrlWithName(category.Name)
                };

                await _categoryService.AddAsync(entity);

                var msg = new AlertMessage()
                {
                    Message = $"{entity.Name} isimli kategori başarıyla eklendi.",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);


                return RedirectToAction("Categories");
            }
            return View(category);
            
        }
        [HttpGet]
        public async Task<IActionResult> EditProduct(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var entity = await _productService.GetByIdAsync((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new ProductModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Url = entity.Url,
                Price = entity.Price,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                CategoryId = entity.CategoryId,
                isStock = entity.isStock
            };
            var categories = await _categoryService.GetAllAsync();
            ViewBag.categories = categories;
            return View(model);
        }
        [HttpPost]
        public  async Task<IActionResult> EditProduct(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                var entity = new Product()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Url = product.Url,
                    Price = product.Price,
                    Description = product.Description,
                    CategoryId = product.CategoryId,
                    isStock = product.isStock,
                    ImageUrl = product.ImageUrl,
                    productImages = new List<ProductImages> { }
                };
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
 
                if (files.Count > 0)
                {
                    _productImagesService.RemoveProductImages(product.Id);
                    foreach (var item in files)
                    {
                          var uploads = Path.Combine(webRootPath, "Images");
                          var extension = Path.GetExtension(item.FileName);
                          var dynamicFileName = Guid.NewGuid().ToString() + "_" + entity.Id + extension;
                          entity.ImageUrl = dynamicFileName;
                          using (var filesStream = new FileStream(Path.Combine(uploads, dynamicFileName), FileMode.Create))
                          {
                              item.CopyTo(filesStream);
                          }
                          entity.productImages.Add(new ProductImages { ImageUrl = dynamicFileName });
                          var entity2 = new ProductImages()
                          {
                              ImageUrl = dynamicFileName,
                              ProductId = entity.Id,
                          };
                          await _imageCreate.AddAsync(entity2);
                    }   
                }
                _productService.Update(entity);

                var msg = new AlertMessage()
                {
                    Message = $"{entity.Name} isimli ürün başarıyla güncellendi.",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);


                return RedirectToAction("Products");
            }
            var categories = await _categoryService.GetAllAsync();
            ViewBag.categories = categories;
            return View(product);
        }
        [HttpGet]
        public async Task<IActionResult> EditCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = await _categoryService.GetByIdAsync((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new CategoryModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Url = entity.Url,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditCategory(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category()
                {
                    Id = category.Id,
                    Name = category.Name,
                    Url = _urlConventer.GetCategoryUrlWithName(category.Name)
                };

                _categoryService.Update(entity);

                var msg = new AlertMessage()
                {
                    Message = $"{entity.Name} isimli kategori başarıyla güncellendi.",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);


                return RedirectToAction("Categories");
            }
            return View(category);
           
        }
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = await _productService.GetByIdAsync((int)id);
            if (entity != null)
            {
                _productService.Remove(entity);
            }

            var msg = new AlertMessage()
            {
                Message = $"{entity.Name} isimli ürün başarıyla silindi.",
                AlertType = "success"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);


            return RedirectToAction("Products");
        }
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = await _categoryService.GetByIdAsync((int)id);
            if (entity != null)
            {
                _categoryService.Remove(entity);
            }

            var msg = new AlertMessage()
            {
                Message = $"{entity.Name} isimli kategori başarıyla silindi.",
                AlertType = "success"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);


            return RedirectToAction("Categories");
        }
        public async Task<IActionResult> NewOrders()
        {
            var orders = await _orderService.GetAllOrders();
            var newOrders = orders.Where(x => x.cargoStatusId == 1).OrderByDescending(x => x.OrderDate);
            return View(new AdminOrdersModel()
            {
                Orders = newOrders
            });
        }
        public async Task<IActionResult> OngoingOrders()
        {
            var orders = await _orderService.GetAllOrders();
            var OngoingOrders = orders.Where(x => x.cargoStatusId == 2).OrderByDescending(x => x.OrderDate);
            return View(new AdminOrdersModel()
            {
                Orders = OngoingOrders
            });
        }
        public async Task<IActionResult> CompletedOrders()
        {
            var orders = await _orderService.GetAllOrders();
            var completedOrders = orders.Where(x => x.cargoStatusId == 3).OrderByDescending(x => x.OrderDate);
            return View(new AdminOrdersModel()
            {
                Orders = completedOrders
            });
        }
        [HttpGet]
        public async Task<IActionResult> EditOrders(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = await _orderService.GetByIdAsync((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new EditOrderModel()
            {
                Id = entity.Id,
                OrderNumber = entity.OrderNumber,
                OrderDate = entity.OrderDate,
                UserId = entity.UserId,
                cargoStatus = entity.cargoStatus,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Address = entity.Address,
                City = entity.City,
                Email = entity.Email,
                Note = entity.Note,
                Phone = entity.Phone,
                PaymentId = entity.PaymentId,
                ConversationId = entity.ConversationId,
                PaymentType = entity.PaymentType,
                OrderState = entity.OrderState,
                OrderItems = entity.OrderItems,
                cargoStatusId = entity.cargoStatusId,
                cargoFirm = entity.cargoFirm,
                trackingCode = entity.trackingCode
            };
            var cargoStatuses = await _cargoStatus.GetAllAsync();
            ViewBag.cargoStatus = cargoStatuses;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditOrders(EditOrderModel entity)
        {
            if (ModelState.IsValid)
            {
                var order = new Order()
                {
                    Id = entity.Id,
                    OrderNumber = entity.OrderNumber,
                    OrderDate = entity.OrderDate,
                    UserId = entity.UserId,
                    cargoStatus = entity.cargoStatus,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Address = entity.Address,
                    City = entity.City,
                    Email = entity.Email,
                    Note = entity.Note,
                    Phone = entity.Phone,
                    PaymentId = entity.PaymentId,
                    ConversationId = entity.ConversationId,
                    PaymentType = entity.PaymentType,
                    OrderState = entity.OrderState,
                    OrderItems = entity.OrderItems,
                    cargoStatusId = entity.cargoStatusId,
                    cargoFirm = entity.cargoFirm,
                    trackingCode = entity.trackingCode
                };

                _orderService.Update(order);
                if(order.cargoStatusId == 1)
                {
                    return RedirectToAction("NewOrders");
                }
                else if (order.cargoStatusId == 2)
                {
                    return RedirectToAction("OngoingOrders");
                }
                else if (order.cargoStatusId == 3)
                {
                    return RedirectToAction("CompletedOrders");
                }
                else
                {
                    return NotFound();
                }
                
            }
            var cargoStatuses = await _cargoStatus.GetAllAsync();
            ViewBag.cargoStatus = cargoStatuses;
            return RedirectToAction("NewOrders");
        }
        public async Task<IActionResult> OrderDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            OrderListModel orderModel;
            var order = await _orderService.GetOrderById((int)id);
            orderModel = new OrderListModel();
            orderModel.OrderId = order.Id;
            orderModel.OrderNumber = order.OrderNumber;
            orderModel.OrderDate = order.OrderDate;
            orderModel.Phone = order.Phone;
            orderModel.FirstName = order.FirstName;
            orderModel.LastName = order.LastName;
            orderModel.Email = order.Email;
            orderModel.Address = order.Address;
            orderModel.City = order.City;
            orderModel.OrderState = order.OrderState;
            orderModel.PaymentType = order.PaymentType;
            orderModel.cargoStatusId = order.cargoStatusId;
            orderModel.trackingCode = order.trackingCode;
            orderModel.cargoFirm = order.cargoFirm;
            orderModel.OrderItems = order.OrderItems.Select(i => new OrderItemModel()
            {
                OrderItemId = i.Id,
                Name = i.Product.Name,
                Price = i.Price,
                Quantity = i.Quantity,
                ImageUrl = i.Product.ImageUrl
            }).ToList();
            var cargoStatuses = await _cargoStatus.GetAllAsync();
            ViewBag.cargoStatus = cargoStatuses;
            return View(orderModel);
        }

    }
}