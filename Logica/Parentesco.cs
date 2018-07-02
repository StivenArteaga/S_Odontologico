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
    public class Parentesco
    {
        private Modelo.Parentesco parentesco = new Modelo.Parentesco();

        public bool insertarParentesco(Objeto.Parentesco objParentesco)
        {
            return parentesco.RegistrarParentesco(objParentesco);
        }


        public DataTable cargarParentesco(string parametro)
        {
            return parentesco.ConsultarParentesco(parametro);
        }

        public bool modificarParentesco(Objeto.Parentesco objParentesco)
        {
            return parentesco.ModificarParentesco(objParentesco);
        }
    }
}
