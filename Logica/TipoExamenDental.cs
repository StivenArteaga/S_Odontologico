using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Logica
{
    public class TipoExamenDental    // Supernumerarios , decoloración, erosión...
    {
        private Modelo.TipoExamenDental tipoExamenDental = new Modelo.TipoExamenDental();

        public bool insertarTipoExamenDental(Objeto.TipoExamenDental objTipoExamenDental)
        {
            return tipoExamenDental.RegistrarTipoExamenDental(objTipoExamenDental);
        }


        public DataTable cargarTipoExamenDental()
        {
            return tipoExamenDental.ConsultarTipoExamenDental();
        }

        public bool modificarTipoExamenDental(Objeto.TipoExamenDental objTipoExamenDental)
        {
            return tipoExamenDental.ModificarTipoExamenDental(objTipoExamenDental);
        }
    }
}
