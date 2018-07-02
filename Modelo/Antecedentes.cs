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
    public class Antecedentes
    {
        string error;
        private Objeto.Antecedentes objHist = new Objeto.Antecedentes();

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

        public bool RegistrarAntecedente(Objeto.Antecedentes parametros)
        {
            bool resultado = false;
            SqlConnection conexion = new SqlConnection();

            try
            {


                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[insertarANTECEDENTESTIPOS]";
                SqlCommand instAntecedentes = new SqlCommand(procedimiento, conexion);
                instAntecedentes.CommandType = System.Data.CommandType.StoredProcedure;
                instAntecedentes.Parameters.AddWithValue("@idTipoAntecedente", parametros.IdTipoAntecedente);
                instAntecedentes.Parameters.AddWithValue("@idHistoriaClinica", parametros.IdHistoriaClinica);
                instAntecedentes.Parameters.AddWithValue("@idRespuesta", parametros.IdRespuesta);
                instAntecedentes.Parameters.AddWithValue("@observacion", parametros.Observacion);


                int resmodelo = instAntecedentes.ExecuteNonQuery();
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



        public DataTable consultarTipoAntecedente()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";

                procedimiento = "[dbo].[consultarTipoAntecedente]";

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


        public DataTable consultarAntecedenteTipo()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";

                procedimiento = "[dbo].[consultarAntecedenteTipo]";

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


        public bool consultarPaciente(string doc)
        {
            DataTable dt = new DataTable();
            bool ban = false;
            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "";

                procedimiento = "[dbo].[consultarPacienteEnHistoriaXDocumento]";

                SqlDataAdapter datosHistoria = new SqlDataAdapter(procedimiento, conexion);
                datosHistoria.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosHistoria.SelectCommand.Parameters.AddWithValue("@documento", doc);
                datosHistoria.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == doc)
                    {
                        ban = true;
                        objHist.Documento = row[0].ToString();
                        objHist.NombreCompletoPaciente = row[1].ToString();
                        objHist.NumeroHistoriaClinica = row[2].ToString();
                        objHist.Fecha = Convert.ToDateTime(row[3].ToString());
                        objHist.IdHistoriaClinica = int.Parse(row[4].ToString());

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
