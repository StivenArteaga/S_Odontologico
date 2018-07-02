using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Oclusoft_Prueba_Material_Design
{
    public partial class EstadoCivil : MaterialSkin.Controls.MaterialForm
    {
        public EstadoCivil()
        {
            InitializeComponent();
        }

        private void EstadoCivil_Load(object sender, EventArgs e)
        {

        }

        //MVC
        Modelo.EstadoCivil modeloEstadoCivil = new Modelo.EstadoCivil();
        Logica.EstadoCivil logicaEstadoCivil = new Logica.EstadoCivil();
        Objeto.EstadoCivil objetoEstadoCivil = new Objeto.EstadoCivil();

        Mensaje msm = new Mensaje();


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
                //MessageBox.Show(this, "Por favor ", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarEstadoCivil();
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
                    error.SetError(txtEstadoCivilNombre, "El estado del estado civil no puede estar vacío");
                    //MessageBox.Show(this, "El estado del estado civil no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del estado civil no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtEstadoCivilNombre, "El campo del nombre del estado civil no puede estar vacío");
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
                        msm.tipoMensaje("Se ha ingresado el estado civil correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarEstadoCivil();
                        btnEstadoCivilGuardar.Visible = false;
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
                error.SetError(txtEstadoCivilNombre, "El campo del nombre del estado civil no puede estar vacío");
            }
        }


        //Cambio de tamaño de letra 

        private void txtEstadoCivilNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtEstadoCivilNombre);
        }

        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }

    }
}
