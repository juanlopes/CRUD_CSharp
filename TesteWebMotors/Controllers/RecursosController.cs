using Microsoft.AspNetCore.Mvc;
using Common;

namespace TesteWebMotors.Controllers
{
    public class RecursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Marcas()
        {
            var json = WebContext.GET("https://desafioonline.webmotors.com.br/api/OnlineChallenge/Make");
            return Content(json);
        }

        [HttpPost]
        public IActionResult Modelos(string idMarca)
        {
            var json = WebContext.GET($"https://desafioonline.webmotors.com.br/api/OnlineChallenge/Model?MakeID={idMarca}");
            return Content(json);
        }

        [HttpPost]
        public IActionResult Versoes(string idModelo)
        {
            var json = WebContext.GET($"https://desafioonline.webmotors.com.br/api/OnlineChallenge/Version?ModelID={idModelo}");
            return Content(json);
        }
    }
}
