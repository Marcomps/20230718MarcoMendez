using AutoMapper;
using Web.Models;
using AFP_Test.Infraestructura.Models;

namespace Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DepartamentoViewModel, Departamentos>();
            CreateMap<Departamentos, DepartamentoViewModel>();

            CreateMap<EmpresaViewModel, Empresa>();
            CreateMap<Empresa, EmpresaViewModel>();
        }
    }
}
