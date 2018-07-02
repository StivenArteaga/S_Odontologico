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
    public class TipoDocumento
    {

        private Modelo.TipoDocumento tipoDocumento = new Modelo.TipoDocumento();

        public bool insertarTipoDocumento(Objeto.TipoDocumento objTipoDocumento)
        {
            return tipoDocumento.RegistrarTipoDocumento(objTipoDocumento);
        }


        public DataTable cargarTipoDocumento(string parametro)
        {

            return tipoDocumento.ConsultarTipoDocumento(parametro);
        }

        public bool modificarTipoDocumento(Objeto.TipoDocumento objTipoDocumento)
        {
            return tipoDocumento.ModificarTipoDocumento(objTipoDocumento);
        }
    }
}
