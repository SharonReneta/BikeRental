using Microsoft.AspNetCore.Mvc;

namespace BikeRental.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/textpage1")]
        public IActionResult HOME()
        {
            return View();
        }


    }
}
