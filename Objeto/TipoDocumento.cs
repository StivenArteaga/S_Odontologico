using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class TipoDocumento
    {
        int idTipoDocumento;
        string nombre;
        int estado;

        public int IdTipoDocumento
        {
            get
            {
                return idTipoDocumento;
            }

            set
            {
                idTipoDocumento = value;
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

        public TipoDocumento()
        {
            nombre = Nombre;
            estado = Estado;
        }
    }
}
