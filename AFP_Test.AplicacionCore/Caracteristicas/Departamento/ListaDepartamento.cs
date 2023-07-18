using AFP_Test.Infraestructura.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AFP_Test.AplicacionCore.Caracteristicas.Departamento
{
    public class ListaDepartamento
    {
        public List<Infraestructura.Models.Departamentos> GetListDepartamento(int idDepartamento)
        {
            using (var db = new DB_AFPContext())
            {
                SqlParameter parametro = new SqlParameter("@IdDepartamento", idDepartamento);
                var departamento = db.Departamentos.FromSqlRaw("EXECUTE [GetDepartamentosPorID] @IdDepartamento", parametro).ToList();

                return departamento;
            }
        }
    }
}
