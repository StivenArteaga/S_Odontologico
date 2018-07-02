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
    public class Genero
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
                Error = "El nombre del genero ya existe";
            }

        }

        public bool RegistrarGenero(Objeto.Genero parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarGENEROS]";
                SqlCommand comandoGenero = new SqlCommand(procedimiento, conexion);

                comandoGenero.CommandType = System.Data.CommandType.StoredProcedure;
                comandoGenero.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoGenero.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoGenero.ExecuteNonQuery();
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



        public DataTable ConsultarGenero(string parametro)
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
                    procedimiento = "[dbo].[consultarGenero]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarGeneroLista]";
                }

                SqlDataAdapter datosGenero = new SqlDataAdapter(procedimiento, conexion);
                datosGenero.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosGenero.Fill(dt);
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



        public bool BuscarGenero(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarGenero]";
                SqlDataAdapter datosGenero = new SqlDataAdapter(procedimiento, conexion);
                datosGenero.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosGenero.Fill(dt);
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



        public bool ModificarGenero(Objeto.Genero parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarGenero]";
                SqlCommand comandoGenero = new SqlCommand(procedimiento, conexion);

                comandoGenero.CommandType = System.Data.CommandType.StoredProcedure;
                comandoGenero.Parameters.AddWithValue("@idGenero", parametros.IdGenero);
                comandoGenero.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoGenero.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoGenero.ExecuteNonQuery();
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
