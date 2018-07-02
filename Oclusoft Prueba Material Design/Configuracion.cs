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

namespace Oclusoft_Prueba_Material_Design
{
    public partial class Configuracion : MaterialForm
    {
        public Configuracion()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey700, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            cargarcombox();
        }


        //MVC Formularios
        //Pais
        Modelo.Pais modeloPais = new Modelo.Pais();
        Logica.Pais logicaPais = new Logica.Pais();
        Objeto.Pais objectoPais = new Objeto.Pais();

        //Departamento
        Modelo.Departamento modeloDepartamento = new Modelo.Departamento();
        Logica.Departamento logicaDepartamento = new Logica.Departamento();
        Objeto.Departamento objetoDepartamento = new Objeto.Departamento();

        //Ciudad
        Modelo.Ciudad modeloCiudad = new Modelo.Ciudad();
        Logica.Ciudad logicaCiudad = new Logica.Ciudad();
        Objeto.Ciudad objetoCiudad = new Objeto.Ciudad();

        //Genero
        Modelo.Genero modeloGenero = new Modelo.Genero();
        Logica.Genero logicaGenero = new Logica.Genero();
        Objeto.Genero objetoGenero = new Objeto.Genero();

        //Aseguradora
        Modelo.Aseguradora modeloAseguradora = new Modelo.Aseguradora();
        Logica.Aseguradora logicaAseguradora = new Logica.Aseguradora();
        Objeto.Aseguradora objetoAseguradora = new Objeto.Aseguradora();

        //GrupoSanguineo
        Modelo.GrupoSanguineo modeloGrupoSanguineo = new Modelo.GrupoSanguineo();
        Logica.GrupoSanguineo logicaGrupoSanguineo = new Logica.GrupoSanguineo();
        Objeto.GrupoSanguineo objetoGrupoSanguineo = new Objeto.GrupoSanguineo();

        //EstadoCivil
        Modelo.EstadoCivil modeloEstadoCivil = new Modelo.EstadoCivil();
        Logica.EstadoCivil logicaEstadoCivil = new Logica.EstadoCivil();
        Objeto.EstadoCivil objetoEstadoCivil = new Objeto.EstadoCivil();

        //Ocupacion
        Modelo.Ocupacion modeloOcupacion = new Modelo.Ocupacion();
        Logica.Ocupacion logicaOcupacion = new Logica.Ocupacion();
        Objeto.Ocupacion objetoOcupacion = new Objeto.Ocupacion();

        //TipoDocumento
        Modelo.TipoDocumento modeloTipoDocumento = new Modelo.TipoDocumento();
        Logica.TipoDocumento logicaTipoDocumento = new Logica.TipoDocumento();
        Objeto.TipoDocumento objetoTipoDocumento = new Objeto.TipoDocumento();

        //Consultorio
        Modelo.Consultorio modeloConsultorio = new Modelo.Consultorio();
        Logica.Consultorio logicaConsultorio = new Logica.Consultorio();
        Objeto.Consultorio objetoConsultorio = new Objeto.Consultorio();

        //TipoSeguro
        Modelo.TipoSeguro modeloTipoSeguro = new Modelo.TipoSeguro();
        Logica.TipoSeguro logicaTipoSeguro = new Logica.TipoSeguro();
        Objeto.TipoSeguro objetoTipoSeguro = new Objeto.TipoSeguro();

        //Parentesco
        Modelo.Parentesco modeloParentesco = new Modelo.Parentesco();
        Logica.Parentesco logicaParentesco = new Logica.Parentesco();
        Objeto.Parentesco objetoParentesco = new Objeto.Parentesco();


        Mensaje msm = new Mensaje();


        //Formularios

