using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Objeto;

namespace Modelo
{
    public class Pais
    {
        private static string error;
        public string[] vector = new string[3];

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

        public bool RegistrarPais(Objeto.Pais parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarPAISES]";
                SqlCommand comandoPais = new SqlCommand(procedimiento, conexion);

                comandoPais.CommandType = System.Data.CommandType.StoredProcedure;
                comandoPais.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoPais.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoPais.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception e)
            {
                mensaje(e);
                //throw new System.Exception("PAis repetido");
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return resultado;
        }

        public void mensaje(Exception e)
        {

            int mierror = -2146232060;
            // string mensajito = "Infracción de la restricción UNIQUE KEY 'uniNombrePais'. No se puede insertar una clave duplicada en el objeto 'dbo.PAISES'. El valor de la clave duplicada es (" + pais.Nombre +").\r\nSe terminó la instrucción.";
            if (e.HResult == mierror)
            {
                Error = "El nombre del pais ya existe";
            }

        }

        public DataTable ConsultarPais(string parametro)
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
                    procedimiento = "[dbo].[consultarPais]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarPaisLista]";
                }

                SqlDataAdapter datospais = new SqlDataAdapter(procedimiento, conexion);
                datospais.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datospais.Fill(dt);
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

            return dt;
        }



        public bool BuscarPais(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarPais]";
                SqlDataAdapter datospais = new SqlDataAdapter(procedimiento, conexion);
                datospais.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datospais.Fill(dt);
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



        public bool ModificarPais(Objeto.Pais parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarPais]";
                SqlCommand comandoPais = new SqlCommand(procedimiento, conexion);

                comandoPais.CommandType = System.Data.CommandType.StoredProcedure;
                comandoPais.Parameters.AddWithValue("@idPais", parametros.IdPais);
                comandoPais.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoPais.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoPais.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception e)
            {
                mensaje(e);
                //throw new System.Exception("PAis repetido");
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
