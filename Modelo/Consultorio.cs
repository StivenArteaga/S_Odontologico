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
    public class Consultorio
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

        public bool RegistrarConsultorio(Objeto.Consultorio parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[insertarCONSULTORIOS]";
                SqlCommand comandoConsultorio = new SqlCommand(procedimiento, conexion);

                comandoConsultorio.CommandType = System.Data.CommandType.StoredProcedure;
                comandoConsultorio.Parameters.AddWithValue("@descripcion", parametros.Descripcion);
                comandoConsultorio.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoConsultorio.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception)
            {
                Error = error;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return resultado;
        }



        public DataTable ConsultarConsultorio(string parametros)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();
                string procedimiento;
                if (parametros == "configuracion")
                {
                    procedimiento = "[dbo].[consultarConsultorio]";
                }
                else
                {
                    procedimiento = "[dbo].[consultarGConsultorioLista]";
                }

                SqlDataAdapter datosConsultorio = new SqlDataAdapter(procedimiento, conexion);
                datosConsultorio.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosConsultorio.Fill(dt);
            }
            catch (Exception)
            {
                Error = error;
                // throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return dt;
        }



        public bool BuscarConsultorio(string nom)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarConsultorio]";
                SqlDataAdapter datosConsultorio = new SqlDataAdapter(procedimiento, conexion);
                datosConsultorio.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosConsultorio.Fill(dt);
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
                Error = error;
                throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return ban;
        }



        public bool ModificarConsultorio(Objeto.Consultorio parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarConsultorio]";
                SqlCommand comandoConsultorio = new SqlCommand(procedimiento, conexion);

                comandoConsultorio.CommandType = System.Data.CommandType.StoredProcedure;
                comandoConsultorio.Parameters.AddWithValue("@idConsultorio", parametros.IdConsultorio);
                comandoConsultorio.Parameters.AddWithValue("@descripcion", parametros.Descripcion);
                comandoConsultorio.Parameters.AddWithValue("@estado", parametros.Estado);

                int resultadoModelo = comandoConsultorio.ExecuteNonQuery();
                if (resultadoModelo > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception)
            {
                Error = error;
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
