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
    public partial class TipoDocumento : MaterialSkin.Controls.MaterialForm
    {
        public TipoDocumento()
        {
            InitializeComponent();
        }

        private void TipoDocumento_Load(object sender, EventArgs e)
        {

        }

        //MVC
        Modelo.TipoDocumento modeloTipoDocumento = new Modelo.TipoDocumento();
        Logica.TipoDocumento logicaTipoDocumento = new Logica.TipoDocumento();
        Objeto.TipoDocumento objetoTipoDocumento = new Objeto.TipoDocumento();

        Mensaje msm = new Mensaje();


        //TipoDocumento

        private bool validarNombreTipoDocumento()
        {
            if (txtTipoDocumentoNombre.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarTipoDocumento()
        {
            txtTipoDocumentoNombre.Text = "";
            radioTipoDocumentoActivo.Checked = false;
            radioTipoDocumentoInactivo.Checked = false;
        }

        private bool validarEstadoTipoDocumento()
        {
            if (radioTipoDocumentoActivo.Checked || radioTipoDocumentoInactivo.Checked)
            { return true; }
            else { return false; }
        }

        private void btnTipoDocumentoRegistrar_Click(object sender, EventArgs e)
        {
            registrarTipoDocumento();
        }

        private void btnTipoDocumentoModificar_Click(object sender, EventArgs e)
        {
            if (txtTipoDocumentoNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del tipo de documento que desea buscar", "warning");
               // MessageBox.Show(this, "Por favor i", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreTipoDocumento = txtTipoDocumentoNombre.Text;

                if (modeloTipoDocumento.BuscarTipoDocumento(nombreTipoDocumento))
                {
                    if (int.Parse(modeloTipoDocumento.vector[2]) == 0)
                    {
                        radioTipoDocumentoInactivo.Select();
                    }
                    else
                    {
                        radioTipoDocumentoActivo.Select();
                    }


                    btnTipoDocumentoGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El tipo de documento ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTipoDocumentoListar_Click(object sender, EventArgs e)
        {
            dataTipoDocumento.DataSource = logicaTipoDocumento.cargarTipoDocumento("configuracion");
        }

        private void btnTipoDocumentoGuardar_Click(object sender, EventArgs e)
        {
            modificarTipoDocumento();
        }

        private void registrarTipoDocumento()
        {
            objetoTipoDocumento.Nombre = txtTipoDocumentoNombre.Text;
            if (radioTipoDocumentoActivo.Checked)
            {
                objetoTipoDocumento.Estado = 1;
            }
            else
            {
                objetoTipoDocumento.Estado = 0;
            }


            if (validarNombreTipoDocumento())
            {
                if (validarEstadoTipoDocumento())
                {
                    if (logicaTipoDocumento.insertarTipoDocumento(objetoTipoDocumento))
                    {
                        msm.tipoMensaje("Se ha ingresado el tipo de documento correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoDocumento();
                        dataTipoDocumento.DataSource = logicaTipoDocumento.cargarTipoDocumento("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloTipoDocumento.Error, "error");
                       // MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoDocumentoActivo, "El estado del tipo de documento no puede estar vacío");
                   // MessageBox.Show(this, "El estado del tipo de documento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de documento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtTipoDocumentoNombre, "El campo del nombre del tipo de documento no puede estar vacío");
            }

        }

        private void modificarTipoDocumento()
        {
            objetoTipoDocumento.IdTipoDocumento = int.Parse(modeloTipoDocumento.vector[0]);
            objetoTipoDocumento.Nombre = txtTipoDocumentoNombre.Text;
            if (radioTipoDocumentoActivo.Checked)
            {
                objetoTipoDocumento.Estado = 1;
            }
            else
            {
                objetoTipoDocumento.Estado = 0;
            }


            if (validarNombreTipoDocumento())
            {
                if (validarEstadoTipoDocumento())
                {
                    if (logicaTipoDocumento.modificarTipoDocumento(objetoTipoDocumento))
                    {
                        msm.tipoMensaje("Se ha actualizado el tipo de documento correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoDocumento();
                        btnTipoDocumentoGuardar.Visible = false;
                        dataTipoDocumento.DataSource = logicaTipoDocumento.cargarTipoDocumento("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloTipoDocumento.Error, "error");
                      // MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoDocumentoActivo, "El estado del tipo de documento no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de documento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de documento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtTipoDocumentoNombre, "El campo del nombre del tipo de documento no puede estar vacío");
            }
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
        
        private void txtTipoDocumentoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtTipoDocumentoNombre);
        }
    }
}
