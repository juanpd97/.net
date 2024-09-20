using Microsoft.AspNetCore.Mvc;

namespace AgendaServicios.web.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
