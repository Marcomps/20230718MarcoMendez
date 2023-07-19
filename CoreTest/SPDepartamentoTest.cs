using AFP_Test.AplicacionCore.Caracteristicas.Departamento;
using AFP_Test.Infraestructura.Models;

namespace CoreTest
{
    public class SPDepartamentoTest
    {
        private readonly ListaDepartamento _listaDepartamento;

        public SPDepartamentoTest()
        {
            _listaDepartamento = new ListaDepartamento();
        }

        [Fact]
        public void GetListDepartamento()
        {
            var id = 2;
            var ressult = _listaDepartamento.GetListDepartamento(id);
            Assert.True(ressult.Count > 0);
        }

        [Fact]
        public void FailGetDepartamento()
        {
            var id = 1000;
            var ressult = _listaDepartamento.GetListDepartamento(id);
            Assert.False(ressult.Count < 0);
        }
    }
}