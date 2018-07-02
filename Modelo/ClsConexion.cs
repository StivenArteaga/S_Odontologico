using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



namespace Modelo
{
    public class ClsConexion
    {
        public SqlConnection Conexion()
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=DUVANMEJIA;Initial Catalog=oclusoft;Integrated Security=True";
            return con;
        }
    }
}
