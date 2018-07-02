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
    public class ExamenEstomatologico
    {
        private Modelo.ExamenEstomatologico examenEstomatologico = new Modelo.ExamenEstomatologico();

        public DataTable consultarTipoExamenEstomatologico()
        {
            return examenEstomatologico.consultarTipoExamenEstomatologico();
        }

        public DataTable consultarExamenEstomatologico()
        {
            return examenEstomatologico.consultarExamenEstomatologico();
        }

        public DataTable consultarRespuesta()
        {
            return examenEstomatologico.consultarRespuesta();
        }

        public bool registrarExamenEstomatologico(Objeto.ExamenEstomatologico objExamenEstomatologico)
        {
            return examenEstomatologico.RegistrarExamenEstomatologico(objExamenEstomatologico);
        }
    }
}
