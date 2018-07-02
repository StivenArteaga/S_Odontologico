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
using System.Diagnostics;

namespace Oclusoft_Prueba_Material_Design
{
    public partial class MenuConfiguracion : MaterialSkin.Controls.MaterialForm
    {
        public MenuConfiguracion()
        {
            InitializeComponent();
        }

        private void MenuConfiguracion_Load(object sender, EventArgs e)
        {

        }


        string url = "";

        private void abrirManualUsuario() //Funcionará solo en caso de que no encuentre la ruta, falta poner un botón que lo abra
        {
            OpenFileDialog abrir = new OpenFileDialog();

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                url = abrir.FileName;
            }
        }

        private void pictureBoxManualUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAbrirManualUsuario.Visible == false)
                {
                    url = "C:\\Users\\luisf\\Documents\\Oclusoft C# Prueba Beta\\oclusoft Beta\\Manual de usuario/MANUAL DE USUARIO.pdf";
                }
                else
                {
                    abrirManualUsuario();
                }

                Process.Start(url);

                limpio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                btnAbrirManualUsuario.Visible = true;
                //throw;
            }

        }

        private void pictureBoxMenuConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion confi = new Configuracion();

            PaginaPrincipal pag = new PaginaPrincipal();
            pag.AgregarFormularioEnPanel((confi));
            //confi.m();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MediaPlayer video = new MediaPlayer();
            video.Show();
        }

        private void btnAbrirManualUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                abrirManualUsuario();
                if (url != "")
                {
                    Process.Start(url);
                    limpio();
                }
                else
                {
                    limpio();
                }
            }
            catch (Exception ex)
            {
                 limpio();
                 MessageBox.Show("" + ex);
            }


        }

        private void limpio()
        {
            btnAbrirManualUsuario.Visible = false;
            url = "";
        }

        private void pictureCrearUsuario_Click(object sender, EventArgs e)
        {
            RegistroUsuario RU = new RegistroUsuario();
            RU.Show();
        }
    }
}
