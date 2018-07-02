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
    public class GrupoSanguineo
    {
        private Modelo.GrupoSanguineo grupoSanguineo = new Modelo.GrupoSanguineo();

        public bool insertarGrupoSanguineo(Objeto.GrupoSanguineo objGrupoSanguineo)
        {
            return grupoSanguineo.RegistrarGrupoSanguineo(objGrupoSanguineo);
        }


        public DataTable cargarGrupoSanguineo(string parametro)
        {
            return grupoSanguineo.ConsultarGrupoSanguineo(parametro);
        }

        public bool modificarGrupoSanguineo(Objeto.GrupoSanguineo objGrupoSanguineo)
        {
            return grupoSanguineo.ModificarGrupoSanguineo(objGrupoSanguineo);
        }
    }
}
