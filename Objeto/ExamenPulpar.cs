using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class ExamenPulpar
    {
        int idExamenPulpar;
        static int idExamen;
        string descripcion;

        public int IdExamenPulpar
        {
            get
            {
                return idExamenPulpar;
            }

            set
            {
                idExamenPulpar = value;
            }
        }

        public int IdExamen
        {
            get
            {
                return idExamen;
            }

            set
            {
                idExamen = value;
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

        //public ExamenPulpar()
        //{
        //    idExamenPulpar = IdExamenPulpar;
        //    idExamen = IdExamen;
        //    descripcion = Descripcion;
        //}
    }
}
