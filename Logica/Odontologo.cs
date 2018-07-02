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
    public class Odontologo
    {
        private Modelo.Odontologo odontologo = new Modelo.Odontologo();

        public bool insertarOdontologo(Objeto.Odontologo objOdontologo)
        {

            return odontologo.RegistrarOdontologo(objOdontologo);

        }

        public bool modificarOdontologo(Objeto.Odontologo objOdontologo)
        {
            return odontologo.ModificarOdontologo(objOdontologo);
        }

        public DataTable cargarTipoDocumento()
        {
            return odontologo.consultarTipoDocumento();
        }

        public DataTable cargarGenero()
        {
            return odontologo.consultarGenero();
        }

        public DataTable cargarConsultorio()
        {

            return odontologo.consultarConsultorio();
        }

        public DataTable cargarGrupoSanguineo()
        {

            return odontologo.consultarGrupoSanguineo();
        }

        //public DataTable mostrarodontologo()
        //{

        //   // return odontologo.Consultar_odontologo();
        //}
    }
}
