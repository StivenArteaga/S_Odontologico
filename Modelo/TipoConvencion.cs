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
    public class TipoConvencion
    {

        public string[] vector = new string[4];

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

        public bool registrarTipoConvencion(Objeto.TipoConvencion parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarTIPOSCONVENCIONES]";
                SqlCommand comandoTipoConvencion = new SqlCommand(procedimiento, conexion);

                comandoTipoConvencion.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoConvencion.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoConvencion.Parameters.AddWithValue("@simbolo", parametros.Simbolo);
                comandoTipoConvencion.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoConvencion.ExecuteNonQuery();
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

        public DataTable consultarTipoConvencion(string parametro)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";

                //if (parametro == "configuracion")
                //{
                    procedimiento = "[dbo].[consultarTipoConvencion]";
                //}
                //else
                //{
                //    procedimiento = "[dbo].[consultarTipoConvencionLista]";
                //}

                SqlDataAdapter datosTipoConvencion = new SqlDataAdapter(procedimiento, conexion);

                datosTipoConvencion.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoConvencion.Fill(dt);
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

        public DataTable consultarTipoConvencion()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";

                //if (parametro == "configuracion")
                //{
                procedimiento = "[dbo].[consultarTipoConvencion]";
                //}
                //else
                //{
                //    procedimiento = "[dbo].[consultarTipoConvencionLista]";
                //}

                SqlDataAdapter datosTipoConvencion = new SqlDataAdapter(procedimiento, conexion);

                datosTipoConvencion.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoConvencion.Fill(dt);
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

        public bool BuscarTipoConvencion(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarTipoConvencion]";
                SqlDataAdapter datosTipoConvencion = new SqlDataAdapter(procedimiento, conexion);
                datosTipoConvencion.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoConvencion.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (row[1].ToString() == nom)
                    {
                        ban = true;

                        vector[0] = row[0].ToString();
                        vector[1] = row[1].ToString();
                        vector[2] = row[2].ToString();
                        vector[3] = row[3].ToString();
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



        public bool modificarTipoConvencion(Objeto.TipoConvencion parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarTipoConvencion]";
                SqlCommand comandoTipoConvencion = new SqlCommand(procedimiento, conexion);

                comandoTipoConvencion.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoConvencion.Parameters.AddWithValue("@idTipoConvencion", parametros.IdTipoConvencion);
                comandoTipoConvencion.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoConvencion.Parameters.AddWithValue("@simbolo", parametros.Simbolo);
                comandoTipoConvencion.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoConvencion.ExecuteNonQuery();
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
