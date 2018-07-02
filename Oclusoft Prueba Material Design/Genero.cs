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
    public partial class Generos : MaterialSkin.Controls.MaterialForm
    {
        public Generos()
        {
            InitializeComponent();
        }

        private void Genero_Load(object sender, EventArgs e)
        {

        }

        //MVC
        Modelo.Genero modeloGenero = new Modelo.Genero();
        Logica.Genero logicaGenero = new Logica.Genero();
        Objeto.Genero objetoGenero = new Objeto.Genero();

        Mensaje msm = new Mensaje();


        // Generos

        private bool validarNombreGenero()
        {
            if (txtGeneroNombre.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarGenero()
        {
            txtGeneroNombre.Text = "";
            radioGeneroActivo.Checked = false;
            radioGeneroInactivo.Checked = false;
        }

        private bool validarEstadoGenero()
        {
            if (radioGeneroActivo.Checked || radioGeneroInactivo.Checked)
            { return true; }
            else { return false; }
        }

        private void btnGeneroRegistrar_Click(object sender, EventArgs e)
        {
            registrarGenero();
        }

        private void btnGeneroModificar_Click(object sender, EventArgs e)
        {
            if (txtGeneroNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del género que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreGenero = txtGeneroNombre.Text;

                if (modeloGenero.BuscarGenero(nombreGenero))
                {
                    if (int.Parse(modeloGenero.vector[2]) == 0)
                    {
                        radioGeneroInactivo.Select();
                    }
                    else
                    {
                        radioGeneroActivo.Select();
                    }


                    btnGeneroGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El género ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGeneroListar_Click(object sender, EventArgs e)
        {
            dataGenero.DataSource = logicaGenero.cargarGenero("configuracion");
        }

        private void btnGeneroGuardar_Click(object sender, EventArgs e)
        {
            modificarGenero();
        }

        private void registrarGenero()
        {

            objetoGenero.Nombre = txtGeneroNombre.Text;
            if (radioGeneroActivo.Checked)
            {
                objetoGenero.Estado = 1;
            }
            else
            {
                objetoGenero.Estado = 0;
            }


            if (validarNombreGenero())
            {
                if (validarEstadoGenero())
                {
                    if (logicaGenero.insertarGenero(objetoGenero))
                    {
                        msm.tipoMensaje("Se ha ingresado el género correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarGenero();
                        dataGenero.DataSource = logicaGenero.cargarGenero("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloGenero.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloGenero.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioGeneroActivo, "El estado del género no puede estar vacío");
                   // MessageBox.Show(this, "El estado del genero no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del genero no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtGeneroNombre, "El campo del nombre del género no puede estar vacío");
            }

        }

        private void modificarGenero()
        {
            objetoGenero.IdGenero = int.Parse(modeloGenero.vector[0]);
            objetoGenero.Nombre = txtGeneroNombre.Text;
            if (radioGeneroActivo.Checked)
            {
                objetoGenero.Estado = 1;
            }
            else
            {
                objetoGenero.Estado = 0;
            }


            if (validarNombreGenero())
            {
                if (validarEstadoGenero())
                {
                    if (logicaGenero.modificarGenero(objetoGenero))
                    {
                        msm.tipoMensaje("Se ha actualizado el género correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarGenero();
                        btnGeneroGuardar.Visible = false;
                        dataGenero.DataSource = logicaGenero.cargarGenero("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloGenero.Error, "error");
                        //MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioGeneroActivo, "El estado del genero no puede estar vacío");
                   // MessageBox.Show(this, "El estado del genero no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del genero no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtGeneroNombre, "El campo del nombre del genero no puede estar vacío");
            }
        }


        // CAmbio de letra a mayuscula
        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }

        private void txtGeneroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtGeneroNombre);

        }
    }
}
