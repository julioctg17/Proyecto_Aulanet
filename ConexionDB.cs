using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Aulanet
{
    public class ConexionDB
    {
        private string cadenaConexion =
"Data Source=MSI;Initial Catalog = ProyectoI; Integrated Security = True;";
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
