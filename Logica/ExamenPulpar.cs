using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Logica
{
    public class ExamenPulpar
    {

        private Modelo.ExamenPulpar examenPulpar = new Modelo.ExamenPulpar();

        public bool insertarExamenPulpar(Objeto.ExamenPulpar objExamenPulpar)
        {
            return examenPulpar.RegistrarExamenPulpar(objExamenPulpar);
        }


        public DataTable cargarExamenPulpar()
        {
            return examenPulpar.ConsultarExamenPulpar();
        }



    }
}
