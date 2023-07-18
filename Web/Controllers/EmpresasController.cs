using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AFP_Test.AplicacionCore.Caracteristicas.Empresa;

namespace Web.Controllers
{
    public class EmpresasController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetListaEmpresa(int idEmpresa)
        {
            var empres = new ListaEmpresa();
            var listaEmpresa = empres.GetListEmpresas(idEmpresa);
            return View(listaEmpresa);
        }

    }
}
