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
    public class Consultorio
    {
        private Modelo.Consultorio consultorio = new Modelo.Consultorio();

        public bool insertarConsultorio(Objeto.Consultorio objConsultorio)
        {
            return consultorio.RegistrarConsultorio(objConsultorio);
        }


        public DataTable cargarConsultorio(string parametros)
        {
            return consultorio.ConsultarConsultorio(parametros);
        }

        public bool modificarConsultorio(Objeto.Consultorio objConsultorio)
        {
            return consultorio.ModificarConsultorio(objConsultorio);
        }
    }
}
