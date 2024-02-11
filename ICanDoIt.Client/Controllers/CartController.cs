using ICanDoIt.Client.Helpers;
using ICanDoIt.Client.Identity;
using ICanDoIt.Client.Models;
using ICanDoIt.Entity.Entities;
using ICanDoIt.Entity.Services;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly UserManager<User> _userManager;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IAdressService _adressService;
        public CartController(IAdressService adressService, IProductService productService, ICartService cartService, UserManager<User> userManager, IOrderService orderService)
        {
            _cartService = cartService;
            _userManager = userManager;
            _orderService = orderService;
            _productService = productService;
            _adressService = adressService;
        }
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                var cart = await _cartService.GetCartByUserId(currentUser.Id);
                return View(new CartModel()
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(i => new CartItemModel()
                    {
                        CartItemId = i.Id,
                        ProductId = i.ProductId,
                        Name = i.Product.Name,
                        Price = (double)i.Product.Price,
                        ImageUrl = i.Product.ImageUrl,
                        Quantity = i.Quantity

                    }).ToList()
                });
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<List<SessionCartModel>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                if(cart == null)
                {
                    return View();
                }
                else
                {
                    ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
                }
                return View();
            }
           
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId,int quantity)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                var currenUserId = currentUser.Id;
                await _cartService.AddToCart(currenUserId, productId, quantity);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (SessionHelper.GetObjectFromJson<List<SessionCartModel>>(HttpContext.Session, "cart") == null)
                {
                    List<SessionCartModel> cart = new List<SessionCartModel>();
                    cart.Add(new SessionCartModel { Product = await _productService.GetByIdAsync(productId), Quantity = quantity });
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                }
                else
                {
                    List<SessionCartModel> cart = SessionHelper.GetObjectFromJson<List<SessionCartModel>>(HttpContext.Session, "cart");
                    int index = isExist(productId);
                    if (index != -1)
                    {
                        cart[index].Quantity = cart[index].Quantity + quantity;
                    }
                    else
                    {
                        cart.Add(new SessionCartModel { Product = await _productService.GetByIdAsync(productId), Quantity = quantity });
                    }
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                }
               
            }
            return RedirectToAction("Index", "Home");

        }
        private int isExist(int id)
        {
            List<SessionCartModel> cart = SessionHelper.GetObjectFromJson<List<SessionCartModel>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        [HttpPost]
        public IActionResult DeleteFromCart(int productId,SessionCartModel model)
        {
            var userId = _userManager.GetUserId(User);
            if (userId != null)
            {
                _cartService.DeleteFromCart(userId, productId);
                return RedirectToAction("Index", "Cart");
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<List<SessionCartModel>>(HttpContext.Session, "cart");
                cart.RemoveAt(model.ProductIndex);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                return RedirectToAction("Index", "Cart");
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> EditCart(CartEditModel model, SessionCartModel model2)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                var productIndex = model.ProductIndex;
                var cart = await _cartService.GetCartByUserId(currentUser.Id);
                cart.CartItems[productIndex].Quantity = model.Quantity;
                _cartService.Update(cart);
                return RedirectToAction("Index", "Cart");
            }
            else
            {
                List<SessionCartModel> cart = SessionHelper.GetObjectFromJson<List<SessionCartModel>>(HttpContext.Session, "cart");
                cart[model2.ProductIndex].Quantity = model.Quantity;      
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                return RedirectToAction("Index", "Cart");
            }
            
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Shipping()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var adresses = await _adressService.GetAdressesByUserId(currentUser.Id);
            return View(adresses);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Shipping(string selectedAdress)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var adresses = await _adressService.GetAdressesByUserId(currentUser.Id);
            return View();
        }
        [Authorize]
        public async Task<IActionResult> Checkout()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var cart = await _cartService.GetCartByUserId(currentUser.Id);
            var orderModel = new OrderModel();
            orderModel.CustomerId = currentUser.Id;
            orderModel.CartModel = new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Name,
                    Price = (double)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity

                }).ToList()
            };
            return View(orderModel);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Checkout(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(User);
                var userId = currentUser.Id;
                var cart = await _cartService.GetCartByUserId(userId);

                model.CartModel = new CartModel()
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(i => new CartItemModel()
                    {
                        CartItemId = i.Id,
                        ProductId = i.ProductId,
                        Name = i.Product.Name,
                        Price = (double)i.Product.Price,
                        ImageUrl = i.Product.ImageUrl,
                        Quantity = i.Quantity

                    }).ToList()
                };

                var payment = PaymentProcess(model);

                if (payment.Status == "success")
                {
                    await SaveOrder(model, payment, userId);
                    ClearCart(model.CartModel.CartId);
                    //await Success2();
                    return View("Success");
                }
                else
                {
                    var userNullmsg = new AlertMessage()
                    {
                        Message = $"{payment.ErrorMessage}",
                        AlertType = "danger"
                    };
                    TempData["message"] = JsonConvert.SerializeObject(userNullmsg);
                }
            }  

            return View(model);
        }
        [Authorize]
        private Payment PaymentProcess(OrderModel model)
        {
            Options options = new Options();
            options.ApiKey = "sandbox-tIovQexx9AxsUGqPyQUKd884xqPqpBKZ";
            options.SecretKey = "sandbox-wXa8b0NAPlQdp9Wq44oAkpalKgFGgz2j";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";

            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = new Random().Next(111111111, 999999999).ToString();
            request.Price = model.CartModel.TotalPrice().ToString();
            request.PaidPrice = model.CartModel.TotalPrice().ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = model.CartModel.CartId.ToString();
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = model.CardName;
            paymentCard.CardNumber = model.CardNumber;
            paymentCard.ExpireMonth = model.ExpirationMonth;
            paymentCard.ExpireYear = model.ExpirationYear;
            paymentCard.Cvc = model.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            Buyer buyer = new Buyer();
            buyer.Id = model.CustomerId;
            buyer.Name = model.FirstName;
            buyer.Surname = model.LastName;
            buyer.GsmNumber = model.Phone;
            buyer.Email = model.Email;
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = model.Address;
            buyer.Ip = "85.34.78.112";
            buyer.City = model.City;
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = model.FirstName;
            shippingAddress.City = model.City;
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = model.Address;
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = model.FirstName;
            billingAddress.City = model.City;
            billingAddress.Country = "Turkey";
            billingAddress.Description = model.Address;
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem;

            foreach (var item in model.CartModel.CartItems)
            {
                basketItem = new BasketItem();
                basketItem.Id = item.ProductId.ToString();
                basketItem.Name = item.Name;
                basketItem.Category1 = "Telefon";
                basketItem.Price = (item.Price * item.Quantity).ToString();
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItems.Add(basketItem);
            }
            request.BasketItems = basketItems;
            return Payment.Create(request, options);
        }
        [Authorize]
        private async Task SaveOrder(OrderModel model,Payment payment,string userId)
        {
            var order = new Order();
            order.OrderNumber = new Random().Next(111111, 999999).ToString();
            order.OrderState = EnumOrderState.completed;
            order.PaymentType = EnumPaymentType.CreditCard;
            order.PaymentId = payment.PaymentId;
            order.ConversationId = payment.ConversationId;
            order.OrderDate = DateTime.Now;
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.UserId = userId;
            order.Address = model.Address;
            order.Phone = model.Phone;
            order.Email = model.Email;
            order.City = model.City;
            order.Note = model.Note;
            order.cargoStatusId = 1;
            order.cargoFirm = null;
            order.trackingCode = null;
            order.OrderItems = new List<Entity.Entities.OrderItem>();

            foreach (var item in model.CartModel.CartItems)
            {
                var orderItem = new Entity.Entities.OrderItem()
                {
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ProductId = item.ProductId
                };
                order.OrderItems.Add(orderItem);
            }
            await _orderService.Create(order);
        }
        [Authorize]
        private void ClearCart(int cartId)
        {
            _cartService.ClearCart(cartId);
        }
        /*public async Task<IActionResult> Success2()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var cart = await _cartService.GetCartByUserId(currentUser.Id);
            var orderModel = new OrderModel();
            orderModel.CustomerId = currentUser.Id;
            orderModel.FirstName = currentUser.FirstName;
            orderModel.LastName = currentUser.LastName;
            orderModel.CartModel = new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Name,
                    Price = (double)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity

                }).ToList()
            };
            ClearCart(cart.Id);
            return View(orderModel);
        }*/
    }
}