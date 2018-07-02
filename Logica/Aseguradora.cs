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
    public class Aseguradora
    {
        private Modelo.Aseguradora aseguradora = new Modelo.Aseguradora();

        public bool insertarAseguradora(Objeto.Aseguradora objAseguradora)
        {
            return aseguradora.RegistrarAseguradora(objAseguradora);
        }


        public DataTable cargarAseguradora(string parametro)
        {
            return aseguradora.ConsultarAseguradora(parametro);
        }

        public bool modificarAseguradora(Objeto.Aseguradora objAseguradora)
        {
            return aseguradora.ModificarAseguradora(objAseguradora);
        }

    }
}
