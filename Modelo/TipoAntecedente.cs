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
    public class TipoAntecedente
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
        
        public bool RegistrarTipoAntecedente(Objeto.TipoAntecedente parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarTIPOANTECEDENTES]";
                SqlCommand comandoTipoSeguro = new SqlCommand(procedimiento, conexion);

                comandoTipoSeguro.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoSeguro.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoSeguro.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoSeguro.ExecuteNonQuery();
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

        public DataTable ConsultarTipoAntecedente()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";


                procedimiento = "[dbo].[consultarTipoAntecedentes]";



                SqlDataAdapter datosTipoSeguro = new SqlDataAdapter(procedimiento, conexion);

                datosTipoSeguro.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoSeguro.Fill(dt);
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
        
        public bool BuscarTipoAntecedente(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarTipoAntecedentes]";
                SqlDataAdapter datosTipoAntecedente = new SqlDataAdapter(procedimiento, conexion);
                datosTipoAntecedente.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosTipoAntecedente.Fill(dt);
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
        
        public bool ModificarTipoAntecedente(Objeto.TipoAntecedente parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarTipoAntecedente]";
                SqlCommand comandoTipoAntecedente = new SqlCommand(procedimiento, conexion);

                comandoTipoAntecedente.CommandType = System.Data.CommandType.StoredProcedure;
                comandoTipoAntecedente.Parameters.AddWithValue("@idTipoAntecedente", parametros.IdTipoAntecedente);
                comandoTipoAntecedente.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoTipoAntecedente.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoTipoAntecedente.ExecuteNonQuery();
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
