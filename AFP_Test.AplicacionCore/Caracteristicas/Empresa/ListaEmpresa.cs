using AFP_Test.Infraestructura.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AFP_Test.AplicacionCore.Caracteristicas.Empresa 
{
    public class ListaEmpresa
    {
        public List<Infraestructura.Models.Empresa> GetListEmpresas(int idEmpresa)
        {
            using (var db = new DB_AFPContext())
            {
                SqlParameter parametro = new SqlParameter("@IdEmpresa", idEmpresa);
                var empleado = db.Empresa.FromSqlRaw("EXECUTE [GetEmployeeById] @IdEmpresa", parametro).ToList();

                return empleado;
            }
        }
    }
}
