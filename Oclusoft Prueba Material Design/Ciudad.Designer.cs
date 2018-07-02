namespace Oclusoft_Prueba_Material_Design
{
    partial class Ciudad
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
            this.dataCiudad = new System.Windows.Forms.DataGridView();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCiudadGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCiudadListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCiudadNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCiudadModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboidDepartamento = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.radioCiudadInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioCiudadActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCiudad
            // 
            this.dataCiudad.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCiudad.Location = new System.Drawing.Point(37, 230);
            this.dataCiudad.Name = "dataCiudad";
            this.dataCiudad.Size = new System.Drawing.Size(725, 151);
            this.dataCiudad.TabIndex = 14;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(359, 77);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(81, 19);
            this.materialLabel8.TabIndex = 25;
            this.materialLabel8.Text = "CIUDADES";
            // 
            // btnCiudadGuardar
            // 
            this.btnCiudadGuardar.Depth = 0;
            this.btnCiudadGuardar.Location = new System.Drawing.Point(656, 187);
            this.btnCiudadGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCiudadGuardar.Name = "btnCiudadGuardar";
            this.btnCiudadGuardar.Primary = true;
            this.btnCiudadGuardar.Size = new System.Drawing.Size(108, 37);
            this.btnCiudadGuardar.TabIndex = 24;
            this.btnCiudadGuardar.Text = "Guardar";
            this.btnCiudadGuardar.UseVisualStyleBackColor = true;
            this.btnCiudadGuardar.Visible = false;
            this.btnCiudadGuardar.Click += new System.EventHandler(this.btnCiudadGuardar_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(33, 109);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(184, 19);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Nombre del departamento";
            // 
            // btnCiudadListar
            // 
            this.btnCiudadListar.Depth = 0;
            this.btnCiudadListar.Location = new System.Drawing.Point(425, 187);
            this.btnCiudadListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCiudadListar.Name = "btnCiudadListar";
            this.btnCiudadListar.Primary = true;
            this.btnCiudadListar.Size = new System.Drawing.Size(108, 37);
            this.btnCiudadListar.TabIndex = 23;
            this.btnCiudadListar.Text = "Listar";
            this.btnCiudadListar.UseVisualStyleBackColor = true;
            this.btnCiudadListar.Click += new System.EventHandler(this.btnCiudadListar_Click);
            // 
            // txtCiudadNombre
            // 
            this.txtCiudadNombre.Depth = 0;
            this.txtCiudadNombre.Hint = "";
            this.txtCiudadNombre.Location = new System.Drawing.Point(282, 153);
            this.txtCiudadNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCiudadNombre.Name = "txtCiudadNombre";
            this.txtCiudadNombre.PasswordChar = '\0';
            this.txtCiudadNombre.SelectedText = "";
            this.txtCiudadNombre.SelectionLength = 0;
            this.txtCiudadNombre.SelectionStart = 0;
            this.txtCiudadNombre.Size = new System.Drawing.Size(150, 23);
            this.txtCiudadNombre.TabIndex = 16;
            this.txtCiudadNombre.UseSystemPasswordChar = false;
            this.txtCiudadNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudadNombre_KeyPress);
            // 
            // btnCiudadModificar
            // 
            this.btnCiudadModificar.Depth = 0;
            this.btnCiudadModificar.Location = new System.Drawing.Point(229, 187);
            this.btnCiudadModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCiudadModificar.Name = "btnCiudadModificar";
            this.btnCiudadModificar.Primary = true;
            this.btnCiudadModificar.Size = new System.Drawing.Size(102, 37);
            this.btnCiudadModificar.TabIndex = 22;
            this.btnCiudadModificar.Text = "Actualizar";
            this.btnCiudadModificar.UseVisualStyleBackColor = true;
            this.btnCiudadModificar.Click += new System.EventHandler(this.btnCiudadModificar_Click);
            // 
            // comboidDepartamento
            // 
            this.comboidDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboidDepartamento.FormattingEnabled = true;
            this.comboidDepartamento.Location = new System.Drawing.Point(283, 109);
            this.comboidDepartamento.Name = "comboidDepartamento";
            this.comboidDepartamento.Size = new System.Drawing.Size(149, 24);
            this.comboidDepartamento.TabIndex = 17;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(37, 187);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(102, 37);
            this.materialRaisedButton2.TabIndex = 21;
            this.materialRaisedButton2.Text = "Ingresar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.btnCiudadRegistrar_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(33, 153);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(147, 19);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "Nombre de la ciudad";
            // 
            // radioCiudadInactivo
            // 
            this.radioCiudadInactivo.AutoSize = true;
            this.radioCiudadInactivo.Depth = 0;
            this.radioCiudadInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioCiudadInactivo.Location = new System.Drawing.Point(684, 123);
            this.radioCiudadInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioCiudadInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioCiudadInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioCiudadInactivo.Name = "radioCiudadInactivo";
            this.radioCiudadInactivo.Ripple = true;
            this.radioCiudadInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioCiudadInactivo.TabIndex = 20;
            this.radioCiudadInactivo.Text = "Inactivo";
            this.radioCiudadInactivo.UseVisualStyleBackColor = true;
            // 
            // radioCiudadActivo
            // 
            this.radioCiudadActivo.AutoSize = true;
            this.radioCiudadActivo.Checked = true;
            this.radioCiudadActivo.Depth = 0;
            this.radioCiudadActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioCiudadActivo.Location = new System.Drawing.Point(551, 123);
            this.radioCiudadActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioCiudadActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioCiudadActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioCiudadActivo.Name = "radioCiudadActivo";
            this.radioCiudadActivo.Ripple = true;
            this.radioCiudadActivo.Size = new System.Drawing.Size(68, 30);
            this.radioCiudadActivo.TabIndex = 19;
            this.radioCiudadActivo.TabStop = true;
            this.radioCiudadActivo.Text = "Activo";
            this.radioCiudadActivo.UseVisualStyleBackColor = true;
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
            this.materialLabel1.Location = new System.Drawing.Point(214, 109);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(15, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "*";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.Red;
            this.materialLabel2.Location = new System.Drawing.Point(177, 153);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(15, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "*";
            // 
            // Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 393);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataCiudad);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.btnCiudadGuardar);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btnCiudadListar);
            this.Controls.Add(this.txtCiudadNombre);
            this.Controls.Add(this.btnCiudadModificar);
            this.Controls.Add(this.comboidDepartamento);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.radioCiudadInactivo);
            this.Controls.Add(this.radioCiudadActivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ciudad";
            this.Text = "Ciudad";
            this.Load += new System.EventHandler(this.Ciudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCiudad;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialRaisedButton btnCiudadGuardar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRaisedButton btnCiudadListar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCiudadNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnCiudadModificar;
        private System.Windows.Forms.ComboBox comboidDepartamento;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRadioButton radioCiudadInactivo;
        private MaterialSkin.Controls.MaterialRadioButton radioCiudadActivo;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}