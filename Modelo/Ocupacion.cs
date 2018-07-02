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
    public class Ocupacion
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

        public bool RegistrarOcupacion(Objeto.Ocupacion parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarOCUPACIONES]";
                SqlCommand comandoOcupacion = new SqlCommand(procedimiento, conexion);

                comandoOcupacion.CommandType = System.Data.CommandType.StoredProcedure;
                comandoOcupacion.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoOcupacion.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoOcupacion.ExecuteNonQuery();
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



        public DataTable ConsultarOcupacion(string parametro)
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
                    procedimiento = "[dbo].[consultarOcupacion]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarOcupacionLista]";
                }



                SqlDataAdapter datosOcupacion = new SqlDataAdapter(procedimiento, conexion);
                datosOcupacion.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosOcupacion.Fill(dt);
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



        public bool BuscarOcupacion(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarOcupacion]";
                SqlDataAdapter datosOcupacion = new SqlDataAdapter(procedimiento, conexion);
                datosOcupacion.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosOcupacion.Fill(dt);
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



        public bool ModificarOcupacion(Objeto.Ocupacion parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarOcupacion]";
                SqlCommand comandoOcupacion = new SqlCommand(procedimiento, conexion);

                comandoOcupacion.CommandType = System.Data.CommandType.StoredProcedure;
                comandoOcupacion.Parameters.AddWithValue("@idOcupacion", parametros.IdOcupacion);
                comandoOcupacion.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoOcupacion.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoOcupacion.ExecuteNonQuery();
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
