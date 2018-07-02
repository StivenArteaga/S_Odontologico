using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Oclusoft_Prueba_Material_Design
{
    public partial class RecuperarContraseña : MaterialSkin.Controls.MaterialForm
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        Mensaje msm = new Mensaje();

        //MVC
        Modelo.CuentasUsuarios mCuenta = new Modelo.CuentasUsuarios();
        Logica.CuentaUsuario logCuenta = new Logica.CuentaUsuario();
        Objeto.CuentasUsuarios objCuenta = new Objeto.CuentasUsuarios();
        Modelo.ClsConexion ClsCone = new Modelo.ClsConexion();

        
        string encriptar(string cadena)
        {
            string resultado = string.Empty;
            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);
            resultado = Convert.ToBase64String(encriptar);

            return resultado;
        }

        public static bool validarEmail(string email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection();

            {

                Modelo.ClsConexion conecta = new Modelo.ClsConexion();
                Conexion = conecta.Conexion();

                if (ValidacionRegistroUsuario.validarEmail(txtCorreo.Text) == false)
                {
                    error.SetError(txtCorreo, "Dirección de correo no válido");
                    return;
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("[dbo].[ValidarCorreo]", Conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
                    try
                    {
                        Conexion.Open();
                        SqlDataReader lector = cmd.ExecuteReader();
                        if (lector.Read())
                        {

                            GenerarNuevaContrasena(txtCorreo.Text);
                        }
                        else
                        {
                            MessageBox.Show("Correo no encontrado");

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }



        }

        public void GenerarNuevaContrasena(string email)
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            int nuevaContrasena = rd.Next(1000000, 999999999);
            SqlConnection Conexion = new SqlConnection();



            Modelo.ClsConexion conecta = new Modelo.ClsConexion();
            Conexion = conecta.Conexion();


            SqlCommand cmd = new SqlCommand("[dbo].[NuevaContrasena]", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@contraseña", encriptar(Convert.ToString(nuevaContrasena)));
            try
            {
                Conexion.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas != 0)
                {
                    EnviarCorreoContrasena(nuevaContrasena, email);
                }
            }
            catch
            {

            }
        }

        private void EnviarCorreoContrasena(int contrasenaNueva, string email)
        {
            string contraseña = this.Contrasena;
            string mensaje = string.Empty;
            //Creando el correo electronico
            string destinatario = email;
            string remitente = "elbinblineo-97@hotmail.es";
            string asunto = "Nueva contraseña Oclusoft";
            string cuerpoDelMesaje = "Su nueva contraseña es" + " " + Convert.ToString(contrasenaNueva);
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);


            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("elbinblineo-97@hotmail.es", contraseña);

            try
            {
                Task.Run(() =>
                {
                    smtp.Send(ms);
                    ms.Dispose();
                   // MessageBox.Show("Correo enviado, sirvase revisar su bandeja de entrada");
                    msm.tipoMensaje("Correo envíado con éxito", "done");
                }
                );

               // msm.tipoMensaje("Ingrese el nombre del país que desea buscar", "warning");
                //MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
            }
            catch (Exception ex)
            {
                msm.tipoMensaje("" + ex.Message, "error");
                //MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            }
        }

        public string Contrasena
        {
            get
            { return "hotmail1197295"; }
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
