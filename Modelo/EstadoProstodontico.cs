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
    public class EstadoProstodontico
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

        public bool RegistrarEstadoProstodontico(Objeto.EstadoProstodontico parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarEstadoProstodontico]";
                SqlCommand comandoEstadoProstodontico = new SqlCommand(procedimiento, conexion);

                comandoEstadoProstodontico.CommandType = System.Data.CommandType.StoredProcedure;
                //comandoEstadoProstodontico.Parameters.AddWithValue("@idEstadoProstodontico", parametros.IdEstadoProstodontico);
                comandoEstadoProstodontico.Parameters.AddWithValue("@presenciaProtesis", parametros.PresenciaProtesis);
                comandoEstadoProstodontico.Parameters.AddWithValue("@tipo", parametros.Tipo);
                comandoEstadoProstodontico.Parameters.AddWithValue("@observacion", parametros.Observacion);
                comandoEstadoProstodontico.Parameters.AddWithValue("@idHistoria", parametros.IdHistoria);

                int resultadoModelo = comandoEstadoProstodontico.ExecuteNonQuery();
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

        public DataTable ConsultarEstadoProstodontico()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";


                procedimiento = "[dbo].[consultarTipoAntecedentes]";



                SqlDataAdapter datosEstadoProstodontico = new SqlDataAdapter(procedimiento, conexion);

                datosEstadoProstodontico.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosEstadoProstodontico.Fill(dt);
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

        public bool BuscarEstadoProstodontico(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarTipoAntecedentes]";
                SqlDataAdapter datosEstadoProstodontico = new SqlDataAdapter(procedimiento, conexion);
                datosEstadoProstodontico.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosEstadoProstodontico.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (row[1].ToString() == nom)
                    {
                        ban = true;

                        vector[0] = row[0].ToString();
                        vector[1] = row[1].ToString();
                        vector[2] = row[2].ToString();
                    }
                }
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

            return ban;
        }

        public bool ModificarEstadoProstodontico(Objeto.EstadoProstodontico parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarTipoAntecedente]";
                SqlCommand comandoEstadoProstodontico = new SqlCommand(procedimiento, conexion);

                comandoEstadoProstodontico.CommandType = System.Data.CommandType.StoredProcedure;
                comandoEstadoProstodontico.Parameters.AddWithValue("@idEstadoProstodontico", parametros.IdEstadoProstodontico);
                comandoEstadoProstodontico.Parameters.AddWithValue("@presenciaProtesis", parametros.PresenciaProtesis);
                comandoEstadoProstodontico.Parameters.AddWithValue("@tipo", parametros.Tipo);
                comandoEstadoProstodontico.Parameters.AddWithValue("@observacion", parametros.Observacion);
                comandoEstadoProstodontico.Parameters.AddWithValue("@idHistoria", parametros.IdHistoria);

                int resultadoModelo = comandoEstadoProstodontico.ExecuteNonQuery();
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

    }
}
