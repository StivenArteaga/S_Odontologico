using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class EstadoProstodontico
    {
        int idEstadoProstodontico;
        int presenciaProtesis;
        string tipo;
        string observacion;
        int idHistoria;

        public int IdEstadoProstodontico
        {
            get
            {
                return idEstadoProstodontico;
            }

            set
            {
                idEstadoProstodontico = value;
            }
        }

        public int PresenciaProtesis
        {
            get
            {
                return presenciaProtesis;
            }

            set
            {
                presenciaProtesis = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Observacion
        {
            get
            {
                return observacion;
            }

            set
            {
                observacion = value;
            }
        }

        public int IdHistoria
        {
            get
            {
                return idHistoria;
            }

            set
            {
                idHistoria = value;
            }
        }

        public EstadoProstodontico()
        {
            idEstadoProstodontico = IdEstadoProstodontico;
            tipo = Tipo;
            presenciaProtesis = PresenciaProtesis;
            observacion = Observacion;
            idHistoria = IdHistoria;
        }
    }
}
