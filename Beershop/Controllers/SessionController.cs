using Beershop.Extensions;
using Beershop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Beershop.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetObject("mySession", new SessionVM { Date = DateTime.Now, Company = "VIVES" });

            return View();
        }
    }
}
