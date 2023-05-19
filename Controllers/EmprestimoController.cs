using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivro.Controllers
{
    public class EmprestimoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
