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
    public class TipoExamenEstomatologico
    {
        private Modelo.TipoExamenEstomatologico tipoExamenEstomatologico = new Modelo.TipoExamenEstomatologico();

        public bool insertarTipoExamenEstomatologico(Objeto.TipoExamenEstomatologico objTipoExamenEstomatologico)
        {
            return tipoExamenEstomatologico.RegistrarTipoExamenEstomatologico(objTipoExamenEstomatologico);
        }


        public DataTable cargarTipoExamenEstomatologico()
        {
            return tipoExamenEstomatologico.ConsultarTipoExamenEstomatologico();
        }

        public bool modificarTipoExamenEstomatologico(Objeto.TipoExamenEstomatologico objTipoExamenEstomatologico)
        {
            return tipoExamenEstomatologico.ModificarTipoExamenEstomatologico(objTipoExamenEstomatologico);
        }
    }
}
