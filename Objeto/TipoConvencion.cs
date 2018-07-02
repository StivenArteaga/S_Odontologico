using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class TipoConvencion
    {
        int idTipoConvencion;
        string nombre;
        string simbolo;
        int estado;

        public int IdTipoConvencion
        {
            get
            {
                return idTipoConvencion;
            }

            set
            {
                idTipoConvencion = value;
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

        public string Simbolo
        {
            get
            {
                return simbolo;
            }

            set
            {
                simbolo = value;
            }
        }

        public TipoConvencion()
        {
            idTipoConvencion = IdTipoConvencion;
            nombre = Nombre;
            estado = Estado;
        }
    }
}
