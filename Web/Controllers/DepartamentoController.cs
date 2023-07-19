using AFP_Test.AplicacionCore.Caracteristicas.Departamento;
using AFP_Test.AplicacionCore.Caracteristicas.Empresa;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

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
        public IActionResult DepartamentoLista(int idDepartamento)
        {
            var empresaLista = new ListaDepartamento();

            List<DepartamentoViewModel> listaDepartamento =
                _mapper.Map<List<DepartamentoViewModel>>(empresaLista.GetListDepartamento(idDepartamento));

            return View(listaDepartamento);
        }
    }
}
