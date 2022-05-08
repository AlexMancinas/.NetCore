using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ConexionSQLSERVER
{
    internal class Conexion
    {
        public static SqlConnection Conexionsql()
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Ejemplo1;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
