using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class TipoExamenDental
    {

        int idDental;
        string nombre;
        int estado;

        public int IdDental
        {
            get
            {
                return idDental;
            }

            set
            {
                idDental = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
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


    }
}
