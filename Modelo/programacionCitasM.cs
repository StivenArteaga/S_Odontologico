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
   public class programacionCitasM
    {
        public DataTable Consultar_paciente(string documento)
        {
            DataTable dt = new DataTable();
     
            SqlConnection conexion = new SqlConnection();


            try
            {


                ClsConexion conect = new ClsConexion();
                conexion = conect.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[consultarPACIENTESXDOCUMENTO]";
                SqlDataAdapter instProgramacionCitas = new SqlDataAdapter(procedimiento, conexion);
                instProgramacionCitas.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                instProgramacionCitas.SelectCommand.Parameters.AddWithValue("@documento", documento);
                instProgramacionCitas.Fill(dt);
            


            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
                //throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return dt;
        }

        public bool Registrar_cita(Objeto.programacionCitasO parametros)

        {
            bool resultado = false;
            SqlConnection conexion = new SqlConnection();

            try
            {

                ClsConexion conect = new ClsConexion();
                conexion = conect.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[insertarPROGRAMACIONCITAS]";
                SqlCommand instProgramacionCitas = new SqlCommand(procedimiento, conexion);
                instProgramacionCitas.CommandType = System.Data.CommandType.StoredProcedure;
                instProgramacionCitas.Parameters.AddWithValue("@idOdontologo", parametros.IdOdontologo);
                instProgramacionCitas.Parameters.AddWithValue("@idPaciente", parametros.IdPaciente);
                instProgramacionCitas.Parameters.AddWithValue("@fechaCita", parametros.FechaCita);
                instProgramacionCitas.Parameters.AddWithValue("@horaInicio", parametros.HoraInicio);
                instProgramacionCitas.Parameters.AddWithValue("@duracion", parametros.Duracion);
                instProgramacionCitas.Parameters.AddWithValue("@descripcion", parametros.Descripcion);
                instProgramacionCitas.Parameters.AddWithValue("@estado", parametros.Estado);



                int resmodelo = instProgramacionCitas.ExecuteNonQuery();
                if (resmodelo > 0)
                {
                    resultado = true;
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



            return resultado;
        }

        //Consultar Odontólogo


        public DataTable Consultar_odontologo()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();

            try
            {


                ClsConexion conect = new ClsConexion();
                conexion = conect.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[consultarODONTOLOGOS]";
                SqlDataAdapter instProgramacionCitas = new SqlDataAdapter(procedimiento, conexion);
                instProgramacionCitas.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                instProgramacionCitas.Fill(dt);

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

            return dt;
        }

        //DTVG CITASXFECHA

        public DataTable listar_CITAXFECHA(DateTime fechaCita)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                ClsConexion conect = new ClsConexion();
                conexion = conect.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarCITAXFECHA]";

                SqlDataAdapter instProgramacionCitas = new SqlDataAdapter(procedimiento, conexion);
                instProgramacionCitas.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                instProgramacionCitas.SelectCommand.Parameters.AddWithValue("@fecha", fechaCita);


                instProgramacionCitas.Fill(dt);

            }
            catch (Exception)
            {
            }
            finally
            {
                conexion.Close();

                conexion.Dispose();
            }

            return dt;
        }


        //DTVG CITASXFECHA

        public DataTable listar_CITAXPACIENTE(string documento)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                ClsConexion conect = new ClsConexion();
                conexion = conect.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarCITAXDOCPACIENTE]";

                SqlDataAdapter instProgramacionCitas = new SqlDataAdapter(procedimiento, conexion);
                instProgramacionCitas.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                instProgramacionCitas.SelectCommand.Parameters.AddWithValue("@documento", documento);


                instProgramacionCitas.Fill(dt);

            }
            catch (Exception)
            {
            }
            finally
            {
                conexion.Close();

                conexion.Dispose();
            }

            return dt;
        }

        //DTVG CITASXDOCYFECHA

        public DataTable listar_CITAXDOCYFECHA(string documento, DateTime fecha)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                ClsConexion conect = new ClsConexion();
                conexion = conect.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarCITAXDOCPACIENTEYFECHA]";

                SqlDataAdapter instProgramacionCitas = new SqlDataAdapter(procedimiento, conexion);
                instProgramacionCitas.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                instProgramacionCitas.SelectCommand.Parameters.AddWithValue("@documento", documento);
                instProgramacionCitas.SelectCommand.Parameters.AddWithValue("@fecha", fecha);


                instProgramacionCitas.Fill(dt);

            }
            catch (Exception)
            {
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
