using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Logica
{
    public class EstadoCivil
    {

        private Modelo.EstadoCivil estadoCivil = new Modelo.EstadoCivil();

        public bool insertarEstadoCivil(Objeto.EstadoCivil objEstadoCivil)
        {
            return estadoCivil.RegistrarEstadoCivil(objEstadoCivil);
        }


        public DataTable cargarEstadoCivil(string parametro)
        {
            return estadoCivil.ConsultarEstadoCivil(parametro);
        }

        public bool modificarEstadoCivil(Objeto.EstadoCivil objEstadoCivil)
        {
            return estadoCivil.ModificarEstadoCivil(objEstadoCivil);
        }
    }
}
