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
    public class TipoExamenEstomatologico
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


        public bool RegistrarTipoExamenEstomatologico(Objeto.TipoExamenEstomatologico parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarESTOMATOLOGICOS]";
                SqlCommand comandoTipoExamenEstomatologico = new SqlCommand(procedimiento, conexion);

                comandoTipoExamenEstomatologico.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoExamenEstomatologico.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoExamenEstomatologico.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoExamenEstomatologico.ExecuteNonQuery();
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

        public DataTable ConsultarTipoExamenEstomatologico()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";


                procedimiento = "[dbo].[consultarTipoExamenEstomatologico]";



                SqlDataAdapter datosTipoExamenEstomatologico = new SqlDataAdapter(procedimiento, conexion);

                datosTipoExamenEstomatologico.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoExamenEstomatologico.Fill(dt);
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

        public bool BuscarTipoExamenEstomatologico(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarTipoExamenEstomatologico]";
                SqlDataAdapter datosTipoExamenEstomatologico = new SqlDataAdapter(procedimiento, conexion);
                datosTipoExamenEstomatologico.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoExamenEstomatologico.Fill(dt);
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

        public bool ModificarTipoExamenEstomatologico(Objeto.TipoExamenEstomatologico parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarTipoExamenEstomatologico]";
                SqlCommand comandoTipoExamenEstomatologico = new SqlCommand(procedimiento, conexion);

                comandoTipoExamenEstomatologico.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoExamenEstomatologico.Parameters.AddWithValue("@idEstomatologico", parametros.IdEstomatologico);
                comandoTipoExamenEstomatologico.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoExamenEstomatologico.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoExamenEstomatologico.ExecuteNonQuery();
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
