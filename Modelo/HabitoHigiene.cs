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
    public class HabitoHigiene
    {
        public static string error;
        private Objeto.HabitoHigiene objHabitoHigiene = new Objeto.HabitoHigiene();

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

        public bool RegistrarHabitoHigiene(Objeto.HabitoHigiene parametros)
        {
            bool resultado = false;
            SqlConnection conexion = new SqlConnection();

            try
            {


                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[insertarHABITOHIGIENICOSXHISTORIA]";
                SqlCommand instHabitoHigiene = new SqlCommand(procedimiento, conexion);
                instHabitoHigiene.CommandType = System.Data.CommandType.StoredProcedure;
                instHabitoHigiene.Parameters.AddWithValue("@idHabitoHigiene", parametros.IdHabitoHigiene);
                instHabitoHigiene.Parameters.AddWithValue("@idHistoriaClinica", parametros.IdHistoriaClinica);
                instHabitoHigiene.Parameters.AddWithValue("@idRespuesta", parametros.IdRespuesta);
                instHabitoHigiene.Parameters.AddWithValue("@frecuencia", parametros.Frecuencia);
                instHabitoHigiene.Parameters.AddWithValue("@observacion", parametros.Observacion);


                int resmodelo = instHabitoHigiene.ExecuteNonQuery();
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


        public DataTable consultarTipoHabitoHigiene()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";

                procedimiento = "[dbo].[consultarTipoHabitoHigiene]";

                SqlDataAdapter datosHabitoHigiene = new SqlDataAdapter(procedimiento, conexion);
                datosHabitoHigiene.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosHabitoHigiene.Fill(dt);
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


        public DataTable consultarHabitoHigiene()
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

                SqlDataAdapter datosHabitoHigiene = new SqlDataAdapter(procedimiento, conexion);
                datosHabitoHigiene.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosHabitoHigiene.Fill(dt);
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

                SqlDataAdapter datosHistoria = new SqlDataAdapter(procedimiento, conexion);
                datosHistoria.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosHistoria.Fill(dt);
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
