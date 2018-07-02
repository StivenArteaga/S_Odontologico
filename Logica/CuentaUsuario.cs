using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Logica
{
    public class CuentaUsuario
    {
        private Modelo.CuentasUsuarios obj = new Modelo.CuentasUsuarios();

        public DataTable CargarRol()
        {
            return obj.ConsultarRol();
        }

        public bool insertarCuentaUsuario(Objeto.CuentasUsuarios parametros)
        {
            return obj.RegistrarCuentaUsuario(parametros);
        }
    }
}
