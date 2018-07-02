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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporte.reporte1' Puede moverla o quitarla según sea necesario.
            this.reporte1TableAdapter.Fill(this.DataSetReporte.reporte1);

            this.reportViewer1.RefreshReport();
        }
    }
}
