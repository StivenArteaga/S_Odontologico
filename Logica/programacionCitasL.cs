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
   public class programacionCitasL
    {
        private Modelo.programacionCitasM obj = new Modelo.programacionCitasM();

        public DataTable Consultar_paciente(string documento)
        {
            return obj.Consultar_paciente(documento);
        }

        public bool insertarProgramacioncitas(Objeto.programacionCitasO programacioncitas)
        {

            return obj.Registrar_cita(programacioncitas);

        }

        public DataTable Cargarodontologo()
        {

            return obj.Consultar_odontologo();
        }

        public DataTable listar_CITAXFECHA(DateTime fecha)
        {
            return obj.listar_CITAXFECHA(fecha);
        }
        
        public DataTable listar_CITAXPACIENTE(string documento)
        {
            return obj.listar_CITAXPACIENTE(documento);
        }
        
        public DataTable listar_CITAXDOCYFECHA(string documento, DateTime fecha)
        {
            return obj.listar_CITAXDOCYFECHA(documento, fecha);
        }
    }
}
