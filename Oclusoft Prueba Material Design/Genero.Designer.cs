namespace Oclusoft_Prueba_Material_Design
{
    partial class Generos
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
            this.dataGenero = new System.Windows.Forms.DataGridView();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGeneroGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtGeneroNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGeneroListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGeneroModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioGeneroActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGeneroRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioGeneroInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGenero
            // 
            this.dataGenero.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGenero.Location = new System.Drawing.Point(50, 195);
            this.dataGenero.Name = "dataGenero";
            this.dataGenero.Size = new System.Drawing.Size(725, 125);
            this.dataGenero.TabIndex = 32;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(358, 68);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(76, 19);
            this.materialLabel10.TabIndex = 31;
            this.materialLabel10.Text = "GENEROS";
            // 
            // btnGeneroGuardar
            // 
            this.btnGeneroGuardar.Depth = 0;
            this.btnGeneroGuardar.Location = new System.Drawing.Point(667, 154);
            this.btnGeneroGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGeneroGuardar.Name = "btnGeneroGuardar";
            this.btnGeneroGuardar.Primary = true;
            this.btnGeneroGuardar.Size = new System.Drawing.Size(108, 35);
            this.btnGeneroGuardar.TabIndex = 30;
            this.btnGeneroGuardar.Text = "Guardar";
            this.btnGeneroGuardar.UseVisualStyleBackColor = true;
            this.btnGeneroGuardar.Visible = false;
            this.btnGeneroGuardar.Click += new System.EventHandler(this.btnGeneroGuardar_Click);
            // 
            // txtGeneroNombre
            // 
            this.txtGeneroNombre.Depth = 0;
            this.txtGeneroNombre.Hint = "";
            this.txtGeneroNombre.Location = new System.Drawing.Point(296, 107);
            this.txtGeneroNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGeneroNombre.Name = "txtGeneroNombre";
            this.txtGeneroNombre.PasswordChar = '\0';
            this.txtGeneroNombre.SelectedText = "";
            this.txtGeneroNombre.SelectionLength = 0;
            this.txtGeneroNombre.SelectionStart = 0;
            this.txtGeneroNombre.Size = new System.Drawing.Size(149, 23);
            this.txtGeneroNombre.TabIndex = 24;
            this.txtGeneroNombre.UseSystemPasswordChar = false;
            this.txtGeneroNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeneroNombre_KeyPress);
            // 
            // btnGeneroListar
            // 
            this.btnGeneroListar.Depth = 0;
            this.btnGeneroListar.Location = new System.Drawing.Point(436, 154);
            this.btnGeneroListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGeneroListar.Name = "btnGeneroListar";
            this.btnGeneroListar.Primary = true;
            this.btnGeneroListar.Size = new System.Drawing.Size(108, 35);
            this.btnGeneroListar.TabIndex = 29;
            this.btnGeneroListar.Text = "Listar";
            this.btnGeneroListar.UseVisualStyleBackColor = true;
            this.btnGeneroListar.Click += new System.EventHandler(this.btnGeneroListar_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(46, 111);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(137, 19);
            this.materialLabel9.TabIndex = 23;
            this.materialLabel9.Text = "Nombre del genero";
            // 
            // btnGeneroModificar
            // 
            this.btnGeneroModificar.Depth = 0;
            this.btnGeneroModificar.Location = new System.Drawing.Point(240, 154);
            this.btnGeneroModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGeneroModificar.Name = "btnGeneroModificar";
            this.btnGeneroModificar.Primary = true;
            this.btnGeneroModificar.Size = new System.Drawing.Size(102, 35);
            this.btnGeneroModificar.TabIndex = 28;
            this.btnGeneroModificar.Text = "Actualizar";
            this.btnGeneroModificar.UseVisualStyleBackColor = true;
            this.btnGeneroModificar.Click += new System.EventHandler(this.btnGeneroModificar_Click);
            // 
            // radioGeneroActivo
            // 
            this.radioGeneroActivo.AutoSize = true;
            this.radioGeneroActivo.Checked = true;
            this.radioGeneroActivo.Depth = 0;
            this.radioGeneroActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioGeneroActivo.Location = new System.Drawing.Point(562, 106);
            this.radioGeneroActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioGeneroActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioGeneroActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioGeneroActivo.Name = "radioGeneroActivo";
            this.radioGeneroActivo.Ripple = true;
            this.radioGeneroActivo.Size = new System.Drawing.Size(68, 30);
            this.radioGeneroActivo.TabIndex = 25;
            this.radioGeneroActivo.TabStop = true;
            this.radioGeneroActivo.Text = "Activo";
            this.radioGeneroActivo.UseVisualStyleBackColor = true;
            // 
            // btnGeneroRegistrar
            // 
            this.btnGeneroRegistrar.Depth = 0;
            this.btnGeneroRegistrar.Location = new System.Drawing.Point(50, 154);
            this.btnGeneroRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGeneroRegistrar.Name = "btnGeneroRegistrar";
            this.btnGeneroRegistrar.Primary = true;
            this.btnGeneroRegistrar.Size = new System.Drawing.Size(100, 35);
            this.btnGeneroRegistrar.TabIndex = 27;
            this.btnGeneroRegistrar.Text = "Registrar";
            this.btnGeneroRegistrar.UseVisualStyleBackColor = true;
            this.btnGeneroRegistrar.Click += new System.EventHandler(this.btnGeneroRegistrar_Click);
            // 
            // radioGeneroInactivo
            // 
            this.radioGeneroInactivo.AutoSize = true;
            this.radioGeneroInactivo.Depth = 0;
            this.radioGeneroInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioGeneroInactivo.Location = new System.Drawing.Point(697, 106);
            this.radioGeneroInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioGeneroInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioGeneroInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioGeneroInactivo.Name = "radioGeneroInactivo";
            this.radioGeneroInactivo.Ripple = true;
            this.radioGeneroInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioGeneroInactivo.TabIndex = 26;
            this.radioGeneroInactivo.Text = "Inactivo";
            this.radioGeneroInactivo.UseVisualStyleBackColor = true;
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
            this.materialLabel2.Location = new System.Drawing.Point(179, 111);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(15, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "*";
            // 
            // Generos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 325);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dataGenero);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.btnGeneroGuardar);
            this.Controls.Add(this.txtGeneroNombre);
            this.Controls.Add(this.btnGeneroListar);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.btnGeneroModificar);
            this.Controls.Add(this.radioGeneroActivo);
            this.Controls.Add(this.btnGeneroRegistrar);
            this.Controls.Add(this.radioGeneroInactivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Generos";
            this.Text = "Genero";
            this.Load += new System.EventHandler(this.Genero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGenero;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialRaisedButton btnGeneroGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGeneroNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnGeneroListar;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialRaisedButton btnGeneroModificar;
        private MaterialSkin.Controls.MaterialRadioButton radioGeneroActivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnGeneroRegistrar;
        private MaterialSkin.Controls.MaterialRadioButton radioGeneroInactivo;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}