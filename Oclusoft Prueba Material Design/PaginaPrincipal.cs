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
    public partial class PaginaPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        public void AgregarFormularioEnPanel(object formHijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();

        }


        private void pictureMaestra_Click(object sender, EventArgs e)
        {
            Configuracion conf = new Configuracion();
            AgregarFormularioEnPanel(conf);
        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxPaciente_Click(object sender, EventArgs e)
        {
            Paciente pac = new Paciente();
            AgregarFormularioEnPanel(pac);
        }

        private void pictureBoxOdontologo_Click(object sender, EventArgs e)
        {
            Odontologo odon = new Odontologo();
            AgregarFormularioEnPanel(odon);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuConfiguracion menuConf = new MenuConfiguracion();
            AgregarFormularioEnPanel(menuConf);
        }

        private void pictureBoxHistoriaClinica_Click(object sender, EventArgs e)
        {
            HistoriaClinica historia = new HistoriaClinica();
            AgregarFormularioEnPanel(historia);
        }

        private void pictureBoxCita_Click(object sender, EventArgs e)
        {
            ProgramacionCitas citas = new ProgramacionCitas();
            AgregarFormularioEnPanel(citas);
        }

        private void pictureBoxOdontograma_Click(object sender, EventArgs e)
        {
            Odontograma odonto = new Odontograma();
            AgregarFormularioEnPanel(odonto);
        }

        private void pictureBoxInformación_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Consultorio consultorio = new Consultorio();
            AgregarFormularioEnPanel(consultorio);
        }
    }
}
