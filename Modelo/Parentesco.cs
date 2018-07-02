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
    public class Parentesco
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

        //public void mensaje(Exception e)
        //{

        //    int mierror = -2146232060;
        //    if (e.HResult == mierror)
        //    {
        //        Error = "El nombre del tipo de seguro ya existe";
        //    }

        //}


        public bool RegistrarParentesco(Objeto.Parentesco parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarPARENTESCO]";
                SqlCommand comandoParentesco = new SqlCommand(procedimiento, conexion);

                comandoParentesco.CommandType = System.Data.CommandType.StoredProcedure;
                comandoParentesco.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoParentesco.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoParentesco.ExecuteNonQuery();
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



        public DataTable ConsultarParentesco(string parametro)
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
                    procedimiento = "[dbo].[consultarParentesco]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarParentescoLista]";
                }


                SqlDataAdapter datosParentesco = new SqlDataAdapter(procedimiento, conexion);

                datosParentesco.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosParentesco.Fill(dt);
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



        public bool BuscarParentesco(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarParentesco]";
                SqlDataAdapter datosParentesco = new SqlDataAdapter(procedimiento, conexion);
                datosParentesco.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosParentesco.Fill(dt);
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



        public bool ModificarParentesco(Objeto.Parentesco parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarParentesco]";
                SqlCommand comandoParentesco = new SqlCommand(procedimiento, conexion);

                comandoParentesco.CommandType = System.Data.CommandType.StoredProcedure;
                comandoParentesco.Parameters.AddWithValue("@idParentesco", parametros.IdParentesco);
                comandoParentesco.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoParentesco.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoParentesco.ExecuteNonQuery();
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
