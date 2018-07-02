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
    public partial class Pais : MaterialSkin.Controls.MaterialForm
    {
        public Pais()
        {
            InitializeComponent();
        }

        private void Pais_Load(object sender, EventArgs e)
        {

        }


        //MVC

        Modelo.Pais modeloPais = new Modelo.Pais();
        Logica.Pais logicaPais = new Logica.Pais();
        Objeto.Pais objectoPais = new Objeto.Pais();

        Mensaje msm = new Mensaje();


        private void btnPaisRegistrar_Click(object sender, EventArgs e)
        {
            registrarPais();
        }

        private void registrarPais()
        {
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
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarPais();
                        dataPais.DataSource = logicaPais.cargarPais("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloPais.Error, "error");
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
               // MessageBox.Show(this, "El campo del nombre del pais no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtPaisNombre, "El campo del país no puede estar vacío");
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
                        MessageBox.Show(this, "Se ha actualizado el pais correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarPais();
                        btnPaisGuardar.Visible = false;
                        dataPais.DataSource = logicaPais.cargarPais("configuracion");

                    }
                    else
                    {
                        MessageBox.Show(this, "No se ha insertado " + modeloPais.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioPaisActivo, "El estado del país no puede estar vacío");
                   // MessageBox.Show(this, "El estado del país no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del pais no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(radioPaisActivo, "El campo del nombre del país no puede estar vacío");
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

        private void txtPaisNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatos(e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtPaisNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del país que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    msm.tipoMensaje("El país ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPaisGuardar_Click(object sender, EventArgs e)
        {
            modificarPais();
        }

        private void btnPaisListar_Click(object sender, EventArgs e)
        {
             dataPais.DataSource = logicaPais.cargarPais("configuracion");
        }

        public void validarIngresoDatos(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        //Cambio de tamaño de  letra
        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }
        
        private void txtPaisNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
             
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtPaisNombre);
        }
    }
}
