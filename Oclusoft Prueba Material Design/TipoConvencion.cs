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
    public partial class TipoConvencion : MaterialSkin.Controls.MaterialForm
    {
        public TipoConvencion()
        {
            InitializeComponent();
        }


        Mensaje msm = new Mensaje();
        //MVC
        Modelo.TipoConvencion modeloTipoConvencion = new Modelo.TipoConvencion();
        Objeto.TipoConvencion objetoTipoConvencion = new Objeto.TipoConvencion();
        Logica.TipoConvencion logicaTipoConvencion = new Logica.TipoConvencion();


        private void TipoConvencion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBuscarConvencion_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

            if (imagen.ShowDialog() == DialogResult.OK)
            {
                pictureConvencion.ImageLocation = imagen.FileName;
                lblRuta.Text = imagen.FileName;
               
            }

        }

        private void btnGuardarConvencion_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (txtNombreConvencion.Text == "")
            {
                error.SetError(txtNombreConvencion, "El campo esta vacío");
            }
            else
            {
                if (lblRuta.Text == "")
                {
                    error.SetError(pictureConvencion, "Selecciona una imagen para la convención");
                }
                else
                {
                    if (!radioActivoTipoConvencion.Checked && !radioInactivoTipoConvencion.Checked)
                    {
                        error.SetError(radioActivoTipoConvencion, "Selecciona el estado de la convención");
                    }
                    else
                    {
                         try
                        {
                            if (radioActivoTipoConvencion.Checked)
                            {
                                objetoTipoConvencion.Estado = 1;
                            }
                            else
                            {
                                objetoTipoConvencion.Estado = 0;
                            }
                            objetoTipoConvencion.Nombre = txtNombreConvencion.Text;
                            objetoTipoConvencion.Simbolo = lblRuta.Text;

                            if (logicaTipoConvencion.insertarTipoConvencion(objetoTipoConvencion))
                            {
                                msm.tipoMensaje("El registro se ha guardado con éxito", "done");
                                limpiar();
                            }
                            else
                            {
                                msm.tipoMensaje("Error " + modeloTipoConvencion.Error, "error");
                            }
                        }
                        catch (Exception xe)
                        {
                            msm.tipoMensaje("Error " + xe.Message, "error");
                        }
                    }
                   
                }
            }
        }

        private void limpiar()
        {
            txtNombreConvencion.Text = "";
            pictureConvencion.Image = null;
            lblRuta.Text = "";
            lblCodigoTipoConvencion.Text = "";
            radioActivoTipoConvencion.Select();
            error.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();  
        }

        private void btnBuscarTipoConvencion_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = "";
                if (txtNombreConvencion.Text != "")
                {

                    string nombre = txtNombreConvencion.Text;
                    if (modeloTipoConvencion.BuscarTipoConvencion(nombre))
                    {
                        lblCodigoTipoConvencion.Text = modeloTipoConvencion.vector[0];
                        txtNombreConvencion.Text =  modeloTipoConvencion.vector[1];
                        OpenFileDialog imagen = new OpenFileDialog();
                        lblRuta.Text = modeloTipoConvencion.vector[2];
                        ruta = lblRuta.Text;
                        imagen.FileName = lblRuta.Text;
                        pictureConvencion.ImageLocation = imagen.FileName;
                        if (int.Parse(modeloTipoConvencion.vector[3]) == 1)
                        {
                            radioActivoTipoConvencion.Select();
                        }
                        else
                        {
                            radioInactivoTipoConvencion.Select();
                        }
             
                    }
                    else
                    {
                        msm.tipoMensaje("El nombre " + (txtNombreConvencion.Text.ToString()) + " no existe", "warning");
                        
                    }

                }
                else
                {
                    msm.tipoMensaje("El nombre de la convención esta vacío", "warning");
                }
            }
            catch (Exception ex)
            {
                msm.tipoMensaje("Error " + ex.Message, "error");

            }

        }

        private void txtNombreConvencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtNombreConvencion);
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

        private void btnModificarTipoConvencion_Click(object sender, EventArgs e)
        {

            error.Clear();
            if (txtNombreConvencion.Text == "")
            {
                error.SetError(txtNombreConvencion, "El campo esta vacío");
            }
            else
            {
                if (lblRuta.Text == "")
                {
                    error.SetError(pictureConvencion, "Selecciona una imagen para la convención");
                }
                else
                {
                    if (!radioActivoTipoConvencion.Checked && !radioInactivoTipoConvencion.Checked)
                    {
                        error.SetError(radioActivoTipoConvencion, "Selecciona el estado de la convención");
                    }
                    else
                    {
                        try
                        {
                            if (radioActivoTipoConvencion.Checked)
                            {
                                objetoTipoConvencion.Estado = 1;
                            }
                            else
                            {
                                objetoTipoConvencion.Estado = 0;
                            }
                            objetoTipoConvencion.IdTipoConvencion = int.Parse(lblCodigoTipoConvencion.Text);
                            objetoTipoConvencion.Nombre = txtNombreConvencion.Text;
                            objetoTipoConvencion.Simbolo = lblRuta.Text;

                            if (logicaTipoConvencion.modificarTipoConvencion(objetoTipoConvencion))
                            {
                                msm.tipoMensaje("El registro se ha actualizado con éxito", "done");
                                limpiar();
                            }
                            else
                            {
                                msm.tipoMensaje("Error " + modeloTipoConvencion.Error, "error");
                            }
                        }
                        catch (Exception xe)
                        {
                            msm.tipoMensaje("Error " + xe.Message, "error");
                        }
                    }

                }
            }


        }
    }
}
