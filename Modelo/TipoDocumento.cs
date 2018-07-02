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
    public class TipoDocumento
    {

        public string[] vector = new string[3];
        string error;

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

        public bool RegistrarTipoDocumento(Objeto.TipoDocumento parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarTIPOSDOCUMENTOS]";
                SqlCommand comandoTipoDocumento = new SqlCommand(procedimiento, conexion);

                comandoTipoDocumento.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoDocumento.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoDocumento.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoDocumento.ExecuteNonQuery();
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



        public DataTable ConsultarTipoDocumento(string parametro)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();
                string procedimiento;
                if (parametro == "configuracion")
                {
                    procedimiento = "[dbo].[consultarTipoDocumento]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarTipoDocumentoEnOdontologo]";
                }


                SqlDataAdapter datosTipoDocumento = new SqlDataAdapter(procedimiento, conexion);

                datosTipoDocumento.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoDocumento.Fill(dt);
            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return dt;
        }



        public bool BuscarTipoDocumento(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarTipoDocumento]";
                SqlDataAdapter datosTipoDocumento = new SqlDataAdapter(procedimiento, conexion);
                datosTipoDocumento.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoDocumento.Fill(dt);
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return ban;
        }



        public bool ModificarTipoDocumento(Objeto.TipoDocumento parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarTipoDocumento]";
                SqlCommand comandoTipoDocumento = new SqlCommand(procedimiento, conexion);

                comandoTipoDocumento.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoDocumento.Parameters.AddWithValue("@idTipoDocumento", parametros.IdTipoDocumento);
                comandoTipoDocumento.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoDocumento.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoDocumento.ExecuteNonQuery();
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
