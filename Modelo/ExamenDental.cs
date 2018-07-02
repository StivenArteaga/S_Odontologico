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
    public class ExamenDental
    {
        public static string error;
        private Objeto.ExamenDental objExamenDental = new Objeto.ExamenDental();

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

        public bool RegistrarExamenDental(Objeto.ExamenDental parametros)
        {
            bool resultado = false;
            SqlConnection conexion = new SqlConnection();

            try
            {


                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[insertarEXAMENDENTAL]";
                SqlCommand instExamenDental = new SqlCommand(procedimiento, conexion);
                instExamenDental.CommandType = System.Data.CommandType.StoredProcedure;
                instExamenDental.Parameters.AddWithValue("@idDental", parametros.IdDental);
                instExamenDental.Parameters.AddWithValue("@idHistoriaClinica", parametros.IdHistoriaClinica);
                instExamenDental.Parameters.AddWithValue("@idRespuesta", parametros.IdRespuesta);
                instExamenDental.Parameters.AddWithValue("@observacion", parametros.Observacion);


                int resmodelo = instExamenDental.ExecuteNonQuery();
                if (resmodelo > 0)
                {
                    resultado = true;
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

            return resultado;
        }


        public DataTable consultarExamenDental()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";

                procedimiento = "[dbo].[consultarExamenDental]";

                SqlDataAdapter datosExamenDental = new SqlDataAdapter(procedimiento, conexion);
                datosExamenDental.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosExamenDental.Fill(dt);
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


        public DataTable consultarTipoExamenDental()
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

                SqlDataAdapter datosExamenDental = new SqlDataAdapter(procedimiento, conexion);
                datosExamenDental.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosExamenDental.Fill(dt);
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


        //public bool consultarPaciente(string doc)
        //{
        //    DataTable dt = new DataTable();
        //    bool ban = false;
        //    SqlConnection conexion = new SqlConnection();

        //    try
        //    {
        //        ClsConexion conectar = new ClsConexion();
        //        conexion = conectar.Conexion();
        //        conexion.Open();

        //        string procedimiento = "";

        //        procedimiento = "[dbo].[consultarPacienteEnHistoriaXDocumento]";

        //        SqlDataAdapter datosHistoria = new SqlDataAdapter(procedimiento, conexion);
        //        datosHistoria.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        datosHistoria.SelectCommand.Parameters.AddWithValue("@documento", doc);
        //        datosHistoria.Fill(dt);


        //        foreach (DataRow row in dt.Rows)
        //        {
        //            if (row[0].ToString() == doc)
        //            {
        //                ban = true;
        //                objHist.Documento = row[0].ToString();
        //                objHist.NombreCompletoPaciente = row[1].ToString();
        //                objHist.NumeroHistoriaClinica = row[2].ToString();
        //                objHist.Fecha = Convert.ToDateTime(row[3].ToString());
        //                objHist.IdHistoriaClinica = int.Parse(row[4].ToString());

        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Error = e.Message;
        //        //throw;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //        conexion.Dispose();

        //    }

        //    return ban;
        //}



        public DataTable consultarRespuesta()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";

                procedimiento = "[dbo].[consultarRespuesta]";

                SqlDataAdapter datosRespuesta = new SqlDataAdapter(procedimiento, conexion);
                datosRespuesta.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosRespuesta.Fill(dt);
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
    }
}
