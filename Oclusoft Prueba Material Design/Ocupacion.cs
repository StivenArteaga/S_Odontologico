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
    public partial class Ocupacion : MaterialSkin.Controls.MaterialForm
    {
        public Ocupacion()
        {
            InitializeComponent();
        }

        private void Ocupacion_Load(object sender, EventArgs e)
        {

        }

        Mensaje msm = new Mensaje();

        //MVC
        Modelo.Ocupacion modeloOcupacion = new Modelo.Ocupacion();
        Logica.Ocupacion logicaOcupacion = new Logica.Ocupacion();
        Objeto.Ocupacion objetoOcupacion = new Objeto.Ocupacion();


       

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
                //MessageBox.Show(this, "Por favor ", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    msm.tipoMensaje("La ocupación ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarOcupacion();
                        dataOcupacion.DataSource = logicaOcupacion.cargarOcupacion("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloOcupacion.Error, "error");
                       // MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        dataOcupacion.DataSource = logicaOcupacion.cargarOcupacion("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloOcupacion.Error, "error");
                        //MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        //Cambiar tamaño de letra
        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }
        
        private void txtOcupacionNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtOcupacionNombre);
        }
    }
}
