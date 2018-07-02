using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Logica
{
    public class EstadoProstodontico
    {
        private Modelo.EstadoProstodontico estadoProstodontico = new Modelo.EstadoProstodontico();

        public bool insertarEstadoProstodontico(Objeto.EstadoProstodontico objEstadoProstodontico)
        {
            return estadoProstodontico.RegistrarEstadoProstodontico(objEstadoProstodontico);
        }


        public DataTable cargarEstadoProstodontico()
        {
            return estadoProstodontico.ConsultarEstadoProstodontico();
        }

        public bool modificarEstadoProstodontico(Objeto.EstadoProstodontico objEstadoProstodontico)
        {
            return estadoProstodontico.ModificarEstadoProstodontico(objEstadoProstodontico);
        }
    }
}
