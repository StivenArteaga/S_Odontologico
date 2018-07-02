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
    public class TipoHabito
    {
        private Modelo.TipoHabito tipoHabito = new Modelo.TipoHabito();

        public bool insertarTipoHabito(Objeto.TipoHabito objTipoHabito)
        {
            return tipoHabito.RegistrarTipoHabito(objTipoHabito);
        }


        public DataTable cargarTipoHabito()
        {
            return tipoHabito.ConsultarTipoHabito();
        }

        public bool modificarTipoHabito(Objeto.TipoHabito objTipoHabito)
        {
            return tipoHabito.ModificarTipoHabito(objTipoHabito);
        }
    }
}
