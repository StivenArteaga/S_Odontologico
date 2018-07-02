using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class TipoHabito
    {
        int idHabitoHigiene;
        string nombre;
        int estado;

        public int IdHabitoHigiene
        {
            get
            {
                return idHabitoHigiene;
            }

            set
            {
                idHabitoHigiene = value;
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

        public TipoHabito()
        {
            idHabitoHigiene = IdHabitoHigiene;
            nombre = Nombre;
            estado = Estado;
        }
    }
}
