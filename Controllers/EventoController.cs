using Microsoft.AspNetCore.Mvc;

namespace Event_Plus.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
