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
    public partial class Ciudad : MaterialSkin.Controls.MaterialForm
    {
        public Ciudad()
        {
            InitializeComponent();
        }

        private void Ciudad_Load(object sender, EventArgs e)
        {
            cargarcombox();
        }

        //MCV
        Modelo.Ciudad modeloCiudad = new Modelo.Ciudad();
        Logica.Ciudad logicaCiudad = new Logica.Ciudad();
        Objeto.Ciudad objetoCiudad = new Objeto.Ciudad();


        Mensaje msm = new Mensaje();


        // Ciudad 

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

        private void btnCiudadRegistrar_Click(object sender, EventArgs e)
        {
            registrarCiudad();
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
                        msm.tipoMensaje("No se ha ingresado " + modeloCiudad.Error, "Error");
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

        private void btnCiudadModificar_Click(object sender, EventArgs e)
        {
            if (txtCiudadNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre de la ciudad que desea buscar", "warning");
                //MessageBox.Show(this, "", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        msm.tipoMensaje("No se ha actualizado " + modeloCiudad.Error, "error");
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
                //MessageBox.Show(this, "El campo del nombre de la ciudad no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(radioCiudadActivo, "El campo del nombre de la ciudad no puede estar vacío");
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

        public void cargarcombox()
        {
            //Ciudad
            comboidDepartamento.ValueMember = "idDepartamento";
            comboidDepartamento.DisplayMember = "nombre";
            comboidDepartamento.DataSource = modeloCiudad.cargarNombreDepartamento();
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
        
        private void txtCiudadNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtCiudadNombre);
        }
    }
}
