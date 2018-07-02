namespace Oclusoft_Prueba_Material_Design
{
    partial class TipoSeguro
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
            this.dataTipoSeguro = new System.Windows.Forms.DataGridView();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.btnTipoSeguroGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtTipoSeguroNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnTipoSeguroListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.btnTipoSeguroModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioTipoSeguroActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnTipoSeguro = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioTipoSeguroInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTipoSeguro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTipoSeguro
            // 
            this.dataTipoSeguro.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataTipoSeguro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTipoSeguro.Location = new System.Drawing.Point(48, 194);
            this.dataTipoSeguro.Name = "dataTipoSeguro";
            this.dataTipoSeguro.Size = new System.Drawing.Size(725, 154);
            this.dataTipoSeguro.TabIndex = 21;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(354, 72);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(143, 19);
            this.materialLabel17.TabIndex = 12;
            this.materialLabel17.Text = "TIPOS DE SEGUROS";
            // 
            // btnTipoSeguroGuardar
            // 
            this.btnTipoSeguroGuardar.Depth = 0;
            this.btnTipoSeguroGuardar.Location = new System.Drawing.Point(665, 153);
            this.btnTipoSeguroGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoSeguroGuardar.Name = "btnTipoSeguroGuardar";
            this.btnTipoSeguroGuardar.Primary = true;
            this.btnTipoSeguroGuardar.Size = new System.Drawing.Size(108, 35);
            this.btnTipoSeguroGuardar.TabIndex = 20;
            this.btnTipoSeguroGuardar.Text = "Guardar";
            this.btnTipoSeguroGuardar.UseVisualStyleBackColor = true;
            this.btnTipoSeguroGuardar.Visible = false;
            this.btnTipoSeguroGuardar.Click += new System.EventHandler(this.btnTipoSeguroGuardar_Click);
            // 
            // txtTipoSeguroNombre
            // 
            this.txtTipoSeguroNombre.Depth = 0;
            this.txtTipoSeguroNombre.Hint = "";
            this.txtTipoSeguroNombre.Location = new System.Drawing.Point(294, 112);
            this.txtTipoSeguroNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTipoSeguroNombre.Name = "txtTipoSeguroNombre";
            this.txtTipoSeguroNombre.PasswordChar = '\0';
            this.txtTipoSeguroNombre.SelectedText = "";
            this.txtTipoSeguroNombre.SelectionLength = 0;
            this.txtTipoSeguroNombre.SelectionStart = 0;
            this.txtTipoSeguroNombre.Size = new System.Drawing.Size(149, 23);
            this.txtTipoSeguroNombre.TabIndex = 14;
            this.txtTipoSeguroNombre.UseSystemPasswordChar = false;
            this.txtTipoSeguroNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoSeguroNombre_KeyPress);
            // 
            // btnTipoSeguroListar
            // 
            this.btnTipoSeguroListar.Depth = 0;
            this.btnTipoSeguroListar.Location = new System.Drawing.Point(434, 153);
            this.btnTipoSeguroListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoSeguroListar.Name = "btnTipoSeguroListar";
            this.btnTipoSeguroListar.Primary = true;
            this.btnTipoSeguroListar.Size = new System.Drawing.Size(108, 35);
            this.btnTipoSeguroListar.TabIndex = 19;
            this.btnTipoSeguroListar.Text = "Listar";
            this.btnTipoSeguroListar.UseVisualStyleBackColor = true;
            this.btnTipoSeguroListar.Click += new System.EventHandler(this.btnTipoSeguroListar_Click);
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(44, 113);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(187, 19);
            this.materialLabel15.TabIndex = 13;
            this.materialLabel15.Text = "Nombre del tipo de seguro";
            // 
            // btnTipoSeguroModificar
            // 
            this.btnTipoSeguroModificar.Depth = 0;
            this.btnTipoSeguroModificar.Location = new System.Drawing.Point(238, 153);
            this.btnTipoSeguroModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoSeguroModificar.Name = "btnTipoSeguroModificar";
            this.btnTipoSeguroModificar.Primary = true;
            this.btnTipoSeguroModificar.Size = new System.Drawing.Size(102, 35);
            this.btnTipoSeguroModificar.TabIndex = 18;
            this.btnTipoSeguroModificar.Text = "Modificar";
            this.btnTipoSeguroModificar.UseVisualStyleBackColor = true;
            this.btnTipoSeguroModificar.Click += new System.EventHandler(this.btnTipoSeguroModificar_Click);
            // 
            // radioTipoSeguroActivo
            // 
            this.radioTipoSeguroActivo.AutoSize = true;
            this.radioTipoSeguroActivo.CausesValidation = false;
            this.radioTipoSeguroActivo.Checked = true;
            this.radioTipoSeguroActivo.Depth = 0;
            this.radioTipoSeguroActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioTipoSeguroActivo.Location = new System.Drawing.Point(577, 108);
            this.radioTipoSeguroActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioTipoSeguroActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioTipoSeguroActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioTipoSeguroActivo.Name = "radioTipoSeguroActivo";
            this.radioTipoSeguroActivo.Ripple = true;
            this.radioTipoSeguroActivo.Size = new System.Drawing.Size(68, 30);
            this.radioTipoSeguroActivo.TabIndex = 15;
            this.radioTipoSeguroActivo.TabStop = true;
            this.radioTipoSeguroActivo.Text = "Activo";
            this.radioTipoSeguroActivo.UseVisualStyleBackColor = true;
            // 
            // btnTipoSeguro
            // 
            this.btnTipoSeguro.Depth = 0;
            this.btnTipoSeguro.Location = new System.Drawing.Point(48, 153);
            this.btnTipoSeguro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoSeguro.Name = "btnTipoSeguro";
            this.btnTipoSeguro.Primary = true;
            this.btnTipoSeguro.Size = new System.Drawing.Size(100, 35);
            this.btnTipoSeguro.TabIndex = 17;
            this.btnTipoSeguro.Text = "Registrar";
            this.btnTipoSeguro.UseVisualStyleBackColor = true;
            this.btnTipoSeguro.Click += new System.EventHandler(this.btnTipoSeguroRegistrar_Click);
            // 
            // radioTipoSeguroInactivo
            // 
            this.radioTipoSeguroInactivo.AutoSize = true;
            this.radioTipoSeguroInactivo.Depth = 0;
            this.radioTipoSeguroInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioTipoSeguroInactivo.Location = new System.Drawing.Point(695, 105);
            this.radioTipoSeguroInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioTipoSeguroInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioTipoSeguroInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioTipoSeguroInactivo.Name = "radioTipoSeguroInactivo";
            this.radioTipoSeguroInactivo.Ripple = true;
            this.radioTipoSeguroInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioTipoSeguroInactivo.TabIndex = 16;
            this.radioTipoSeguroInactivo.Text = "Inactivo";
            this.radioTipoSeguroInactivo.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // materialLabel34
            // 
            this.materialLabel34.AutoSize = true;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel34.Location = new System.Drawing.Point(225, 112);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(15, 19);
            this.materialLabel34.TabIndex = 70;
            this.materialLabel34.Text = "*";
            // 
            // TipoSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 360);
            this.Controls.Add(this.materialLabel34);
            this.Controls.Add(this.dataTipoSeguro);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.btnTipoSeguroGuardar);
            this.Controls.Add(this.txtTipoSeguroNombre);
            this.Controls.Add(this.btnTipoSeguroListar);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.btnTipoSeguroModificar);
            this.Controls.Add(this.radioTipoSeguroActivo);
            this.Controls.Add(this.btnTipoSeguro);
            this.Controls.Add(this.radioTipoSeguroInactivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoSeguro";
            this.Text = "Tipo Seguro";
            this.Load += new System.EventHandler(this.TipoSeguro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTipoSeguro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTipoSeguro;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialRaisedButton btnTipoSeguroGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTipoSeguroNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnTipoSeguroListar;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialRaisedButton btnTipoSeguroModificar;
        private MaterialSkin.Controls.MaterialRadioButton radioTipoSeguroActivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnTipoSeguro;
        private MaterialSkin.Controls.MaterialRadioButton radioTipoSeguroInactivo;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
    }
}