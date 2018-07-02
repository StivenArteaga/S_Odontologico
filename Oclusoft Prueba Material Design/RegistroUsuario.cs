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
    public partial class RegistroUsuario : MaterialSkin.Controls.MaterialForm
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        //MVC
        Modelo.CuentasUsuarios ModeloCuentasUsuarios = new Modelo.CuentasUsuarios();
        Logica.CuentaUsuario LogicaCuenta = new Logica.CuentaUsuario();
        Objeto.CuentasUsuarios objCuentaUsuario = new Objeto.CuentasUsuarios();

        //Instancias
        private static RegistroUsuario m_FormDefInstance;
        validacion v = new validacion();

        Mensaje msm = new Mensaje();

       
        private void limpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
            comboRolUsuario.SelectedIndex = 1;
            txtEmailUsuario.Text = "";
            txtContraseñaUsuario.Text = "";
            txtConfirmarContraseñaUsuario.Text = "";
        }

        private void cargarComboBox()
        {
            comboRolUsuario.ValueMember = "idRolCuentaUsuario";
            comboRolUsuario.DisplayMember = "nombre";
            comboRolUsuario.DataSource = LogicaCuenta.CargarRol();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            cargarComboBox();
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

        string encriptar(string cadena)
        {
            string resultado = string.Empty;
            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);
            resultado = Convert.ToBase64String(encriptar);

            return resultado;
        }

        string desencriptar(string cadena)
        {
            string resultado = string.Empty;
            Byte[] desencriptar = Convert.FromBase64String(cadena);

            resultado = System.Text.Encoding.Unicode.GetString(desencriptar);

            return resultado;
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboRolUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        public static RegistroUsuario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new RegistroUsuario();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmailUsuario.Text == "")
                {
                    errorProvider1.SetError(txtEmailUsuario, "Ingrese su correo electrónico");
                    return;
                }
                else if (ValidacionRegistroUsuario.validarEmail(txtEmailUsuario.Text) == false)
                {
                    errorProvider1.SetError(txtEmailUsuario, "Dirección de correo no válido");
                    return;
                }
                else if (ModeloCuentasUsuarios.BuscarCuentaXEmail(txtEmailUsuario.Text))
                {
                    errorProvider1.SetError(txtEmailUsuario, "Correo ya existe");
                }

                else if (txtNombreUsuario.Text == "")
                {
                    errorProvider1.SetError(txtNombreUsuario, "Ingrese su nombre");
                    return;
                }
                else if (ModeloCuentasUsuarios.BuscarCuentaXNombre(txtNombreUsuario.Text))
                {
                    errorProvider1.SetError(txtNombreUsuario, "Nombre ya existe");
                }
                else if (txtTelefonoUsuario.Text == "")
                {
                    errorProvider1.SetError(txtTelefonoUsuario, "Ingrese número de teléfono");
                }
                else if (txtTelefonoUsuario.Text.Length < 7 || txtTelefonoUsuario.Text.Length > 20)
                {
                    errorProvider1.SetError(txtTelefonoUsuario, "Longitud del número de teléfono no es la correcta");
                }
                else if (txtContraseñaUsuario.Text == "")
                {

                    errorProvider1.SetError(txtContraseñaUsuario, "Ingrese su contraseña");
                    return;
                }
                else if (txtContraseñaUsuario.TextLength < 7)
                {
                    errorProvider1.SetError(txtContraseñaUsuario, "Contraseña poco segura");
                }
                else if (txtContraseñaUsuario.TextLength > 35)
                {
                    errorProvider1.SetError(txtContraseñaUsuario, "Contraseña sobre paso su longitud");
                }
                else if (txtConfirmarContraseñaUsuario.Text == "")
                {
                    errorProvider1.SetError(txtConfirmarContraseñaUsuario, "Ingrese confirmación de contraseña");
                    return;
                }
                else
                {
                    if (txtConfirmarContraseñaUsuario.Text == txtContraseñaUsuario.Text)
                    {
                        guardar("ingresar");
                    }
                    else
                    {
                        msm.tipoMensaje("Contraseña no coinciden", "warning");
                 //       MessageBox.Show("");
                    }
                }
            }
            catch (Exception ex)
            {
                msm.tipoMensaje("Error " + ex.Message, "error");
            }
           
        }

        private void guardar(string x)
        {
            errorProvider1.Clear();
            objCuentaUsuario.Nombre = txtNombreUsuario.Text;
            objCuentaUsuario.Email = txtEmailUsuario.Text;
            objCuentaUsuario.Telefono = int.Parse(txtTelefonoUsuario.Text);
            objCuentaUsuario.Contraseña = encriptar(this.txtConfirmarContraseñaUsuario.Text);
            objCuentaUsuario.IdRolCuentaUsuario = int.Parse(comboRolUsuario.SelectedValue.ToString());

            if (x == "ingresar")
            {
                if (LogicaCuenta.insertarCuentaUsuario(objCuentaUsuario))
                {
                    msm.tipoMensaje("Se han ingresado los datos correctamente", "done");
                    //MessageBox.Show("");
                   limpiarCampos();                    
                }             
            }
            else
            {
                objCuentaUsuario.IdCuentaUsuario = int.Parse(lblidCuentaUsuario.Text);
                if (ModeloCuentasUsuarios.ModificarCuenta(objCuentaUsuario))
                {
                    msm.tipoMensaje("Datos actualizados correctamente", "done");
                    //MessageBox.Show("");
                    limpiarCampos();   
                }
            }

        }
        
        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtTelefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void BuscarXEmail_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string email = txtEmailUsuario.Text;
            try
            {
                if (ValidacionRegistroUsuario.validarEmail(txtEmailUsuario.Text) == false)
                {
                    msm.tipoMensaje("Formato de correo ingresado incorrecto", "warning");
                }
                else if (ModeloCuentasUsuarios.BuscarCuentaUsuarioXEmailModificar(email))
                {
                    int ValorId = Convert.ToInt32(ModeloCuentasUsuarios.vector[0]);
                    lblidCuentaUsuario.Text = ModeloCuentasUsuarios.vector[0];
                    txtNombreUsuario.Text = ModeloCuentasUsuarios.vector[1];
                    txtEmailUsuario.Text = ModeloCuentasUsuarios.vector[2];
                    txtTelefonoUsuario.Text = ModeloCuentasUsuarios.vector[3];
                    txtContraseñaUsuario.Text = ModeloCuentasUsuarios.vector[4];
                    txtConfirmarContraseñaUsuario.Text = txtContraseñaUsuario.Text;
                    comboRolUsuario.SelectedValue = ModeloCuentasUsuarios.vector[5];

                }
                else
                {
                    msm.tipoMensaje("Correo no existe en el sistema", "warning");
                    //MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                msm.tipoMensaje("Error "+ ex.Message, "error");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (validarEmail(txtEmailUsuario.Text) == false)
                {
                    errorProvider1.SetError(txtEmailUsuario, "Formato del correo es incorrecto");
                }
                else if (txtNombreUsuario.Text == "")
                {
                    errorProvider1.SetError(txtNombreUsuario, "Ingrese su nombre");
                }
                else if (txtTelefonoUsuario.Text == "")
                {
                    errorProvider1.SetError(txtTelefonoUsuario, "Ingrese su número de teléfono");
                }
                else if (txtTelefonoUsuario.Text.Length < 7 || txtTelefonoUsuario.Text.Length > 12)
                {
                    errorProvider1.SetError(txtTelefonoUsuario, "Longitud del número de teléfono no es la correcta");
                }
                else if (txtContraseñaUsuario.Text == "")
                {
                    errorProvider1.SetError(txtContraseñaUsuario, "Ingrese su contraseña");
                }
                else if (txtConfirmarContraseñaUsuario.Text == "")
                {
                    errorProvider1.SetError(txtConfirmarContraseñaUsuario, "Ingrese confirmación de contraseña");
                }
                else if (txtContraseñaUsuario.TextLength < 7)
                {
                    errorProvider1.SetError(txtContraseñaUsuario, "Contraseña poco segura");
                }
                else if (txtContraseñaUsuario.TextLength > 35)
                {
                    errorProvider1.SetError(txtContraseñaUsuario, "Contraseña sobre paso su longitud");

                }
                else
                {
                    if (txtContraseñaUsuario.Text == txtConfirmarContraseñaUsuario.Text)
                    {
                        guardar("modificar");
                    }
                    else
                    {
                        msm.tipoMensaje("Contraseñas no coinciden", "warning");
                    }
                }
            }
            catch (Exception ex)
            {
                msm.tipoMensaje("Error " + ex.Message, "error");
                //throw;
            }
        }



        private void convertirAMayuscula(KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txtEmailUsuario.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }
        }

        private void txtEmailUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            convertirAMayuscula(e);
        }

        private void txtNombreUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            convertirAMayuscula(e);
        }

        private void txtTelefonoUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
            if (Char.IsWhiteSpace(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '´') || (e.KeyChar == '{') || (e.KeyChar == '}') || (e.KeyChar == '[') || (e.KeyChar == ']'))
            {
                e.Handled = true;

            }
            convertirAMayuscula(e);

        }

        private void txtContraseñaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            convertirAMayuscula(e);
        }

        private void txtConfirmarContraseñaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            convertirAMayuscula(e);
        }
    }
}
