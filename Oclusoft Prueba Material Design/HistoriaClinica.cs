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
    public partial class HistoriaClinica : MaterialSkin.Controls.MaterialForm
    {
        public HistoriaClinica()
        {
            InitializeComponent();
        }

        private void HistoriaClinica_Load(object sender, EventArgs e)
        {


            //Antecedentes
            dataAntecedente.DataSource = logicaHisClinicaAntecedente.consultarTipoAntecedente();
            dataAntecedente.Columns[1].Visible = false;
            dataAntecedente.Columns[2].Width = 300;

            dataTipoAntecedente.DataSource = logicaTipoAntecedente.cargarTipoAntecedente();
            dataTipoAntecedente.Columns[0].Visible = false;
            dataTipoAntecedente.Columns[2].Width = 600;
            //dataTipoAntecedente.DataSource = false;
            
            cargarRespuesta();

            //HabitosHigienicos
            dataHabitoHigiene.DataSource = logicaHabitoHigiene.consultarTipoHabitoHigiene();
            dataHabitoHigiene.Columns[2].Visible = false;
            dataHabitoHigiene.Columns[3].Width = 300;

            //ExamenEstomatologico
            dataExamenEstomatologico.DataSource = logicaExamenEstomatologico.consultarTipoExamenEstomatologico();
            dataExamenEstomatologico.Columns[1].Visible = false;
            dataExamenEstomatologico.Columns[3].Visible = false;
            dataExamenEstomatologico.Columns[2].Width = 300;

            //ExamenDental
            dataExamenDental.DataSource = logicaExamenDental.consultarTipoExamenDental();
            dataExamenDental.Columns[1].Visible = false;
            dataExamenDental.Columns[3].Visible = false;
            dataExamenDental.Columns[2].Width = 300;

            //Respuesta
            dataRespuestaHistoriaClinica.DataSource = logicaRespuestaHistoriaClinica.cargarRespuestaHistoriaClinica();
            dataRespuestaHistoriaClinica.Columns[0].Visible = false;

        }

        Mensaje msm = new Mensaje();

        //MVC

        //TipoAntecedente
        Modelo.TipoAntecedente modeloTipoAntecedente = new Modelo.TipoAntecedente();
        Logica.TipoAntecedente logicaTipoAntecedente = new Logica.TipoAntecedente();
        Objeto.TipoAntecedente objectoTipoAntecedente = new Objeto.TipoAntecedente();

        //Antecedentes
        Modelo.Antecedentes modeloHisClinicaAntecedente = new Modelo.Antecedentes();
        Objeto.Antecedentes objetoHisClinicaAntecedente = new Objeto.Antecedentes();
        Logica.Antecedentes logicaHisClinicaAntecedente = new Logica.Antecedentes();

        //RespuestaHistoriaClinica
        Modelo.RespuestaHistoriaClinica modeloRespuestaHistoriaClinica = new Modelo.RespuestaHistoriaClinica();
        Objeto.RespuestaHistoriaClinica objetoRespuestaHistoriaClinica = new Objeto.RespuestaHistoriaClinica();
        Logica.RespuestaHistoriaClinica logicaRespuestaHistoriaClinica = new Logica.RespuestaHistoriaClinica();

        //TipoHabito
        Modelo.TipoHabito modeloTipoHabito = new Modelo.TipoHabito();
        Objeto.TipoHabito objetoTipoHabito = new Objeto.TipoHabito();
        Logica.TipoHabito logicaTipoHabito = new Logica.TipoHabito();

        //HabitoHigiene
        Modelo.HabitoHigiene modeloHabitoHigiene = new Modelo.HabitoHigiene();
        Objeto.HabitoHigiene objetoHabitoHigiene = new Objeto.HabitoHigiene();
        Logica.HabitoHigiene logicaHabitoHigiene = new Logica.HabitoHigiene();

        // TipoExamenEstomatologico
        Modelo.TipoExamenEstomatologico modeloTipoExamenEstomatologico = new Modelo.TipoExamenEstomatologico();
        Objeto.TipoExamenEstomatologico objetoTipoExamenEstomatologico = new Objeto.TipoExamenEstomatologico();
        Logica.TipoExamenEstomatologico logicaTipoExamenEstomatologico = new Logica.TipoExamenEstomatologico();

        //ExamenEstomatologico
        Modelo.ExamenEstomatologico modeloExamenEstomatologico = new Modelo.ExamenEstomatologico();
        Objeto.ExamenEstomatologico objetoExamenEstomatologico = new Objeto.ExamenEstomatologico();
        Logica.ExamenEstomatologico logicaExamenEstomatologico = new Logica.ExamenEstomatologico();

        //TipoExamenDental
        Modelo.TipoExamenDental modeloTipoExamenDental = new Modelo.TipoExamenDental();
        Objeto.TipoExamenDental objetoTipoExamenDental = new Objeto.TipoExamenDental();
        Logica.TipoExamenDental logicaTipoExamenDental = new Logica.TipoExamenDental();


        //ExamenDental
        Modelo.ExamenDental modeloExamenDental = new Modelo.ExamenDental();
        Objeto.ExamenDental objetoExamenDental = new Objeto.ExamenDental();
        Logica.ExamenDental logicaExamenDental = new Logica.ExamenDental();


        //EstadoProstodontico
        Modelo.EstadoProstodontico modeloEstadoProstodontico = new Modelo.EstadoProstodontico();
        Objeto.EstadoProstodontico objetoEstadoProstodontico = new Objeto.EstadoProstodontico();
        Logica.EstadoProstodontico logicaEstadoProstodontico = new Logica.EstadoProstodontico();

        //ExamenPulpar
        Modelo.ExamenPulpar modeloExamenPulpar = new Modelo.ExamenPulpar();
        Objeto.ExamenPulpar objetoExamenPulpar = new Objeto.ExamenPulpar();
        Logica.ExamenPulpar logicaExamenPulpar = new Logica.ExamenPulpar();

        private void cargarRespuesta()
        {
            //AntecedentesMedicos
            comboAntecedenteTipo.ValueMember = "idRespuesta";
            comboAntecedenteTipo.DisplayMember = "respuesta";
            comboAntecedenteTipo.DataSource = logicaHisClinicaAntecedente.consultarRespuesta(); //logicaHisClinica.consultarAntecedenteTipo();

            //HabitosHigienicos
            ComboHabitoHigienico.ValueMember = "idRespuesta";
            ComboHabitoHigienico.DisplayMember = "respuesta";
            ComboHabitoHigienico.DataSource = logicaHabitoHigiene.consultarRespuesta();

            //ExamenEstomatologico
            comboExamenEstomatologico.ValueMember = "idRespuesta";
            comboExamenEstomatologico.DisplayMember = "respuesta";
            comboExamenEstomatologico.DataSource = logicaExamenEstomatologico.consultarRespuesta();

            //ExamenDental
            comboExamenDental.ValueMember = "idRespuesta";
            comboExamenDental.DisplayMember = "respuesta";
            comboExamenDental.DataSource = logicaExamenDental.consultarRespuesta();

            //EstadoProstodontico
            comboPresenciaProtesis.ValueMember = "idRespuesta";
            comboPresenciaProtesis.DisplayMember = "respuesta";
            comboPresenciaProtesis.DataSource = logicaExamenEstomatologico.consultarRespuesta();

        }

        private bool validarBusqueda()
        {
            if (txtDocumentoPaciente.Text == "" && txtNumeroHistoriaClinica.Text == "")
            {
                msm.tipoMensaje("Ingresa el documento del paciente o el número de la historia clínica", "warning");
                //MessageBox.Show(" ingresa el documento del paciente o el número de la historia clínica");
                return true;
            }
            else
            {
                if (txtDocumentoPaciente.Text != "" && txtNumeroHistoriaClinica.Text != "")
                {
                    msm.tipoMensaje("La búsqueda no se puede realizar por los dos campos a la vez", "warning");
                    //MessageBox.Show("La busqueda no se puede realizar por los dos campos a la vez");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            if (!validarBusqueda())
            {

                string documento;
                if (txtDocumentoPaciente.Text != "")
                {
                    documento = txtDocumentoPaciente.Text;
                }
                else
                {
                    documento = txtNumeroHistoriaClinica.Text;
                }
                if (modeloHisClinicaAntecedente.consultarPaciente(documento))
                {
                    txtDocumentoPaciente.Text = objetoHisClinicaAntecedente.Documento;
                    txtNumeroHistoriaClinica.Text = objetoHisClinicaAntecedente.NumeroHistoriaClinica;
                    lblNombrePaciente.Text = objetoHisClinicaAntecedente.NombreCompletoPaciente;
                    lblIdHistoriaClinica.Text = objetoHisClinicaAntecedente.IdHistoriaClinica.ToString();
                    dateFecha.Value = objetoHisClinicaAntecedente.Fecha;
                }
                else
                {
                    msm.tipoMensaje("El paciente no se encuentra registrado", "warning");
                    //MessageBox.Show("El paciente no se encuentra registrado");
                }
            }
        }

        private void limpiar()
        {
            lblNombrePaciente.Text = "";
            txtNumeroHistoriaClinica.Text = "";
            lblIdHistoriaClinica.Text = "";
            //dataAntecedente.DataSource = null;
            txtDocumentoPaciente.Text = "";
            dateFecha.Value = DateTime.Today;
        }

        private void btnGuardarAntecedentes_Click(object sender, EventArgs e)
        {
            bool ban = false;
            if (!validarBusqueda())
            {
                foreach (DataGridViewRow row in dataAntecedente.Rows)
                {
                    objetoHisClinicaAntecedente.IdHistoriaClinica = int.Parse(lblIdHistoriaClinica.Text); //HistoriaClinica 
                    objetoHisClinicaAntecedente.Observacion = txtObservacion.Text; //Observación    
                    objetoHisClinicaAntecedente.IdRespuesta = row.Cells[0].Value.ToString(); // IdRespuesta
                    objetoHisClinicaAntecedente.IdTipoAntecedente = int.Parse(row.Cells[1].Value.ToString());
                    //MessageBox.Show("Id Estamologico" + row.Cells[1].Value.ToString());
                    //MessageBox.Show(dataAntecedente.CurrentCell.Value.ToString());
                    // MessageBox.Show("Id respuesta " + row.Cells[0].Value.ToString());
                    if (logicaHisClinicaAntecedente.registrarAntecedente(objetoHisClinicaAntecedente))
                    {
                        ban = true;
                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloHisClinicaAntecedente.Error, "error");
                        //MessageBox.Show(this, "Se ha presetado un error al modificar" + modeloHisClinicaAntecedente.Error, "Error modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (ban == true)
                {
                    msm.tipoMensaje("El registro se ha ingresado con éxito", "done");
                    //MessageBox.Show(this, "El registro se ha insertado con éxito", "Ingreso con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }


            //objetoHisClinicaAntecedente.IdRespuesta = (dataAntecedente.Rows[0].Cells[0].Value.ToString());

        }



        //TipoAntecedente

        private void btnTipoAntecedenteRegistrar_Click(object sender, EventArgs e)
        {
            registrarTipoAntecedente();
        }

        private void btnTipoAntecedenteModificar_Click(object sender, EventArgs e)
        {
            if (txtTipoAntecedenteNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del tipo de antecedente que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre del tipo de antecedente que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreTipoAntecedente = txtTipoAntecedenteNombre.Text;

                if (modeloTipoAntecedente.BuscarTipoAntecedente(nombreTipoAntecedente))
                {
                    if (int.Parse(modeloTipoAntecedente.vector[2]) == 0)
                    {
                        radioTipoAntecedenteInactivo.Select();
                    }
                    else
                    {
                        radioTipoAntecedenteActivo.Select();
                    }


                    btnTipoAntecedenteGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El tipo de antecedente ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "El tipo de antecedente a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTipoAntecedenteListar_Click(object sender, EventArgs e)
        {
            dataTipoAntecedente.DataSource = logicaTipoAntecedente.cargarTipoAntecedente();
            //dataTipoAntecedente.Columns[0].Visible = false;
            //dataTipoAntecedente.Columns[1].Width = 300;
        }

        private void btnTipoAntecedenteGuardar_Click(object sender, EventArgs e)
        {
            modificarTipoAntecedente();
        }

        private void registrarTipoAntecedente()
        {
            error.Clear();
            objectoTipoAntecedente.Nombre = txtTipoAntecedenteNombre.Text;
            if (radioTipoAntecedenteActivo.Checked)
            {
                objectoTipoAntecedente.Estado = 1;
            }
            else
            {
                objectoTipoAntecedente.Estado = 0;
            }


            if (validarNombreTipoAntecedente())
            {
                if (validarEstadoTipoAntecedente())
                {
                    if (logicaTipoAntecedente.insertarTipoAntecedente(objectoTipoAntecedente))
                    {
                        msm.tipoMensaje("Se ha ingresado el tipo de antecedente correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado el tipo de antecedente correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoAntecedente();
                        //cargarcombox();
                        dataTipoAntecedente.DataSource = logicaTipoAntecedente.cargarTipoAntecedente();
                        //dataTipoAntecedente.Columns[0].Visible = false;
                        //dataTipoAntecedente.Columns[1].Width = 300;

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloTipoAntecedente.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloTipoAntecedente.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoAntecedenteActivo,"El estado del tipo de antecedente no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de antecedente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                error.SetError(txtTipoAntecedenteNombre, "El campo del nombre del tipo de antecedente no puede estar vacío");
                //MessageBox.Show(this, "El campo del nombre del tipo de antecedente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void modificarTipoAntecedente()
        {

            error.Clear();
            objectoTipoAntecedente.IdTipoAntecedente = int.Parse(modeloTipoAntecedente.vector[0]);
            objectoTipoAntecedente.Nombre = txtTipoAntecedenteNombre.Text;
            if (radioTipoAntecedenteActivo.Checked)
            {
                objectoTipoAntecedente.Estado = 1;
            }
            else
            {
                objectoTipoAntecedente.Estado = 0;
            }


            if (validarNombreTipoAntecedente())
            {
                if (validarEstadoTipoAntecedente())
                {
                    if (logicaTipoAntecedente.modificarTipoAntecedente(objectoTipoAntecedente))
                    {
                        msm.tipoMensaje("Se ha actualizado el tipo de antecedente correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado el tipo de antecedente correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoAntecedente();
                        btnTipoAntecedenteGuardar.Visible = false;
                        //cargarcombox();
                        dataTipoAntecedente.DataSource = logicaTipoAntecedente.cargarTipoAntecedente();
                        //dataTipoAntecedente.Columns[1].Width = 600;
                        //dataTipoAntecedente.Columns[0].Visible = false;
                        

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloTipoAntecedente.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloTipoAntecedente.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoAntecedenteActivo, "El estado del tipo de antecedente no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de antecedente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de antecedente no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtTipoAntecedenteNombre, "El campo del nombre del tipo de antecedente no puede estar vacío");
            }
        }

        private bool validarNombreTipoAntecedente()
        {
            if (txtTipoAntecedenteNombre.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiarTipoAntecedente()
        {
            txtTipoAntecedenteNombre.Text = "";
            radioTipoAntecedenteActivo.Checked = false;
            radioTipoAntecedenteInactivo.Checked = false;
        }

        private bool validarEstadoTipoAntecedente()
        {
            if (radioTipoAntecedenteActivo.Checked || radioTipoAntecedenteInactivo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //RespuestaHistoriaClinica
        private void btnTipoRespuestaRegistrar_Click(object sender, EventArgs e)
        {
            registrarRespuestaHistoriaClinica();
            limpiarRespuestaHistoriaClinica();
        }

        private void btnTipoRespuestaModificar_Click(object sender, EventArgs e)
        {
            if (txtRespuestaHistoriaClinicaNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre de la respuesta que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre de la respuesta que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreRespuestaHistoriaClinica = txtRespuestaHistoriaClinicaNombre.Text;

                if (modeloRespuestaHistoriaClinica.BuscarRespuestaHistoriaClinica(nombreRespuestaHistoriaClinica))
                {
                    if (int.Parse(modeloRespuestaHistoriaClinica.vector[2]) == 0)
                    {
                        radioRespuestaHistoriaClinicaInactivo.Select();
                    }
                    else
                    {
                        radioRespuestaHistoriaClinicaActivo.Select();
                    }


                    btnRespuestaHistoriaClinicaGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El nombre de la respuesta ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "El nombre de la  respuesta a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTipoRespuestaListar_Click(object sender, EventArgs e)
        {
            dataRespuestaHistoriaClinica.DataSource = logicaRespuestaHistoriaClinica.cargarRespuestaHistoriaClinica();
        }

        private void btnTipoRespuestaGuardar_Click(object sender, EventArgs e)
        {
            modificarRespuestaHistoriaClinica();
        }

        private void registrarRespuestaHistoriaClinica()
        {
            error.Clear();
            objetoRespuestaHistoriaClinica.Respuesta = txtRespuestaHistoriaClinicaNombre.Text;
            if (radioRespuestaHistoriaClinicaActivo.Checked)
            {
                objetoRespuestaHistoriaClinica.Estado = 1;
            }
            else
            {
                objetoRespuestaHistoriaClinica.Estado = 0;
            }


            if (validarNombreRespuestaHistoriaClinica())
            {
                if (validarEstadoRespuestaHistoriaClinica())
                {
                    if (logicaRespuestaHistoriaClinica.insertarRespuestaHistoriaClinica(objetoRespuestaHistoriaClinica))
                    {
                        msm.tipoMensaje("Se ha ingresado el nombre de la respuesta correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado el nombre de la respuesta correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarRespuestaHistoriaClinica();
                        //cargarcombox();
                        dataRespuestaHistoriaClinica.DataSource = logicaRespuestaHistoriaClinica.cargarRespuestaHistoriaClinica();

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloRespuestaHistoriaClinica.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloRespuestaHistoriaClinica.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioRespuestaHistoriaClinicaActivo, "El estado de la respuesta no puede estar vacío");
                    //MessageBox.Show(this, "El estado de la respuesta no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre de la respuesta no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtRespuestaHistoriaClinicaNombre, "El campo del nombre de la respuesta no puede estar vacío");
            }

        }

        private void modificarRespuestaHistoriaClinica()
        {
            error.Clear();
            objetoRespuestaHistoriaClinica.IdRespuesta = int.Parse(modeloRespuestaHistoriaClinica.vector[0]);
            objetoRespuestaHistoriaClinica.Respuesta = txtRespuestaHistoriaClinicaNombre.Text;
            if (radioRespuestaHistoriaClinicaActivo.Checked)
            {
                objetoRespuestaHistoriaClinica.Estado = 1;
            }
            else
            {
                objetoRespuestaHistoriaClinica.Estado = 0;
            }


            if (validarNombreRespuestaHistoriaClinica())
            {
                if (validarEstadoRespuestaHistoriaClinica())
                {
                    if (logicaRespuestaHistoriaClinica.modificarRespuestaHistoriaClinica(objetoRespuestaHistoriaClinica))
                    {
                        msm.tipoMensaje("Se ha actualizado el nombre de la respuesta correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado el nombre de la respuesta correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarRespuestaHistoriaClinica();
                        btnRespuestaHistoriaClinicaGuardar.Visible = false;
                        //cargarcombox();
                        dataRespuestaHistoriaClinica.DataSource = logicaRespuestaHistoriaClinica.cargarRespuestaHistoriaClinica();

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloRespuestaHistoriaClinica.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloRespuestaHistoriaClinica.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioRespuestaHistoriaClinicaActivo, "El estado de la respuesta no puede estar vacío");
                    //MessageBox.Show(this, "El estado de la respuesta no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
               // MessageBox.Show(this, "El campo del nombre de la respuesta no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtRespuestaHistoriaClinicaNombre, "El campo del nombre de la respuesta no puede estar vacío");
            }
        }

        private bool validarNombreRespuestaHistoriaClinica()
        {
            if (txtRespuestaHistoriaClinicaNombre.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiarRespuestaHistoriaClinica()
        {
            txtTipoAntecedenteNombre.Text = "";
            radioTipoAntecedenteActivo.Checked = false;
            radioTipoAntecedenteInactivo.Checked = false;
        }

        private bool validarEstadoRespuestaHistoriaClinica()
        {
            if (radioRespuestaHistoriaClinicaActivo.Checked || radioRespuestaHistoriaClinicaInactivo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarCampoRespuestaAntecedente()
        {
            bool bandera = false;
            foreach (DataGridViewRow row in dataAntecedente.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    bandera = true;
                }
            }
            return bandera;
        }

        private bool validarQueSeLlenaraRegistroAPaciente()
        {
            if (lblIdHistoriaClinica.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnGuardarAntecedentes_Click_1(object sender, EventArgs e)
        {
            bool ban = false;

            if (!validarQueSeLlenaraRegistroAPaciente())
            {
                if (validarCampoRespuestaAntecedente())
                {
                    msm.tipoMensaje("Llena todos los campos de la respuesta", "warning");
                    //MessageBox.Show("Por favor llena todos los campos de la respuesta");
                }
                else
                {
                    foreach (DataGridViewRow row in dataAntecedente.Rows)
                    {
                        objetoHisClinicaAntecedente.IdHistoriaClinica = int.Parse(lblIdHistoriaClinica.Text); //HistoriaClinica 
                        objetoHisClinicaAntecedente.Observacion = txtObservacion.Text; //Observación    
                        objetoHisClinicaAntecedente.IdRespuesta = row.Cells[0].Value.ToString(); // IdRespuesta
                        objetoHisClinicaAntecedente.IdTipoAntecedente = int.Parse(row.Cells[1].Value.ToString());
                        objetoHisClinicaAntecedente.Fecha = DateTime.Today;
                        if (logicaHisClinicaAntecedente.registrarAntecedente(objetoHisClinicaAntecedente))
                        {
                            ban = true;
                        }
                        else
                        {
                            msm.tipoMensaje("Error " + modeloHisClinicaAntecedente.Error, "error");
                            //MessageBox.Show(this, "Se ha presetado un error al modificar" + modeloHisClinicaAntecedente.Error, "Error modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (ban == true)
                    {
                        msm.tipoMensaje("El registro se ha ingresado con éxito", "done");
                        //MessageBox.Show(this, "El registro se ha insertado con éxito", "Ingreso con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
            }
            else
            {
                msm.tipoMensaje("Falta asociar paciente, verifica la consulta del paciente", "warning");
                //MessageBox.Show("Falta asociar paciente, verifica la consulta del paciente");
            }
        }


        //TipoHabito
        private void btnTipoHabitoRegistrar_Click(object sender, EventArgs e)
        {
            registrarTipoHabito();
        }

        private void btnTipoHabitoModificar_Click(object sender, EventArgs e)
        {
            if (txtTipoHabitoNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del tipo de hábito que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre del tipo de hábito que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreTipoHabito = txtTipoHabitoNombre.Text;

                if (modeloTipoHabito.BuscarTipoHabito(nombreTipoHabito))
                {
                    if (int.Parse(modeloTipoHabito.vector[2]) == 0)
                    {
                        radioTipoHabitoInactivo.Select();
                    }
                    else
                    {
                        radioTipoHabitoActivo.Select();
                    }


                    btnTipoHabitoGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El tipo de hábito ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "El tipo de hábito a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTipoHabitoListar_Click(object sender, EventArgs e)
        {
            dataTipoHabito.DataSource = logicaTipoHabito.cargarTipoHabito();
        }

        private void btnTipoHabitoGuardar_Click(object sender, EventArgs e)
        {
            modificarTipoHabito();
        }

        private void registrarTipoHabito()
        {
            error.Clear();
            objetoTipoHabito.Nombre = txtTipoHabitoNombre.Text;
            if (radioTipoHabitoActivo.Checked)
            {
                objetoTipoHabito.Estado = 1;
            }
            else
            {
                objetoTipoHabito.Estado = 0;
            }


            if (validarNombreTipoHabito())
            {
                if (validarEstadoTipoHabito())
                {
                    if (logicaTipoHabito.insertarTipoHabito(objetoTipoHabito))
                    {
                        msm.tipoMensaje("Se ha ingresado el tipo de hábito correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado el tipo de hábito correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoHabito();
                        //cargarcombox();
                        dataTipoHabito.DataSource = logicaTipoHabito.cargarTipoHabito();

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloTipoHabito.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloTipoHabito.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoHabitoActivo, "El estado del tipo de hábito no puede estar vacío");
                   // MessageBox.Show(this, "El estado del tipo de hábito no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de hábito no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtTipoHabitoNombre, "El campo del nombre del tipo de hábito no puede estar vacío");
            }

        }

        private void modificarTipoHabito()
        {
            error.Clear();
            objetoTipoHabito.IdHabitoHigiene = int.Parse(modeloTipoHabito.vector[0]);
            objetoTipoHabito.Nombre = txtTipoHabitoNombre.Text;
            if (radioTipoHabitoActivo.Checked)
            {
                objetoTipoHabito.Estado = 1;
            }
            else
            {
                objetoTipoHabito.Estado = 0;
            }


            if (validarNombreTipoHabito())
            {
                if (validarEstadoTipoHabito())
                {
                    if (logicaTipoHabito.modificarTipoHabito(objetoTipoHabito))
                    {
                        msm.tipoMensaje("Se ha actualizado el tipo de hábito correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado el tipo de hábito correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoHabito();
                        btnTipoHabitoGuardar.Visible = false;
                        //cargarcombox();
                        dataTipoHabito.DataSource = logicaTipoHabito.cargarTipoHabito();

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloTipoHabito.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloTipoHabito.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoHabitoActivo, "El estado del tipo de hábito no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de hábito no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de hábito no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtTipoHabitoNombre, "El campo del nombre del tipo de hábito no puede estar vacío");
            }
        }

        private bool validarNombreTipoHabito()
        {
            if (txtTipoHabitoNombre.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiarTipoHabito()
        {
            txtTipoHabitoNombre.Text = "";
            radioTipoHabitoActivo.Checked = false;
            radioTipoHabitoInactivo.Checked = false;
        }

        private bool validarEstadoTipoHabito()
        {
            if (radioTipoHabitoActivo.Checked || radioTipoHabitoInactivo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //HabitoHigieneRespuesta
        private void btnHabitoHigieneRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnHabitoHigieneModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnHabitoHigieneListar_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private bool validarCampoRespuestaHabitoHigienico()
        {
            bool bandera = false;
            foreach (DataGridViewRow row in dataHabitoHigiene.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    bandera = true;
                }
            }
            return bandera;
        }

        private bool validarCampoFrecuencia()
        {
            //int i = 0, j = 0;
            bool bandera = false;
            foreach (DataGridViewRow row in dataHabitoHigiene.Rows)
            {
                
                if (row.Cells[1].Value == null)
                {
                    bandera = true;
                    //error.SetError(dataAntecedente.Rows[2], "La frecuencia esta vacía");
                }
                //i++;
                //j++;
            }
            return bandera;
        }

        //private bool validarQueNoHallaLetrasEnLaFrecuencia()
        //{
        //    bool ban = false;
        //    Regex num = new Regex("[0-9]");

        //    foreach (DataGridViewRow row in dataHabitoHigiene.Rows)

        //    {
        //        if (num.IsMatch("row.Cells[1].Value"))
        //        {

        //            // errorIcono.SetError((row.Cells(1).Value), "Formato invalido");
        //            MessageBox.Show("" +num);
        //            ban = true;
        //            break;
        //        }
        //    }
        //    return ban;
        //}

        private void button9_Click(object sender, EventArgs e)
        {

            bool ban = false;
            try
            {
                if (!validarQueSeLlenaraRegistroAPaciente())
                {
                    if (validarCampoRespuestaHabitoHigienico())
                    {
                        msm.tipoMensaje("Llena todos los campos de la respuesta", "warning");
                        //MessageBox.Show(this, "Por favor llena todos los campos de la respuesta", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!validarCampoFrecuencia())
                        {
                            // if (!validarQueNoHallaLetrasEnLaFrecuencia())
                            {
                                foreach (DataGridViewRow row in dataHabitoHigiene.Rows)
                                {
                                    objetoHabitoHigiene.IdHistoriaClinica = int.Parse(lblIdHistoriaClinica.Text); //HistoriaClinica 
                                    objetoHabitoHigiene.Observacion = txtObservacionHabitoHigiene.Text; //Observación    
                                    objetoHabitoHigiene.IdRespuesta = row.Cells[0].Value.ToString(); // IdRespuesta
                                    objetoHabitoHigiene.Frecuencia = int.Parse(row.Cells[1].Value.ToString());
                                    objetoHabitoHigiene.IdHabitoHigiene = int.Parse(row.Cells[2].Value.ToString());
                                    objetoHabitoHigiene.Fecha = DateTime.Today;
                                    if (logicaHabitoHigiene.registrarHabitoHigiene(objetoHabitoHigiene))
                                    {
                                        ban = true;
                                    }
                                    else
                                    {
                                        msm.tipoMensaje("Error " + modeloHabitoHigiene.Error, "error");
                                        //MessageBox.Show(this, "Se ha presetado un error al ingresar" + modeloHabitoHigiene.Error, "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                if (ban == true)
                                {
                                    msm.tipoMensaje("El registro se ha ingresado con éxito", "done");
                                    //MessageBox.Show(this, "El registro se ha insertado con éxito", "Ingreso con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiar();
                                }
                            }
                            //else
                            //{
                            //    MessageBox.Show(this, "Formato de campo es erroneo" + modeloHabitoHigiene.Error, "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                        }
                        else
                        {
                            msm.tipoMensaje("Faltan el campo de frecuencia" + modeloHabitoHigiene.Error, "warning");
                            //MessageBox.Show(this, "Faltan el campo de frecuencia" + modeloHabitoHigiene.Error, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    msm.tipoMensaje("Falta asociar paciente, verifica la consulta del paciente", "warning");
                   // MessageBox.Show(this, "Falta asociar paciente, verifica la consulta del paciente", "Falta paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                msm.tipoMensaje("Error " + ex.Message, "error");
               // MessageBox.Show("Error de tipo " + ex.Message);
                // throw;
            }

        }

        private void dataHabitoHigiene_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoDatosFrecuencia(e);
        }

        private void validarIngresoDatosFrecuencia(KeyPressEventArgs e)
        {
            if (dataHabitoHigiene.CurrentCell.ColumnIndex == 3)
            {
                if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
                    e.Handled = false;
                else
                    e.Handled = true;
            }

        }

        private void dataGridDatos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataHabitoHigiene.CurrentCell.ColumnIndex == 4)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataHabitoHigiene_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dataHabitoHigiene_KeyPress);
                }
            }
        }


        // TipoExamenEstomatologico

        private void registrarTipoExamenEstomatologico()
        {
            objetoTipoExamenEstomatologico.Nombre = txtTipoExamenEstomatologicoNombre.Text;
            if (radioTipoExamenEstomatologicoActivo.Checked)
            {
                objetoTipoExamenEstomatologico.Estado = 1;
            }
            else
            {
                objetoTipoExamenEstomatologico.Estado = 0;
            }


            if (validarNombreTipoExamenEstomatologico())
            {
                if (validarEstadoTipoExamenEstomatologico())
                {
                    if (logicaTipoExamenEstomatologico.insertarTipoExamenEstomatologico(objetoTipoExamenEstomatologico))
                    {
                        msm.tipoMensaje("Se ha ingresado el tipo de examen estomatológico correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado el tipo de examen estomatológico correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoExamenEstomatologico();
                        //cargarcombox();
                        dataTipoExamenEstomatologico.DataSource = logicaTipoExamenEstomatologico.cargarTipoExamenEstomatologico();

                    }
                    else
                    {
                        msm.tipoMensaje("Error " + modeloTipoExamenEstomatologico.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloTipoExamenEstomatologico.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoExamenEstomatologicoActivo, "El estado del tipo de examen estomatológico no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de examen estomatológico no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de examen estomatológico no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtTipoExamenEstomatologicoNombre, "El campo del nombre del tipo de examen estomatológico no puede estar vacío");
            }

        }

        private void modificarTipoExamenEstomatologico()
        {
            objetoTipoExamenEstomatologico.IdEstomatologico = int.Parse(modeloTipoExamenEstomatologico.vector[0]);
            objetoTipoExamenEstomatologico.Nombre = txtTipoExamenEstomatologicoNombre.Text;
            if (radioTipoExamenEstomatologicoActivo.Checked)
            {
                objetoTipoExamenEstomatologico.Estado = 1;
            }
            else
            {
                objetoTipoExamenEstomatologico.Estado = 0;
            }


            if (validarNombreTipoExamenEstomatologico())
            {
                if (validarEstadoTipoExamenEstomatologico())
                {
                    if (logicaTipoExamenEstomatologico.modificarTipoExamenEstomatologico(objetoTipoExamenEstomatologico))
                    {
                        msm.tipoMensaje("Se ha actualizado el tipo de examen estomatológico correctamente", "done");
                       // MessageBox.Show(this, "Se ha modificado el tipo de examen estomatológico correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoExamenEstomatologico();
                        btnTipoExamenEstomatologicoGuardar.Visible = false;
                        //cargarcombox();
                        dataTipoExamenEstomatologico.DataSource = logicaTipoExamenEstomatologico.cargarTipoExamenEstomatologico();

                    }
                    else
                    {
                        msm.tipoMensaje("Error "+ modeloTipoExamenEstomatologico.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloTipoExamenEstomatologico.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioTipoExamenEstomatologicoActivo, "El estado del tipo de examen estomatológico no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de examen estomatológico no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de examen estomatológico no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtTipoExamenEstomatologicoNombre, "El campo del nombre del tipo de examen estomatológico no puede estar vacío");
            }
        }

        private bool validarNombreTipoExamenEstomatologico()
        {
            if (txtTipoExamenEstomatologicoNombre.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiarTipoExamenEstomatologico()
        {
            txtTipoExamenEstomatologicoNombre.Text = "";
            radioTipoExamenEstomatologicoActivo.Checked = false;
            radioTipoExamenEstomatologicoInactivo.Checked = false;
        }

        private bool validarEstadoTipoExamenEstomatologico()
        {
            if (radioTipoExamenEstomatologicoActivo.Checked || radioTipoExamenEstomatologicoInactivo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnTipoExamenEstomatologicoRegistrar_Click(object sender, EventArgs e)
        {
            registrarTipoExamenEstomatologico();
        }

        private void btnTipoExamenEstomatologicoModificar_Click(object sender, EventArgs e)
        {
            if (txtTipoExamenEstomatologicoNombre.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del tipo de examen estomatológico que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre del tipo de examen estomatológico que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreTipoExamenEstomatologico = txtTipoExamenEstomatologicoNombre.Text;

                if (modeloTipoExamenEstomatologico.BuscarTipoExamenEstomatologico(nombreTipoExamenEstomatologico))
                {
                    if (int.Parse(modeloTipoExamenEstomatologico.vector[2]) == 0)
                    {
                        radioTipoExamenEstomatologicoInactivo.Select();
                    }
                    else
                    {
                        radioTipoExamenEstomatologicoActivo.Select();
                    }


                    btnTipoExamenEstomatologicoGuardar.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El tipo de examen estomatológico ha actulizar no se encuentra registrado", "warning");
                   // MessageBox.Show(this, "El tipo de examen estomatológico a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTipoExamenEstomatologicoListar_Click(object sender, EventArgs e)
        {
            dataTipoExamenEstomatologico.DataSource = logicaTipoExamenEstomatologico.cargarTipoExamenEstomatologico();
        }

        private void btnTipoExamenEstomatologicoGuardar_Click(object sender, EventArgs e)
        {
            modificarTipoExamenEstomatologico();
        }


        //RespuestaExamenEstomatologico
        private bool validarCampoRespuestaExamenEstomatologico()
        {
            bool bandera = false;
            foreach (DataGridViewRow row in dataExamenEstomatologico.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    bandera = true;
                }
            }
            return bandera;
        }


        //ExamenPulpar
        private void btnGuardarExamenPulpar_Click(object sender, EventArgs e)
        {
                try
                {

                    error.Clear();
                    if (lblIdHistoriaClinica.Text == "")
                    {
                        msm.tipoMensaje("Falta asociar paciente, verifica la consulta del paciente", "warning");
                    }
                    else
                    {
                        if (txtObservacionExamenPulpar.Text == "")
                        {
                            error.SetError(txtTipoEstadoProstodontico, "El campo observación esta vacío");
                        }
                        else
                        {
                            objetoExamenPulpar.IdExamen = int.Parse(lblIdHistoriaClinica.Text);
                            objetoExamenPulpar.Descripcion = txtObservacionExamenPulpar.Text;

                            if (logicaExamenPulpar.insertarExamenPulpar(objetoExamenPulpar))
                            {
                                msm.tipoMensaje("Se ha ingresado el examen pulpar correctamente", "done");
                            }
                            else
                            {
                                msm.tipoMensaje("Error " + modeloExamenPulpar.Error, "error");
                            MessageBox.Show("" + modeloExamenPulpar.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                
                    msm.tipoMensaje("Error " + ex.Message, "error");
                }
            }

        

        //EstadoProstodontico
        private void btnGuardarEstadoProstodontico_Click(object sender, EventArgs e)
        {
            
            if (comboPresenciaProtesis.SelectedIndex == -1)
            {
                error.SetError(comboPresenciaProtesis, "Selecciona el estado prostodóntico");
            }
            else
            {
                try
                {
                    if (lblIdHistoriaClinica.Text == "")
                    {
                        msm.tipoMensaje("Falta asociar paciente, verifica la consulta del paciente", "warning");
                    }
                    else
                    {
                        if (txtTipoEstadoProstodontico.Text == "")
                        {
                            error.SetError(txtTipoEstadoProstodontico, "El campo tipo esta vacío");
                        }
                        else
                        {
                            objetoEstadoProstodontico.IdHistoria = int.Parse(lblIdHistoriaClinica.Text);
                            objetoEstadoProstodontico.PresenciaProtesis = int.Parse(comboPresenciaProtesis.SelectedValue.ToString());
                            objetoEstadoProstodontico.Tipo = txtTipoEstadoProstodontico.Text;
                            objetoEstadoProstodontico.Observacion = txtObservacionEstadoProstodontico.Text;

                            if (logicaEstadoProstodontico.insertarEstadoProstodontico(objetoEstadoProstodontico))
                            {
                                msm.tipoMensaje("Se ha ingresado el estado prostodóntico correctamente", "done");
                            }
                            else
                            {
                                msm.tipoMensaje("Error " + modeloEstadoProstodontico.Error, "error");
                            }
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    msm.tipoMensaje("Error " + ex.Message, "error");
                }
                
            }
        }

        //ExamenEstomatologico
        private void btnExamenEstomatologico_Click(object sender, EventArgs e)
        {
            
            bool ban = false;
            try
            {
                if (!validarQueSeLlenaraRegistroAPaciente())
                {
                    if (validarCampoRespuestaExamenEstomatologico())
                    {
                        msm.tipoMensaje("Llena todos los campos de la respuesta", "warning");
                       // MessageBox.Show(this, "Por favor llena todos los campos de la respuesta", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        foreach (DataGridViewRow row in dataExamenEstomatologico.Rows)
                        {
                            objetoExamenEstomatologico.IdHistoriaClinica = int.Parse(lblIdHistoriaClinica.Text); //HistoriaClinica 
                            objetoExamenEstomatologico.Observacion = txtExamenEstomatologicoObservacion.Text; //Observación    
                            objetoExamenEstomatologico.IdRespuesta = row.Cells[0].Value.ToString(); // IdRespuesta
                            objetoExamenEstomatologico.IdEstomatologico = int.Parse(row.Cells[1].Value.ToString());

                            //objetoExamenEstomatologico.Fecha = DateTime.Today;
                            if (logicaExamenEstomatologico.registrarExamenEstomatologico(objetoExamenEstomatologico))
                            {
                                ban = true;
                            }
                            else
                            {
                                msm.tipoMensaje("Error al ingresar " + modeloHabitoHigiene.Error, "error");
                                //MessageBox.Show(this, "Se ha presentado un error al ingresar" + modeloHabitoHigiene.Error, "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (ban == true)
                        {
                            msm.tipoMensaje("El registro se ha ingresado con éxito", "done");
                            //MessageBox.Show(this, "El registro se ha insertado con éxito", "Ingreso con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }
                    }
                }
                else
                {
                    msm.tipoMensaje("Falta asociar paciente, verifica la consulta del paciente", "warning");
                    //MessageBox.Show(this, "Falta asociar paciente, verifica la consulta del paciente", "Falta paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                msm.tipoMensaje("Error " + ex.Message, "error");
               // MessageBox.Show("Error de tipo " + ex.Message);
                // throw;
            }
        }



        //TipoExamenDental
        private void registrarTipoExamenDental()
        {
            objetoTipoExamenDental.Nombre = txtNombreTipoExamenDental.Text;
            if (radioActivoTipoExamenDental.Checked)
            {
                objetoTipoExamenDental.Estado = 1;
            }
            else
            {
                objetoTipoExamenDental.Estado = 0;
            }


            if (validarNombreTipoExamenDental())
            {
                if (validarEstadoTipoExamenDental())
                {
                    if (logicaTipoExamenDental.insertarTipoExamenDental(objetoTipoExamenDental))
                    {
                        msm.tipoMensaje("Se ha ingresado el tipo de examen dental correctamente", "done");
                        //MessageBox.Show(this, "Se ha insertado el tipo de examen dental correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoExamenDental();
                        //cargarcombox();
                        dataTipoExamenDental.DataSource = logicaTipoExamenDental.cargarTipoExamenDental();

                    }
                    else
                    {
                        msm.tipoMensaje("No se ha ingresado " + modeloTipoExamenDental.Error, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloTipoExamenDental.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioInactivoTipoExamenDental, "El estado del tipo de examen dental no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de examen dental no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de examen dental no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtNombreTipoExamenDental, "El campo del nombre del tipo de examen dental no puede estar vacío");
            }

        }

        private void modificarTipoExamenDental()
        {
            objetoTipoExamenDental.IdDental = int.Parse(modeloTipoExamenDental.vector[0]);
            objetoTipoExamenDental.Nombre = txtNombreTipoExamenDental.Text;
            if (radioActivoTipoExamenDental.Checked)
            {
                objetoTipoExamenDental.Estado = 1;
            }
            else
            {
                objetoTipoExamenDental.Estado = 0;
            }


            if (validarNombreTipoExamenDental())
            {
                if (validarEstadoTipoExamenDental())
                {
                    if (logicaTipoExamenDental.modificarTipoExamenDental(objetoTipoExamenDental))
                    {
                        msm.tipoMensaje("Se ha actualizado el tipo de examen dental correctamente", "done");
                        //MessageBox.Show(this, "Se ha modificado el tipo de examen dental correctamente", "Registro éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarTipoExamenDental();
                        btnGuardarTipoExamenDental.Visible = false;
                        //cargarcombox();
                        dataTipoExamenDental.DataSource = logicaTipoExamenDental.cargarTipoExamenDental();

                    }
                    else
                    {
                        msm.tipoMensaje("No se ha ingresado " + modeloTipoExamenDental, "error");
                        //MessageBox.Show(this, "No se ha insertado " + modeloTipoExamenDental.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error.SetError(radioActivoTipoExamenDental, "El estado del tipo de examen dental no puede estar vacío");
                    //MessageBox.Show(this, "El estado del tipo de examen dental no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show(this, "El campo del nombre del tipo de examen dental no puede estar vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error.SetError(txtNombreTipoExamenDental, "El campo del nombre del tipo de examen dental no puede estar vacío");
            }
        }

        private bool validarNombreTipoExamenDental()
        {
            if (txtNombreTipoExamenDental.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiarTipoExamenDental()
        {
            txtNombreTipoExamenDental.Text = "";
            radioActivoTipoExamenDental.Checked = false;
            radioInactivoTipoExamenDental.Checked = false;
        }

        private bool validarEstadoTipoExamenDental()
        {
            if (radioActivoTipoExamenDental.Checked || radioInactivoTipoExamenDental.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnRegistrarTipoExamenDental_Click(object sender, EventArgs e)
        {
            registrarTipoExamenDental();
        }

        private void btnModificarTipoExamenDental_Click(object sender, EventArgs e)
        {
            if (txtNombreTipoExamenDental.Text == "")
            {
                msm.tipoMensaje("Ingrese el nombre del tipo de examen dental que desea buscar", "warning");
                //MessageBox.Show(this, "Por favor ingrese el nombre del tipo de examen dental que desea buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombreTipoExamenDental = txtNombreTipoExamenDental.Text;

                if (modeloTipoExamenDental.BuscarTipoExamenDental(nombreTipoExamenDental))
                {
                    if (int.Parse(modeloTipoExamenDental.vector[2]) == 0)
                    {
                        radioInactivoTipoExamenDental.Select();
                    }
                    else
                    {
                        radioActivoTipoExamenDental.Select();
                    }


                    btnGuardarTipoExamenDental.Visible = true;
                }
                else
                {
                    msm.tipoMensaje("El tipo de examen dental ha actualizar no se encuentra registrado", "warning");
                    //MessageBox.Show(this, "El tipo de examen dental a modificar no se encuentra registrado", "No se encuentra registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnListarTipoExamenDental_Click(object sender, EventArgs e)
        {
            dataTipoExamenDental.DataSource = logicaTipoExamenDental.cargarTipoExamenDental();
        }

        private void btnGuardarTipoExamenDental_Click(object sender, EventArgs e)
        {
            modificarTipoExamenDental();
        }



        //ExamenDental

        private bool validarCampoRespuestaExamenDental()
        {
            bool bandera = false;
            foreach (DataGridViewRow row in dataExamenDental.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    bandera = true;
                }
            }
            return bandera;
        }
        
        private void btnGuardarExamenDental_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + objetoExamenDental.IdHistoriaClinica);
            bool ban = false;
            try
            {
                if (!validarQueSeLlenaraRegistroAPaciente())
                {
                    if (validarCampoRespuestaExamenDental())
                    {
                        msm.tipoMensaje("Llena todos los campos de la respuesta", "warning");
                       // MessageBox.Show(this, "Por favor llena todos los campos de la respuesta", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        foreach (DataGridViewRow row in dataExamenDental.Rows)
                        {
                            objetoExamenDental.IdHistoriaClinica = int.Parse(lblIdHistoriaClinica.Text); //HistoriaClinica 
                            objetoExamenDental.Observacion = txtObservacionExamenDental.Text; //Observación    
                            objetoExamenDental.IdRespuesta = row.Cells[0].Value.ToString(); // IdRespuesta
                            objetoExamenDental.IdDental = int.Parse(row.Cells[1].Value.ToString());

                            //objetoExamenEstomatologico.Fecha = DateTime.Today;
                            if (logicaExamenDental.registrarExamenDental(objetoExamenDental))
                            {
                                ban = true;
                            }
                            else
                            {
                                msm.tipoMensaje("Error al ingresar " + modeloExamenDental.Error, "error");
                                //MessageBox.Show(this, "Se ha presentado un error al ingresar" + modeloExamenDental.Error, "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (ban == true)
                        {
                            msm.tipoMensaje("El registro se ha ingresado con éxito", "done");
                            //MessageBox.Show(this, "El registro se ha insertado con éxito", "Ingreso con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }
                    }
                }
                else
                {
                    msm.tipoMensaje("Falta asociar paciente, verifica la consulta del paciente", "warning");
                    //MessageBox.Show(this, "Falta asociar paciente, verifica la consulta del paciente", "Falta paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                msm.tipoMensaje("Error " + ex.Message, "error");
                //MessageBox.Show("Error de tipo " + ex.Message);
                // throw;
            }
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabAntecedente)
            {
                materialTabSelector2.Visible = true;
                materialTabSelector3.Visible = false;
                materialTabSelector4.Visible = false;
                materialTabSelector5.Visible = false;
                
            }
            else
            {
                if (materialTabControl1.SelectedTab == tabHabitoHigienico)
                {
                    materialTabSelector2.Visible = false;
                    materialTabSelector3.Visible = true;
                    materialTabSelector4.Visible = false;
                    materialTabSelector5.Visible = false;
                    materialTabSelector6.Visible = false;
                }
                else
                {
                    if (materialTabControl1.SelectedTab == tabExamenesEstomatologicos)
                    {
                        materialTabSelector2.Visible = false;
                        materialTabSelector3.Visible = false;
                        materialTabSelector4.Visible = true;
                        materialTabSelector5.Visible = false;
                        materialTabSelector6.Visible = false;
                    }
                    else
                    {
                        if (materialTabControl1.SelectedTab == tabExamenDental)
                        {
                            materialTabSelector2.Visible = false;
                            materialTabSelector3.Visible = false;
                            materialTabSelector4.Visible = false;
                            materialTabSelector5.Visible = true;
                            materialTabSelector6.Visible = false;
                        }
                        else
                        {
                            if (materialTabControl1.SelectedTab == tabObservaciones)
                            {
                                materialTabSelector2.Visible = false;
                                materialTabSelector3.Visible = false;
                                materialTabSelector4.Visible = false;
                                materialTabSelector5.Visible = false;
                                materialTabSelector6.Visible = true;
                            }
                            else
                            {
                                if (materialTabControl1.SelectedTab == tabEstadoProstodontico)
                                {
                                    materialTabSelector2.Visible = false;
                                    materialTabSelector3.Visible = false;
                                    materialTabSelector4.Visible = false;
                                    materialTabSelector5.Visible = false;
                                    materialTabSelector6.Visible = false;
                                }
                                else
                                {
                                    materialTabSelector2.Visible = false;
                                    materialTabSelector3.Visible = false;
                                    materialTabSelector4.Visible = false;
                                    materialTabSelector5.Visible = false;
                                    materialTabSelector6.Visible = false;
                                }
                                
                            }
                        }
                    }
                }
            }
        }

        private void dataAntecedente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataAntecedente.Columns[e.ColumnIndex].Name == "comboAntecedenteTipo")
            //{
            //    DataGridViewRow row = dataAntecedente.Rows[e.RowIndex];

            //    DataGridViewComboBoxEditingControl celdaSeleccionada = row.Cells["comboAntecedenteTipo"] as DataGridViewComboBoxEditingControl;

            //    if (Convert.ToBoolean(celdaSeleccionada.Value))
            //    {
            //        string mensaje = string.Format("evento celdaSeleccionada.\n\nSe ha seleccionado, \nIdTipoAntecedente: '{1}'"
            //            , row.Cells["idTipoAntecedente"].Value);

            //        MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        string mensaje = string.Format("No se ha seleccionado el campo"
            //           , row.Cells["idTipoAntecedente"].Value);

            //        MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
        

        //Cambio de tamaño de letra

        private void cambioLetra(KeyPressEventArgs e, MaterialSingleLineTextField txt)
        {
            if (Char.IsLower(e.KeyChar))
            {
                txt.SelectedText = Convert.ToString(Char.ToUpper(e.KeyChar));
                e.Handled = true;
            }

        }

        private void txtNumeroHistoriaClinica_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtNumeroHistoriaClinica);
        }

        private void txtDocumentoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtDocumentoPaciente);
        }

        private void txtTipoAntecedenteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtTipoAntecedenteNombre);
        }

        private void txtObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtObservacion);
        }

        private void txtTipoHabitoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtTipoHabitoNombre);
        }

        private void txtObservacionHabitoHigiene_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtObservacionHabitoHigiene);
        }

        private void txtTipoExamenEstomatologicoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtTipoExamenEstomatologicoNombre);
        }

        private void txtExamenEstomatologicoObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtExamenEstomatologicoObservacion);
        }

        private void txtNombreTipoExamenDental_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtNombreTipoExamenDental);
        }

        private void txtObservacionExamenDental_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtObservacionExamenDental);
        }

        private void txtRespuestaHistoriaClinicaNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambioLetra(e, txtRespuestaHistoriaClinicaNombre);
        }

        private void materialTabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataRespuestaHistoriaClinica.DataSource = logicaRespuestaHistoriaClinica.cargarRespuestaHistoriaClinica();
        }

       
    }
}
