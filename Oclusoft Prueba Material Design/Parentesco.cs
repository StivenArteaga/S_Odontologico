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
    public partial class Parentesco : MaterialSkin.Controls.MaterialForm
    {
        public Parentesco()
        {
            InitializeComponent();
        }

        private void Parentesco_Load(object sender, EventArgs e)
        {

        }

        Mensaje msm = new Mensaje();

        //MVC
        Modelo.Parentesco modeloParentesco = new Modelo.Parentesco();
        Logica.Parentesco logicaParentesco = new Logica.Parentesco();
        Objeto.Parentesco objetoParentesco = new Objeto.Parentesco();



        //Parentesco


        private bool validarNombreParentesco()
        {
            if (txtParentescoNombre.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarParentesco()
        {
            txtParentescoNombre.Text = "";
            radioParentescoActivo.Checked = false;
            radioParentescoInactivo.Checked = false;
        }

        private bool validarEstadoParentesco()
        {
            if (radioParentescoActivo.Checked || radioParentescoInactivo.Checked)
            { return true; }
            else { return false; }
        }

        private void registrarParentesco()
        {
            objetoParentesco.Nombre = txtParentescoNombre.Text;
            if (radioParentescoActivo.Checked)
            {
                objetoParentesco.Estado = 1;
            }
            else
            {
                objetoParentesco.Estado = 0;
            }


            if (validarNombreParentesco())
            {
                if (validarEstadoParentesco())
                {
                    if (logicaParentesco.insertarParentesco(objetoParentesco))
                    {
                        msm.tipoMensaje("Se ha ingresado el parentesco correctamente", "done");
                       // MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarParentesco();
                        dataParentesco.DataSource = logicaParentesco.cargarParentesco("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error al ingresar " + modeloParentesco.Error, "error");
                       // MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioParentescoActivo, "El estado del parentesco no puede estar vacío");
                   // MessageBox.Show(this, "El estado del parentesco no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
               // MessageBox.Show(this, "El campo del nombre del parentesco no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtParentescoNombre, "El campo del nombre del parentesco no puede estar vacío");
            }

        }

        private void modificarParentesco()
        {
            objetoParentesco.IdParentesco = int.Parse(modeloParentesco.vector[0]);
            objetoParentesco.Nombre = txtParentescoNombre.Text;
            if (radioParentescoActivo.Checked)
            {
                objetoParentesco.Estado = 1;
            }
            else
            {
                objetoParentesco.Estado = 0;
            }


            if (validarNombreParentesco())
            {
                if (validarEstadoParentesco())
                {
                    if (logicaParentesco.modificarParentesco(objetoParentesco))
                    {
                        msm.tipoMensaje("Se ha actualizado la información del parentesco correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarParentesco();
                        btnParentescoGuardar.Visible = false;
                        dataParentesco.DataSource = logicaParentesco.cargarParentesco("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloParentesco.Error, "error");
                       // MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioParentescoActivo, "El estado del parentesco no puede estar vacío");
                    //MessageBox.Show(this, "El estado del parentesco no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del parentesco no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtParentescoNombre, "El campo del nombre del parentesco no puede estar vacío");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            registrarParentesco();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtParentescoNombre.Text == "")
            {
                 msm.tipoMensaje("Ingrese el nombre del parentesco que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre del parentesco que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreParentesco = txtParentescoNombre.Text;

                if (modeloParentesco.BuscarParentesco(nombreParentesco))
                {
                    if (int.Parse(modeloParentesco.vector[2]) == 0)
                    {
                        radioParentescoInactivo.Select();
                    }
                    else
                    {
                        radioParentescoActivo.Select();
                    }


                    btnParentescoGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El nombre del parentesco ha actualizar no se encuentra registrado", "warning");
                    MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataParentesco.DataSource = logicaParentesco.cargarParentesco("configuracion");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modificarParentesco();
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
        
        private void txtParentescoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtParentescoNombre);
        }
    }
}
