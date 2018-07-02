using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class RespuestaHistoriaClinica
    {
        int idRespuesta;
        string respuesta;
        int estado;

        public int IdRespuesta
        {
            get
            {
                return idRespuesta;
            }

            set
            {
                idRespuesta = value;
            }
        }

        public string Respuesta
        {
            get
            {
                return respuesta;
            }

            set
            {
                respuesta = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public RespuestaHistoriaClinica()
        {
            idRespuesta = IdRespuesta;
            respuesta = Respuesta;
            estado = Estado;
        }
    }
}
