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
    public class RespuestaHistoriaClinica
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


        public bool RegistrarRespuestaHistoriaClinica(Objeto.RespuestaHistoriaClinica parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarRESPUESTAHISTORIACLINICA]";
                SqlCommand comandoRespuestaHistoriaClinica = new SqlCommand(procedimiento, conexion);

                comandoRespuestaHistoriaClinica.CommandType = System.Data.CommandType.StoredProcedure;
                comandoRespuestaHistoriaClinica.Parameters.AddWithValue("@respuesta", parametros.Respuesta);
                comandoRespuestaHistoriaClinica.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoRespuestaHistoriaClinica.ExecuteNonQuery();
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



        public DataTable ConsultarRespuestaHistoriaClinica()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";


                procedimiento = "[dbo].[consultarRespuestaHistoriaClinica]";



                SqlDataAdapter datosRespuestaHistoriaClinica = new SqlDataAdapter(procedimiento, conexion);

                datosRespuestaHistoriaClinica.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosRespuestaHistoriaClinica.Fill(dt);
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



        public bool BuscarRespuestaHistoriaClinica(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarRespuestaHistoriaClinica]";
                SqlDataAdapter datosRespuestaHistoriaClinica = new SqlDataAdapter(procedimiento, conexion);
                datosRespuestaHistoriaClinica.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosRespuestaHistoriaClinica.Fill(dt);
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



        public bool ModificarRespuestaHistoriaClinica(Objeto.RespuestaHistoriaClinica parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarRespuestaHistoriaClinica]";
                SqlCommand comandoRespuestaHistoriaClinica = new SqlCommand(procedimiento, conexion);

                comandoRespuestaHistoriaClinica.CommandType = System.Data.CommandType.StoredProcedure;
                comandoRespuestaHistoriaClinica.Parameters.AddWithValue("@idRespuesta", parametros.IdRespuesta);
                comandoRespuestaHistoriaClinica.Parameters.AddWithValue("@respuesta", parametros.Respuesta);
                comandoRespuestaHistoriaClinica.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoRespuestaHistoriaClinica.ExecuteNonQuery();
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
