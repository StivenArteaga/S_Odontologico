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
    public class Departamento
    {
        private Modelo.Departamento departamento = new Modelo.Departamento();

        public bool insertarDepartamento(Objeto.Departamento objDepartamento)
        {
            return departamento.RegistrarDepartamento(objDepartamento);
        }


        public DataTable cargarDepartamento()
        {
            return departamento.ConsultarDepartamento();
        }

        public DataTable cargarNombreDepartamento()
        {
            return departamento.cargarNombrePais();
        }

        public bool modificarDepartamento(Objeto.Departamento objDepartamento)
        {
            return departamento.modificarDepartamento(objDepartamento);
        }
    }
}
