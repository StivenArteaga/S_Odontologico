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
    public class RespuestaHistoriaClinica
    {
        private Modelo.RespuestaHistoriaClinica respuestaHistoriaClinica = new Modelo.RespuestaHistoriaClinica();


        public bool insertarRespuestaHistoriaClinica(Objeto.RespuestaHistoriaClinica objRespuestaHistoriaClinica)
        {
            return respuestaHistoriaClinica.RegistrarRespuestaHistoriaClinica(objRespuestaHistoriaClinica);
        }


        public DataTable cargarRespuestaHistoriaClinica()
        {
            return respuestaHistoriaClinica.ConsultarRespuestaHistoriaClinica();
        }

        public bool modificarRespuestaHistoriaClinica(Objeto.RespuestaHistoriaClinica objRespuestaHistoriaClinica)
        {
            return respuestaHistoriaClinica.ModificarRespuestaHistoriaClinica(objRespuestaHistoriaClinica);
        }
    }
}
