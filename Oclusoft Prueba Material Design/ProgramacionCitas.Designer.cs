namespace Oclusoft_Prueba_Material_Design
{
    partial class ProgramacionCitas
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
            this.btnPCitasBuscarXDocumento = new System.Windows.Forms.Button();
            this.btnPCitasBuscarXFecha = new System.Windows.Forms.Button();
            this.LnombrePC = new System.Windows.Forms.Label();
            this.BTNregistrarPC = new System.Windows.Forms.Button();
            this.DGVcitasPC = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNconsultarPC = new System.Windows.Forms.Button();
            this.txtPCitasDocumento = new System.Windows.Forms.TextBox();
            this.MCfechaPC = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcitasPC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPCitasBuscarXDocumento
            // 
            this.btnPCitasBuscarXDocumento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCitasBuscarXDocumento.Location = new System.Drawing.Point(203, 265);
            this.btnPCitasBuscarXDocumento.Name = "btnPCitasBuscarXDocumento";
            this.btnPCitasBuscarXDocumento.Size = new System.Drawing.Size(34, 23);
            this.btnPCitasBuscarXDocumento.TabIndex = 23;
            this.btnPCitasBuscarXDocumento.Text = "...";
            this.btnPCitasBuscarXDocumento.UseVisualStyleBackColor = true;
            this.btnPCitasBuscarXDocumento.Click += new System.EventHandler(this.btnPCitasBuscarXDocumento_Click);
            // 
            // btnPCitasBuscarXFecha
            // 
            this.btnPCitasBuscarXFecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCitasBuscarXFecha.Location = new System.Drawing.Point(203, 40);
            this.btnPCitasBuscarXFecha.Name = "btnPCitasBuscarXFecha";
            this.btnPCitasBuscarXFecha.Size = new System.Drawing.Size(34, 23);
            this.btnPCitasBuscarXFecha.TabIndex = 22;
            this.btnPCitasBuscarXFecha.Text = "...";
            this.btnPCitasBuscarXFecha.UseVisualStyleBackColor = true;
            this.btnPCitasBuscarXFecha.Click += new System.EventHandler(this.btnPCitasBuscarXFecha_Click);
            // 
            // LnombrePC
            // 
            this.LnombrePC.AutoSize = true;
            this.LnombrePC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnombrePC.Location = new System.Drawing.Point(42, 353);
            this.LnombrePC.Name = "LnombrePC";
            this.LnombrePC.Size = new System.Drawing.Size(223, 18);
            this.LnombrePC.TabIndex = 21;
            this.LnombrePC.Text = "Aquí va el nombre del Paciente";
            // 
            // BTNregistrarPC
            // 
            this.BTNregistrarPC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNregistrarPC.Location = new System.Drawing.Point(858, 348);
            this.BTNregistrarPC.Name = "BTNregistrarPC";
            this.BTNregistrarPC.Size = new System.Drawing.Size(78, 23);
            this.BTNregistrarPC.TabIndex = 20;
            this.BTNregistrarPC.Text = "Ingresar Cita";
            this.BTNregistrarPC.UseVisualStyleBackColor = true;
            this.BTNregistrarPC.Click += new System.EventHandler(this.BTNregistrarPC_Click);
            // 
            // DGVcitasPC
            // 
            this.DGVcitasPC.BackgroundColor = System.Drawing.Color.MintCream;
            this.DGVcitasPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcitasPC.Location = new System.Drawing.Point(337, 71);
            this.DGVcitasPC.Name = "DGVcitasPC";
            this.DGVcitasPC.Size = new System.Drawing.Size(599, 243);
            this.DGVcitasPC.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Documento";
            // 
            // BTNconsultarPC
            // 
            this.BTNconsultarPC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNconsultarPC.Location = new System.Drawing.Point(747, 348);
            this.BTNconsultarPC.Name = "BTNconsultarPC";
            this.BTNconsultarPC.Size = new System.Drawing.Size(75, 23);
            this.BTNconsultarPC.TabIndex = 16;
            this.BTNconsultarPC.Text = "Consultar";
            this.BTNconsultarPC.UseVisualStyleBackColor = true;
            this.BTNconsultarPC.Click += new System.EventHandler(this.BTNconsultarPC_Click);
            // 
            // txtPCitasDocumento
            // 
            this.txtPCitasDocumento.Location = new System.Drawing.Point(45, 294);
            this.txtPCitasDocumento.Name = "txtPCitasDocumento";
            this.txtPCitasDocumento.Size = new System.Drawing.Size(192, 20);
            this.txtPCitasDocumento.TabIndex = 15;
            // 
            // MCfechaPC
            // 
            this.MCfechaPC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MCfechaPC.Location = new System.Drawing.Point(45, 71);
            this.MCfechaPC.MaxSelectionCount = 1;
            this.MCfechaPC.Name = "MCfechaPC";
            this.MCfechaPC.ShowTodayCircle = false;
            this.MCfechaPC.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Citas";
            // 
            // ProgramacionCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 408);
            this.Controls.Add(this.btnPCitasBuscarXDocumento);
            this.Controls.Add(this.btnPCitasBuscarXFecha);
            this.Controls.Add(this.LnombrePC);
            this.Controls.Add(this.BTNregistrarPC);
            this.Controls.Add(this.DGVcitasPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNconsultarPC);
            this.Controls.Add(this.txtPCitasDocumento);
            this.Controls.Add(this.MCfechaPC);
            this.Controls.Add(this.label1);
            this.Name = "ProgramacionCitas";
            this.Text = "ProgramacionCitas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVcitasPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPCitasBuscarXDocumento;
        private System.Windows.Forms.Button btnPCitasBuscarXFecha;
        private System.Windows.Forms.Label LnombrePC;
        private System.Windows.Forms.Button BTNregistrarPC;
        private System.Windows.Forms.DataGridView DGVcitasPC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNconsultarPC;
        private System.Windows.Forms.TextBox txtPCitasDocumento;
        private System.Windows.Forms.MonthCalendar MCfechaPC;
        private System.Windows.Forms.Label label1;
    }
}