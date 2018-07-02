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

namespace Oclusoft_Prueba_Material_Design
{
    public partial class Cargando : MaterialSkin.Controls.MaterialForm
    {
        public Cargando()
        {
            InitializeComponent();
            var admin = MaterialSkinManager.Instance;
            admin.AddFormToManage(this);
            admin.Theme = MaterialSkinManager.Themes.LIGHT;
            admin.ColorScheme = new ColorScheme(Primary.Green600, Primary.BlueGrey900, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            
        }

        private void Cargando_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            progressBar1.Increment(1);
            lblContador.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                ValidacionRegistroUsuario logeo = new ValidacionRegistroUsuario();
                logeo .Show();
            }
            if (progressBar1.Value > 10 && progressBar1.Value < 25)
            {
                this.BackColor = System.Drawing.Color.LightSteelBlue;
                BackColor = System.Drawing.Color.LightSteelBlue;
            }
            else
            {
                if (progressBar1.Value >= 25 && progressBar1.Value <= 38)
                {
                    this.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    if (progressBar1.Value >= 39 && progressBar1.Value <= 52)
                    {
                        this.BackColor = System.Drawing.Color.DarkCyan;
                    }
                    else
                    {
                        if (progressBar1.Value > 52 && progressBar1.Value < 65)
                        {
                            this.BackColor = System.Drawing.Color.LightBlue;
                        }
                        else
                        {
                            if (progressBar1.Value >= 65 && progressBar1.Value < 80)
                            {
                                this.BackColor = System.Drawing.Color.DarkViolet;
                            }
                            else
                            {
                                this.BackColor = System.Drawing.Color.Cyan;
                            }
                        }
                    }

                }
            }
        }
    }
}
