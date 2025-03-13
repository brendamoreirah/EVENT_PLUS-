using Microsoft.AspNetCore.Mvc;

namespace Event_Plus.Controllers
{
    public class TipoEventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
