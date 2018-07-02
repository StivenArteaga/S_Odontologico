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
    public class Ocupacion
    {

        private Modelo.Ocupacion ocupacion = new Modelo.Ocupacion();

        public bool insertarOcupacion(Objeto.Ocupacion objOcupacion)
        {
            return ocupacion.RegistrarOcupacion(objOcupacion);
        }


        public DataTable cargarOcupacion(string parametro)
        {
            return ocupacion.ConsultarOcupacion(parametro);
        }

        public bool modificarOcupacion(Objeto.Ocupacion objOcupacion)
        {
            return ocupacion.ModificarOcupacion(objOcupacion);
        }
    }
}
