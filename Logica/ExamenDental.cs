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
    public class ExamenDental
    {
        private Modelo.ExamenDental examenDental = new Modelo.ExamenDental();

        public DataTable consultarTipoExamenDental()
        {
            return examenDental.consultarTipoExamenDental();
        }

        public DataTable consultarExamenDental()
        {
            return examenDental.consultarExamenDental();
        }

        public DataTable consultarRespuesta()
        {
            return examenDental.consultarRespuesta();
        }

        public bool registrarExamenDental(Objeto.ExamenDental objExamenDental)
        {
            return examenDental.RegistrarExamenDental(objExamenDental);
        }
    }
}
