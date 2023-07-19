using AFP_Test.AplicacionCore.Caracteristicas.Departamento;
using AFP_Test.AplicacionCore.Caracteristicas.Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTest
{
    public class SPEmpresaTest
    {
        private readonly ListaEmpresa _listaEmpresa;

        public SPEmpresaTest()
        {
            _listaEmpresa = new ListaEmpresa();
        }

        [Fact]
        public void GetListEmpresas()
        {
            var id = 1;
            var ressult = _listaEmpresa.GetListEmpresas(id);
            Assert.True(ressult.Count > 0);
        }

        [Fact]
        public void FailGetEmpresas()
        {
            var id = 1000;
            var ressult = _listaEmpresa.GetListEmpresas(id);
            Assert.False(ressult.Count < 0);
        }
    }
}
