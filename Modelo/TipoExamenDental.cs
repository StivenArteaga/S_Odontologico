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
    public class TipoExamenDental
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


        public bool RegistrarTipoExamenDental(Objeto.TipoExamenDental parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarDENTAL]";
                SqlCommand comandoTipoExamenDental = new SqlCommand(procedimiento, conexion);

                comandoTipoExamenDental.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoExamenDental.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoExamenDental.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoExamenDental.ExecuteNonQuery();
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

        public DataTable ConsultarTipoExamenDental()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";


                procedimiento = "[dbo].[consultarTipoExamenDental]";



                SqlDataAdapter datosTipoExamenDental = new SqlDataAdapter(procedimiento, conexion);

                datosTipoExamenDental.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoExamenDental.Fill(dt);
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

        public bool BuscarTipoExamenDental(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarTipoExamenDental]";
                SqlDataAdapter datosTipoExamenDental = new SqlDataAdapter(procedimiento, conexion);
                datosTipoExamenDental.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoExamenDental.Fill(dt);
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

        public bool ModificarTipoExamenDental(Objeto.TipoExamenDental parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarTipoExamenDental]";
                SqlCommand comandoTipoExamenDental = new SqlCommand(procedimiento, conexion);

                comandoTipoExamenDental.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoExamenDental.Parameters.AddWithValue("@idDental", parametros.IdDental);
                comandoTipoExamenDental.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoExamenDental.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoExamenDental.ExecuteNonQuery();
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
