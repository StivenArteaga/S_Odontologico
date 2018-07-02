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
    public class HabitoHigiene
    {
        private Modelo.HabitoHigiene habitoHigiene = new Modelo.HabitoHigiene();

        public DataTable consultarTipoHabitoHigiene()
        {
            return habitoHigiene.consultarTipoHabitoHigiene();
        }

        public DataTable consultarHabitoHigiene()
        {
            return habitoHigiene.consultarHabitoHigiene();
        }

        public DataTable consultarRespuesta()
        {
            return habitoHigiene.consultarRespuesta();
        }

        public bool registrarHabitoHigiene(Objeto.HabitoHigiene objHabitoHigiene)
        {
            return habitoHigiene.RegistrarHabitoHigiene(objHabitoHigiene);
        }
    }
}
