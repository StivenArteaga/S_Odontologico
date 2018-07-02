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
    public partial class RegistrarCitas : Form
    {
        public RegistrarCitas()
        {
            InitializeComponent();
        }




        private void registrarCita_Load(object sender, EventArgs e)
        {
            cargarcombox();

        }

        Logica.programacionCitasL objProgramacioncitas = new Logica.programacionCitasL();
        Objeto.programacionCitasO objProgramacioncitas1 = new Objeto.programacionCitasO();
        DataView dt = new DataView();

        private void cargarcombox()
        {

            comboRCitaOdontologo.ValueMember = "idOdontologo";
            comboRCitaOdontologo.DisplayMember = "nombres";
            comboRCitaOdontologo.DataSource = objProgramacioncitas.Cargarodontologo();
        }

        private void BTNpcguardar_Click(object sender, EventArgs e)
        {


            //INSERTAR
            if (validarCamposCita())
            {
                objProgramacioncitas1.IdOdontologo = int.Parse(comboRCitaOdontologo.SelectedValue.ToString());
                objProgramacioncitas1.Duracion = int.Parse(txtRCitaDuracion.Text);
                objProgramacioncitas1.Descripcion = txtRCitaMotivo.Text;
                objProgramacioncitas1.FechaCita = DateTime.Parse(dateRCitaFecha.Text);
                objProgramacioncitas1.HoraInicio = TimeSpan.Parse(timeRCitaHoraInicio.Text);
                //objProgramacioncitas1.Estado = (Int16)(CHBestadoPC.Checked == true ? 1 : 0);

                if (comboRCitaEstado.SelectedIndex == -1)
                {
                    error.SetError(comboRCitaEstado, "Seleccione una opción");
                }
                else
                {
                    if (comboRCitaEstado.SelectedIndex == 0)
                    {
                        objProgramacioncitas1.Estado = 0;
                        MessageBox.Show("0");
                    }

                    else
                    {

                        if (comboRCitaEstado.SelectedIndex == 1)
                        {

                            objProgramacioncitas1.Estado = 1;
                            MessageBox.Show("1");
                        }

                        else
                        {

                            if (comboRCitaEstado.SelectedIndex == 2)
                            {

                                objProgramacioncitas1.Estado = 2;
                                MessageBox.Show("2");
                            }

                        }
                    }



                    int idpaciente = 0;
                    foreach (DataRowView item in dt)
                    {
                        idpaciente = int.Parse(item.Row[0].ToString());
                    }

                    objProgramacioncitas1.IdPaciente = idpaciente;

                    if (objProgramacioncitas.insertarProgramacioncitas(objProgramacioncitas1))
                    {
                        MessageBox.Show("ha insertado correctamente");
                        //dataGridView1.DataSource = objOdontologo.mostrarodontologo();

                    }
                    limpiarRC();

                }

            }
        }

        private void limpiarRC()
        {
            LnombreRC.Text = "";
            dateRCitaFecha.Text = "";
            txtRCitaMotivo.Text = "";
            timeRCitaHoraInicio.Text = "";
            txtRCitaDuracion.Text = "";
            //CHBestadoPC.Checked = false;
        }

        private bool validarCamposCita()
        {
            bool ban = false;
            error.Clear();
            if (LnombreRC.Text == "")
            {
                error.SetError(LnombreRC, "El campo Documento está vacío");
                return false;
            }
            else
            {
                if (dateRCitaFecha.Text == "")
                {
                    error.SetError(dateRCitaFecha, "El campo Fecha está vacío");
                    return false;
                }
                else
                {
                    if (comboRCitaOdontologo.SelectedIndex == -1)
                    {
                        error.SetError(comboRCitaOdontologo, "El campo Odontólogo está vacío");
                        return false;
                    }
                    else
                    {
                        if (timeRCitaHoraInicio.Text == "")
                        {
                            error.SetError(timeRCitaHoraInicio, "El campo Hora de Inicio está vacío");
                            return false;
                        }
                        else
                        {
                            if (txtRCitaMotivo.Text == "")
                            {
                                error.SetError(txtRCitaMotivo, "El campo Motivo está vacío");
                                return false;
                            }

                            else
                            {
                                if (txtRCitaDuracion.Text == "")
                                {
                                    error.SetError(txtRCitaDuracion, "El campo Duración está vacío");

                                    return false;
                                }


                                //else {
                                //    if (CBestadoPC.SelectedIndex == -1)
                                //    {
                                //        error.SetError(LnombreRC, "El campo Duración está vacío");
                                //        return false;
                                //    }
                                else
                                    if (txtRCitaDuracion.Text != "")
                                {
                                    try
                                    {
                                        int duracion = int.Parse(txtRCitaDuracion.Text);
                                        ban = true;
                                    }
                                    catch (Exception)
                                    {
                                        error.SetError(txtRCitaDuracion, "El campo Duración sólo acepta números");

                                        ban = false;
                                    }
                                    return ban;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BTNbuscarxdocumentoRC_Click(object sender, EventArgs e)
        {
            dt = new Logica.programacionCitasL().Consultar_paciente(txtRCitaDocumentoPaciente.Text.Trim()).AsDataView();
            string a = "";
            foreach (DataRowView item in dt)
            {
                a = item.Row[2].ToString() + " " + item.Row[3].ToString() + " " + item.Row[4].ToString();
            }
            LnombreRC.Text = a;

        }

        private void RegistrarCitas_Load(object sender, EventArgs e)
        {
            cargarcombox();
        }
    }
}
