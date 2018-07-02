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
    public class Genero
    {
        private Modelo.Genero genero = new Modelo.Genero();

        public bool insertarGenero(Objeto.Genero objGenero)
        {
            return genero.RegistrarGenero(objGenero);
        }


        public DataTable cargarGenero(string parametro)
        {
            return genero.ConsultarGenero(parametro);
        }

        public bool modificarGenero(Objeto.Genero objGenero)
        {
            return genero.ModificarGenero(objGenero);
        }
    }
}
