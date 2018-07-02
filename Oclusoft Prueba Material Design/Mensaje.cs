using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oclusoft_Prueba_Material_Design
{
    public partial class Mensaje : Form
    {
        public Mensaje()
        {
            InitializeComponent();
        }
        private int contador;

        private void Mensaje_Load(object sender, EventArgs e)
        {
            Enabled = true;
            timer1.Interval = 1000;
            contador = 0;
            

        }

        public void tipoMensaje(string mensaje, string tipoMensaje)
        {
            this.Show();
            contar();
            string ruta = "C:\\Users\\luisf\\Desktop\\Proyecto Oclusoft\\Oclusoft Prueba Material Design\\Imagenes";
            if (tipoMensaje == "done")
            {
                this.BackColor = Color.Green;
                pictureMensaje.Image = Image.FromFile(ruta +"\\De acuerdo.png");
            }
            else
            {
                if (tipoMensaje == "warning")
                {
                    pictureMensaje.Image = Image.FromFile(ruta +"\\Advertencia.png");
                    this.BackColor = Color.Yellow;
                }
                else
                {
                    pictureMensaje.Image = Image.FromFile(ruta +"\\Error.png");
                    this.BackColor = Color.Red;
                }
            }
            alertaMensaje.Text = mensaje;
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            contar();
        }

        private void contar()
        {

            timer1.Enabled = true;
            if (contador >= 5)
            {
                // Exit loop code.
                timer1.Enabled = false;
                contador = 0;
                this.Hide();
                
            }
            else
            {
                // Run your procedure here.
                // Increment counter.
                contador = contador + 1;
               // alertaMensaje.Text = "Procedures Run: " + contador.ToString();
            }
        }

        private void Mensaje_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Mensaje_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
            contador = 1;
        }

        private void Mensaje_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
}
