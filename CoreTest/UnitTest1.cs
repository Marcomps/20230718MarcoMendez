using AFP_Test.AplicacionCore.Caracteristicas.Departamento;
using AFP_Test.Infraestructura.Models;

namespace CoreTest
{
    public class UnitTest1
    {
        private readonly ListaDepartamento _listaDepartamento;

        public UnitTest1()
        {
            _listaDepartamento = new ListaDepartamento();
        }

        [Fact]
        public void GetListEmpresas()
        {
            var id = 1;
            var ressult = _listaDepartamento.GetListDepartamento(id);
            var empresa = Assert.IsType<List<Empresa>>(ressult.Count);
            Assert.True(empresa.Count > 0);
        }
    }
}