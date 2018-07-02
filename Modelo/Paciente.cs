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
    public class Paciente
    {

        public string[] vector = new string[28];
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

        public bool RegistrarPaciente(Objeto.Paciente parametros)
        {
            bool resultado = false;
            SqlConnection conexion = new SqlConnection();

            try
            {


                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[insertarPACIENTES]";
                SqlCommand instPaciente = new SqlCommand(procedimiento, conexion);
                instPaciente.CommandType = System.Data.CommandType.StoredProcedure;
                instPaciente.Parameters.AddWithValue("@documento", parametros.Documento);
                instPaciente.Parameters.AddWithValue("@nombres", parametros.Nombres);
                instPaciente.Parameters.AddWithValue("@primerApellido", parametros.PrimerApellido);
                instPaciente.Parameters.AddWithValue("@segundoApellido", parametros.SegundoApellido);
                instPaciente.Parameters.AddWithValue("@fechaNacimiento", parametros.FechaNacimiento);
                instPaciente.Parameters.AddWithValue("@email", parametros.Email);
                instPaciente.Parameters.AddWithValue("@barrio", parametros.Barrio);
                instPaciente.Parameters.AddWithValue("@direccion", parametros.Direccion);
                instPaciente.Parameters.AddWithValue("@telefonoFijo", parametros.TelefonoFijo);
                instPaciente.Parameters.AddWithValue("@telefonoMovil", parametros.TelefonoMovil);
                instPaciente.Parameters.AddWithValue("@observacion", parametros.Observacion);
                instPaciente.Parameters.AddWithValue("@estado", parametros.Estado);
                instPaciente.Parameters.AddWithValue("@idGenero", parametros.IdGenero);
                instPaciente.Parameters.AddWithValue("@idCiudad", parametros.IdCiudad);
                instPaciente.Parameters.AddWithValue("@idEstadoCivil", parametros.IdEstadoCivil);
                instPaciente.Parameters.AddWithValue("@idTipoDocumento", parametros.IdTipoDocumento);
                instPaciente.Parameters.AddWithValue("@idOcupacion", parametros.IdOcupacion);
                instPaciente.Parameters.AddWithValue("@idAseguradora", parametros.IdAseguradora);
                instPaciente.Parameters.AddWithValue("@idTipoSeguro", parametros.IdTipoSeguro);
                instPaciente.Parameters.AddWithValue("@idGrupoSanguineo", parametros.IdGrupoSanguineo);

                instPaciente.Parameters.AddWithValue("@nombreResponsable", parametros.NombreResponsable);
                instPaciente.Parameters.AddWithValue("@apellidoResponsable", parametros.ApellidoResponsable);
                instPaciente.Parameters.AddWithValue("@telefonoResponsable", parametros.TelefonoResponsable);
                instPaciente.Parameters.AddWithValue("@direccionResponsable", parametros.DireccionResponsable);
                instPaciente.Parameters.AddWithValue("@idParentescoResponsable", parametros.IdParentescoResponsable);



                int resmodelo = instPaciente.ExecuteNonQuery();
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

            dt = tipoDoc.ConsultarTipoDocumento("paciente");

            return dt;
        }
        
        public DataTable consultarGenero()
        {

            DataTable dt = new DataTable();
            Genero genero = new Genero();
            dt = genero.ConsultarGenero("paciente");

            return dt;
        }
        
        public DataTable consultarOcupacion()
        {
            DataTable dt = new DataTable();

            Ocupacion ocupacion = new Ocupacion();
            dt = ocupacion.ConsultarOcupacion("paciente");

            return dt;
        }
        
        public DataTable consultarTipoSeguro()
        {
            DataTable dt = new DataTable();

            TipoSeguro tipoSeguro = new TipoSeguro();
            dt = tipoSeguro.ConsultarTipoSeguro("paciente");

            return dt;
        }
        
        public DataTable consultarEstadoCivil()
        {
            DataTable dt = new DataTable();
            EstadoCivil estadoCivil = new EstadoCivil();
            dt = estadoCivil.ConsultarEstadoCivil("paciente");

            return dt;
        }
        
        public DataTable consultarAseguradora()
        {
            DataTable dt = new DataTable();

            Aseguradora aseguradora = new Aseguradora();
            dt = aseguradora.ConsultarAseguradora("paciente");

            return dt;
        }
        
        public DataTable consultarGrupoSanguineo()
        {
            DataTable dt = new DataTable();
            GrupoSanguineo grupo = new GrupoSanguineo();
            dt = grupo.ConsultarGrupoSanguineo("paciente");

            return dt;
        }
        
        public DataTable consultarParentesco()
        {
            DataTable dt = new DataTable();
            Parentesco grupo = new Parentesco();
            dt = grupo.ConsultarParentesco("paciente");

            return dt;
        }
        
        public bool BuscarPacienteXDocumento(string doc)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarPacienteXDocumento]";
                SqlDataAdapter datosPacienteXDocumento = new SqlDataAdapter(procedimiento, conexion);
                datosPacienteXDocumento.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosPacienteXDocumento.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {

                    if (row[1].ToString() == doc)
                    {
                        ban = true;

                        vector[0] = row[0].ToString(); //TipoDocumento
                        vector[1] = row[1].ToString(); //Documento
                        vector[2] = row[2].ToString(); // Nombre
                        vector[3] = row[3].ToString(); // Apellido1 
                        vector[4] = row[4].ToString(); // Apellido2
                        vector[5] = row[5].ToString(); //Email
                        vector[6] = row[6].ToString(); //TelefonoFijo
                        vector[7] = row[7].ToString(); //TelefonoMovil
                        vector[8] = row[8].ToString(); //Estado
                        vector[9] = row[9].ToString(); //Genero
                        vector[10] = row[10].ToString(); //EstadoCivil
                        vector[11] = row[11].ToString(); //GrupoSanguineo
                        vector[12] = row[12].ToString(); //Aseguradora
                        vector[13] = row[13].ToString(); //TipoSeguro
                        vector[14] = row[14].ToString(); //Ocupacion
                        vector[15] = row[15].ToString(); //Barrio
                        vector[16] = row[16].ToString(); //Dirección
                        vector[17] = row[17].ToString(); //FechaNacimiento
                        vector[18] = row[18].ToString(); //Observación
                        vector[19] = row[19].ToString(); //NombreParentesco
                        vector[20] = row[20].ToString(); //ApellidoParentesco
                        vector[21] = row[21].ToString(); //Telefono
                        vector[22] = row[22].ToString(); //Dirección
                        vector[23] = row[23].ToString(); //idParentesco
                        vector[24] = row[24].ToString(); //Pais
                        vector[25] = row[25].ToString(); //Departamento
                        vector[26] = row[26].ToString(); //Ciudad
                        vector[27] = row[27].ToString(); //IdPaciente
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
        
        public DataTable consultarPais()
        {
            DataTable dt = new DataTable();
            Pais pais = new Pais();
            dt = pais.ConsultarPais("paciente");

            return dt;
        }
        
        public DataTable consultarDepartamentoPaciente(int idPais)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[consultarDepartamentoPaciente]";
                SqlDataAdapter datosOdontologo = new SqlDataAdapter(procedimiento, conexion);

                datosOdontologo.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosOdontologo.SelectCommand.Parameters.AddWithValue("@idPais", idPais);
                datosOdontologo.Fill(dt);
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
        
        public DataTable consultarCiudadPaciente(int idDepartamento)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[consultarCiudadPaciente]";
                SqlDataAdapter datosOdontologo = new SqlDataAdapter(procedimiento, conexion);

                datosOdontologo.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosOdontologo.SelectCommand.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                datosOdontologo.Fill(dt);
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
        
        public DataTable ConsultarPaciente()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[consultarPaciente]";
                SqlDataAdapter datosPaciente = new SqlDataAdapter(procedimiento, conexion);
                datosPaciente.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosPaciente.Fill(dt);
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

            return dt;
        }
        
        //public bool BuscarOdontologoXDocumento(string doc)
        //{
        //    DataTable dt = new DataTable();

        //    SqlConnection conexion = new SqlConnection();
        //    bool ban = false;
        //    try
        //    {
        //        ClsConexion conectar = new ClsConexion();
        //        conexion = conectar.Conexion();
        //        conexion.Open();


        //        string procedimiento = "[dbo].[consultarOdontologoXDocumento]";
        //        SqlDataAdapter datosOdontologoXDocumento = new SqlDataAdapter(procedimiento, conexion);
        //        datosOdontologoXDocumento.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        datosOdontologoXDocumento.Fill(dt);
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            if (row[1].ToString() == doc)
        //            {
        //                ban = true;

        //                vector[0] = row[0].ToString();
        //                vector[1] = row[1].ToString();
        //                vector[2] = row[2].ToString();
        //                vector[3] = row[3].ToString();
        //                vector[4] = row[4].ToString();
        //                vector[5] = row[5].ToString();
        //                vector[6] = row[6].ToString();
        //                vector[7] = row[7].ToString();
        //                vector[8] = row[8].ToString();
        //                vector[9] = row[9].ToString();
        //                vector[10] = row[10].ToString();
        //                vector[11] = row[11].ToString();
        //                vector[12] = row[12].ToString();
        //                vector[13] = row[13].ToString();

        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        // throw;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //        conexion.Dispose();

        //    }

        //    return ban;
        //}
        
        public bool ModificarPaciente(Objeto.Paciente parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarPaciente]";
                SqlCommand comandoPaciente = new SqlCommand(procedimiento, conexion);
                comandoPaciente.CommandType = System.Data.CommandType.StoredProcedure;
                comandoPaciente.Parameters.AddWithValue("@idPaciente", parametros.IdPaciente);
                comandoPaciente.Parameters.AddWithValue("@documento", parametros.Documento);
                comandoPaciente.Parameters.AddWithValue("@nombres", parametros.Nombres);
                comandoPaciente.Parameters.AddWithValue("@primerApellido", parametros.PrimerApellido);
                comandoPaciente.Parameters.AddWithValue("@segundoApellido", parametros.SegundoApellido);
                comandoPaciente.Parameters.AddWithValue("@fechaNacimiento", parametros.FechaNacimiento);
                comandoPaciente.Parameters.AddWithValue("@email", parametros.Email);
                comandoPaciente.Parameters.AddWithValue("@barrio", parametros.Barrio);
                comandoPaciente.Parameters.AddWithValue("@direccion", parametros.Direccion);
                comandoPaciente.Parameters.AddWithValue("@telefonoFijo", parametros.TelefonoFijo);
                comandoPaciente.Parameters.AddWithValue("@telefonoMovil", parametros.TelefonoMovil);
                comandoPaciente.Parameters.AddWithValue("@observacion", parametros.Observacion);
                comandoPaciente.Parameters.AddWithValue("@estado", parametros.Estado);
                comandoPaciente.Parameters.AddWithValue("@idGenero", parametros.IdGenero);
                comandoPaciente.Parameters.AddWithValue("@idCiudad", parametros.IdCiudad);
                comandoPaciente.Parameters.AddWithValue("@idEstadoCivil", parametros.IdEstadoCivil);
                comandoPaciente.Parameters.AddWithValue("@idTipoDocumento", parametros.IdTipoDocumento);
                comandoPaciente.Parameters.AddWithValue("@idOcupacion", parametros.IdOcupacion);
                comandoPaciente.Parameters.AddWithValue("@idAseguradora", parametros.IdAseguradora);
                comandoPaciente.Parameters.AddWithValue("@idTipoSeguro", parametros.IdTipoSeguro);
                comandoPaciente.Parameters.AddWithValue("@idGrupoSanguineo", parametros.IdGrupoSanguineo);

                comandoPaciente.Parameters.AddWithValue("@nombreResponsable", parametros.NombreResponsable);
                comandoPaciente.Parameters.AddWithValue("@apellidoResponsable", parametros.ApellidoResponsable);
                comandoPaciente.Parameters.AddWithValue("@telefonoResponsable", parametros.TelefonoResponsable);
                comandoPaciente.Parameters.AddWithValue("@direccionResponsable", parametros.DireccionResponsable);
                comandoPaciente.Parameters.AddWithValue("@idParentescoResponsable", parametros.IdParentescoResponsable);

                int resultadoModelo = comandoPaciente.ExecuteNonQuery();
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
