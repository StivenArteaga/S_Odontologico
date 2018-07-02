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
    public class Paciente
    {

        private Modelo.Paciente paciente = new Modelo.Paciente();

        public bool insertarPaciente(Objeto.Paciente objPaciente)
        {

            return paciente.RegistrarPaciente(objPaciente);

        }

        public bool modificarPaciente(Objeto.Paciente objPaciente)
        {
            return paciente.ModificarPaciente(objPaciente);
        }

        public DataTable cargarTipoDocumento()
        {
            return paciente.consultarTipoDocumento();
        }

        public DataTable cargarGenero()
        {
            return paciente.consultarGenero();
        }

        public DataTable cargarOcupacion()
        {

            return paciente.consultarOcupacion();
        }

        public DataTable cargarGrupoSanguineo()
        {
            return paciente.consultarGrupoSanguineo();
        }

        public DataTable cargarParentesco()
        {
            return paciente.consultarParentesco();
        }
    }
}
