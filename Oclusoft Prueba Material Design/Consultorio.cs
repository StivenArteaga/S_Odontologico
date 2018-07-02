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
    public partial class Consultorio : MaterialSkin.Controls.MaterialForm
    {
        public Consultorio()
        {
            InitializeComponent();
        }




        //MVC
        Modelo.Consultorio modeloConsultorio = new Modelo.Consultorio();
        Logica.Consultorio logicaConsultorio = new Logica.Consultorio();
        Objeto.Consultorio objetoConsultorio = new Objeto.Consultorio();


        Mensaje msm = new Mensaje();

        //Consultorio

        private bool validarNombreConsultorio()
        {
            if (txtConsultorioDescripcion.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarConsultorio()
        {
            txtConsultorioDescripcion.Text = "";
            radioConsultorioActivo.Checked = false;
            radioConsultorioInactivo.Checked = false;
        }

        private bool validarEstadoConsultorio()
        {
            if (radioConsultorioActivo.Checked || radioConsultorioInactivo.Checked)
            { return true; }
            else { return false; }
        }

        private void btnConsultorioRegistrar_Click(object sender, EventArgs e)
        {
            registrarConsultorio();
        }

        private void btnConsultorioModificar_Click(object sender, EventArgs e)
        {
            if (txtConsultorioDescripcion.Text == "")
            {
                msm.tipoMensaje("Ingrese el número del consultorio que desea buscar", "warning");
               // MessageBox.Show(this, "Por favor ingrese el número del consultorio que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreConsultorio = txtConsultorioDescripcion.Text;

                if (modeloConsultorio.BuscarConsultorio(nombreConsultorio))
                {
                    if (int.Parse(modeloConsultorio.vector[2]) == 0)
                    {
                        radioConsultorioInactivo.Select();
                    }
                    else
                    {
                        radioConsultorioActivo.Select();
                    }


                    btnConsultorioGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El número del consultorio ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnConsultorioListar_Click(object sender, EventArgs e)
        {
            dataConsultorio.DataSource = logicaConsultorio.cargarConsultorio("configuracion");
        }

        private void btnConsultorioGuardar_Click(object sender, EventArgs e)
        {
            modificarConsultorio();
        }
        
        private void registrarConsultorio()
        {
            objetoConsultorio.Descripcion = txtConsultorioDescripcion.Text;
            if (radioConsultorioActivo.Checked)
            {
                objetoConsultorio.Estado = 1;
            }
            else
            {
                objetoConsultorio.Estado = 0;
            }


            if (validarNombreConsultorio())
            {
                if (validarEstadoConsultorio())
                {
                    if (logicaConsultorio.insertarConsultorio(objetoConsultorio))
                    {
                        msm.tipoMensaje("Se ha ingresado el número del consultorio correctamente", "done");
                       // MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarConsultorio();
                        dataConsultorio.DataSource = logicaConsultorio.cargarConsultorio("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error al insertar " + modeloConsultorio.Error, "error");
                       // MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioConsultorioActivo, "El estado del consultorio no puede estar vacío");
                    //MessageBox.Show(this, "El estado del consultorio no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
               // MessageBox.Show(this, "El campo del número del consultorio no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtConsultorioDescripcion, "El campo del número del consultorio no puede estar vacío");
            }

        }

        private void modificarConsultorio()
        {
            objetoConsultorio.IdConsultorio = int.Parse(modeloConsultorio.vector[0]);
            objetoConsultorio.Descripcion = txtConsultorioDescripcion.Text;
            if (radioConsultorioActivo.Checked)
            {
                objetoConsultorio.Estado = 1;
            }
            else
            {
                objetoConsultorio.Estado = 0;
            }


            if (validarNombreConsultorio())
            {
                if (validarEstadoConsultorio())
                {
                    if (logicaConsultorio.modificarConsultorio(objetoConsultorio))
                    {
                        msm.tipoMensaje("Se ha actualizado el número del consultorio correctamente", "done");
                       // MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarConsultorio();
                        btnConsultorioGuardar.Visible = false;
                        dataConsultorio.DataSource = logicaConsultorio.cargarConsultorio("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Eror " + modeloConsultorio.Error, "error");
                        //MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioConsultorioActivo, "El estado del consultorio no puede estar vacío");
                    //MessageBox.Show(this, "El estado del consultorio no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
               // MessageBox.Show(this, "El campo del número del consultorio no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtConsultorioDescripcion, "El campo del número del consultorio no puede estar vacío");
            }
        }


        //Cambiar tamaño de la letra

        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }
        
        private void txtConsultorioDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtConsultorioDescripcion);
        }
    }
}
