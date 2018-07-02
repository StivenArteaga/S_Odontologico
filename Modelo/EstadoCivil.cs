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
    public class EstadoCivil
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

        public bool RegistrarEstadoCivil(Objeto.EstadoCivil parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarESTADOSCIVILES]";
                SqlCommand comandoEstadoCivil = new SqlCommand(procedimiento, conexion);

                comandoEstadoCivil.CommandType = System.Data.CommandType.StoredProcedure;
                comandoEstadoCivil.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoEstadoCivil.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoEstadoCivil.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception e)
            {
                error = e.Message;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return resultado;
        }



        public DataTable ConsultarEstadoCivil(string parametro)
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
                    procedimiento = "[dbo].[consultarEstadoCivil]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarEstadoCivilLista]";
                }


                SqlDataAdapter datosEstadoCivil = new SqlDataAdapter(procedimiento, conexion);
                datosEstadoCivil.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosEstadoCivil.Fill(dt);
            }
            catch (Exception e)
            {
                error = e.Message;
                //throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return dt;
        }



        public bool BuscarEstadoCivil(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarEstadoCivil]";
                SqlDataAdapter datosEstadoCivil = new SqlDataAdapter(procedimiento, conexion);
                datosEstadoCivil.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosEstadoCivil.Fill(dt);
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
                error = e.Message;
                //throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return ban;
        }



        public bool ModificarEstadoCivil(Objeto.EstadoCivil parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarEstadoCivil]";
                SqlCommand comandoEstadoCivil = new SqlCommand(procedimiento, conexion);

                comandoEstadoCivil.CommandType = System.Data.CommandType.StoredProcedure;
                comandoEstadoCivil.Parameters.AddWithValue("@idEstadoCivil", parametros.IdEstadoCivil);
                comandoEstadoCivil.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoEstadoCivil.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoEstadoCivil.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception e)
            {
                error = e.Message;
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
