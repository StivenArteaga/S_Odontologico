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
    public class Odontologo
    {
        public string[] vector = new string[13];
        static string error;

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

        public bool RegistrarOdontologo(Objeto.Odontologo parametros)
        {
            bool resultado = false;
            SqlConnection conexion = new SqlConnection();

            try
            {


                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[insertarODONTOLOGOS]";
                SqlCommand instOdontologo = new SqlCommand(procedimiento, conexion);
                instOdontologo.CommandType = System.Data.CommandType.StoredProcedure;
                instOdontologo.Parameters.AddWithValue("@documento", parametros.Documento);
                instOdontologo.Parameters.AddWithValue("@nombres", parametros.Nombre);
                instOdontologo.Parameters.AddWithValue("@primerApellido", parametros.PrimerApellido);
                instOdontologo.Parameters.AddWithValue("@segundoApellido", parametros.SegundoApellido);
                instOdontologo.Parameters.AddWithValue("@especialidad", parametros.Especialidad);
                instOdontologo.Parameters.AddWithValue("@email", parametros.Email);
                instOdontologo.Parameters.AddWithValue("@telefono", parametros.Telefono);
                instOdontologo.Parameters.AddWithValue("@estado", parametros.Estado);
                instOdontologo.Parameters.AddWithValue("@idGenero", parametros.IdGenero);
                instOdontologo.Parameters.AddWithValue("@idTipoDocumento", parametros.IdTipoDocumento);
                instOdontologo.Parameters.AddWithValue("@idConsultorio", parametros.IdConsultorio);
                instOdontologo.Parameters.AddWithValue("@idGrupoSanguineo", parametros.IdGrupoSanguineo);


                int resmodelo = instOdontologo.ExecuteNonQuery();
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


        public DataTable consultarTipoDocumento()
        {
            DataTable dt = new DataTable();
            TipoDocumento tipoDoc = new TipoDocumento();

            dt = tipoDoc.ConsultarTipoDocumento("odontologo");

            return dt;
        }


        public DataTable consultarGenero()
        {

            DataTable dt = new DataTable();
            Genero genero = new Genero();
            dt = genero.ConsultarGenero("odontologo");

            return dt;
        }


        public DataTable consultarConsultorio()
        {
            DataTable dt = new DataTable();

            Consultorio consultorio = new Consultorio();
            dt = consultorio.ConsultarConsultorio("odontologo");

            return dt;
        }


        public DataTable consultarGrupoSanguineo()
        {
            DataTable dt = new DataTable();
            GrupoSanguineo grupo = new GrupoSanguineo();
            dt = grupo.ConsultarGrupoSanguineo("odontologo");

            return dt;
        }


        public DataTable ConsultarOdontologo()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[consultarOdontologo]";
                SqlDataAdapter datosOdontologo = new SqlDataAdapter(procedimiento, conexion);
                datosOdontologo.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosOdontologo.Fill(dt);
            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return dt;
        }



        public bool BuscarOdontologoXDocumento(string doc)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarOdontologoXDocumento]";
                SqlDataAdapter datosOdontologoXDocumento = new SqlDataAdapter(procedimiento, conexion);
                datosOdontologoXDocumento.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosOdontologoXDocumento.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (row[1].ToString() == doc)
                    {
                        ban = true;

                        vector[0] = row[0].ToString();
                        vector[1] = row[1].ToString();
                        vector[2] = row[2].ToString();
                        vector[3] = row[3].ToString();
                        vector[4] = row[4].ToString();
                        vector[5] = row[5].ToString();
                        vector[6] = row[6].ToString();
                        vector[7] = row[7].ToString();
                        vector[8] = row[8].ToString();
                        vector[9] = row[9].ToString();
                        vector[10] = row[10].ToString();
                        vector[11] = row[11].ToString();
                        vector[12] = row[12].ToString();
                        vector[13] = row[13].ToString();

                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();

            }

            return ban;
        }



        public bool ModificarOdontologo(Objeto.Odontologo parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarOdontologo]";
                SqlCommand comandoOdontologo = new SqlCommand(procedimiento, conexion);

                comandoOdontologo.CommandType = System.Data.CommandType.StoredProcedure;
                comandoOdontologo.Parameters.AddWithValue("@idOdontologo", parametros.IdOdontologo);
                comandoOdontologo.Parameters.AddWithValue("@documento", parametros.Documento);
                comandoOdontologo.Parameters.AddWithValue("@nombres", parametros.Nombre);
                comandoOdontologo.Parameters.AddWithValue("@primerApellido", parametros.PrimerApellido);
                comandoOdontologo.Parameters.AddWithValue("@segundoApellido", parametros.SegundoApellido);
                comandoOdontologo.Parameters.AddWithValue("@especialidad", parametros.Especialidad);
                comandoOdontologo.Parameters.AddWithValue("@email", parametros.Email);
                comandoOdontologo.Parameters.AddWithValue("@telefono", parametros.Telefono);
                comandoOdontologo.Parameters.AddWithValue("@estado", parametros.Estado);
                comandoOdontologo.Parameters.AddWithValue("@idGenero", parametros.IdGenero);
                comandoOdontologo.Parameters.AddWithValue("@idTipoDocumento", parametros.IdTipoDocumento);
                comandoOdontologo.Parameters.AddWithValue("@idConsultorio", parametros.IdConsultorio);
                comandoOdontologo.Parameters.AddWithValue("@idGrupoSanguineo", parametros.IdGrupoSanguineo);

                int resultadoModelo = comandoOdontologo.ExecuteNonQuery();
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
