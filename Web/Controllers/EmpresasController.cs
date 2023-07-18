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
        public IActionResult GetListaEmpresasa(int id)
        {
            var empres = new ListaEmpresa();
            var listaEmpresas = empres.GetListEmpresas(id);
            return View(listaEmpresas);
        }

    }
}
