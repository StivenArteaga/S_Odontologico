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
    public class Antecedentes
    {
        private Modelo.Antecedentes hclinica = new Modelo.Antecedentes();

        public DataTable consultarTipoAntecedente()
        {
            return hclinica.consultarTipoAntecedente();
        }

        public DataTable consultarAntecedenteTipo()
        {
            return hclinica.consultarAntecedenteTipo();
        }

        public DataTable consultarRespuesta()
        {
            return hclinica.consultarRespuesta();
        }

        public bool registrarAntecedente(Objeto.Antecedentes objAntecedentes)
        {
            return hclinica.RegistrarAntecedente(objAntecedentes);
        }
    }
}
