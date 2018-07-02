using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Modelo
{
    public class CuentasUsuarios
    {

        private string mensaje;
        private string email;
        private string contraseña;
        private int idRolCuentaUsuario;

        public string[] vector = new string[6];
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

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public int IdRolCuentaUsuario
        {
            get
            {
                return idRolCuentaUsuario;
            }

            set
            {
                idRolCuentaUsuario = value;
            }
        }

        public bool RegistrarCuentaUsuario(Objeto.CuentasUsuarios parametros)
        {
            bool resultado = false;
            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conecta = new ClsConexion();
                conexion = conecta.Conexion();
                conexion.Open();
                string procedimientoalm = "[dbo].[insertarCUENTASUSUSARIOS]";
                SqlCommand inserCuenta = new SqlCommand(procedimientoalm, conexion);
                inserCuenta.CommandType = System.Data.CommandType.StoredProcedure;
                inserCuenta.Parameters.AddWithValue("@nombre", parametros.Nombre);
                inserCuenta.Parameters.AddWithValue("@email", parametros.Email);
                inserCuenta.Parameters.AddWithValue("@telefono", parametros.Telefono);
                inserCuenta.Parameters.AddWithValue("@contraseña", parametros.Contraseña);
                inserCuenta.Parameters.AddWithValue("@idRolCuentaUsuario", parametros.IdRolCuentaUsuario);

                int resulmodelo = inserCuenta.ExecuteNonQuery();
                if (resulmodelo > 0)
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

        public DataTable ConsultarRol()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conecta = new ClsConexion();
                conexion = conecta.Conexion();
                conexion.Open();
                string procedimiento = "[dbo].[consultarROLCUENTAUSUARIO]";
                SqlDataAdapter inserCuenta = new SqlDataAdapter(procedimiento, conexion);
                inserCuenta.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                inserCuenta.Fill(dt);

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

        public bool BuscarCuentaXNombre(string Nombre)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarCuentaXNombre]";
                SqlDataAdapter datosCuentaXNombre = new SqlDataAdapter(procedimiento, conexion);
                datosCuentaXNombre.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosCuentaXNombre.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == Nombre)
                    {
                        ban = true;

                        //vector[0] = row[0].ToString();


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

        public bool BuscarCuentaXEmail(string Email)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[consultarCuentaXEmail]";
                SqlDataAdapter datosCuentaXEmail = new SqlDataAdapter(procedimiento, conexion);
                datosCuentaXEmail.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosCuentaXEmail.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == Email)
                    {
                        ban = true;

                        //vector[0] = row[0].ToString();


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

        public bool Verificar()
        {
            SqlConnection conexion = new SqlConnection();
            ClsConexion conectar = new ClsConexion();
            conexion = conectar.Conexion();
            conexion.Open();



            bool resultado = false;
            SqlCommand comando = new SqlCommand("select * from CUENTASUSUARIOS where email='" + email + "'and contraseña='" + contraseña + "'and idRolCuentaUsuario='" + idRolCuentaUsuario + "'", conexion);
            SqlDataReader ejecuta = comando.ExecuteReader();
            if (ejecuta.Read())
            {
                resultado = true;
                Mensaje = "Su Logueo Fue Ingresado Correctamente \n \n               Bienvenido al Sistema \n \n de Tarjetas de Banco";
            }
            else
            {
                Mensaje = "         Excedio el Limite de Intentos al Sistema \n \nEspere unos Minutos y Ingrese Su Logueo Otra Vez";
            }

            return resultado;
        }

        public bool BuscarCuentaUsuarioXEmailModificar(string email)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();
            bool ban = false;
            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();


                string procedimiento = "[dbo].[ConsultarCuentaUsuarioXEmailModificar]";
                SqlDataAdapter datosCuentaEmail = new SqlDataAdapter(procedimiento, conexion);
                datosCuentaEmail.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                datosCuentaEmail.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (row[2].ToString() == email)
                    {
                        ban = true;

                        vector[0] = row[0].ToString();
                        vector[1] = row[1].ToString();
                        vector[2] = row[2].ToString();
                        vector[3] = row[3].ToString();
                        vector[4] = row[4].ToString();
                        vector[5] = row[5].ToString();
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

        public bool ModificarCuenta(Objeto.CuentasUsuarios parametros)
        {
            bool resultado = false;

            SqlConnection conexion = new SqlConnection();

            try
            {
                ClsConexion conectar = new ClsConexion();
                conexion = conectar.Conexion();
                conexion.Open();

                string procedimiento = "[dbo].[modificarCuenta]";
                SqlCommand comandoCuenta = new SqlCommand(procedimiento, conexion);

                comandoCuenta.CommandType = System.Data.CommandType.StoredProcedure;
                comandoCuenta.Parameters.AddWithValue("@idCuentasUsuarios", parametros.IdCuentaUsuario);
                comandoCuenta.Parameters.AddWithValue("@nombre", parametros.Nombre);
                comandoCuenta.Parameters.AddWithValue("@email", parametros.Email);
                comandoCuenta.Parameters.AddWithValue("@telefono", parametros.Telefono);
                comandoCuenta.Parameters.AddWithValue("@contraseña", parametros.Contraseña);
                comandoCuenta.Parameters.AddWithValue("@idRolCuentaUsuario", parametros.IdRolCuentaUsuario);

                int resultadoModelo = comandoCuenta.ExecuteNonQuery();
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
