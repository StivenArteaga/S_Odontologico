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
    public partial class TipoSeguro : MaterialSkin.Controls.MaterialForm
    {
        public TipoSeguro()
        {
            InitializeComponent();
        }

        private void TipoSeguro_Load(object sender, EventArgs e)
        {

        }

        //MVC
        Modelo.TipoSeguro modeloTipoSeguro = new Modelo.TipoSeguro();
        Logica.TipoSeguro logicaTipoSeguro = new Logica.TipoSeguro();
        Objeto.TipoSeguro objetoTipoSeguro = new Objeto.TipoSeguro();

        Mensaje msm = new Mensaje();


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
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoSeguro();
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
                    error.SetError(radioTipoSeguroActivo,"El estado del tipo de seguro no puede estar vacío");
                   // MessageBox.Show(this, "El estado del tipo de seguro no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de seguro no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        msm.tipoMensaje("Se ha actualizado el tipo de seguro correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoSeguro();
                        btnTipoSeguroGuardar.Visible = false;
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
               // MessageBox.Show(this, "El campo del nombre del tipo de seguro no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(radioTipoSeguroActivo, "El campo del nombre del tipo de seguro no puede estar vacío");
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
                   // MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Cambio de tamaño de letra
        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }

        private void txtTipoSeguroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtTipoSeguroNombre);
        }
    }
}
