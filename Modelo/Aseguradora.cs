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
    public class Aseguradora
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
                Error = "El nombre de la aseguradora ya existe";
            }

        }

        public bool RegistrarAseguradora(Objeto.Aseguradora parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarASEGURADORAS]";
                SqlCommand comandoAsegura = new SqlCommand(procedimiento, conexion);

                comandoAsegura.CommandType = System.Data.CommandType.StoredProcedure;
                comandoAsegura.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoAsegura.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoAsegura.ExecuteNonQuery();
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
        
        public DataTable ConsultarAseguradora(string parametro)
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
                    procedimiento = "[dbo].[consultarAseguradora]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarAseguradoraLista]";
                }

                SqlDataAdapter datosAseguradora = new SqlDataAdapter(procedimiento, conexion);

                datosAseguradora.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosAseguradora.Fill(dt);
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



        public bool BuscarAseguradora(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarAseguradora]";
                SqlDataAdapter datosAseguradora = new SqlDataAdapter(procedimiento, conexion);
                datosAseguradora.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosAseguradora.Fill(dt);
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
                throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return ban;
        }



        public bool ModificarAseguradora(Objeto.Aseguradora parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarAseguradora]";
                SqlCommand comandoAseguradora = new SqlCommand(procedimiento, conexion);

                comandoAseguradora.CommandType = System.Data.CommandType.StoredProcedure;
                comandoAseguradora.Parameters.AddWithValue("@idAseguradora", parametros.IdAseguradora);
                comandoAseguradora.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoAseguradora.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoAseguradora.ExecuteNonQuery();
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
