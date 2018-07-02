namespace Oclusoft_Prueba_Material_Design
{
    partial class Consultorio
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
            this.dataConsultorio = new System.Windows.Forms.DataGridView();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConsultorioGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtConsultorioDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnConsultorioListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConsultorioModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioConsultorioActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnConsultorioRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioConsultorioInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataConsultorio
            // 
            this.dataConsultorio.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataConsultorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsultorio.Location = new System.Drawing.Point(46, 194);
            this.dataConsultorio.Name = "dataConsultorio";
            this.dataConsultorio.Size = new System.Drawing.Size(725, 154);
            this.dataConsultorio.TabIndex = 31;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(352, 72);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(118, 19);
            this.materialLabel17.TabIndex = 22;
            this.materialLabel17.Text = "CONSULTORIOS";
            // 
            // btnConsultorioGuardar
            // 
            this.btnConsultorioGuardar.Depth = 0;
            this.btnConsultorioGuardar.Location = new System.Drawing.Point(663, 153);
            this.btnConsultorioGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultorioGuardar.Name = "btnConsultorioGuardar";
            this.btnConsultorioGuardar.Primary = true;
            this.btnConsultorioGuardar.Size = new System.Drawing.Size(108, 35);
            this.btnConsultorioGuardar.TabIndex = 30;
            this.btnConsultorioGuardar.Text = "Guardar";
            this.btnConsultorioGuardar.UseVisualStyleBackColor = true;
            this.btnConsultorioGuardar.Visible = false;
            this.btnConsultorioGuardar.Click += new System.EventHandler(this.btnConsultorioGuardar_Click);
            // 
            // txtConsultorioDescripcion
            // 
            this.txtConsultorioDescripcion.Depth = 0;
            this.txtConsultorioDescripcion.Hint = "";
            this.txtConsultorioDescripcion.Location = new System.Drawing.Point(292, 112);
            this.txtConsultorioDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConsultorioDescripcion.Name = "txtConsultorioDescripcion";
            this.txtConsultorioDescripcion.PasswordChar = '\0';
            this.txtConsultorioDescripcion.SelectedText = "";
            this.txtConsultorioDescripcion.SelectionLength = 0;
            this.txtConsultorioDescripcion.SelectionStart = 0;
            this.txtConsultorioDescripcion.Size = new System.Drawing.Size(149, 23);
            this.txtConsultorioDescripcion.TabIndex = 24;
            this.txtConsultorioDescripcion.UseSystemPasswordChar = false;
            this.txtConsultorioDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultorioDescripcion_KeyPress);
            // 
            // btnConsultorioListar
            // 
            this.btnConsultorioListar.Depth = 0;
            this.btnConsultorioListar.Location = new System.Drawing.Point(432, 153);
            this.btnConsultorioListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultorioListar.Name = "btnConsultorioListar";
            this.btnConsultorioListar.Primary = true;
            this.btnConsultorioListar.Size = new System.Drawing.Size(108, 35);
            this.btnConsultorioListar.TabIndex = 29;
            this.btnConsultorioListar.Text = "Listar";
            this.btnConsultorioListar.UseVisualStyleBackColor = true;
            this.btnConsultorioListar.Click += new System.EventHandler(this.btnConsultorioListar_Click);
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(42, 113);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(168, 19);
            this.materialLabel15.TabIndex = 23;
            this.materialLabel15.Text = "Nùmero del consultorio";
            // 
            // btnConsultorioModificar
            // 
            this.btnConsultorioModificar.Depth = 0;
            this.btnConsultorioModificar.Location = new System.Drawing.Point(236, 153);
            this.btnConsultorioModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultorioModificar.Name = "btnConsultorioModificar";
            this.btnConsultorioModificar.Primary = true;
            this.btnConsultorioModificar.Size = new System.Drawing.Size(102, 35);
            this.btnConsultorioModificar.TabIndex = 28;
            this.btnConsultorioModificar.Text = "Actualizar";
            this.btnConsultorioModificar.UseVisualStyleBackColor = true;
            this.btnConsultorioModificar.Click += new System.EventHandler(this.btnConsultorioModificar_Click);
            // 
            // radioConsultorioActivo
            // 
            this.radioConsultorioActivo.AutoSize = true;
            this.radioConsultorioActivo.CausesValidation = false;
            this.radioConsultorioActivo.Checked = true;
            this.radioConsultorioActivo.Depth = 0;
            this.radioConsultorioActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioConsultorioActivo.Location = new System.Drawing.Point(575, 108);
            this.radioConsultorioActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioConsultorioActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioConsultorioActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioConsultorioActivo.Name = "radioConsultorioActivo";
            this.radioConsultorioActivo.Ripple = true;
            this.radioConsultorioActivo.Size = new System.Drawing.Size(68, 30);
            this.radioConsultorioActivo.TabIndex = 25;
            this.radioConsultorioActivo.TabStop = true;
            this.radioConsultorioActivo.Text = "Activo";
            this.radioConsultorioActivo.UseVisualStyleBackColor = true;
            // 
            // btnConsultorioRegistrar
            // 
            this.btnConsultorioRegistrar.Depth = 0;
            this.btnConsultorioRegistrar.Location = new System.Drawing.Point(46, 153);
            this.btnConsultorioRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultorioRegistrar.Name = "btnConsultorioRegistrar";
            this.btnConsultorioRegistrar.Primary = true;
            this.btnConsultorioRegistrar.Size = new System.Drawing.Size(100, 35);
            this.btnConsultorioRegistrar.TabIndex = 27;
            this.btnConsultorioRegistrar.Text = "Registrar";
            this.btnConsultorioRegistrar.UseVisualStyleBackColor = true;
            this.btnConsultorioRegistrar.Click += new System.EventHandler(this.btnConsultorioRegistrar_Click);
            // 
            // radioConsultorioInactivo
            // 
            this.radioConsultorioInactivo.AutoSize = true;
            this.radioConsultorioInactivo.Depth = 0;
            this.radioConsultorioInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioConsultorioInactivo.Location = new System.Drawing.Point(693, 105);
            this.radioConsultorioInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioConsultorioInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioConsultorioInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioConsultorioInactivo.Name = "radioConsultorioInactivo";
            this.radioConsultorioInactivo.Ripple = true;
            this.radioConsultorioInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioConsultorioInactivo.TabIndex = 26;
            this.radioConsultorioInactivo.Text = "Inactivo";
            this.radioConsultorioInactivo.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.Red;
            this.materialLabel1.Location = new System.Drawing.Point(206, 113);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(15, 19);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "*";
            // 
            // Consultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 358);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataConsultorio);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.btnConsultorioGuardar);
            this.Controls.Add(this.txtConsultorioDescripcion);
            this.Controls.Add(this.btnConsultorioListar);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.btnConsultorioModificar);
            this.Controls.Add(this.radioConsultorioActivo);
            this.Controls.Add(this.btnConsultorioRegistrar);
            this.Controls.Add(this.radioConsultorioInactivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consultorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio";
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataConsultorio;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultorioGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConsultorioDescripcion;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultorioListar;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultorioModificar;
        private MaterialSkin.Controls.MaterialRadioButton radioConsultorioActivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultorioRegistrar;
        private MaterialSkin.Controls.MaterialRadioButton radioConsultorioInactivo;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}