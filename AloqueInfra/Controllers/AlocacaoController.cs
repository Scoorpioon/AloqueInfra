using Microsoft.AspNetCore.Mvc;

namespace AloqueInfra.Controllers
{
    public class AlocacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
