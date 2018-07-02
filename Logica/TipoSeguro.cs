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
    public class TipoSeguro
    {

        private Modelo.TipoSeguro tipoSeguro = new Modelo.TipoSeguro();

        public bool insertarTipoSeguro(Objeto.TipoSeguro objTipoSeguro)
        {
            return tipoSeguro.RegistrarTipoSeguro(objTipoSeguro);
        }


        public DataTable cargarTipoSeguro(string parametro)
        {
            return tipoSeguro.ConsultarTipoSeguro(parametro);
        }

        public bool modificarTipoSeguro(Objeto.TipoSeguro objTipoSeguro)
        {
            return tipoSeguro.ModificarTipoSeguro(objTipoSeguro);
        }
    }
}
