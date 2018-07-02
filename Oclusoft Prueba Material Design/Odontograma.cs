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
    public partial class Odontograma : Form
    {
        public Odontograma()
        {
            InitializeComponent();
        }

        private void Odontograma_Load(object sender, EventArgs e)
        {

        }
         
        int color, idConvencion;

        //Instanciar la convención
        Convencion conv = new Convencion();
        
        

        private void btn18centro_Click(object sender, EventArgs e)
        {
           
            conv.Show();
            MessageBox.Show("" + conv.color);
            
        }

        private void btn18centro_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Se perdio foco");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //    if (co)
            //    {

            //    }
        }
    }
}
