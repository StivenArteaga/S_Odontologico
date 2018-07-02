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
    public partial class Convencion : MaterialSkin.Controls.MaterialForm
    {
        public Convencion()
        {
            InitializeComponent();
        }

        //MVC
        Modelo.TipoConvencion modeloTipoConvencion = new Modelo.TipoConvencion();
        Objeto.TipoConvencion objetoTipoConvencion = new Objeto.TipoConvencion();
        Logica.TipoConvencion logicaTipoConvencion = new Logica.TipoConvencion();


        private void Convencion_Load(object sender, EventArgs e)
        {
            Enabled = true;
            cargarCombo();

        }

        public int color, idConvencion;

        public void cargarCombo()
        {
            // Tipo Convencion
            comboConvencion.ValueMember = "idTipoConvencion";
            comboConvencion.DisplayMember = "nombre";
            comboConvencion.DataSource = modeloTipoConvencion.consultarTipoConvencion();
        }


        private bool validarConvencion()
        {
            if (comboConvencion.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarColor()
        {
            if (colorAzul.Checked || colorRojo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void comboConvencion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    string imagen = openFileDialog1.FileName;
                //    pictureImgConvencion.Image = Image.FromFile(imagen);
                //}

                pictureImgConvencion.Image = Image.FromFile("C: \\Users\\luisf\\Pictures\\Esposita\\22236130_1512658515467320_1928399133_n.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }

        private void Convencion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void Convencion_Load_1(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private void agregarTipoDocumento_Click(object sender, EventArgs e)
        {
            TipoConvencion tipoCon = new TipoConvencion();
            tipoCon.Show();

        }

        private void comboConvencion_DropDown(object sender, EventArgs e)
        {
            comboConvencion.DataSource = modeloTipoConvencion.consultarTipoConvencion();
        }

        private void Convencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this. == DialogResult.Cancel)
            //{
            //    MessageBox.Show("Se cerro");
            //}
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (!validarConvencion())
            {
                if (validarColor())
                {

                    if (colorAzul.Checked)
                    {
                        color = 0;
                    }
                    else
                    {
                        color = 1;
                    }
                    idConvencion = int.Parse(comboConvencion.SelectedValue.ToString());   
                }
                else
                {
                    error.SetError(colorRojo, "Falta el color de la convención");
                    error.SetError(colorAzul, "Falta el color de la convención");
                }
            }
            else
            {
                error.SetError(comboConvencion, "Falta la convención del diente");
            }
        }
    }
}
