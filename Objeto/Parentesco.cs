using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Parentesco
    {
        int idParentesco;
        string nombre;
        int estado;

        public int IdParentesco
        {
            get
            {
                return idParentesco;
            }

            set
            {
                idParentesco = value;
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


        public Parentesco()
        {
            idParentesco = IdParentesco;
            nombre = Nombre;
            estado = Estado;
        }
    }
}
