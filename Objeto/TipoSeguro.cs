using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class TipoSeguro
    {
        int idTipoSeguro;
        string nombre;
        int estado;

        public int IdTipoSeguro
        {
            get
            {
                return idTipoSeguro;
            }

            set
            {
                idTipoSeguro = value;
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


        public TipoSeguro()
        {
            idTipoSeguro = IdTipoSeguro;
            nombre = Nombre;
            estado = Estado;
        }
    }
}
