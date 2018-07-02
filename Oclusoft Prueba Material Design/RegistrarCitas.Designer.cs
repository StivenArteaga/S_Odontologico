namespace Oclusoft_Prueba_Material_Design
{
    partial class RegistrarCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboRCitaEstado = new System.Windows.Forms.ComboBox();
            this.LnombreRC = new System.Windows.Forms.Label();
            this.btnRCitabuscarxdoc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateRCitaFecha = new System.Windows.Forms.DateTimePicker();
            this.txtRCitaDocumentoPaciente = new System.Windows.Forms.TextBox();
            this.BTNpcguardar = new System.Windows.Forms.Button();
            this.txtRCitaMotivo = new System.Windows.Forms.RichTextBox();
            this.txtRCitaDuracion = new System.Windows.Forms.TextBox();
            this.timeRCitaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.comboRCitaOdontologo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRCitaEstado
            // 
            this.comboRCitaEstado.FormattingEnabled = true;
            this.comboRCitaEstado.Items.AddRange(new object[] {
            "Activo ",
            "Inactivo",
            "Cita Cancelada"});
            this.comboRCitaEstado.Location = new System.Drawing.Point(571, 313);
            this.comboRCitaEstado.Name = "comboRCitaEstado";
            this.comboRCitaEstado.Size = new System.Drawing.Size(121, 21);
            this.comboRCitaEstado.TabIndex = 49;
            // 
            // LnombreRC
            // 
            this.LnombreRC.AutoSize = true;
            this.LnombreRC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnombreRC.Location = new System.Drawing.Point(469, 58);
            this.LnombreRC.Name = "LnombreRC";
            this.LnombreRC.Size = new System.Drawing.Size(0, 18);
            this.LnombreRC.TabIndex = 48;
            // 
            // btnRCitabuscarxdoc
            // 
            this.btnRCitabuscarxdoc.Location = new System.Drawing.Point(378, 56);
            this.btnRCitabuscarxdoc.Name = "btnRCitabuscarxdoc";
            this.btnRCitabuscarxdoc.Size = new System.Drawing.Size(33, 23);
            this.btnRCitabuscarxdoc.TabIndex = 47;
            this.btnRCitabuscarxdoc.Text = "...";
            this.btnRCitabuscarxdoc.UseVisualStyleBackColor = true;
            this.btnRCitabuscarxdoc.Click += new System.EventHandler(this.BTNbuscarxdocumentoRC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Documento Paciente";
            // 
            // dateRCitaFecha
            // 
            this.dateRCitaFecha.Location = new System.Drawing.Point(138, 93);
            this.dateRCitaFecha.Name = "dateRCitaFecha";
            this.dateRCitaFecha.Size = new System.Drawing.Size(216, 20);
            this.dateRCitaFecha.TabIndex = 45;
            // 
            // txtRCitaDocumentoPaciente
            // 
            this.txtRCitaDocumentoPaciente.Location = new System.Drawing.Point(228, 56);
            this.txtRCitaDocumentoPaciente.Name = "txtRCitaDocumentoPaciente";
            this.txtRCitaDocumentoPaciente.Size = new System.Drawing.Size(127, 20);
            this.txtRCitaDocumentoPaciente.TabIndex = 44;
            // 
            // BTNpcguardar
            // 
            this.BTNpcguardar.Location = new System.Drawing.Point(451, 386);
            this.BTNpcguardar.Name = "BTNpcguardar";
            this.BTNpcguardar.Size = new System.Drawing.Size(75, 23);
            this.BTNpcguardar.TabIndex = 43;
            this.BTNpcguardar.Text = "Registrar";
            this.BTNpcguardar.UseVisualStyleBackColor = true;
            this.BTNpcguardar.Click += new System.EventHandler(this.BTNpcguardar_Click);
            // 
            // txtRCitaMotivo
            // 
            this.txtRCitaMotivo.Location = new System.Drawing.Point(76, 273);
            this.txtRCitaMotivo.Name = "txtRCitaMotivo";
            this.txtRCitaMotivo.Size = new System.Drawing.Size(240, 74);
            this.txtRCitaMotivo.TabIndex = 42;
            this.txtRCitaMotivo.Text = "";
            // 
            // txtRCitaDuracion
            // 
            this.txtRCitaDuracion.Location = new System.Drawing.Point(571, 228);
            this.txtRCitaDuracion.Name = "txtRCitaDuracion";
            this.txtRCitaDuracion.Size = new System.Drawing.Size(126, 20);
            this.txtRCitaDuracion.TabIndex = 41;
            // 
            // timeRCitaHoraInicio
            // 
            this.timeRCitaHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeRCitaHoraInicio.Location = new System.Drawing.Point(571, 172);
            this.timeRCitaHoraInicio.Name = "timeRCitaHoraInicio";
            this.timeRCitaHoraInicio.ShowUpDown = true;
            this.timeRCitaHoraInicio.Size = new System.Drawing.Size(126, 20);
            this.timeRCitaHoraInicio.TabIndex = 40;
            // 
            // comboRCitaOdontologo
            // 
            this.comboRCitaOdontologo.FormattingEnabled = true;
            this.comboRCitaOdontologo.Location = new System.Drawing.Point(190, 190);
            this.comboRCitaOdontologo.Name = "comboRCitaOdontologo";
            this.comboRCitaOdontologo.Size = new System.Drawing.Size(126, 21);
            this.comboRCitaOdontologo.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Duración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Hora Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Odontólogo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Registrar Cita";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 50;
            this.label8.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Motivo";
            // 
            // RegistrarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 439);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboRCitaEstado);
            this.Controls.Add(this.LnombreRC);
            this.Controls.Add(this.btnRCitabuscarxdoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateRCitaFecha);
            this.Controls.Add(this.txtRCitaDocumentoPaciente);
            this.Controls.Add(this.BTNpcguardar);
            this.Controls.Add(this.txtRCitaMotivo);
            this.Controls.Add(this.txtRCitaDuracion);
            this.Controls.Add(this.timeRCitaHoraInicio);
            this.Controls.Add(this.comboRCitaOdontologo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarCitas";
            this.Text = "RegistrarCitas";
            this.Load += new System.EventHandler(this.RegistrarCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRCitaEstado;
        private System.Windows.Forms.Label LnombreRC;
        private System.Windows.Forms.Button btnRCitabuscarxdoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateRCitaFecha;
        private System.Windows.Forms.TextBox txtRCitaDocumentoPaciente;
        private System.Windows.Forms.Button BTNpcguardar;
        private System.Windows.Forms.RichTextBox txtRCitaMotivo;
        private System.Windows.Forms.TextBox txtRCitaDuracion;
        private System.Windows.Forms.DateTimePicker timeRCitaHoraInicio;
        private System.Windows.Forms.ComboBox comboRCitaOdontologo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}