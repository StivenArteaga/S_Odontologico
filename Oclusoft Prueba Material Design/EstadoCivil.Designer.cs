namespace Oclusoft_Prueba_Material_Design
{
    partial class EstadoCivil
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
            this.dataEstadoCivil = new System.Windows.Forms.DataGridView();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.radioEstadoCivilInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtEstadoCivilNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radioEstadoCivilActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEstadoCivilGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEstadoCivilRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEstadoCivilListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEstadoCivilModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadoCivil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEstadoCivil
            // 
            this.dataEstadoCivil.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataEstadoCivil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstadoCivil.Location = new System.Drawing.Point(35, 227);
            this.dataEstadoCivil.Name = "dataEstadoCivil";
            this.dataEstadoCivil.Size = new System.Drawing.Size(725, 137);
            this.dataEstadoCivil.TabIndex = 22;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(318, 84);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(106, 19);
            this.materialLabel12.TabIndex = 21;
            this.materialLabel12.Text = "ESTADO CIVIL";
            // 
            // radioEstadoCivilInactivo
            // 
            this.radioEstadoCivilInactivo.AutoSize = true;
            this.radioEstadoCivilInactivo.Depth = 0;
            this.radioEstadoCivilInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioEstadoCivilInactivo.Location = new System.Drawing.Point(682, 116);
            this.radioEstadoCivilInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioEstadoCivilInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioEstadoCivilInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioEstadoCivilInactivo.Name = "radioEstadoCivilInactivo";
            this.radioEstadoCivilInactivo.Ripple = true;
            this.radioEstadoCivilInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioEstadoCivilInactivo.TabIndex = 20;
            this.radioEstadoCivilInactivo.Text = "Inactivo";
            this.radioEstadoCivilInactivo.UseVisualStyleBackColor = true;
            // 
            // txtEstadoCivilNombre
            // 
            this.txtEstadoCivilNombre.Depth = 0;
            this.txtEstadoCivilNombre.Hint = "";
            this.txtEstadoCivilNombre.Location = new System.Drawing.Point(281, 123);
            this.txtEstadoCivilNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstadoCivilNombre.Name = "txtEstadoCivilNombre";
            this.txtEstadoCivilNombre.PasswordChar = '\0';
            this.txtEstadoCivilNombre.SelectedText = "";
            this.txtEstadoCivilNombre.SelectionLength = 0;
            this.txtEstadoCivilNombre.SelectionStart = 0;
            this.txtEstadoCivilNombre.Size = new System.Drawing.Size(149, 23);
            this.txtEstadoCivilNombre.TabIndex = 14;
            this.txtEstadoCivilNombre.UseSystemPasswordChar = false;
            this.txtEstadoCivilNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstadoCivilNombre_KeyPress);
            // 
            // radioEstadoCivilActivo
            // 
            this.radioEstadoCivilActivo.AutoSize = true;
            this.radioEstadoCivilActivo.Checked = true;
            this.radioEstadoCivilActivo.Depth = 0;
            this.radioEstadoCivilActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioEstadoCivilActivo.Location = new System.Drawing.Point(552, 116);
            this.radioEstadoCivilActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioEstadoCivilActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioEstadoCivilActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioEstadoCivilActivo.Name = "radioEstadoCivilActivo";
            this.radioEstadoCivilActivo.Ripple = true;
            this.radioEstadoCivilActivo.Size = new System.Drawing.Size(68, 30);
            this.radioEstadoCivilActivo.TabIndex = 19;
            this.radioEstadoCivilActivo.TabStop = true;
            this.radioEstadoCivilActivo.Text = "Activo";
            this.radioEstadoCivilActivo.UseVisualStyleBackColor = true;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(31, 128);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(168, 19);
            this.materialLabel11.TabIndex = 13;
            this.materialLabel11.Text = "Nombre del estado civil";
            // 
            // btnEstadoCivilGuardar
            // 
            this.btnEstadoCivilGuardar.Depth = 0;
            this.btnEstadoCivilGuardar.Location = new System.Drawing.Point(652, 171);
            this.btnEstadoCivilGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEstadoCivilGuardar.Name = "btnEstadoCivilGuardar";
            this.btnEstadoCivilGuardar.Primary = true;
            this.btnEstadoCivilGuardar.Size = new System.Drawing.Size(108, 35);
            this.btnEstadoCivilGuardar.TabIndex = 18;
            this.btnEstadoCivilGuardar.Text = "Guardar";
            this.btnEstadoCivilGuardar.UseVisualStyleBackColor = true;
            this.btnEstadoCivilGuardar.Visible = false;
            this.btnEstadoCivilGuardar.Click += new System.EventHandler(this.btnEstadoCivilGuardar_Click);
            // 
            // btnEstadoCivilRegistrar
            // 
            this.btnEstadoCivilRegistrar.Depth = 0;
            this.btnEstadoCivilRegistrar.Location = new System.Drawing.Point(35, 171);
            this.btnEstadoCivilRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEstadoCivilRegistrar.Name = "btnEstadoCivilRegistrar";
            this.btnEstadoCivilRegistrar.Primary = true;
            this.btnEstadoCivilRegistrar.Size = new System.Drawing.Size(100, 35);
            this.btnEstadoCivilRegistrar.TabIndex = 15;
            this.btnEstadoCivilRegistrar.Text = "Registrar";
            this.btnEstadoCivilRegistrar.UseVisualStyleBackColor = true;
            this.btnEstadoCivilRegistrar.Click += new System.EventHandler(this.btnEstadoCivilRegistrar_Click);
            // 
            // btnEstadoCivilListar
            // 
            this.btnEstadoCivilListar.Depth = 0;
            this.btnEstadoCivilListar.Location = new System.Drawing.Point(421, 171);
            this.btnEstadoCivilListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEstadoCivilListar.Name = "btnEstadoCivilListar";
            this.btnEstadoCivilListar.Primary = true;
            this.btnEstadoCivilListar.Size = new System.Drawing.Size(108, 35);
            this.btnEstadoCivilListar.TabIndex = 17;
            this.btnEstadoCivilListar.Text = "Listar";
            this.btnEstadoCivilListar.UseVisualStyleBackColor = true;
            this.btnEstadoCivilListar.Click += new System.EventHandler(this.btnEstadoCivilListar_Click);
            // 
            // btnEstadoCivilModificar
            // 
            this.btnEstadoCivilModificar.Depth = 0;
            this.btnEstadoCivilModificar.Location = new System.Drawing.Point(225, 171);
            this.btnEstadoCivilModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEstadoCivilModificar.Name = "btnEstadoCivilModificar";
            this.btnEstadoCivilModificar.Primary = true;
            this.btnEstadoCivilModificar.Size = new System.Drawing.Size(102, 35);
            this.btnEstadoCivilModificar.TabIndex = 16;
            this.btnEstadoCivilModificar.Text = "Actualizar";
            this.btnEstadoCivilModificar.UseVisualStyleBackColor = true;
            this.btnEstadoCivilModificar.Click += new System.EventHandler(this.btnEstadoCivilModificar_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.Red;
            this.materialLabel2.Location = new System.Drawing.Point(196, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(15, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "*";
            // 
            // EstadoCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 376);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dataEstadoCivil);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.radioEstadoCivilInactivo);
            this.Controls.Add(this.txtEstadoCivilNombre);
            this.Controls.Add(this.radioEstadoCivilActivo);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.btnEstadoCivilGuardar);
            this.Controls.Add(this.btnEstadoCivilRegistrar);
            this.Controls.Add(this.btnEstadoCivilListar);
            this.Controls.Add(this.btnEstadoCivilModificar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstadoCivil";
            this.Text = "Estado Civil";
            this.Load += new System.EventHandler(this.EstadoCivil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadoCivil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEstadoCivil;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialRadioButton radioEstadoCivilInactivo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstadoCivilNombre;
        private MaterialSkin.Controls.MaterialRadioButton radioEstadoCivilActivo;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialRaisedButton btnEstadoCivilGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEstadoCivilRegistrar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEstadoCivilListar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEstadoCivilModificar;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}