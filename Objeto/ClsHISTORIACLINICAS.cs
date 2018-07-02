using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class ClsHISTORIACLINICAS
    {
        private string idHistoriaClinica;
        private DateTime fecha;
        private Int16 estado;

        public string IdHistoriaClinica
        {
            get
            {
                return idHistoriaClinica;
            }

            set
            {
                idHistoriaClinica = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public short Estado
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



        public ClsHISTORIACLINICAS() { }

        public ClsHISTORIACLINICAS(string idHistoriaClinica, DateTime fecha, Int16 estado)
        {
            this.idHistoriaClinica = idHistoriaClinica;
            this.fecha = fecha;
            this.estado = estado;
        }

    }
}