        public void cargarcombox()
        {
            // Departamentos
            comboidPais.ValueMember = "idPais";
            comboidPais.DisplayMember = "nombre";
            comboidPais.DataSource = modeloDepartamento.cargarNombrePais();

            //Ciudad
            comboidDepartamento.ValueMember = "idDepartamento";
            comboidDepartamento.DisplayMember = "nombre";
            comboidDepartamento.DataSource = modeloCiudad.cargarNombreDepartamento();
        }

        
        //País
        public void validarIngresoDatos(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void registrarPais()
        {
            error.Clear();
            objectoPais.Nombre = txtPaisNombre.Text;
            if (radioPaisActivo.Checked)
            {
                objectoPais.Estado = 1;
            }
            else
            {
                objectoPais.Estado = 0;
            }


            if (validarNombrePais())
            {
                if (validarEstadoPais())
                {
                    if (logicaPais.insertarPais(objectoPais))
                    {
                        msm.tipoMensaje("Se ha ingresado el país correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado el pais correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarPais();
                        cargarcombox();
                        dataPais.DataSource = logicaPais.cargarPais("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloPais.Error, "error");
                       // MessageBox.Show(this, "No se ha insertado " + modeloPais.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioPaisActivo, "El estado del país no puede estar vacío");
                    //MessageBox.Show(this, "El estado del país no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del pais no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtPaisNombre, "El campo del nombre no puede estar vacío");
            }

        }

        private void modificarPais()
        {
            objectoPais.IdPais = int.Parse(modeloPais.vector[0]);
            objectoPais.Nombre = txtPaisNombre.Text;
            if (radioPaisActivo.Checked)
            {
                objectoPais.Estado = 1;
            }
            else
            {
                objectoPais.Estado = 0;
            }


            if (validarNombrePais())
            {
                if (validarEstadoPais())
                {
                    if (logicaPais.modificarPais(objectoPais))
                    {
                        msm.tipoMensaje("Se ha actualizado el país correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado el pais correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarPais();
                        btnPaisGuardar.Visible = false;
                        cargarcombox();
                        dataPais.DataSource = logicaPais.cargarPais("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloPais.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloPais.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioPaisActivo, "El estado del país no puede estar vacío");
                    //MessageBox.Show(this, "", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
               // MessageBox.Show(this, "El campo del nombre del pais no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtPaisNombre, "El campo del nombre no puede estar vacío");
            }
        }

        private bool validarNombrePais()
        {
            if (txtPaisNombre.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiarPais()
        {
            txtPaisNombre.Text = "";
            radioPaisActivo.Checked = false;
            radioPaisInactivo.Checked = false;
        }

        private bool validarEstadoPais()
        {
            if (radioPaisActivo.Checked || radioPaisInactivo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnPaisRegistrar_Click(object sender, EventArgs e)
        {
            registrarPais();
        }

        private void btnPaisModificar_Click(object sender, EventArgs e)
        {
            if (txtPaisNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del país que desea buscar", "warning");
               // MessageBox.Show(this, "Por favor ingrese el nombre del país que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombrePais = txtPaisNombre.Text;

                if (modeloPais.BuscarPais(nombrePais))
                {
                    if (int.Parse(modeloPais.vector[2]) == 0)
                    {
                        radioPaisInactivo.Select();
                    }
                    else
                    {
                        radioPaisActivo.Select();
                    }


                    btnPaisGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El país a actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "El país a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPaisListar_Click(object sender, EventArgs e)
        {
            dataPais.DataSource = logicaPais.cargarPais("configuracion");
        }

        private void btnPaisGuardar_Click(object sender, EventArgs e)
        {
            modificarPais();
        }



        //Departamento
        private void limpiarDepartamento()
        {
            txtDepartamentoNombre.Text = "";
            radioDepartamentoActivo.Checked = false;
            radioDepartamentoInactivo.Checked = false;
        }

        private bool validarEstadoDepartamento()
        {
            if (radioDepartamentoActivo.Checked || radioDepartamentoInactivo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarComboIdPais()
        {
            if (comboidPais.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void modificarDepartamento()
        {
            objetoDepartamento.IdDepartamento = int.Parse(modeloDepartamento.vector[0]);
            objetoDepartamento.Nombre = txtDepartamentoNombre.Text;
            if (radioDepartamentoActivo.Checked)
            {
                objetoDepartamento.Estado = 1;
            }
            else
            {
                objetoDepartamento.Estado = 0;
            }

            if (validarComboIdPais())
            {
                error.SetError(comboidPais, "El campo del país no puede estar vacío");
            }
            else
            {
                if (validarNombreDepartamento())
                {
                    if (validarEstadoDepartamento())
                    {
                        objetoDepartamento.IdPais = int.Parse(comboidPais.SelectedValue.ToString());
                        if (logicaDepartamento.modificarDepartamento(objetoDepartamento))
                        {
                            msm.tipoMensaje("Se ha actualizado el departamento correctamente", "done");
                            //MessageBox.Show(this, "Se ha modificado el departamento correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarDepartamento();
                            cargarcombox();
                            btnDepartamentoGuardar.Visible = false;
                            dataDepartamento.DataSource = logicaDepartamento.cargarDepartamento();

                        }
                        else
                        {
                            msm.tipoMensaje("Error "+ modeloDepartamento.Error, "error");
                            //MessageBox.Show(this, "No se ha insertado " + modeloDepartamento.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        error.SetError(radioDepartamentoActivo, "El estado del departamento no puede estar vacío");
                       // MessageBox.Show(this, "El estado del departamento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    //MessageBox.Show(this, "El campo del nombre del departamento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.SetError(txtDepartamentoNombre, "El campo del nombre del departamento no puede estar vacío");
                }
            }
        }

        private bool validarNombreDepartamento()
        {

            if (txtDepartamentoNombre.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void registrarDepartamento()
        {
            objetoDepartamento.Nombre = txtDepartamentoNombre.Text;
            //objetoDepartamento.IdPais = int.Parse(comboidPais.SelectedValue.ToString());
            if (radioDepartamentoActivo.Checked)
            {
                objetoDepartamento.Estado = 1;
            }
            else
            {
                objetoDepartamento.Estado = 0;
            }


            if (validarComboIdPais())
            {
                error.SetError(comboidPais, "El campo del país no puede estar vacío");
            }
            else
            {
                if (validarNombreDepartamento())
                {
                    if (validarEstadoDepartamento())
                    {
                        objetoDepartamento.IdPais = int.Parse(comboidPais.SelectedValue.ToString());
                        if (logicaDepartamento.insertarDepartamento(objetoDepartamento))
                        {
                            msm.tipoMensaje("Se ha ingresado el departamento correctamente", "done");
                            //MessageBox.Show(this, "Se ha insertado el departamento correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataDepartamento.DataSource = logicaDepartamento.cargarDepartamento();
                            cargarcombox();
                        }
                        else
                        {
                            msm.tipoMensaje("Error " + modeloDepartamento.Error, "error");
                            //MessageBox.Show(this, "No se ha insertado " + modeloDepartamento.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                       // MessageBox.Show(this, "El estado del departamento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error.SetError(radioDepartamentoActivo, "El estado del departamento no puede estar vacío");
                    }
                }
                else
                {
                    //MessageBox.Show(this, "El campo del nombre del departamento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.SetError(comboidPais, "El nombre del departamento no puede estar vacío");
                }
            }
        }

        private void btnDepartamentoRegistrar_Click(object sender, EventArgs e)
        {
            registrarDepartamento();
        }

        private void btnDepartamentoModificar_Click(object sender, EventArgs e)
        {
            if (txtDepartamentoNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del departamento que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre del departamento que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreDepartamento = txtDepartamentoNombre.Text;

                if (modeloDepartamento.BuscarDepartamento(nombreDepartamento))
                {
                    if (int.Parse(modeloDepartamento.vector[2]) == 0)
                    {
                        radioDepartamentoInactivo.Select();
                    }
                    else
                    {
                        radioDepartamentoActivo.Select();
                    }
                    comboidPais.ValueMember = "idPais";
                    int r = int.Parse(modeloDepartamento.vector[3]);
                    comboidPais.SelectedValue = r;
                    btnDepartamentoGuardar.Visible = true;
                    this.Refresh();
                }
                else
                {
                    msm.tipoMensaje("El departamento ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "El departamento a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tabDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void btnDepartamentoListar_Click(object sender, EventArgs e)
        {
            dataDepartamento.DataSource = logicaDepartamento.cargarDepartamento();
        }

        private void btnDepartamentoGuardar_Click(object sender, EventArgs e)
        {
            modificarDepartamento();
        }


        //Ciudad

        private bool validarNombreCiudad()
        {
            if (txtCiudadNombre.Text == "") { return false; }
            else { return true; }
        }

        private bool validarEstadoCiudad()
        {
            if (radioCiudadActivo.Checked || radioCiudadInactivo.Checked) { return true; }
            else { return false; }
        }

        private void limpiarCiudad()
        {
            txtCiudadNombre.Text = "";
            radioCiudadActivo.Checked = false;
            radioCiudadInactivo.Checked = false;
        }

        private void registrarCiudad()
        {
            objetoCiudad.Nombre = txtCiudadNombre.Text;
            if (radioCiudadActivo.Checked)
            {
                objetoCiudad.Estado = 1;
            }
            else
            {
                objetoCiudad.Estado = 0;
            }


            if (validarNombreCiudad())
            {
                if (validarEstadoCiudad())
                {
                    objetoCiudad.IdDepartamento = int.Parse(comboidDepartamento.SelectedValue.ToString());
                    if (logicaCiudad.insertarCiudad(objetoCiudad))
                    {
                        msm.tipoMensaje("Se ha ingresado la ciudad correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado la ciudad correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataCiudad.DataSource = logicaCiudad.cargarCiudad();
                        cargarcombox();
                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloCiudad.Error, "error"); 
                        //MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioCiudadActivo, "El estado de la ciudad no puede estar vacío");
                    //MessageBox.Show(this, "El estado de la ciudad no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre de la ciudad no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtCiudadNombre, "El campo del nombre de la ciudad no puede estar vacío");
            }
        }

        private void modificarCiudad()
        {

            objetoCiudad.IdCiudad = int.Parse(modeloCiudad.vector[0]);
            objetoCiudad.Nombre = txtCiudadNombre.Text;
            if (radioCiudadActivo.Checked)
            {
                objetoCiudad.Estado = 1;
            }
            else
            {
                objetoCiudad.Estado = 0;
            }


            if (validarNombreCiudad())
            {
                if (validarEstadoCiudad())
                {
                    objetoCiudad.IdDepartamento = int.Parse(comboidDepartamento.SelectedValue.ToString());
                    if (logicaCiudad.modificarCiudad(objetoCiudad))
                    {
                        msm.tipoMensaje("Se ha actualizado la ciudad correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado la ciudad correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCiudad();
                        cargarcombox();
                        btnCiudadGuardar.Visible = false;
                        dataCiudad.DataSource = logicaCiudad.cargarCiudad();

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloCiudad.Error, "error");
                        //MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioCiudadActivo, "El estado de la ciudad no puede estar vacío");
                    //MessageBox.Show(this, "El estado de la ciudad no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El nombre de la ciudad no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtCiudadNombre, "El nombre de la ciudad no puede estar vacío");
            }
        }

        private void btnCiudadRegistrar_Click(object sender, EventArgs e)
        {
            registrarCiudad();
        }

        private void btnCiudadModificar_Click(object sender, EventArgs e)
        {
            if (txtCiudadNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre de la ciudad que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre de la ciudad que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreCiudad = txtCiudadNombre.Text;

                if (modeloCiudad.BuscarCiudad(nombreCiudad))
                {
                    if (int.Parse(modeloCiudad.vector[2]) == 0)
                    {
                        radioCiudadInactivo.Select();
                    }
                    else
                    {
                        radioCiudadActivo.Select();
                    }
                    comboidDepartamento.ValueMember = "idDepartamento";
                    int r = int.Parse(modeloCiudad.vector[3]);
                    comboidDepartamento.SelectedValue = r;
                    btnCiudadGuardar.Visible = true;
                    this.Refresh();
                }
                else
                {
                    msm.tipoMensaje("La ciudad ha actualizar no se encuentra registrada", "warning");
                    //MessageBox.Show(this, "La ciudad a modificar no se encuentra registrada", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCiudadListar_Click(object sender, EventArgs e)
        {
            dataCiudad.DataSource = logicaCiudad.cargarCiudad();
        }

        private void btnCiudadGuardar_Click(object sender, EventArgs e)
        {
            modificarCiudad();
        }


        //Aseguradora

        private bool validarNombreAseguradora()
        {
            if (txtAseguradoraNombre.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarAseguradora()
        {
            txtAseguradoraNombre.Text = "";
            radioAseguradoraActivo.Checked = false;
            radioAseguradoraInactivo.Checked = false;
        }

        private bool validarEstadoAseguradora()
        {
            if (radioAseguradoraActivo.Checked || radioAseguradoraInactivo.Checked)
            { return true; }
            else { return false; }
        }

        private void btnAseguradoraIngresar_Click(object sender, EventArgs e)
        {
            registrarAseguradora();
        }

        private void btnAseguradoraModificar_Click(object sender, EventArgs e)
        {
            if (txtAseguradoraNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre de la aseguradora que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre de la aseguradora que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreAseguradora = txtAseguradoraNombre.Text;

                if (modeloAseguradora.BuscarAseguradora(nombreAseguradora))
                {
                    if (int.Parse(modeloAseguradora.vector[2]) == 0)
                    {
                        radioAseguradoraInactivo.Select();
                    }
                    else
                    {
                        radioAseguradoraActivo.Select();
                    }


                    btnAseguradoraGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("La aseguradora a actualizar no se encuentra registrada", "warning");
                    //MessageBox.Show(this, "La aseguradora a modificar no se encuentra registrada", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAseguradoraListar_Click(object sender, EventArgs e)
        {
            dataAseguradora.DataSource = logicaAseguradora.cargarAseguradora("configuracion");
        }

        private void btnAseguradoraGuardar_Click(object sender, EventArgs e)
        {
            modificarAseguradora();
        }

        private void registrarAseguradora()
        {
            objetoAseguradora.Nombre = txtAseguradoraNombre.Text;
            if (radioAseguradoraActivo.Checked)
            {
                objetoAseguradora.Estado = 1;
            }
            else
            {
                objetoAseguradora.Estado = 0;
            }


            if (validarNombreAseguradora())
            {
                if (validarEstadoAseguradora())
                {
                    if (logicaAseguradora.insertarAseguradora(objetoAseguradora))
                    {
                        msm.tipoMensaje("Se ha ingresado la aseguradora correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado la aseguradora correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarAseguradora();
                        cargarcombox();
                        dataAseguradora.DataSource = logicaAseguradora.cargarAseguradora("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloAseguradora.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloAseguradora.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioAseguradoraActivo, "El estado de la aseguradora no puede estar vacío");
                    //MessageBox.Show(this, "El estado de la aseguradora no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre de la aseguradora no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtAseguradoraNombre, "El campo del nombre de la aseguradora no puede estar vacío");
            }

        }

        private void modificarAseguradora()
        {
            objetoAseguradora.IdAseguradora = int.Parse(modeloAseguradora.vector[0]);
            objetoAseguradora.Nombre = txtAseguradoraNombre.Text;
            if (radioAseguradoraActivo.Checked)
            {
                objetoAseguradora.Estado = 1;
            }
            else
            {
                objetoAseguradora.Estado = 0;
            }


            if (validarNombreAseguradora())
            {
                if (validarEstadoAseguradora())
                {
                    if (logicaAseguradora.modificarAseguradora(objetoAseguradora))
                    {
                        msm.tipoMensaje("Se ha actualizado la aseguradora correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado la aseguradora correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarAseguradora();
                        btnAseguradoraGuardar.Visible = false;
                        cargarcombox();
                        dataAseguradora.DataSource = logicaAseguradora.cargarAseguradora("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloAseguradora.Error, "error");
                        //MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //MessageBox.Show(this, "El estado de la aseguradora no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.SetError(radioAseguradoraActivo, "El estado de la aseguradora no puede estar vacío");
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre de la aseguradora no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtAseguradoraNombre, "El campo del nombre de la aseguradora no puede estar vacío");
            }
        }


        //Estados civiles

        private bool validarNombreEstadoCivil()
        {
            if (txtEstadoCivilNombre.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarEstadoCivil()
        {
            txtEstadoCivilNombre.Text = "";
            radioEstadoCivilActivo.Checked = false;
            radioEstadoCivilInactivo.Checked = false;
        }

        private bool validarEstadoEstadoCivil()
        {
            if (radioEstadoCivilActivo.Checked || radioEstadoCivilInactivo.Checked)
            { return true; }
            else { return false; }
        }

        private void btnEstadoCivilRegistrar_Click(object sender, EventArgs e)
        {
            registrarEstadoCivil();
        }

        private void btnEstadoCivilModificar_Click(object sender, EventArgs e)
        {

            if (txtEstadoCivilNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del estado civil que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor v", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreEstadoCivil = txtEstadoCivilNombre.Text;

                if (modeloEstadoCivil.BuscarEstadoCivil(nombreEstadoCivil))
                {
                    if (int.Parse(modeloEstadoCivil.vector[2]) == 0)
                    {
                        radioEstadoCivilInactivo.Select();
                    }
                    else
                    {
                        radioEstadoCivilActivo.Select();
                    }


                    btnEstadoCivilGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El estado civil ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "El estado civil a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEstadoCivilListar_Click(object sender, EventArgs e)
        {
            dataEstadoCivil.DataSource = logicaEstadoCivil.cargarEstadoCivil("configuracion");
        }

        private void btnEstadoCivilGuardar_Click(object sender, EventArgs e)
        {
            modificarEstadoCivil();
        }

        private void registrarEstadoCivil()
        {
            objetoEstadoCivil.Nombre = txtEstadoCivilNombre.Text;
            if (radioEstadoCivilActivo.Checked)
            {
                objetoEstadoCivil.Estado = 1;
            }
            else
            {
                objetoEstadoCivil.Estado = 0;
            }


            if (validarNombreEstadoCivil())
            {
                if (validarEstadoEstadoCivil())
                {
                    if (logicaEstadoCivil.insertarEstadoCivil(objetoEstadoCivil))
                    {
                        msm.tipoMensaje("Se ha ingresado el estado civil correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado el estado civil correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarEstadoCivil();
                        cargarcombox();
                        dataEstadoCivil.DataSource = logicaEstadoCivil.cargarEstadoCivil("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloEstadoCivil.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioEstadoCivilActivo, "El estado del estado civil no puede estar vacío");
                    //MessageBox.Show(this, "El estado del estado civil no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del estado civil no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtEstadoCivilNombre, "El campo del nombre  no puede estar vacío");
            }

        }

        private void modificarEstadoCivil()
        {
            objetoEstadoCivil.IdEstadoCivil = int.Parse(modeloEstadoCivil.vector[0]);
            objetoEstadoCivil.Nombre = txtEstadoCivilNombre.Text;
            if (radioEstadoCivilActivo.Checked)
            {
                objetoEstadoCivil.Estado = 1;
            }
            else
            {
                objetoEstadoCivil.Estado = 0;
            }


            if (validarNombreEstadoCivil())
            {
                if (validarEstadoEstadoCivil())
                {
                    if (logicaEstadoCivil.modificarEstadoCivil(objetoEstadoCivil))
                    {
                        msm.tipoMensaje("Se ha actualizado el estado civil correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado el estado civil correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarEstadoCivil();
                        btnEstadoCivilGuardar.Visible = false;
                        cargarcombox();
                        dataEstadoCivil.DataSource = logicaEstadoCivil.cargarEstadoCivil("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloEstadoCivil.Error, "error");
                        //MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioEstadoCivilActivo, "El estado del estado civil no puede estar vacío");
                    //MessageBox.Show(this, "El estado del estado civil no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del estado civil no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtEstadoCivilNombre, "El nombre del estado civil no puede estar vacío");
            }
        }


        //Ocupacion

        private bool validarNombreOcupacion()
        {
            if (txtOcupacionNombre.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarOcupacion()
        {
            txtOcupacionNombre.Text = "";
            radioOcupacionActivo.Checked = false;
            radioOcupacionInactivo.Checked = false;
        }

        private bool validarEstadoOcupacion()
        {
            if (radioOcupacionActivo.Checked || radioOcupacionInactivo.Checked)
            { return true; }
            else { return false; }
        }
        
        private void btnOcupacionRegistrar_Click(object sender, EventArgs e)
        {
            registrarOcupacion();
        }

        private void btnOcupacionModificar_Click(object sender, EventArgs e)
        {
            if (txtOcupacionNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre de la ocupación que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre de la ocupación que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreOcupacion = txtOcupacionNombre.Text;

                if (modeloOcupacion.BuscarOcupacion(nombreOcupacion))
                {
                    if (int.Parse(modeloOcupacion.vector[2]) == 0)
                    {
                        radioOcupacionInactivo.Select();
                    }
                    else
                    {
                        radioOcupacionActivo.Select();
                    }


                    btnOcupacionGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("La ocupación ha actualizar no se encuentra registrada", "warning");
                    //MessageBox.Show(this, "La ocupación a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnOcupacionListar_Click(object sender, EventArgs e)
        {
            dataOcupacion.DataSource = logicaOcupacion.cargarOcupacion("configuracion");
        }

        private void btnOcupacionGuardar_Click(object sender, EventArgs e)
        {
            modificarOcupacion();
        }

        private void registrarOcupacion()
        {
            objetoOcupacion.Nombre = txtOcupacionNombre.Text;
            if (radioOcupacionActivo.Checked)
            {
                objetoOcupacion.Estado = 1;
            }
            else
            {
                objetoOcupacion.Estado = 0;
            }


            if (validarNombreOcupacion())
            {
                if (validarEstadoOcupacion())
                {
                    if (logicaOcupacion.insertarOcupacion(objetoOcupacion))
                    {
                        msm.tipoMensaje("Se ha ingresado la ocupación correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado la ocupación correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarOcupacion();
                        cargarcombox();
                        dataOcupacion.DataSource = logicaOcupacion.cargarOcupacion("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloOcupacion.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioOcupacionActivo, "El estado de la ocupación no puede estar vacío");
                    //MessageBox.Show(this, "El estado de la ocupación no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
               // MessageBox.Show(this, "El campo del nombre de la ocupación no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtOcupacionNombre, "El campo del nombre de la ocupación no puede estar vacío");
            }

        }

        private void modificarOcupacion()
        {
            objetoOcupacion.IdOcupacion = int.Parse(modeloOcupacion.vector[0]);
            objetoOcupacion.Nombre = txtOcupacionNombre.Text;
            if (radioOcupacionActivo.Checked)
            {
                objetoOcupacion.Estado = 1;
            }
            else
            {
                objetoOcupacion.Estado = 0;
            }


            if (validarNombreOcupacion())
            {
                if (validarEstadoOcupacion())
                {
                    if (logicaOcupacion.modificarOcupacion(objetoOcupacion))
                    {
                        msm.tipoMensaje("Se ha actualizado la ocupación correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado la ocupación correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarOcupacion();
                        btnOcupacionGuardar.Visible = false;
                        cargarcombox();
                        dataOcupacion.DataSource = logicaOcupacion.cargarOcupacion("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloOcupacion.Error, "error");
                       // MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioOcupacionActivo, "El estado de la ocupación no puede estar vacío");
                    //MessageBox.Show(this, "El estado de la ocupación no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre de la ocupación no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtOcupacionNombre, "El campo del nombre de la ocupación no puede estar vacío");
            }
        }



        //TipoSeguro

        private bool validarNombreTipoSeguro()
        {
            if (txtTipoSeguroNombre.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarTipoSeguro()
        {
            txtTipoSeguroNombre.Text = "";
            radioTipoSeguroActivo.Checked = false;
            radioTipoSeguroInactivo.Checked = false;
        }

        private bool validarEstadoTipoSeguro()
        {
            if (radioTipoSeguroActivo.Checked || radioTipoSeguroInactivo.Checked)
            { return true; }
            else { return false; }
        }

        private void registrarTipoSeguro()
        {
            objetoTipoSeguro.Nombre = txtTipoSeguroNombre.Text;
            if (radioTipoSeguroActivo.Checked)
            {
                objetoTipoSeguro.Estado = 1;
            }
            else
            {
                objetoTipoSeguro.Estado = 0;
            }


            if (validarNombreTipoSeguro())
            {
                if (validarEstadoTipoSeguro())
                {
                    if (logicaTipoSeguro.insertarTipoSeguro(objetoTipoSeguro))
                    {
                        msm.tipoMensaje("Se ha ingresado el tipo de seguro correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado el tipo de seguro correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoSeguro();
                        cargarcombox();
                        dataTipoSeguro.DataSource = logicaTipoSeguro.cargarTipoSeguro("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloTipoSeguro.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoSeguroActivo, "El estado del tipo de seguro no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de seguro no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
               // MessageBox.Show(this, "El campo del nombre del tipo de seguro no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtTipoSeguroNombre, "El campo del nombre del tipo de seguro no puede estar vacío");
            }

        }

        private void modificarTipoSeguro()
        {
            objetoTipoSeguro.IdTipoSeguro = int.Parse(modeloTipoSeguro.vector[0]);
            objetoTipoSeguro.Nombre = txtTipoSeguroNombre.Text;
            if (radioTipoSeguroActivo.Checked)
            {
                objetoTipoSeguro.Estado = 1;
            }
            else
            {
                objetoTipoSeguro.Estado = 0;
            }


            if (validarNombreTipoSeguro())
            {
                if (validarEstadoTipoSeguro())
                {
                    if (logicaTipoSeguro.modificarTipoSeguro(objetoTipoSeguro))
                    {
                        msm.tipoMensaje("Se ha actualizado el nombre del tipo de seguro correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado el nombre del tipo de seguro correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoSeguro();
                        btnTipoSeguroGuardar.Visible = false;
                        cargarcombox();
                        dataTipoSeguro.DataSource = logicaTipoSeguro.cargarTipoSeguro("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloTipoSeguro.Error, "error");
                       // MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoSeguroActivo, "El estado del tipo de seguro no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de seguro no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de seguro no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtTipoSeguroNombre, "El campo del nombre del tipo de seguro no puede estar vacío");
            }
        }

        private void btnTipoSeguroRegistrar_Click(object sender, EventArgs e)
        {
            registrarTipoSeguro();
        }

        private void btnTipoSeguroModificar_Click(object sender, EventArgs e)
        {
            if (txtTipoSeguroNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del tipo de seguro que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre del tipo de seguro que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreTipoSeguro = txtTipoSeguroNombre.Text;

                if (modeloTipoSeguro.BuscarTipoSeguro(nombreTipoSeguro))
                {
                    if (int.Parse(modeloTipoSeguro.vector[2]) == 0)
                    {
                        radioTipoSeguroInactivo.Select();
                    }
                    else
                    {
                        radioTipoSeguroActivo.Select();
                    }


                    btnTipoSeguroGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El nombre del tipo de seguro ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "El nombre del tipo de seguro a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTipoSeguroListar_Click(object sender, EventArgs e)
        {
            dataTipoSeguro.DataSource = logicaTipoSeguro.cargarTipoSeguro("configuracion");
        }

        private void btnTipoSeguroGuardar_Click(object sender, EventArgs e)
        {
            modificarTipoSeguro();
        }


        //Parentesco

        private bool validarNombreParentesco()
        {
            if (txtParentescoNombre.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarParentesco()
        {
            txtParentescoNombre.Text = "";
            radioParentescoActivo.Checked = false;
            radioParentescoInactivo.Checked = false;
        }

        private bool validarEstadoParentesco()
        {
            if (radioParentescoActivo.Checked || radioParentescoInactivo.Checked)
            { return true; }
            else { return false; }
        }

        private void registrarParentesco()
        {
            objetoParentesco.Nombre = txtParentescoNombre.Text;
            if (radioParentescoActivo.Checked)
            {
                objetoParentesco.Estado = 1;
            }
            else
            {
                objetoParentesco.Estado = 0;
            }


            if (validarNombreParentesco())
            {
                if (validarEstadoParentesco())
                {
                    if (logicaParentesco.insertarParentesco(objetoParentesco))
                    {
                        msm.tipoMensaje("Se ha ingresado el parentesco correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado el parentesco correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarParentesco();
                        cargarcombox();
                        dataParentesco.DataSource = logicaParentesco.cargarParentesco("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error" + modeloParentesco.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioParentescoActivo, "El estado del parentesco no puede estar vacío");
                    //MessageBox.Show(this, "El estado del parentesco no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del parentesco no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtParentescoNombre, "El campo del nombre del parentesco no puede estar vacío");

            }

        }

        private void modificarParentesco()
        {
            objetoParentesco.IdParentesco = int.Parse(modeloParentesco.vector[0]);
            objetoParentesco.Nombre = txtParentescoNombre.Text;
            if (radioParentescoActivo.Checked)
            {
                objetoParentesco.Estado = 1;
            }
            else
            {
                objetoParentesco.Estado = 0;
            }


            if (validarNombreParentesco())
            {
                if (validarEstadoParentesco())
                {
                    if (logicaParentesco.modificarParentesco(objetoParentesco))
                    {
                        msm.tipoMensaje("Se ha actualizado el nombre del parentesco correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado el nombre del parentesco correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarParentesco();
                        btnParentescoGuardar.Visible = false;
                        cargarcombox();
                        dataParentesco.DataSource = logicaParentesco.cargarParentesco("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloParentesco.Error, "error");
                        //MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioParentescoActivo, "El estado del parentesco no puede estar vacío");
                    //MessageBox.Show(this, "El estado del parentesco no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del parentesco no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtParentescoNombre, "El campo del nombre del parentesco no puede estar vacío");
            }
        }

        private void btnParentesco_Click(object sender, EventArgs e)
        {
            registrarParentesco();
        }

        private void btnParentescoModificar_Click(object sender, EventArgs e)
        {
            if (txtParentescoNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del parentesco que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre del parentesco que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreParentesco = txtParentescoNombre.Text;

                if (modeloParentesco.BuscarParentesco(nombreParentesco))
                {
                    if (int.Parse(modeloParentesco.vector[2]) == 0)
                    {
                        radioParentescoInactivo.Select();
                    }
                    else
                    {
                        radioParentescoActivo.Select();
                    }


                    btnParentescoGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El nombre del parentesco a modificar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "El nombre del parentesco a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnParentescoListar_Click(object sender, EventArgs e)
        {
            dataParentesco.DataSource = logicaParentesco.cargarParentesco("configuracion");
        }

        private void btnParentescoGuardar_Click(object sender, EventArgs e)
        {
            modificarParentesco();
        }


        //Cambio de letra a Mayuscula

        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }


        private void txtPaisNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtPaisNombre);
        }

        private void txtDepartamentoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtDepartamentoNombre);
        }

        private void txtCiudadNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtCiudadNombre);
        }

        private void txtAseguradoraNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtAseguradoraNombre);
        }

        private void txtEstadoCivilNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtEstadoCivilNombre);
        }

        private void txtOcupacionNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtOcupacionNombre);
        }

        private void txtTipoSeguroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtTipoSeguroNombre);
        }

        private void txtParentescoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtParentescoNombre);
        }
    }
}
