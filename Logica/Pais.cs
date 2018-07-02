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
    public class Pais
    {
        private Modelo.Pais pais = new Modelo.Pais();

        public bool insertarPais(Objeto.Pais objPais)
        {
            return pais.RegistrarPais(objPais);
        }


        public DataTable cargarPais(string parametro)
        {
            return pais.ConsultarPais(parametro);
        }

        public bool modificarPais(Objeto.Pais objPais)
        {
            return pais.ModificarPais(objPais);
        }
    }
}
