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
    public partial class Aseguradora : MaterialSkin.Controls.MaterialForm
    {
        public Aseguradora()
        {
            InitializeComponent();
        }

        private void Aseguradora_Load(object sender, EventArgs e)
        {

        }

        //MVC 
        Modelo.Aseguradora modeloAseguradora = new Modelo.Aseguradora();
        Logica.Aseguradora logicaAseguradora = new Logica.Aseguradora();
        Objeto.Aseguradora objetoAseguradora = new Objeto.Aseguradora();

        Mensaje msm = new Mensaje();

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
               // MessageBox.Show(this, "", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    msm.tipoMensaje("La aseguradora ha actualizar no se encuentra registrada", "warning");
                    //MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAseguradoraListar_Click(object sender, EventArgs e)
        {
            dataAseguradora.DataSource = logicaAseguradora.cargarAseguradora("configuracion");
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
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarAseguradora();
                        dataAseguradora.DataSource = logicaAseguradora.cargarAseguradora("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error" + modeloAseguradora.Error, "Error");
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
                error.SetError(txtAseguradoraNombre, "El campo del nombre de la aseguradora no puede estar vacío");
               // MessageBox.Show(this, "El campo del nombre de la aseguradora no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                        dataAseguradora.DataSource = logicaAseguradora.cargarAseguradora("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("No se ha actualizado " + modeloAseguradora.Error, "error");
                        //MessageBox.Show(this, "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAseguradoraGuardar_Click(object sender, EventArgs e)
        {
            modificarAseguradora();
        }

        //Cambiar tamaño de letra
        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }
        
        private void txtAseguradoraNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtAseguradoraNombre);
        }
    }
}
