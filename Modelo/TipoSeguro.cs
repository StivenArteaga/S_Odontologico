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
    public class TipoSeguro
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

        public void mensaje(Exception e)
        {

            int mierror = -2146232060;
            if (e.HResult == mierror)
            {
                Error = "El nombre del tipo de seguro ya existe";
            }

        }


        public bool RegistrarTipoSeguro(Objeto.TipoSeguro parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarTIPOSEGURO]";
                SqlCommand comandoTipoSeguro = new SqlCommand(procedimiento, conexion);

                comandoTipoSeguro.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoSeguro.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoSeguro.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoSeguro.ExecuteNonQuery();
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



        public DataTable ConsultarTipoSeguro(string parametro)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";


                if (parametro == "configuracion")
                {
                    procedimiento = "[dbo].[consultarTipoSeguro]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarTipoSeguroLista]";
                }


                SqlDataAdapter datosTipoSeguro = new SqlDataAdapter(procedimiento, conexion);

                datosTipoSeguro.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoSeguro.Fill(dt);
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



        public bool BuscarTipoSeguro(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarTipoSeguro]";
                SqlDataAdapter datosTipoSeguro = new SqlDataAdapter(procedimiento, conexion);
                datosTipoSeguro.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoSeguro.Fill(dt);
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



        public bool ModificarTipoSeguro(Objeto.TipoSeguro parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarTipoSeguro]";
                SqlCommand comandoTipoSeguro = new SqlCommand(procedimiento, conexion);

                comandoTipoSeguro.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoSeguro.Parameters.AddWithValue("@idTipoSeguro", parametros.IdTipoSeguro);
                comandoTipoSeguro.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoSeguro.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoSeguro.ExecuteNonQuery();
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
