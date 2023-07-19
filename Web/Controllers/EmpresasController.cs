using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AFP_Test.AplicacionCore.Caracteristicas.Empresa;
using AutoMapper;
using Web.Models;

namespace Web.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly IMapper _mapper;

        public EmpresasController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ListaEmpresas(int idEmpresa)
        {
            //List<ProductViewModels> prodList = _mapper.Map<List<ProductViewModels>>(db.Products.ToList());
            var empresaLista = new ListaEmpresa();

            List<EmpresaViewModel> listaEmpresa = _mapper.Map<List<EmpresaViewModel>>(empresaLista.GetListEmpresas(idEmpresa)); //empres.GetListEmpresas(idEmpresa);
            return View(listaEmpresa);
        }

    }
}
