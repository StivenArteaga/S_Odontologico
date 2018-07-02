using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Oclusoft_Prueba_Material_Design
{
    public partial class ValidacionRegistroUsuario : Form
    {
        public ValidacionRegistroUsuario()
        {
            InitializeComponent();
        }


        Logica.CuentaUsuario logicaCuenta = new Logica.CuentaUsuario();
        Modelo.CuentasUsuarios modeloCuentaUs = new Modelo.CuentasUsuarios();
        Objeto.CuentasUsuarios objCuenta = new Objeto.CuentasUsuarios();




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

        private void ValidacionRegistroUsuario_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        private void cargarComboBox()
        {
            comboTipoUsuario.ValueMember = "idRolCuentaUsuario";
            comboTipoUsuario.DisplayMember = "nombre";
            comboTipoUsuario.DataSource = logicaCuenta.CargarRol();
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string encriptar(string cadena)
        {
            string resultado = string.Empty;
            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);
            resultado = Convert.ToBase64String(encriptar);

            return resultado;
        }

        private void btnEntrarUsuario_Click(object sender, EventArgs e)
        {

            txtContraseñaLogin.Text = encriptar(txtContraseñaLogin.Text);
            modeloCuentaUs.Email = txtEmailLogin.Text;
            modeloCuentaUs.Contraseña = txtContraseñaLogin.Text;
            modeloCuentaUs.IdRolCuentaUsuario = int.Parse(comboTipoUsuario.SelectedValue.ToString());

            if (txtEmailLogin.Text == "")
            {
                errorProvider1.SetError(txtEmailLogin, "Ingrese el usuario");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmailLogin, "");
                if (txtContraseñaLogin.Text == "")
                {
                    errorProvider1.SetError(txtContraseñaLogin, "Ingrese su contraseña");
                    return;
                }
                else if (validarEmail(txtEmailLogin.Text) == false)
                {
                    errorProvider1.SetError(txtEmailLogin, "Dirección de correo no válida");
                }
                else
                {
                    errorProvider1.SetError(txtContraseñaLogin, "");
                    
                    if (!CAD.CADValidacionRegistroUsuario.ExisteUsuario(txtEmailLogin.Text,txtContraseñaLogin.Text))
                    {                        
                        MessageBox.Show("Usuario y contraseña incorrectos");
                        txtEmailLogin.Text = "";
                        txtContraseñaLogin.Text = "";
                        txtEmailLogin.Focus();
                        return; 
                    }
                    else if (modeloCuentaUs.Verificar() == true)
                    {
                        if (comboTipoUsuario.Text == "Auxiliar")
                        {
                            PaginaPrincipal princip = new PaginaPrincipal();
                            princip.Show();
                            this.Hide();
                            princip.pictureBoxOdontologo.Visible = false;
                            princip.pictureMaestra.Visible = false;
                            princip.pictureBox2.Visible = false;
                        }
                        else
                        {
                            PaginaPrincipal princip = new PaginaPrincipal();
                            princip.Show();
                            this.Hide();
                            princip.pictureBoxOdontologo.Enabled = true;
                            princip.pictureBox2.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El tipo de usuario no es el correcto");
                    }

                }
            }
        }

        string desencriptar(string cadena)
        {
            string resultado = string.Empty;
            Byte[] desencriptar = Convert.FromBase64String(cadena);

            resultado = System.Text.Encoding.Unicode.GetString(desencriptar);

            return resultado;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña RCC = new RecuperarContraseña();
            RCC.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmailLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txtEmailLogin.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }
        }

        private void txtContraseñaLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txtContraseñaLogin.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }
        }
    }
}
