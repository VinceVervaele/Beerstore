using Beershop.Extensions;
using Beershop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Beershop.Controllers
{
    public class Session2Controller : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetObject<SessionVM>("mySession") != null)
            {
                SessionVM? sessionVM = HttpContext.Session.GetObject<SessionVM>("mySession");

                return View(sessionVM);
            }
            else
            {
                return View();
            }
            
        }
    }
}
