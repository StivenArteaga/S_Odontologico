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
    public class TipoHabito
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


        public bool RegistrarTipoHabito(Objeto.TipoHabito parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarHABITOHIGIENES]";
                SqlCommand comandoTipoHabito = new SqlCommand(procedimiento, conexion);

                comandoTipoHabito.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoHabito.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoHabito.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoHabito.ExecuteNonQuery();
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

        public DataTable ConsultarTipoHabito()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";


                procedimiento = "[dbo].[consultarHabitoHigiene]";



                SqlDataAdapter datosTipoHabito = new SqlDataAdapter(procedimiento, conexion);

                datosTipoHabito.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoHabito.Fill(dt);
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

        public bool BuscarTipoHabito(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarHabitoHigiene]";
                SqlDataAdapter datosTipoHabito = new SqlDataAdapter(procedimiento, conexion);
                datosTipoHabito.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoHabito.Fill(dt);
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

        public bool ModificarTipoHabito(Objeto.TipoHabito parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarHabitoHigiene]";
                SqlCommand comandoTipoHabito = new SqlCommand(procedimiento, conexion);

                comandoTipoHabito.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoHabito.Parameters.AddWithValue("@idHabitoHigiene", parametros.IdHabitoHigiene);
                comandoTipoHabito.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoHabito.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoHabito.ExecuteNonQuery();
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
