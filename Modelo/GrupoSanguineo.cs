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
    public class GrupoSanguineo
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

        public bool RegistrarGrupoSanguineo(Objeto.GrupoSanguineo parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarGRUPOSANGUINEO]";
                SqlCommand comandoGrupoSanguineo = new SqlCommand(procedimiento, conexion);

                comandoGrupoSanguineo.CommandType = System.Data.CommandType.StoredProcedure;
                comandoGrupoSanguineo.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoGrupoSanguineo.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoGrupoSanguineo.ExecuteNonQuery();
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



        public DataTable ConsultarGrupoSanguineo(string parametro)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento;

                if (parametro == "configuracion")
                {
                    procedimiento = "[dbo].[consultarGrupoSanguineo]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarGrupoSanguineoLista]";
                }

                SqlDataAdapter datosGrupoSanguineo = new SqlDataAdapter(procedimiento, conexion);
                datosGrupoSanguineo.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosGrupoSanguineo.Fill(dt);
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



        public bool BuscarGrupoSanguineo(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarGrupoSanguineo]";
                SqlDataAdapter datosGrupoSanguineo = new SqlDataAdapter(procedimiento, conexion);
                datosGrupoSanguineo.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosGrupoSanguineo.Fill(dt);
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
                throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return ban;
        }



        public bool ModificarGrupoSanguineo(Objeto.GrupoSanguineo parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarGrupoSanguineo]";
                SqlCommand comandoGrupoSanguineo = new SqlCommand(procedimiento, conexion);

                comandoGrupoSanguineo.CommandType = System.Data.CommandType.StoredProcedure;
                comandoGrupoSanguineo.Parameters.AddWithValue("@idGrupoSanguineo", parametros.IdGrupoSanguineo);
                comandoGrupoSanguineo.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoGrupoSanguineo.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoGrupoSanguineo.ExecuteNonQuery();
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
