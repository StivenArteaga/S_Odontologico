using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;


namespace Oclusoft_Prueba_Material_Design
{
    public partial class Odontologo : MaterialSkin.Controls.MaterialForm
    {
        public Odontologo()
        {
            InitializeComponent();
        }

        private void Odontologo_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        //string error = "";

        //MCV 
        Modelo.Odontologo modeloOdontologo = new Modelo.Odontologo();
        Logica.Odontologo logicaOdontologo = new Logica.Odontologo();
        Objeto.Odontologo objetoOdontologo = new Objeto.Odontologo();

        Mensaje msm = new Mensaje();


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (validarDocumento())
            {
                if (validarNombre())
                {
                    if (validarPrimerApellido())
                    {
                        if (validarEspecialidad())
                        {
                            if (validarTelefono())
                            {
                                if (validarEstado())
                                {


                                    if (txtOdontologoEmail.Text == "")
                                    {
                                        objetoOdontologo.Email = txtOdontologoEmail.Text;
                                       


                                        if (comboOdontologoTipoDocumento.SelectedIndex == -1)
                                        {
                                            errorProvider.SetError(comboOdontologoTipoDocumento, "Selecciona el tipo de documento");
                                        }
                                        else
                                        {
                                            if (comboOdontologoConsultorio.SelectedIndex == -1)
                                            {
                                                errorProvider.SetError(comboOdontologoConsultorio, "Selecciona el consultorio");
                                            }
                                            else
                                            {
                                                if (comboOdontologoGenero.SelectedIndex == -1)
                                                {
                                                    errorProvider.SetError(comboOdontologoGenero, "Selecciona el género");
                                                }
                                                else
                                                {
                                                    if (comboOdontologoGrupoSanguineo.SelectedIndex == -1)
                                                    {
                                                        errorProvider.SetError(comboOdontologoTipoDocumento, "Selecciona el grupo sanguíneo");
                                                    }
                                                    else
                                                    {
                                                       guardar("ingresar");
                                                    }
                                                }
                                            }

                                        }
                                    }

                                    else
                                    {
                                        string email = txtOdontologoEmail.Text;
                                        if (comprobarFormatoEmail(email))
                                        {
                                            objetoOdontologo.Email = txtOdontologoEmail.Text;
                                            

                                            if (comboOdontologoTipoDocumento.SelectedIndex == -1)
                                            {
                                                errorProvider.SetError(comboOdontologoTipoDocumento, "Selecciona el tipo de documento");
                                            }
                                            else
                                            {
                                                if (comboOdontologoConsultorio.SelectedIndex == -1)
                                                {
                                                    errorProvider.SetError(comboOdontologoConsultorio, "Selecciona el consultorio");
                                                }
                                                else
                                                {
                                                    if (comboOdontologoGenero.SelectedIndex == -1)
                                                    {
                                                        errorProvider.SetError(comboOdontologoGenero, "Selecciona el género");
                                                    }
                                                    else
                                                    {
                                                        if (comboOdontologoGrupoSanguineo.SelectedIndex == -1)
                                                        {
                                                            errorProvider.SetError(comboOdontologoTipoDocumento, "Selecciona el grupo sanguíneo");
                                                        }
                                                        else
                                                        {
                                                            guardar("ingresar");
                                                        }
                                                    }
                                                }

                                            }
                                        }
                                        else
                                        {
                                            errorProvider.SetError(txtOdontologoEmail, "El formato del email es incorrecto");
                                            //MessageBox.Show(this, "El formato del email es incorrecto", "Error en el email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                }
                                else
                                {
                                    errorProvider.SetError(radioOdontologoActivo, "El estado no puede estar vacío");
                                   // MessageBox.Show(this, "El estado no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                errorProvider.SetError(txtOdontologoTelefono, "El campo del teléfono no puede estar vacío");
                               // MessageBox.Show(this, "El campo del telefono no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            errorProvider.SetError(txtOdontologoEspecialidad, "El campo de la especialidad no puede estar vacío");
                            //MessageBox.Show(this, "El campo de la especialidad no puede estar vacía", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txtOdontologoPrimerApellido, "El campo del apellido paterno no puede estar vacío");
                        //MessageBox.Show(this, "El campo del apellido paterno no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider.SetError(txtOdontologoEspecialidad, "El nombre del odontólogo no puede estar vacío");
                   // MessageBox.Show(this, "El nombre del odontologo esta vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errorProvider.SetError(txtOdontologoDocumento, "El documento se encuentra vacío");
              //  MessageBox.Show(this, "El documento se encuentra vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarCombos()
        {
            //TipoDocumento
            comboOdontologoTipoDocumento.ValueMember = "idTipoDocumento";
            comboOdontologoTipoDocumento.DisplayMember = "nombre";
            comboOdontologoTipoDocumento.DataSource = modeloOdontologo.consultarTipoDocumento();

            //Genero
            comboOdontologoGenero.ValueMember = "idGenero";
            comboOdontologoGenero.DisplayMember = "nombre";
            comboOdontologoGenero.DataSource = modeloOdontologo.consultarGenero();

            //Consultorio
            comboOdontologoConsultorio.ValueMember = "idConsultorio";
            comboOdontologoConsultorio.DisplayMember = "descripcion";
            comboOdontologoConsultorio.DataSource = modeloOdontologo.consultarConsultorio();

            //GrupoSanguineo
            comboOdontologoGrupoSanguineo.ValueMember = "idGrupoSanguineo";
            comboOdontologoGrupoSanguineo.DisplayMember = "nombre";
            comboOdontologoGrupoSanguineo.DataSource = modeloOdontologo.consultarGrupoSanguineo();
            
        }

        private bool validarDocumento()
        {
            if (txtOdontologoDocumento.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool validarNombre()
        {
            if (txtOdontologoNombres.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validarPrimerApellido()
        {
            if (txtOdontologoPrimerApellido.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validarEspecialidad()
        {
            if (txtOdontologoEspecialidad.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validarTelefono()
        {
            if (txtOdontologoTelefono.Text == "")
            {
                return false;
            }
            else
            {
                if (txtOdontologoTelefono.TextLength < 7 || txtOdontologoTelefono.TextLength > 15)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private bool validarEstado()
        {
            if (radioOdontologoActivo.Checked || radioOdontologoInactivo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void limpiar()
        {
            comboOdontologoTipoDocumento.SelectedValue = 1;
            txtOdontologoDocumento.Text = "";
            txtOdontologoNombres.Text = "";
            txtOdontologoPrimerApellido.Text = "";
            txtOdontologoSegundoApellido.Text = "";
            txtOdontologoEspecialidad.Text = "";
            txtOdontologoEmail.Text = "";
            txtOdontologoTelefono.Text = "";
            if (radioOdontologoActivo.Checked)
            {
                radioOdontologoActivo.Checked = false;
            }
            else
            {
                radioOdontologoInactivo.Checked = false;
            }
            comboOdontologoGenero.SelectedValue = 1;
            comboOdontologoConsultorio.SelectedValue = 1;
            comboOdontologoGrupoSanguineo.SelectedValue = 1;
        }

        public static bool comprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
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

        private void btnOdontologoBuscar_Click(object sender, EventArgs e)
        {
            buscarOdontologoXDocumento();
        }

        public void buscarOdontologoXDocumento()
        {
            try
            {
                if (validarDocumento())
                {

                    string documento = txtOdontologoDocumento.Text;
                    if (modeloOdontologo.BuscarOdontologoXDocumento(documento))
                    {
                        comboOdontologoTipoDocumento.SelectedValue = modeloOdontologo.vector[0];
                        txtOdontologoDocumento.Text = modeloOdontologo.vector[1];
                        txtOdontologoNombres.Text = modeloOdontologo.vector[2];
                        txtOdontologoPrimerApellido.Text = modeloOdontologo.vector[3];
                        txtOdontologoSegundoApellido.Text = modeloOdontologo.vector[4];
                        txtOdontologoEspecialidad.Text = modeloOdontologo.vector[5];
                        txtOdontologoEmail.Text = modeloOdontologo.vector[6];
                        txtOdontologoTelefono.Text = modeloOdontologo.vector[7];
                        if (int.Parse(modeloOdontologo.vector[8]) == 0)
                        {
                            radioOdontologoInactivo.Select();
                        }
                        else
                        {
                            radioOdontologoActivo.Select();
                        }
                        comboOdontologoGenero.SelectedValue = modeloOdontologo.vector[9];
                        comboOdontologoConsultorio.SelectedValue = modeloOdontologo.vector[10];
                        comboOdontologoGrupoSanguineo.SelectedValue = modeloOdontologo.vector[11];
                        objetoOdontologo.IdOdontologo = int.Parse(modeloOdontologo.vector[12]);
                    }
                    else
                    {
                        msm.tipoMensaje("El documento a buscar no se encuentra registrado", "warning");
                       // MessageBox.Show(this, "El documento a buscar no se encuentra registrado", "No se encuentra registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    errorProvider.SetError(txtOdontologoDocumento, "El documento del odontólogo no puede estar vacío");
                   // MessageBox.Show(this, "El documento del odontologo no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception e)
            {
                msm.tipoMensaje("Error "+ e.Message, "error");
            }

        }

        private void btnOdontologoModificar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                if (validarDocumento())
                {

                    if (validarNombre())
                    {
                        if (validarPrimerApellido())
                        {
                            if (validarEspecialidad())
                            {
                                if (validarTelefono())
                                {

                                    if (validarEstado())
                                    {
                                        if (txtOdontologoEmail.Text == "")
                                        {
                                            objetoOdontologo.Email = txtOdontologoEmail.Text;
                                            if (comboOdontologoTipoDocumento.SelectedIndex == -1)
                                            {
                                                errorProvider.SetError(comboOdontologoTipoDocumento, "Selecciona el tipo de documento");
                                            }
                                            else
                                            {
                                                if (comboOdontologoConsultorio.SelectedIndex == -1)
                                                {
                                                    errorProvider.SetError(comboOdontologoConsultorio, "Selecciona el consultorio");
                                                }
                                                else
                                                {
                                                    if (comboOdontologoGenero.SelectedIndex == -1 )
                                                    {
                                                        errorProvider.SetError(comboOdontologoGenero, "Selecciona el género");
                                                    }
                                                    else
                                                    {
                                                        if (comboOdontologoGrupoSanguineo.SelectedIndex == -1)
                                                        {
                                                            errorProvider.SetError(comboOdontologoTipoDocumento, "Selecciona el grupo sanguíneo");
                                                        }
                                                        else
                                                        {
                                                            guardar("modificar");
                                                        }
                                                    }
                                                }
                                                
                                            }
                                            
                                        }
                                        else
                                        {
                                            string email = txtOdontologoEmail.Text;
                                            if (comprobarFormatoEmail(email))
                                            {
                                                objetoOdontologo.Email = txtOdontologoEmail.Text;


                                                if (comboOdontologoTipoDocumento.SelectedIndex == -1)
                                                {
                                                    errorProvider.SetError(comboOdontologoTipoDocumento, "Selecciona el tipo de documento");
                                                }
                                                else
                                                {
                                                    if (comboOdontologoConsultorio.SelectedIndex == -1)
                                                    {
                                                        errorProvider.SetError(comboOdontologoConsultorio, "Selecciona el consultorio");
                                                    }
                                                    else
                                                    {
                                                        if (comboOdontologoGenero.SelectedIndex == -1)
                                                        {
                                                            errorProvider.SetError(comboOdontologoGenero, "Selecciona el género");
                                                        }
                                                        else
                                                        {
                                                            if (comboOdontologoGrupoSanguineo.SelectedIndex == -1)
                                                            {
                                                                errorProvider.SetError(comboOdontologoTipoDocumento, "Selecciona el grupo sanguíneo");
                                                            }
                                                            else
                                                            {
                                                                guardar("modificar");
                                                            }
                                                        }
                                                    }

                                                }
                                            }
                                            else
                                            {
                                                errorProvider.SetError(txtOdontologoEmail, "El formato del email es incorrecto");
                                               // MessageBox.Show(this, "El formato del email es incorrecto", "Error en el email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }

                                    }
                                    else
                                    {
                                        errorProvider.SetError(radioOdontologoActivo, "El estado no puede estar vacío");
                                       // MessageBox.Show(this, "El estado no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    errorProvider.SetError(txtOdontologoTelefono, "El campo del teléfono no puede estar vacío");
                                    //MessageBox.Show(this, "El campo del telefono no puede estar vacío o tiene el rango incompleto", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                errorProvider.SetError(txtOdontologoEspecialidad, "El campo de la especialidad no puede estar vacío");
                               // MessageBox.Show(this, "El campo de la especialidad no puede estar vacía", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            errorProvider.SetError(txtOdontologoPrimerApellido, "El campo del apellido paterno no puede estar vacío");
                            //MessageBox.Show(this, "El campo del apellido paterno no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txtOdontologoNombres, "El nombre del odontólogo no puede estar vacío");
                        //MessageBox.Show(this, "El nombre del odontologo esta vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    errorProvider.SetError(txtOdontologoEspecialidad, "El documento del odontólogo no puede estar vacío");
                   // MessageBox.Show(this, "El documento del odontologo no puede estar vacío", "Campo a buscar vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                msm.tipoMensaje("Error " + ex.Message, "error");

                // throw;
            }

        }

        public void guardar(string x)
        {
            try
            {
                objetoOdontologo.IdTipoDocumento = int.Parse(comboOdontologoTipoDocumento.SelectedValue.ToString());
                objetoOdontologo.Documento = txtOdontologoDocumento.Text.ToUpper();
                objetoOdontologo.Nombre = txtOdontologoNombres.Text.ToUpper();
                objetoOdontologo.PrimerApellido = txtOdontologoPrimerApellido.Text.ToUpper();
                objetoOdontologo.SegundoApellido = txtOdontologoSegundoApellido.Text.ToUpper();
                objetoOdontologo.Especialidad = txtOdontologoEspecialidad.Text.ToUpper();


                objetoOdontologo.Telefono = txtOdontologoTelefono.Text;
                if (radioOdontologoActivo.Checked)
                {
                    objetoOdontologo.Estado = 1;
                }
                else
                {
                    objetoOdontologo.Estado = 0;
                }
                objetoOdontologo.IdGenero = int.Parse(comboOdontologoGenero.SelectedValue.ToString());
                objetoOdontologo.IdConsultorio = int.Parse(comboOdontologoConsultorio.SelectedValue.ToString());
                objetoOdontologo.IdGrupoSanguineo = int.Parse(comboOdontologoGrupoSanguineo.SelectedValue.ToString());
                if (x == "ingresar")
                {
                    if (logicaOdontologo.insertarOdontologo(objetoOdontologo))
                    {
                        msm.tipoMensaje("El registro se ha ingresado con éxito", "done");
                        //MessageBox.Show(this, "El registro se ha insertado con éxito", "Ingreso con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        msm.tipoMensaje("Error al modificar " + modeloOdontologo.Error, "error");
                        //MessageBox.Show(this, "Se ha presetado un error al modificar" + modeloOdontologo.Error, "Error modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (logicaOdontologo.modificarOdontologo(objetoOdontologo))
                    {
                        msm.tipoMensaje("El registro se ha actualizado con éxito", "done");
                        // MessageBox.Show(this, "El registro se ha modificado con éxito", "Modificación con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloOdontologo.Error, "error");
                        // MessageBox.Show(this, "Se ha presetado un error al modificar" + modeloOdontologo.Error, "Error modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e)
            {

                msm.tipoMensaje("Error " + e.Message, "error");
            }
            

        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void agregarConsultorio_Click(object sender, EventArgs e)
        {
            Consultorio consultorio = new Consultorio();
            consultorio.Show();
        }

        private void agregarGenero_Click(object sender, EventArgs e)
        {
            Generos gen = new Generos();
            gen.Show();
        }

        private void agregarGrupoSanguineo_Click(object sender, EventArgs e)
        {
            GrupoSanguineo grupoSang = new GrupoSanguineo();
            grupoSang.Show();
        }

        private void agregarTipoDocumento_Click(object sender, EventArgs e)
        {
            TipoDocumento tipoDoc = new TipoDocumento();
            tipoDoc.Show();
        }

        public void validarIngresoDatos(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtOdontologoNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
            cambioLetra(e, txtOdontologoNombres);
        }

        private void txtOdontologoPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
            cambioLetra(e, txtOdontologoPrimerApellido);
        }

        private void txtOdontologoSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
            cambioLetra(e, txtOdontologoSegundoApellido);
        }

        private void txtOdontologoEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
            cambioLetra(e, txtOdontologoEspecialidad);
        }

        private void comboOdontologoTipoDocumento_DropDown(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void comboOdontologoConsultorio_DropDown(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void comboOdontologoGenero_DropDown(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void comboOdontologoGrupoSanguineo_DropDown(object sender, EventArgs e)
        {
            cargarCombos();
        }

        //Cambiar tamaño de letra
        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar)){
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }
       
        }


        //PROPIEDADES DEL TEXTBOX KEYPRESS
        private void txtOdontologoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtOdontologoDocumento);
        }

        private void txtOdontologoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtOdontologoTelefono);

            if (Char.IsWhiteSpace(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '´') || (e.KeyChar == '{') || (e.KeyChar == '}') || (e.KeyChar == '[') || (e.KeyChar == ']'))
            {
                e.Handled = true;
            }

        }

        private void txtOdontologoEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtOdontologoEmail);
        }
    }
}
