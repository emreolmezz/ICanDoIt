using ICanDoIt.Client.EmailServices;
using ICanDoIt.Client.Helpers;
using ICanDoIt.Client.Identity;
using ICanDoIt.Client.Models;
using ICanDoIt.Entity.Entities;
using ICanDoIt.Entity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Controllers
{
   
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly ICartService _cartService;
        private readonly IOrderService _orderService;
        private readonly IAdressService _adressService;
        private readonly IService<cargoStatus> _cargoStatus;
        public AccountController(IService<cargoStatus> cargoStatus, IAdressService adressService, IOrderService orderService, UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender,RoleManager<IdentityRole> roleManager, ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _cartService = cartService;
            _orderService = orderService;
            _adressService = adressService;
            _cargoStatus = cargoStatus;
        }
        [HttpGet]
        public IActionResult Login(string ReturnUrl=null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                var userNullmsg = new AlertMessage()
                {
                    Message = $"Email veya şifre yanlış",
                    AlertType = "danger"
                };
                TempData["message"] = JsonConvert.SerializeObject(userNullmsg);
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user,model.Password,true,false);
            if (result.Succeeded)
            {
                if (SessionHelper.GetObjectFromJson<List<SessionCartModel>>(HttpContext.Session, "cart") != null)
                {
                    var userId = user.Id;
                    var sessionCart = SessionHelper.GetObjectFromJson<List<SessionCartModel>>(HttpContext.Session, "cart");
                    foreach (var item in sessionCart)
                    {
                        await _cartService.AddToCart(userId, item.Product.Id, item.Quantity);
                    }
                    HttpContext.Session.Remove("cart");
                }
                return Redirect(model.ReturnUrl?? "~/");
            }
            var passwordError = new AlertMessage()
            {
                Message = $"Email veya şifre yanlış",
                AlertType = "danger"
            };
            TempData["message"] = JsonConvert.SerializeObject(passwordError);
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email,
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var rolecontrol = await _roleManager.FindByNameAsync("Customer");
                if (rolecontrol == null)
                {
                    await _roleManager.CreateAsync(new IdentityRole("Customer"));
                }
                await _cartService.InitializeCart(user.Id);
                await _userManager.AddToRoleAsync(user, "Customer");
                return RedirectToAction("Login","Account");
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);

            if (user == null)
            {
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = code
            });

            // sending the reset password mail
            await _emailSender.SendEmailAsync(Email, "Reset Password", $"Parolanızı yenilemek için linke <a href='https://localhost:44374{url}'>tıklayınız.</a>");

            return View();
        }
        public async Task<IActionResult> ResetPassword(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return RedirectToAction("Home", "Index");
            }
            if (userId == null || token == null)
            {
                return RedirectToAction("Home", "Index");
            }

            var model = new ResetPasswordModel { 
                Token = token,
                UserId = user.Id
            };

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return RedirectToAction("Home", "Index");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }

            return View(model);
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> Manage()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Home","Index");
            }
            return View();
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ProfileInfo(string id)
        {
            var currentUserId = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUserId == null)
            {
                return NotFound();
            }
            if (currentUserId.Id == id)
            {
                var currentUser = await _userManager.FindByIdAsync(id);
                if (currentUser == null)
                {
                    return NotFound();
                }
                return View(new UserSelfChangeModel()
                {
                    UserId = currentUser.Id,
                    FirstName = currentUser.FirstName,
                    LastName = currentUser.LastName,
                    Email = currentUser.Email,
                });
            }
            else
            {
                return NotFound();
            }
            
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProfileInfo(UserSelfChangeModel model)
        {
            var currentUserId = await _userManager.GetUserAsync(HttpContext.User);
            if (currentUserId == null)
            {
                return NotFound();
            }
            if (currentUserId.Id == model.UserId)
            {
                if (ModelState.IsValid)
                {
                    var currentUser = await _userManager.FindByIdAsync(model.UserId);
                    if (currentUser != null)
                    {
                        currentUser.FirstName = model.FirstName;
                        currentUser.LastName = model.LastName;
                        currentUser.Email = model.Email;
                        var result = await _userManager.UpdateAsync(currentUser);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                else
                {
                   return View(model);
                }
            }

            return NotFound();

        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> PasswordChange()
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (currentuser == null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (currentuser.Id == null)
            {
                return RedirectToAction("Manage", "Account");
            }


            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PasswordChange(ChangePasswordModel model)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (currentuser.Id == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByIdAsync(currentuser.Id);
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Manage", "Account");
            }
            else
            {
                var currentPasswordError = new AlertMessage()
                {
                    Message = $"Şuan ki şifrenizi yanlış girdiniz",
                    AlertType = "danger"
                };
                TempData["message"] = JsonConvert.SerializeObject(currentPasswordError);
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Adresses()
        {
            var currentuser = await _userManager.GetUserAsync(User);
            return View(new AdressModel()
            {
                Adresses = await _adressService.GetAdressesByUserId(currentuser.Id)
            });
        }
        [HttpGet]
        public IActionResult NewAdress()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewAdress(AddAdressModel model)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var newAdress = new Adresses()
            {
                Title = model.Title,
                City = model.City,
                Town = model.Town,
                Adress = model.Adress,
                ZipCode = model.ZipCode,
                UserId = currentUser.Id
            };
            await _adressService.AddAsync(newAdress);
            return RedirectToAction("Adresses");
        }
        [HttpGet]
        public async Task<IActionResult> EditAdress(int? id)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (id == null)
            {
                return NotFound();
            }
            var adress = await _adressService.GetAdressById((int)id);
            if (adress == null)
            {
                return NotFound();
            }
            if (currentUser.Id == adress.UserId)
            {
                var model = new AddAdressModel()
                {
                    Title = adress.Title,
                    City = adress.City,
                    Town = adress.Town,
                    Adress = adress.Adress,
                    ZipCode = adress.ZipCode,
                    UserId = adress.UserId
                };
                return View(model);
            }          
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditAdress(AddAdressModel model)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                if (currentUser.Id == model.UserId)
                {
                    var EditAdress = new Adresses()
                    {
                        Id = model.Id,
                        Title = model.Title,
                        City = model.City,
                        Town = model.Town,
                        Adress = model.Adress,
                        ZipCode = model.ZipCode,
                        UserId = currentUser.Id
                    };
                    _adressService.Update(EditAdress);
                    return RedirectToAction("Adresses");
                }
                
            }
            return NotFound();
            
        }
        public async Task<IActionResult> DeleteAdress(int? id)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (id == null)
            {
                return NotFound();
            }
            var entity = await _adressService.GetByIdAsync((int)id);
            if (currentUser.Id == entity.UserId)
            {
                if (entity != null)
                {
                    _adressService.Remove(entity);
                }

                return RedirectToAction("Adresses");
            }
            return NotFound();
            
        }

        public async Task<IActionResult> Orders()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var userOrders = await _orderService.GetUserOrders(currentUser.Id);
            var orderListModel = new List<OrderListModel>();
            OrderListModel orderModel;
            foreach (var order in userOrders)
            {
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

                orderListModel.Add(orderModel);
            }
            var cargoStatuses = await _cargoStatus.GetAllAsync();
            ViewBag.cargoStatus = cargoStatuses;
            return View(orderListModel);
        }
    }
}
