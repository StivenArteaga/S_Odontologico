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
    public partial class GrupoSanguineo : MaterialSkin.Controls.MaterialForm
    {
        public GrupoSanguineo()
        {
            InitializeComponent();
        }

        private void GrupoSanguineo_Load(object sender, EventArgs e)
        {

        }

        //MCV
        Modelo.GrupoSanguineo modeloGrupoSanguineo = new Modelo.GrupoSanguineo();
        Logica.GrupoSanguineo logicaGrupoSanguineo = new Logica.GrupoSanguineo();
        Objeto.GrupoSanguineo objetoGrupoSanguineo = new Objeto.GrupoSanguineo();

        Mensaje msm = new Mensaje();


        //Grupo sanguineo

        private bool validarNombreGrupoSanguineo()
        {
            if (txtGrupoSanguineoNombre.Text == "")
            { return false; }
            else { return true; }
        }

        private void limpiarGrupoSanguineo()
        {
            txtGrupoSanguineoNombre.Text = "";
            radioGrupoSanguineoActivo.Checked = false;
            radioGrupoSanguineoInactivo.Checked = false;
        }

        private bool validarEstadoGrupoSanguineo()
        {
            if (radioGrupoSanguineoActivo.Checked || radioGrupoSanguineoInactivo.Checked)
            { return true; }
            else { return false; }
        }

        private void btnGrupoSanguineoRegistrar_Click(object sender, EventArgs e)
        {
            registrarGrupoSanguineo();
        }

        private void btnGrupoSanguineoModificar_Click(object sender, EventArgs e)
        {
            if (txtGrupoSanguineoNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del grupo sanguíneo que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreGrupoSanguineo = txtGrupoSanguineoNombre.Text;

                if (modeloGrupoSanguineo.BuscarGrupoSanguineo(nombreGrupoSanguineo))
                {
                    if (int.Parse(modeloGrupoSanguineo.vector[2]) == 0)
                    {
                        radioGrupoSanguineoInactivo.Select();
                    }
                    else
                    {
                        radioGrupoSanguineoActivo.Select();
                    }


                    btnGrupoSanguineoGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El grupo sanguíneo ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGrupoSanguineoListar_Click(object sender, EventArgs e)
        {
            dataGrupoSanguineo.DataSource = logicaGrupoSanguineo.cargarGrupoSanguineo("configuracion");
        }

        private void btnGrupoSanguineoGuardar_Click(object sender, EventArgs e)
        {
            modificarGrupoSanguineo();
        }

        private void registrarGrupoSanguineo()
        {
            objetoGrupoSanguineo.Nombre = txtGrupoSanguineoNombre.Text;
            if (radioGrupoSanguineoActivo.Checked)
            {
                objetoGrupoSanguineo.Estado = 1;
            }
            else
            {
                objetoGrupoSanguineo.Estado = 0;
            }


            if (validarNombreGrupoSanguineo())
            {
                if (validarEstadoGrupoSanguineo())
                {
                    if (logicaGrupoSanguineo.insertarGrupoSanguineo(objetoGrupoSanguineo))
                    {
                        msm.tipoMensaje("Se ha ingresado el grupo sanguíneo correctamente", "warning");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarGrupoSanguineo();
                        dataGrupoSanguineo.DataSource = logicaGrupoSanguineo.cargarGrupoSanguineo("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloGrupoSanguineo.Error, "error");
                       // MessageBox.Show(this, "No se ha insertado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioGrupoSanguineoActivo, "El campo del nombre del grupo sanguíneo no puede estar vacío");
                    //MessageBox.Show(this, "El estado del grupo sanguineo no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del grupo sanguineo no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtGrupoSanguineoNombre, "El campo del nombre del grupo sanguíneo no puede estar vacío");
            }

        }

        private void modificarGrupoSanguineo()
        {
            objetoGrupoSanguineo.IdGrupoSanguineo = int.Parse(modeloGrupoSanguineo.vector[0]);
            objetoGrupoSanguineo.Nombre = txtGrupoSanguineoNombre.Text;
            if (radioGrupoSanguineoActivo.Checked)
            {
                objetoGrupoSanguineo.Estado = 1;
            }
            else
            {
                objetoGrupoSanguineo.Estado = 0;
            }


            if (validarNombreGrupoSanguineo())
            {
                if (validarEstadoGrupoSanguineo())
                {
                    if (logicaGrupoSanguineo.modificarGrupoSanguineo(objetoGrupoSanguineo))
                    {
                        msm.tipoMensaje("Se ha actualizado el grupo sanguíneo correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarGrupoSanguineo();
                        btnGrupoSanguineoGuardar.Visible = false;
                        dataGrupoSanguineo.DataSource = logicaGrupoSanguineo.cargarGrupoSanguineo("configuracion");

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloGrupoSanguineo.Error, "error");
                       // MessageBox.Show(this, "No se ha modificado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioGrupoSanguineoActivo, "El estado del grupo sanguíneo no puede estar vacío");
                    //MessageBox.Show(this, "El estado del grupo sanguineo no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
               // MessageBox.Show(this, "El campo del nombre del grupo sanguineo no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtGrupoSanguineoNombre, "El campo del nombre del grupo sanguíneo no puede estar vacío");
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

        private void txtGrupoSanguineoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != '+' ) && (e.KeyChar != '-'))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtGrupoSanguineoNombre);
        }
    }
}
