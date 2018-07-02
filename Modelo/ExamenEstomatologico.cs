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
    public class ExamenEstomatologico
    {
        public static string error;
        private Objeto.ExamenEstomatologico objExamenEstomatologico = new Objeto.ExamenEstomatologico();

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

        public bool RegistrarExamenEstomatologico(Objeto.ExamenEstomatologico parametros)
        {
            bool resultado = false;
            SqlConnection conexion = new SqlConnection();

            try
            {


                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[insertarEXAMENESTOMATOLOGICOS]";
                SqlCommand instExamenEstomatologico = new SqlCommand(procedimiento, conexion);
                instExamenEstomatologico.CommandType = System.Data.CommandType.StoredProcedure;
                instExamenEstomatologico.Parameters.AddWithValue("@idEstomatologico", parametros.IdEstomatologico);
                instExamenEstomatologico.Parameters.AddWithValue("@idHistoriaClinica", parametros.IdHistoriaClinica);
                instExamenEstomatologico.Parameters.AddWithValue("@idRespuesta", parametros.IdRespuesta);

                instExamenEstomatologico.Parameters.AddWithValue("@observacion", parametros.Observacion);


                int resmodelo = instExamenEstomatologico.ExecuteNonQuery();
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


        public DataTable consultarExamenEstomatologico()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";

                procedimiento = "[dbo].[consultarExamenEstomatologico]";

                SqlDataAdapter datosExamenEstomatologico = new SqlDataAdapter(procedimiento, conexion);
                datosExamenEstomatologico.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosExamenEstomatologico.Fill(dt);
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


        public DataTable consultarTipoExamenEstomatologico()
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

                SqlDataAdapter datosExamenEstomatologico = new SqlDataAdapter(procedimiento, conexion);
                datosExamenEstomatologico.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosExamenEstomatologico.Fill(dt);
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
