using AFP_Test.AplicacionCore.Caracteristicas.Departamento;
using AFP_Test.AplicacionCore.Caracteristicas.Empresa;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class DepartamentoController : Controller
    {

        private readonly IMapper _mapper;

        public DepartamentoController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetListaDepartamento(int idDepartamento)
        {
            var empres = new ListaDepartamento();
            var lestDepartamento = empres.GetListDepartamento(idDepartamento);
            return View(lestDepartamento);
        }
    }
}
