using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Modelo
{
    public class ExamenPulpar
    {
        public string[] vector = new string[3];

        private static string error;

        public string Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }

        public bool RegistrarExamenPulpar(Objeto.ExamenPulpar parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarEXAMENPULPARES]";
                SqlCommand comandoExamenPulpar = new SqlCommand(procedimiento, conexion);

                comandoExamenPulpar.CommandType = System.Data.CommandType.StoredProcedure;
                //comandoEstadoProstodontico.Parameters.AddWithValue("@idEstadoProstodontico", parametros.IdEstadoProstodontico);
                comandoExamenPulpar.Parameters.AddWithValue("@idExamen", parametros.IdExamen);
                comandoExamenPulpar.Parameters.AddWithValue("@descripcion", parametros.Descripcion);

                int resultadoModelo = comandoExamenPulpar.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception e)
            {
                Error = e.Message;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return resultado;
        }

        public DataTable ConsultarExamenPulpar()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";


                procedimiento = "[dbo].[consultarExamenPulpar]";



                SqlDataAdapter datosExamenPulpar = new SqlDataAdapter(procedimiento, conexion);

                datosExamenPulpar.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosExamenPulpar.Fill(dt);
            }
            catch (Exception e)
            {
                Error = e.Message;
                //throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return dt;
        }

    }
}
