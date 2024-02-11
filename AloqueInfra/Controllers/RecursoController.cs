using Microsoft.AspNetCore.Mvc;

namespace AloqueInfra.Controllers
{
    public class RecursoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
