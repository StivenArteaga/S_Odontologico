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
    public class Ciudad
    {
        string error;

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

        public DataTable cargarNombreDepartamento()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[consultarNombreDepartamento]";
                SqlDataAdapter dataCiudad = new SqlDataAdapter(procedimiento, conexion);
                dataCiudad.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                dataCiudad.Fill(dt);

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



        public bool RegistrarCiudad(Objeto.Ciudad parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarCIUDADES]";
                SqlCommand comandoCiudad = new SqlCommand(procedimiento, conexion);

                comandoCiudad.CommandType = System.Data.CommandType.StoredProcedure;
                comandoCiudad.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoCiudad.Parameters.AddWithValue("@estado", parametros.Estado);
                comandoCiudad.Parameters.AddWithValue("@idDepartamento", parametros.IdDepartamento);

                int resultadoModelo = comandoCiudad.ExecuteNonQuery();
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





        public DataTable ConsultarCiudad()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[consultarCiudad]";
                SqlDataAdapter datosCiudad = new SqlDataAdapter(procedimiento, conexion);
                datosCiudad.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosCiudad.Fill(dt);
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

            return dt;
        }



        public bool ModificarCiudad(Objeto.Ciudad parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarCiudad]";
                SqlCommand comandoCiudad = new SqlCommand(procedimiento, conexion);

                comandoCiudad.CommandType = System.Data.CommandType.StoredProcedure;
                comandoCiudad.Parameters.AddWithValue("@idCiudad", parametros.IdCiudad);
                comandoCiudad.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoCiudad.Parameters.AddWithValue("@estado", parametros.Estado);
                comandoCiudad.Parameters.AddWithValue("@idDepartamento", parametros.IdDepartamento);

                int resultadoModelo = comandoCiudad.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception e)
            {
                Error = e.Message;
                //throw new System.Exception("PAis repetido");
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return resultado;
        }



        public bool BuscarCiudad(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarCiudad]";
                SqlDataAdapter datosCiudad = new SqlDataAdapter(procedimiento, conexion);
                datosCiudad.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosCiudad.Fill(dt);
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

                //  throw;
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
