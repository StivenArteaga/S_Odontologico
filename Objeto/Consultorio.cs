using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Consultorio
    {

        int idConsultorio;
        string descripcion;
        int estado;

        public int IdConsultorio
        {
            get
            {
                return idConsultorio;
            }

            set
            {
                idConsultorio = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
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

        public Consultorio()
        {
            descripcion = Descripcion;
            estado = Estado;
        }
    }
}
