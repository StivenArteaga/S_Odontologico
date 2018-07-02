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
    public class TipoConvencion
    {
        private Modelo.TipoConvencion tipoConvencion = new Modelo.TipoConvencion();

        public bool insertarTipoConvencion(Objeto.TipoConvencion objTipoConvencion)
        {
            return tipoConvencion.registrarTipoConvencion(objTipoConvencion);
        }


        public DataTable cargarTipoConvencion(string parametro)
        {
            return tipoConvencion.consultarTipoConvencion(parametro);
        }

        public bool modificarTipoConvencion(Objeto.TipoConvencion objTipoConvencion)
        {
            return tipoConvencion.modificarTipoConvencion(objTipoConvencion);
        }
    }
}
