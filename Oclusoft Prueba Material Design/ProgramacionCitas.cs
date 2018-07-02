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
    public partial class ProgramacionCitas : Form
    {
        public ProgramacionCitas()
        {
            InitializeComponent();
        }

        Logica.programacionCitasL objProgramacioncitas = new Logica.programacionCitasL();
        Objeto.programacionCitasO objProgramacioncitas1 = new Objeto.programacionCitasO();
        DataView dt = new DataView();
        DataTable rc = new DataTable();


        private void BTNconsultarPC_Click(object sender, EventArgs e)
        {

            dt = new Logica.programacionCitasL().Consultar_paciente(txtPCitasDocumento.Text.Trim()).AsDataView();
            string a = "";
            foreach (DataRowView item in dt)
            {
                a = item.Row[2].ToString() + " " + item.Row[3].ToString() + " " + item.Row[4].ToString();
            }
            

            LnombrePC.Text = a;
            
            rc = objProgramacioncitas.listar_CITAXFECHA(Convert.ToDateTime(MCfechaPC.SelectionEnd.ToShortDateString()));
            DGVcitasPC.DataSource = rc;

        }

        private void BTNregistrarPC_Click(object sender, EventArgs e)
        {
            //objProgramacioncitas1.Documento = TXTdocumentoPC.Text;
            objProgramacioncitas1.FechaCita = Convert.ToDateTime(MCfechaPC.SelectionEnd.ToShortDateString());
            RegistrarCitas registrarCita = new RegistrarCitas();
            registrarCita.Show();

        }
        
        private void btnPCitasBuscarXFecha_Click(object sender, EventArgs e)
        {
            //Data Grid View CITAXFECHA
            rc = objProgramacioncitas.listar_CITAXFECHA(Convert.ToDateTime(MCfechaPC.SelectionEnd.ToShortDateString()));
            DGVcitasPC.DataSource = rc;
        }

        private void btnPCitasBuscarXDocumento_Click(object sender, EventArgs e)
        {
            dt = new Logica.programacionCitasL().Consultar_paciente(txtPCitasDocumento.Text.Trim()).AsDataView();


            string a = "";

            foreach (DataRowView item in dt)
            {
                a = item.Row[2].ToString() + " " + item.Row[3].ToString() + " " + item.Row[4].ToString();
            }

            LnombrePC.Text = a;
            //Data Grid View CITAXDOC
            rc = objProgramacioncitas.listar_CITAXPACIENTE(txtPCitasDocumento.Text);
            DGVcitasPC.DataSource = rc;
        }

    }
}
