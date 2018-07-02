using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class TipoExamenEstomatologico /// Labio inferior, labio superior, comisuras, mejillas, paladar
    {
        int idEstomatologico;
        string nombre;
        int estado;

        public int IdEstomatologico
        {
            get
            {
                return idEstomatologico;
            }

            set
            {
                idEstomatologico = value;
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

        public TipoExamenEstomatologico()
        {
            idEstomatologico = IdEstomatologico;
            nombre = Nombre;
            estado = Estado;
        }
    }
}
