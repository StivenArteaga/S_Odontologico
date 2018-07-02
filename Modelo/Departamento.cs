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
    public class Departamento
    {

        private static string error;
        public string[] vector = new string[5];

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

        public DataTable cargarNombrePais()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[consultarNombrePais]";
                SqlDataAdapter dataDepartamento = new SqlDataAdapter(procedimiento, conexion);
                dataDepartamento.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                dataDepartamento.Fill(dt);

            }
            catch (Exception e)
            {
                Error = e.Message;
                // throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
            return dt;
        }

        public bool RegistrarDepartamento(Objeto.Departamento parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarDEPARTAMENTOS]";
                SqlCommand comandoDepartamento = new SqlCommand(procedimiento, conexion);

                comandoDepartamento.CommandType = System.Data.CommandType.StoredProcedure;
                comandoDepartamento.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoDepartamento.Parameters.AddWithValue("@estado", parametros.Estado);
                comandoDepartamento.Parameters.AddWithValue("@idPais", parametros.IdPais);

                int resultadoModelo = comandoDepartamento.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception e)
            {
                // mensaje(e);
                //throw new System.Exception("PAis repetido");
                Console.WriteLine(e.Message);
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

            if (e.HResult == mierror)
            {
                Error = "El nombre del departamento ya existe";
            }

        }

        public DataTable ConsultarDepartamento()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[consultarDepartamento]";
                SqlDataAdapter datosDepartamento = new SqlDataAdapter(procedimiento, conexion);
                datosDepartamento.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosDepartamento.Fill(dt);
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



        public bool modificarDepartamento(Objeto.Departamento parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarDepartamento]";
                SqlCommand comandoDepartamento = new SqlCommand(procedimiento, conexion);

                comandoDepartamento.CommandType = System.Data.CommandType.StoredProcedure;
                comandoDepartamento.Parameters.AddWithValue("@idDepartamento", parametros.IdDepartamento);
                comandoDepartamento.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoDepartamento.Parameters.AddWithValue("@estado", parametros.Estado);
                comandoDepartamento.Parameters.AddWithValue("@idPais", parametros.IdPais);

                int resultadoModelo = comandoDepartamento.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception e)
            {
                Error = e.Message;
                //mensaje(e);
                //throw new System.Exception("PAis repetido");
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return resultado;
        }



        public bool BuscarDepartamento(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarDepartamento]";
                SqlDataAdapter datosDepartamento = new SqlDataAdapter(procedimiento, conexion);
                datosDepartamento.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosDepartamento.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (row[1].ToString() == nom)
                    {
                        ban = true;

                        vector[0] = row[0].ToString();
                        vector[1] = row[1].ToString();
                        vector[2] = row[2].ToString();
                        vector[3] = row[3].ToString();
                        vector[4] = row[4].ToString();
                    }
                }
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

            return ban;
        }


    }
}
