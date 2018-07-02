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
    public class Ciudad
    {
        private Modelo.Ciudad ciudad = new Modelo.Ciudad();


        public bool insertarCiudad(Objeto.Ciudad objCiudad)
        {
            return ciudad.RegistrarCiudad(objCiudad);
        }


        public DataTable cargarCiudad()
        {
            return ciudad.ConsultarCiudad();
        }

        public DataTable cargarNombreCiudad()
        {
            return ciudad.cargarNombreDepartamento();
        }

        public bool modificarCiudad(Objeto.Ciudad objCiudad)
        {
            return ciudad.ModificarCiudad(objCiudad);
        }
    }
}
