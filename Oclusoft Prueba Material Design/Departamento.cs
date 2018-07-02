using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Oclusoft_Prueba_Material_Design
{
    public partial class Departamento : MaterialSkin.Controls.MaterialForm
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void Departamento_Load(object sender, EventArgs e)
        {
            cargarcombox();
        }

        //MVC
        Modelo.Departamento modeloDepartamento = new Modelo.Departamento();
        Logica.Departamento logicaDepartamento = new Logica.Departamento();
        Objeto.Departamento objetoDepartamento = new Objeto.Departamento();

        Mensaje msm = new Mensaje();


        // Departamento


        private void limpiarDepartamento()
        {
            txtDepartamentoNombre.Text = "";
            radioDepartamentoActivo.Checked = false;
            radioDepartamentoInactivo.Checked = false;
        }

        private bool validarEstadoDepartamento()
        {
            if (radioDepartamentoActivo.Checked || radioDepartamentoInactivo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void modificarDepartamento()
        {
            objetoDepartamento.IdDepartamento = int.Parse(modeloDepartamento.vector[0]);
            objetoDepartamento.Nombre = txtDepartamentoNombre.Text;
            if (radioDepartamentoActivo.Checked)
            {
                objetoDepartamento.Estado = 1;
            }
            else
            {
                objetoDepartamento.Estado = 0;
            }


            if (validarNombreDepartamento())
            {
                if (validarEstadoDepartamento())
                {
                    objetoDepartamento.IdPais = int.Parse(comboidPais.SelectedValue.ToString());
                    if (logicaDepartamento.modificarDepartamento(objetoDepartamento))
                    {
                        msm.tipoMensaje("Se ha actualizado el departamento correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarDepartamento();
                        cargarcombox();
                        btnDepartamentoGuardar.Visible = false;
                        dataDepartamento.DataSource = logicaDepartamento.cargarDepartamento();

                    }
                    else
                    {
                        msm.tipoMensaje("Error "+ modeloDepartamento.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloDepartamento.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioDepartamentoActivo, "El campo del nombre del departamento no puede estar vacío");
                   // MessageBox.Show(this, "El estado del departamento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del departamento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtDepartamentoNombre, "El campo del nombre del departamento no puede estar vacío");
            }
        }

        private bool validarNombreDepartamento()
        {

            if (txtDepartamentoNombre.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void registrarDepartamento()
        {
            objetoDepartamento.Nombre = txtDepartamentoNombre.Text;
            //objetoDepartamento.IdPais = int.Parse(comboidPais.SelectedValue.ToString());
            if (radioDepartamentoActivo.Checked)
            {
                objetoDepartamento.Estado = 1;
            }
            else
            {
                objetoDepartamento.Estado = 0;
            }



            if (validarNombreDepartamento())
            {
                if (validarEstadoDepartamento())
                {
                    objetoDepartamento.IdPais = int.Parse(comboidPais.SelectedValue.ToString());
                    if (logicaDepartamento.insertarDepartamento(objetoDepartamento))
                    {
                        msm.tipoMensaje("Se ha ingresado el departamento correctamente", "done");
                        //MessageBox.Show(this, "", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataDepartamento.DataSource = logicaDepartamento.cargarDepartamento();
                        cargarcombox();
                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloDepartamento.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloDepartamento.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioDepartamentoActivo, "El estado del departamento no puede estar vacío");
                    //MessageBox.Show(this, "El estado del departamento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del departamento no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtDepartamentoNombre, "El campo del nombre del departamento no puede estar vacío");
            }
        }

        private void btnDepartamentoRegistrar_Click(object sender, EventArgs e)
        {

            registrarDepartamento();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataDepartamento.DataSource = logicaDepartamento.cargarDepartamento();
        }

        private void btnDepartamentoModificar_Click(object sender, EventArgs e)
        {
            if (txtDepartamentoNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese nombre del departamento que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreDepartamento = txtDepartamentoNombre.Text;

                if (modeloDepartamento.BuscarDepartamento(nombreDepartamento))
                {
                    if (int.Parse(modeloDepartamento.vector[2]) == 0)
                    {
                        radioDepartamentoInactivo.Select();
                    }
                    else
                    {
                        radioDepartamentoActivo.Select();
                    }
                    comboidPais.ValueMember = "idPais";
                    int r = int.Parse(modeloDepartamento.vector[3]);
                    comboidPais.SelectedValue = r;
                    btnDepartamentoGuardar.Visible = true;
                    this.Refresh();
                }
                else
                {
                    msm.tipoMensaje("El departamento ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDepartamentoGuardar_Click(object sender, EventArgs e)
        {
            modificarDepartamento();
        }
        
        public void cargarcombox()
        {
            // Departamentos
            comboidPais.ValueMember = "idPais";
            comboidPais.DisplayMember = "nombre";
            comboidPais.DataSource = modeloDepartamento.cargarNombrePais();

        }

        private void dataDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        //Cambio de letra

        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }
        
        private void txtDepartamentoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
            cambioLetra(e, txtDepartamentoNombre);

        }
    }
}
