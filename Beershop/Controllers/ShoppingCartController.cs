using Beershop.Extensions;
using Beershop.Services;
using Beershop.ViewModels;
using BeerStore.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Beershop.Controllers
{
    public class ShoppingCartController : Controller
    {
        

        public IActionResult Index()
        {
            ShoppingCartVM shopping = HttpContext.Session.GetObject<ShoppingCartVM>("ShoppingCart"); 


            return View(shopping);
        }

        public async Task<IActionResult> Delete(int? bierNr)
        {
            ShoppingCartVM cartList = HttpContext.Session.GetObject<ShoppingCartVM>("ShoppingCart");


            CartVM? itemToRemove = cartList?.Cart?.FirstOrDefault(r => r.Biernr == bierNr);
           
            if(itemToRemove != null)
            {
                cartList?.Cart?.Remove(itemToRemove);
                HttpContext.Session.SetObject("ShoppingCart", cartList);
            }


            return View("Index", cartList);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Payment(ShoppingCartVM carts)
        {
            string? userID = User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

    }
}
