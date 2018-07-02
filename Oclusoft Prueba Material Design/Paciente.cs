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
    public partial class Paciente : MaterialSkin.Controls.MaterialForm
    {
        public Paciente()
        {
            InitializeComponent();
            this.msm.Location = new Point(800, 500);
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            cargarCombox();
            comboPacienteTipoDocumento.Focus();
        }

        //MVC
        Modelo.Paciente modeloPaciente = new Modelo.Paciente();
        Objeto.Paciente objetoPaciente = new Objeto.Paciente();
        Logica.Paciente logicaPaciente = new Logica.Paciente();

        //Formulario de los mensajes
        Mensaje msm = new Mensaje();
        

        //Variables globales
        DateTime ahora = DateTime.Now;
        int edad;
        //string error;

        private void cargarCombox()
        {
            // Tipo documento
            comboPacienteTipoDocumento.ValueMember = "idTipoDocumento";
            comboPacienteTipoDocumento.DisplayMember = "nombre";
            comboPacienteTipoDocumento.DataSource = modeloPaciente.consultarTipoDocumento();

            //Genero
            comboPacienteGenero.ValueMember = "idGenero";
            comboPacienteGenero.DisplayMember = "nombre";
            comboPacienteGenero.DataSource = modeloPaciente.consultarGenero();

            //GrupoSanguineo
            comboPacienteGrupoSanguineo.ValueMember = "idGrupoSanguineo";
            comboPacienteGrupoSanguineo.DisplayMember = "nombre";
            comboPacienteGrupoSanguineo.DataSource = modeloPaciente.consultarGrupoSanguineo();

            //TipoSeguro
            comboPacienteTipoSeguro.ValueMember = "idTipoSeguro";
            comboPacienteTipoSeguro.DisplayMember = "nombre";
            comboPacienteTipoSeguro.DataSource = modeloPaciente.consultarTipoSeguro();

            //EstadoCivil
            comboPacienteEstadoCivil.ValueMember = "idEstadoCivil";
            comboPacienteEstadoCivil.DisplayMember = "nombre";
            comboPacienteEstadoCivil.DataSource = modeloPaciente.consultarEstadoCivil();


            //Aseguradora
            comboPacienteAseguradora.ValueMember = "idAseguradora";
            comboPacienteAseguradora.DisplayMember = "nombre";
            comboPacienteAseguradora.DataSource = modeloPaciente.consultarAseguradora();

            //Ocupación
            comboPacienteOcupacion.ValueMember = "idOcupacion";
            comboPacienteOcupacion.DisplayMember = "nombre";
            comboPacienteOcupacion.DataSource = modeloPaciente.consultarOcupacion();

            //Parentesco
            comboResponsableParentesco.ValueMember = "idParentesco";
            comboResponsableParentesco.DisplayMember = "nombre";
            comboResponsableParentesco.DataSource = modeloPaciente.consultarParentesco();


        }

        private void mostrarPais()
        {
            //Paises
            comboPacientePais.ValueMember = "idPais";
            comboPacientePais.DisplayMember = "nombre";
            comboPacientePais.DataSource = modeloPaciente.consultarPais();

            //---------------------------------------------------------------
            comboPacienteCiudad.DataSource = null;
            comboPacienteCiudad.Refresh();
            comboPacienteCiudad.Items.Clear();
            comboPacienteDepartamento.DataSource = null;
            comboPacienteDepartamento.Refresh();
            comboPacienteDepartamento.Items.Clear();
        }

        private void comboPacientePais_DropDown(object sender, EventArgs e)
        {
            mostrarPais();
        }

        private void mostrarDepartamento(int idPais)
        {
            //Departamento
            comboPacienteDepartamento.ValueMember = "idDepartamento";
            comboPacienteDepartamento.DisplayMember = "nombre";
            comboPacienteDepartamento.DataSource = modeloPaciente.consultarDepartamentoPaciente(idPais);

        }

        private void mostrarCiudad(int idDepartamento)
        {
            //Ciudad
            comboPacienteCiudad.ValueMember = "idCiudad";
            comboPacienteCiudad.DisplayMember = "nombre";
            comboPacienteCiudad.DataSource = modeloPaciente.consultarCiudadPaciente(idDepartamento);

        }

        private void comboPacienteDepartamento_DropDown(object sender, EventArgs e)
        {
            if (comboPacientePais.SelectedIndex == -1)
            {
            }
            else
            {
                try
                {
                    int idPais;
                    idPais = int.Parse(comboPacientePais.SelectedValue.ToString());

                    mostrarDepartamento(idPais);
                }
                catch (Exception ex)
                {
                    msm.tipoMensaje("Error " + ex.Message, "error");
                    //throw;
                }
            }
        }

        private void comboPacienteCiudad_DropDown(object sender, EventArgs e)
        {
            if (comboPacienteDepartamento.SelectedIndex == -1)
            {
            }
            else
            {
                try
                {
                    int idDepartamento;
                    idDepartamento = int.Parse(comboPacienteDepartamento.SelectedValue.ToString());

                    mostrarCiudad(idDepartamento);
                }
                catch (Exception ex)
                {
                    msm.tipoMensaje("Error " + ex.Message, "error");
                    //throw;
                }
            }
        }
        
        private bool calcularEdad()
        {
            //DateTime cumpleaños = new DateTime();
            DateTime cumpleaños;
            cumpleaños = datePacienteFechaNacimiento.Value;


            edad = ahora.Year - cumpleaños.Year;
            if (ahora.Month < cumpleaños.Month || (ahora.Month == cumpleaños.Month && ahora.Day < cumpleaños.Day))
                edad--;
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnPacienteBuscar_Click(object sender, EventArgs e)
        {
            //Ejemplo
            //validarTipoDocumento();
             buscarOdontologoXDocumento();
        }

        private bool validarTipoDocumento()
        {
            //calcularEdad();
            MessageBox.Show("Edad" + edad);
            bool ban = false;
            
            if (edad >= 0 && edad < 7)
            {
                if (comboPacienteTipoDocumento.Text == ("REGISTRO CIVIL"))
                {
                    ban = true;
                }
                else
                {
                    ban = false;
                }
            }
            else
            {
                if (edad >= 7 && edad < 18)
                {
                    if (comboPacienteTipoDocumento.Text == ("TARJETA IDENTIDAD") || comboPacienteTipoDocumento.Equals("TARJETA DE IDENTIDAD") || comboPacienteTipoDocumento.Text == ("TI") || comboPacienteTipoDocumento.Equals("TARJETA DE IDENTIFICACION") || comboPacienteTipoDocumento.Equals("TARJETAS DE IDENTIDAD"))
                    {
                        ban = true;
                    }
                    else
                    {
                        ban = false;
                    }
                }
                else
                {
                    if (edad >= 18)
                    {
                        if (comboPacienteTipoDocumento.Text == ("CEDULA") || comboPacienteTipoDocumento.Text == ("CÉDULA") || comboPacienteTipoDocumento.Text == ("CC"))
                        {
                            ban = true;
                        }
                        else
                        {
                            ban = false;
                        }
                    }
                    else
                    {
                        ban = false;
                    }
                }
            }
            return ban;
        }

        public bool validarCamposInformacionPaciente()
        {
            errorProvider.Clear();
            if (txtPacienteNombres.Text == "")
            {
                errorProvider.SetError(txtPacienteNombres, "El nombre del paciente no puede estar vacío");
                //MessageBox.Show("El nombre del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (txtPacientePrimerApellido.Text == "")
                {
                    errorProvider.SetError(txtPacientePrimerApellido, "El apellido paterno del paciente no puede estar vacío");
                    //MessageBox.Show("El apellido paterno del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    if (comboPacienteGenero.SelectedIndex == -1)
                    {
                        errorProvider.SetError(comboPacienteGenero, "El género del paciente no puede estar vacío");
                        //MessageBox.Show("El genero del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        if (comboPacienteEstadoCivil.SelectedIndex == -1)
                        {
                            errorProvider.SetError(comboPacienteEstadoCivil, "El estado civil del paciente no puede estar vacío");
                            //MessageBox.Show("El estado civil del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            if (comboPacienteGrupoSanguineo.SelectedIndex == -1)
                            {
                                errorProvider.SetError(comboPacienteGrupoSanguineo, "El grupo sanguíneo del paciente no puede estar vacío");
                               // MessageBox.Show("El grupo sanguineo del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else
                            {
                                if (comboPacienteAseguradora.SelectedIndex == -1)
                                {
                                    errorProvider.SetError(comboPacienteAseguradora, "La aseguradora del paciente no puede estar vacío");
                                   // MessageBox.Show("La aseguradora del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return true;
                                }
                                else
                                {
                                    if (comboPacienteTipoSeguro.SelectedIndex == -1)
                                    {
                                        errorProvider.SetError(comboPacienteTipoSeguro, "El tipo de seguro del paciente no puede estar vacío");
                                       // MessageBox.Show("El tipo de seguro del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return true;
                                    }
                                    else
                                    {
                                        if (comboPacienteOcupacion.SelectedIndex == -1)
                                        {
                                            errorProvider.SetError(comboPacientePais, "La ocupación del paciente no puede estar vacío");
                                            //MessageBox.Show("La ocupación del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return true;
                                        }
                                        else
                                        {
                                            if (comboPacientePais.SelectedIndex == -1)
                                            {
                                                errorProvider.SetError(comboPacientePais, "El país del paciente no puede estar vacío");
                                               // MessageBox.Show("El país del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return true;
                                            }
                                            else
                                            {
                                                if (comboPacienteDepartamento.SelectedIndex == -1)
                                                {
                                                    errorProvider.SetError(comboPacientePais, "El departamento del paciente no puede estar vacío");
                                                    //MessageBox.Show("El departamento del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return true;
                                                }
                                                else
                                                {
                                                    if (comboPacienteCiudad.SelectedIndex == -1)
                                                    {
                                                        errorProvider.SetError(comboPacientePais, "La ciudad del paciente no puede estar vacío");
                                                       // MessageBox.Show("La ciudad del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return true;
                                                    }
                                                    else
                                                    {
                                                        if (txtPacienteBarrio.Text == "")
                                                        {
                                                            errorProvider.SetError(txtPacienteBarrio, "El barrio donde vive el paciente no puede estar vacío");
                                                            //MessageBox.Show("El barrio donde vive el paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            return true;
                                                        }
                                                        else
                                                        {
                                                            if (txtPacienteDireccion.Text == "")
                                                            {
                                                                errorProvider.SetError(txtPacienteDireccion, "La dirección del paciente no puede estar vacío");
                                                               // MessageBox.Show("La dirección del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                return true;
                                                            }
                                                            else
                                                            {
                                                                if (!radioPacienteActivo.Checked && !radioPacienteInactivo.Checked)
                                                                {
                                                                    errorProvider.SetError(radioPacienteActivo, "El estado del paciente no puede estar vacío");
                                                                    //MessageBox.Show("El estado del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    return true;
                                                                }
                                                                else
                                                                {
                                                                    //if (txtPacienteEmail.Text != "" || txtPacienteEmail.Text == null)
                                                                    //{
                                                                    //    string email = txtPacienteEmail.Text;
                                                                    //    if (!validarEmail(email))
                                                                    //    {
                                                                    //        errorProvider.SetError(txtPacienteEmail, "El formato del correo del paciente es incorrecto");
                                                                    //        //MessageBox.Show("El formato del correo del paciente esta incorrecto", "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    //        return true;
                                                                    //    }
                                                                    //    else
                                                                    //    {
                                                                    //        return false;
                                                                    //    }
                                                                    //}
                                                                    //else
                                                                    //{
                                                                        
                                                                        if (datePacienteFechaNacimiento.Value >= ahora)
                                                                        {
                                                                            errorProvider.SetError(datePacienteFechaNacimiento, "La fecha de nacimiento es incorrecta");
                                                                           // MessageBox.Show("La fecha de nacimiento es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            return true;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (edad < 18)
                                                                            {
                                                                                if (txtResponsableNombres.Text == "")
                                                                                {
                                                                                    errorProvider.SetError(txtResponsableNombres, "El nombre del responsable no puede estar vacío");
                                                                                    //MessageBox.Show("El nombre del responsable no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                    return true;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (txtResponsableApellidos.Text == "")
                                                                                    {
                                                                                        errorProvider.SetError(txtResponsableApellidos, "El apellido del responsable no puede estar vacío");
                                                                                        //MessageBox.Show("El apellido del responsable no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                        return true;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (txtResponsableDireccion.Text == "")
                                                                                        {
                                                                                            errorProvider.SetError(txtResponsableDireccion, "La dirección del responsable no puede estar vacío");
                                                                                            //MessageBox.Show("La dirección del responsable no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                            return true;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (comboResponsableParentesco.SelectedIndex == -1)
                                                                                            {
                                                                                                errorProvider.SetError(comboPacientePais, "El parentesco del responsable no puede estar vacío");
                                                                                                //MessageBox.Show("El parentesco del responsable no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                                return true;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                            if (txtResponsableTelefono.Text == "")
                                                                                            {
                                                                                                errorProvider.SetError(txtResponsableTelefono, "El campo no puede estar vacío");
                                                                                                return true;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (txtResponsableTelefono.TextLength <= 6 || txtResponsableTelefono.TextLength > 25)
                                                                                                {
                                                                                                    errorProvider.SetError(txtResponsableTelefono, "La longitud del teléfono es incorrecta");
                                                                                                    return true;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    return false;
                                                                                                }

                                                                                            }


                                                                                            //if (txtPacienteEmail.Text != "")
                                                                                            //    {
                                                                                            //        string email = txtPacienteEmail.Text;
                                                                                            //        if (!validarEmail(email))
                                                                                            //        {
                                                                                            //            errorProvider.SetError(txtPacienteEmail, "El formato del correo del paciente esta incorrecto");
                                                                                            //           // MessageBox.Show("El formato del correo del paciente esta incorrecto", "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                            //            return true;
                                                                                            //        }
                                                                                            //        else
                                                                                            //        {
                                                                                            //        return false;
                                                                                            //        }
                                                                                            //    }
                                                                                            //    else
                                                                                            //    {
                                                                                            //        return false;
                                                                                            //    }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                //   MessageBox.Show("Es mayor de edad");
                                                                                return false;
                                                                            }
                                                                        }
                                                                    }
                                                               // }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
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

        public bool validarCamposDocumentosPaciente()
        {
            errorProvider.Clear();
            if (comboPacienteTipoDocumento.SelectedIndex == -1)
            {
                errorProvider.SetError(comboPacienteTipoDocumento, "El tipo de documento del paciente no puede estar vacío");
               // MessageBox.Show("El tipo de documento del paciente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (txtPacienteDocumento.Text == "")
                {
                    errorProvider.SetError(txtPacienteDocumento, "El documento del paciente no puede estar vacío");
                   // MessageBox.Show("El documento del responsable no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void datePacienteFechaNacimiento_Leave(object sender, EventArgs e)
        {
            if (!calcularEdad())
            {
                groupResponsable.Visible = true;
            }
            else
            {
                groupResponsable.Visible = false;
            }

        }

        public void buscarOdontologoXDocumento()
        {
            try
            {
                if (!validarCamposDocumentosPaciente())
                {

                    string documento = txtPacienteDocumento.Text;
                    if (modeloPaciente.BuscarPacienteXDocumento(documento))
                    {

                        groupResponsable.Visible = false;
                        comboPacienteTipoDocumento.SelectedValue = modeloPaciente.vector[0];
                        txtPacienteDocumento.Text = modeloPaciente.vector[1];
                        txtPacienteNombres.Text = modeloPaciente.vector[2];
                        txtPacientePrimerApellido.Text = modeloPaciente.vector[3];
                        txtPacienteSegundoApellido.Text = modeloPaciente.vector[4];
                        txtPacienteEmail.Text = modeloPaciente.vector[5];
                        txtPacienteTelefonoFijo.Text = modeloPaciente.vector[6];
                        txtPacienteTelefonoMovil.Text = modeloPaciente.vector[7];
                        comboPacienteGenero.SelectedValue = modeloPaciente.vector[9];
                        comboPacienteEstadoCivil.SelectedValue = modeloPaciente.vector[10];
                        comboPacienteGrupoSanguineo.SelectedValue = modeloPaciente.vector[11];
                        comboPacienteAseguradora.SelectedValue = modeloPaciente.vector[12];
                        comboPacienteTipoSeguro.SelectedValue = modeloPaciente.vector[13];
                        comboPacienteOcupacion.SelectedValue = modeloPaciente.vector[14];
                        txtPacienteBarrio.Text = modeloPaciente.vector[15];
                        txtPacienteDireccion.Text = modeloPaciente.vector[16];
                        datePacienteFechaNacimiento.Text = modeloPaciente.vector[17];
                        txtPacienteObservacion.Text = modeloPaciente.vector[18];
                        if (!calcularEdad())
                        {
                            txtResponsableNombres.Text = modeloPaciente.vector[19];
                            txtResponsableApellidos.Text = modeloPaciente.vector[20];
                            txtResponsableTelefono.Text = modeloPaciente.vector[21];
                            txtResponsableDireccion.Text = modeloPaciente.vector[22];
                            comboResponsableParentesco.SelectedValue = modeloPaciente.vector[23];
                            groupResponsable.Visible = true;
                        }

                        comboPacientePais.SelectedValue = modeloPaciente.vector[24];
                        comboPacienteDepartamento.SelectedValue = modeloPaciente.vector[25];
                        comboPacienteCiudad.SelectedValue = modeloPaciente.vector[26];
                        //    objetoOdontologo.IdOdontologo = int.Parse(modeloPaciente.vector[12]);
                        idPaciente.Text = modeloPaciente.vector[27];
                        if (int.Parse(modeloPaciente.vector[8]) == 0)
                        {
                            radioPacienteInactivo.Select();
                        }
                        else
                        {
                            radioPacienteActivo.Select();
                        }
                    }
                    else
                    {
                        
                        try
                        {
                            msm.Show();
                            msm.tipoMensaje("El tipo de documento " + (comboPacienteTipoDocumento.Text.ToString()) + " con el número " + txtPacienteDocumento.Text
                            + " no existe", "warning");
                        }
                        catch (ObjectDisposedException )
                        {
                            msm.Close();
                            msm.tipoMensaje("El tipo de documento " + (comboPacienteTipoDocumento.Text.ToString()) + " con el número " + txtPacienteDocumento.Text
                            + " no existe", "warning");
                        }
                          
                        //MessageBox.Show("El tipo de documento " + (comboPacienteTipoDocumento.Text.ToString()) + " con el número " + txtPacienteDocumento.Text
                        //    + " no existe deba salir mensaje");
                    }

                }
                else
                {
                    msm.tipoMensaje("El documento del paciente no puede estar vacío", "warning");
                }
            }
            catch (Exception e)
            {
                msm.tipoMensaje("Error " + e.Message, "error"); 

            }

        }

        public void guardar(string x)
        {
            objetoPaciente.IdTipoDocumento = int.Parse(comboPacienteTipoDocumento.SelectedValue.ToString());
            objetoPaciente.Documento = txtPacienteDocumento.Text;
            objetoPaciente.Nombres = txtPacienteNombres.Text;
            objetoPaciente.PrimerApellido = txtPacientePrimerApellido.Text;
            objetoPaciente.SegundoApellido = txtPacienteSegundoApellido.Text;
            objetoPaciente.Email = txtPacienteEmail.Text;
            objetoPaciente.TelefonoFijo = txtPacienteTelefonoFijo.Text;
            objetoPaciente.TelefonoMovil = txtPacienteTelefonoMovil.Text;
            objetoPaciente.IdGenero = int.Parse(comboPacienteGenero.SelectedValue.ToString());
            objetoPaciente.IdEstadoCivil = int.Parse(comboPacienteEstadoCivil.SelectedValue.ToString());
            objetoPaciente.IdGrupoSanguineo = int.Parse(comboPacienteGrupoSanguineo.SelectedValue.ToString());
            objetoPaciente.IdAseguradora = int.Parse(comboPacienteAseguradora.SelectedValue.ToString());
            objetoPaciente.IdTipoSeguro = int.Parse(comboPacienteTipoSeguro.SelectedValue.ToString());
            objetoPaciente.IdOcupacion = int.Parse(comboPacienteOcupacion.SelectedValue.ToString());
            objetoPaciente.IdCiudad = int.Parse(comboPacienteCiudad.SelectedValue.ToString());
            objetoPaciente.Barrio = txtPacienteBarrio.Text;
            objetoPaciente.Direccion = txtPacienteDireccion.Text;
            objetoPaciente.FechaNacimiento = datePacienteFechaNacimiento.Value;
            objetoPaciente.Observacion = txtPacienteObservacion.Text;
            objetoPaciente.IdPaciente = int.Parse(idPaciente.Text);

            if (radioPacienteActivo.Checked)
            {
                objetoPaciente.Estado = 1;
            }
            else
            {
                objetoPaciente.Estado = 0;
            }
            objetoPaciente.NombreResponsable = txtResponsableNombres.Text;
            objetoPaciente.ApellidoResponsable = txtResponsableApellidos.Text;
            objetoPaciente.DireccionResponsable = txtResponsableDireccion.Text;
            objetoPaciente.TelefonoResponsable = txtResponsableTelefono.Text;
            objetoPaciente.IdParentescoResponsable = int.Parse(comboResponsableParentesco.SelectedValue.ToString());

            if (x == "ingresar")
            {
                if (logicaPaciente.insertarPaciente(objetoPaciente))
                {
                    msm.tipoMensaje("El registro se ha ingresado con éxito", "done");
                   // MessageBox.Show(this, "", "Ingreso con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    msm.tipoMensaje("Error " + modeloPaciente.Error, "error");
                }
            }
            else
            {
                if (logicaPaciente.modificarPaciente(objetoPaciente))
                {
                    msm.tipoMensaje("El registro se ha actualizado con éxito", "done");
                    limpiar();
                }
                else
                {
                    msm.tipoMensaje("Error " + modeloPaciente.Error, "error");
                }
            }

        }

        private void limpiar()
        {
            comboPacienteTipoDocumento.SelectedValue = 1;
            txtPacienteDocumento.Text = "";
            txtPacienteNombres.Text = "";
            txtPacientePrimerApellido.Text = "";
            txtPacienteSegundoApellido.Text = "";
            txtPacienteEmail.Text = "";
            txtPacienteTelefonoFijo.Text = "";
            txtPacienteTelefonoMovil.Text = "";
            comboPacienteGenero.SelectedValue = 1;
            comboPacienteEstadoCivil.SelectedValue = 1;
            comboPacienteGrupoSanguineo.SelectedValue = 1;
            comboPacienteAseguradora.SelectedValue = 1;
            comboPacienteTipoSeguro.SelectedValue = 1;
            comboPacienteOcupacion.SelectedValue = 1;
            comboPacientePais.SelectedValue = 1;
            comboPacienteDepartamento.SelectedValue = 1;
            comboPacienteCiudad.SelectedValue = 1;
            txtPacienteBarrio.Text = "";
            txtPacienteDireccion.Text = "";
            txtPacienteObservacion.Text = "";
            datePacienteFechaNacimiento.Value = DateTime.Today;
            if (radioPacienteActivo.Checked)
            {
                radioPacienteActivo.Checked = false;
            }
            else
            {
                radioPacienteInactivo.Checked = false;
            }
            txtResponsableNombres.Text = "";
            txtResponsableApellidos.Text = "";
            txtResponsableDireccion.Text = "";
            txtResponsableTelefono.Text = "";
            comboResponsableParentesco.SelectedValue = 1;
        }

        private void btnPacienteGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();
                if (!validarCamposDocumentosPaciente())
                {
                    if (!validarCamposInformacionPaciente())
                    {
                        if (validarTipoDocumento())
                        {
                            if (txtPacienteEmail.Text != "" || txtPacienteEmail.Text == null)
                            {
                                string email = txtPacienteEmail.Text;
                                if (!validarEmail(email))
                                {
                                    errorProvider.SetError(txtPacienteEmail, "El formato del correo del paciente es incorrecto");
                                    //MessageBox.Show("El formato del correo del paciente esta incorrecto", "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if (txtPacienteTelefonoFijo.Text == "")
                                    {
                                        
                                        if (txtPacienteTelefonoMovil.Text == "")
                                        {
                                            guardar("ingresar");
                                        }
                                        else
                                        {
                                            if (txtPacienteTelefonoMovil.TextLength < 11 || txtPacienteTelefonoMovil.TextLength > 25)
                                            {
                                                errorProvider.SetError(txtPacienteTelefonoMovil, "La longitud del teléfono móvil es incorrecta");
                                            }
                                            else
                                            {
                                                guardar("ingresar");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if ((txtPacienteTelefonoFijo.TextLength <= 6 || txtPacienteTelefonoFijo.TextLength > 25))
                                        {
                                            errorProvider.SetError(txtPacienteTelefonoFijo, "La longitud del teléfono fijo es incorrecta");
                                        }
                                        else
                                        {
                                            if (txtPacienteTelefonoMovil.TextLength < 11 || txtPacienteTelefonoMovil.TextLength > 25)
                                            {
                                                errorProvider.SetError(txtPacienteTelefonoMovil, "La longitud del teléfono móvil es incorrecta");
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
                                if (txtPacienteTelefonoFijo.Text == "")
                                {

                                    if (txtPacienteTelefonoMovil.Text == "")
                                    {
                                        guardar("ingresar");
                                    }
                                    else
                                    {
                                        if (txtPacienteTelefonoMovil.TextLength < 11 || txtPacienteTelefonoMovil.TextLength > 25)
                                        {
                                            errorProvider.SetError(txtPacienteTelefonoMovil, "La longitud del teléfono móvil es incorrecta");
                                        }
                                        else
                                        {
                                            guardar("ingresar");
                                        }
                                    }
                                }
                                else
                                {
                                    if ((txtPacienteTelefonoFijo.TextLength <= 6 || txtPacienteTelefonoFijo.TextLength > 25))
                                    {
                                        errorProvider.SetError(txtPacienteTelefonoFijo, "La longitud del teléfono fijo es incorrecta");
                                    }
                                    else
                                    {
                                        if (txtPacienteTelefonoMovil.TextLength < 11 || txtPacienteTelefonoMovil.TextLength > 25)
                                        {
                                            errorProvider.SetError(txtPacienteTelefonoMovil, "La longitud del teléfono móvil es incorrecta");
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
                            errorProvider.SetError(comboPacienteTipoDocumento, "La edad no corresponde con el tipo de documento");
                        }

                    }

                }

            }
            catch(Exception ex)
            {
                msm.tipoMensaje("Error " + ex.Message, "error");
            }


        }

        private void btnPacienteModificar_Click(object sender, EventArgs e)
        {
            if (!validarCamposDocumentosPaciente())
            {
                if (!validarCamposInformacionPaciente())
                {
                    //guardar("modificar");

                    if (txtPacienteEmail.Text != "" || txtPacienteEmail.Text == null)
                    {
                        string email = txtPacienteEmail.Text;
                        if (!validarEmail(email))
                        {
                            errorProvider.SetError(txtPacienteEmail, "El formato del correo del paciente es incorrecto");
                            //MessageBox.Show("El formato del correo del paciente esta incorrecto", "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (txtPacienteTelefonoFijo.Text == "")
                            {

                                if (txtPacienteTelefonoMovil.Text == "")
                                {
                                    guardar("modificar");
                                }
                                else
                                {
                                    if (txtPacienteTelefonoMovil.TextLength < 11 || txtPacienteTelefonoMovil.TextLength > 25)
                                    {
                                        errorProvider.SetError(txtPacienteTelefonoMovil, "La longitud del teléfono móvil es incorrecta");
                                    }
                                    else
                                    {
                                        guardar("modificar");
                                    }
                                }
                            }
                            else
                            {
                                if ((txtPacienteTelefonoFijo.TextLength <= 6 || txtPacienteTelefonoFijo.TextLength > 25))
                                {
                                    errorProvider.SetError(txtPacienteTelefonoFijo, "La longitud del teléfono fijo es incorrecta");
                                }
                                else
                                {
                                    if (txtPacienteTelefonoMovil.TextLength < 11 || txtPacienteTelefonoMovil.TextLength > 25)
                                    {
                                        errorProvider.SetError(txtPacienteTelefonoMovil, "La longitud del teléfono móvil es incorrecta");
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
                        if (txtPacienteTelefonoFijo.Text == "")
                        {

                            if (txtPacienteTelefonoMovil.Text == "")
                            {
                                guardar("modificar");
                            }
                            else
                            {
                                if (txtPacienteTelefonoMovil.TextLength < 11 || txtPacienteTelefonoMovil.TextLength > 25)
                                {
                                    errorProvider.SetError(txtPacienteTelefonoMovil, "La longitud del teléfono móvil es incorrecta");
                                }
                                else
                                {
                                    guardar("modificar");
                                }
                            }
                        }
                        else
                        {
                            if ((txtPacienteTelefonoFijo.TextLength <= 6 || txtPacienteTelefonoFijo.TextLength > 25))
                            {
                                errorProvider.SetError(txtPacienteTelefonoFijo, "La longitud del teléfono fijo es incorrecta");
                            }
                            else
                            {
                                if (txtPacienteTelefonoMovil.TextLength < 11 || txtPacienteTelefonoMovil.TextLength > 25)
                                {
                                    errorProvider.SetError(txtPacienteTelefonoMovil, "La longitud del teléfono móvil es incorrecta");
                                }
                                else
                                {
                                    guardar("modificar");
                                }
                            }
                        }
                    }
                    }
            }
        }

        private void agregarTipoDocumento_Click(object sender, EventArgs e)
        {
            TipoDocumento tipoDoc = new TipoDocumento();
            tipoDoc.Show();
            cargarCombox();
        }

        private void agregarGenero_Click(object sender, EventArgs e)
        {
            Generos gen = new Generos();
            gen.Show();
        }

        private void agregarPais_Click(object sender, EventArgs e)
        {
            Pais pais = new Pais();
            pais.Show();
        }

        private void agregarDepartamento_Click(object sender, EventArgs e)
        {
            Departamento dep = new Departamento();
            dep.Show();
        }

        private void agregarCiudad_Click(object sender, EventArgs e)
        {
            Ciudad ciu = new Ciudad();
            ciu.Show();
        }

        private void agregarOcupacion_Click(object sender, EventArgs e)
        {
            Ocupacion ocu = new Ocupacion();
            ocu.Show();
        }

        private void agregarAseguradora_Click(object sender, EventArgs e)
        {
            Aseguradora aseg = new Aseguradora();
            aseg.Show();
        }

        private void agregarEstadoCivil_Click(object sender, EventArgs e)
        {
            EstadoCivil est = new EstadoCivil();
            est.Show();
        }

        private void agregarTipoSeguro_Click(object sender, EventArgs e)
        {
            TipoSeguro tipoSeg = new TipoSeguro();
            tipoSeg.Show();
        }

        private void agregarGrupoSanguineo_Click(object sender, EventArgs e)
        {
            GrupoSanguineo grupoSang = new GrupoSanguineo();
            grupoSang.Show();
        }

        private void agregarParentesco_Click(object sender, EventArgs e)
        {
            Parentesco paren = new Parentesco();
            paren.Show();
        }

        private void txtPacienteNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
            cambioLetra(e, txtPacienteNombres);
        }

        public void validarIngresoDatos(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPacientePrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
            cambioLetra(e, txtPacientePrimerApellido);
        }

        private void txtPacienteSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
            cambioLetra(e, txtPacienteSegundoApellido);
        }

        private void txtResponsableNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
            cambioLetra(e, txtResponsableNombres);
        }

        private void txtResponsableApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
            cambioLetra(e, txtResponsableApellidos);
        }


        //Cargar los combox cuando se modifica o actualizan
        private void comboPacienteTipoDocumento_DropDown(object sender, EventArgs e)
        {
            cargarCombox();
        }

        private void comboPacienteGenero_DropDown(object sender, EventArgs e)
        {
            cargarCombox();
        }

        private void comboPacienteEstadoCivil_DropDown(object sender, EventArgs e)
        {
            cargarCombox();
        }

        private void comboPacienteGrupoSanguineo_DropDown(object sender, EventArgs e)
        {
            cargarCombox();
        }

        private void comboPacienteAseguradora_DropDown(object sender, EventArgs e)
        {
            cargarCombox();
        }

        private void comboPacienteTipoSeguro_DropDown(object sender, EventArgs e)
        {
            cargarCombox();
        }

        private void comboPacienteOcupacion_DropDown(object sender, EventArgs e)
        {
            cargarCombox();
        }

        private void comboResponsableParentesco_DropDown(object sender, EventArgs e)
        {
            cargarCombox();
        }


        //Cambio de tamaño de letra
        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }



        private void txtPacienteDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtPacienteDocumento);
        }

        private void txtPacienteEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtPacienteEmail);
        }

        private void txtPacienteTelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtPacienteTelefonoFijo);
            if (Char.IsWhiteSpace(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '´') || (e.KeyChar == '{') || (e.KeyChar == '}') || (e.KeyChar == '[') || (e.KeyChar == ']'))
            {
                e.Handled = true;

            }
            
        }

        private void txtPacienteTelefonoMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtPacienteTelefonoMovil);
            if (Char.IsWhiteSpace(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '´'))
            {
                e.Handled = true;

            }
        }

        private void txtPacienteBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtPacienteBarrio);
        }

        private void txtPacienteDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtPacienteDireccion);
        }

        private void txtResponsableTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtResponsableTelefono);
            if (Char.IsWhiteSpace(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == '´'))
            {
                e.Handled = true;

            }
        }

        private void txtResponsableDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtResponsableDireccion);

        }
    }
}
