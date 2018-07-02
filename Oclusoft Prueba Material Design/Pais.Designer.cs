namespace Oclusoft_Prueba_Material_Design
{
    partial class Pais
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
            this.dataPais = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnPaisRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPaisNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPaisGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioPaisActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnPaisModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioPaisInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnPaisListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPais
            // 
            this.dataPais.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPais.Location = new System.Drawing.Point(46, 209);
            this.dataPais.Name = "dataPais";
            this.dataPais.Size = new System.Drawing.Size(727, 129);
            this.dataPais.TabIndex = 12;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(374, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "PAÍSES";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(42, 111);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Nombre del país";
            // 
            // btnPaisRegistrar
            // 
            this.btnPaisRegistrar.Depth = 0;
            this.btnPaisRegistrar.Location = new System.Drawing.Point(46, 157);
            this.btnPaisRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPaisRegistrar.Name = "btnPaisRegistrar";
            this.btnPaisRegistrar.Primary = true;
            this.btnPaisRegistrar.Size = new System.Drawing.Size(102, 36);
            this.btnPaisRegistrar.TabIndex = 17;
            this.btnPaisRegistrar.Text = "Registrar";
            this.btnPaisRegistrar.UseVisualStyleBackColor = true;
            this.btnPaisRegistrar.Click += new System.EventHandler(this.btnPaisRegistrar_Click);
            // 
            // txtPaisNombre
            // 
            this.txtPaisNombre.Depth = 0;
            this.txtPaisNombre.Hint = "";
            this.txtPaisNombre.Location = new System.Drawing.Point(199, 111);
            this.txtPaisNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPaisNombre.Name = "txtPaisNombre";
            this.txtPaisNombre.PasswordChar = '\0';
            this.txtPaisNombre.SelectedText = "";
            this.txtPaisNombre.SelectionLength = 0;
            this.txtPaisNombre.SelectionStart = 0;
            this.txtPaisNombre.Size = new System.Drawing.Size(154, 23);
            this.txtPaisNombre.TabIndex = 14;
            this.txtPaisNombre.UseSystemPasswordChar = false;
            this.txtPaisNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaisNombre_KeyPress_1);
            // 
            // btnPaisGuardar
            // 
            this.btnPaisGuardar.Depth = 0;
            this.btnPaisGuardar.Location = new System.Drawing.Point(665, 157);
            this.btnPaisGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPaisGuardar.Name = "btnPaisGuardar";
            this.btnPaisGuardar.Primary = true;
            this.btnPaisGuardar.Size = new System.Drawing.Size(108, 36);
            this.btnPaisGuardar.TabIndex = 20;
            this.btnPaisGuardar.Text = "Guardar";
            this.btnPaisGuardar.UseVisualStyleBackColor = true;
            this.btnPaisGuardar.Visible = false;
            this.btnPaisGuardar.Click += new System.EventHandler(this.btnPaisGuardar_Click);
            // 
            // radioPaisActivo
            // 
            this.radioPaisActivo.AutoSize = true;
            this.radioPaisActivo.Checked = true;
            this.radioPaisActivo.Depth = 0;
            this.radioPaisActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioPaisActivo.Location = new System.Drawing.Point(563, 106);
            this.radioPaisActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioPaisActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioPaisActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioPaisActivo.Name = "radioPaisActivo";
            this.radioPaisActivo.Ripple = true;
            this.radioPaisActivo.Size = new System.Drawing.Size(68, 30);
            this.radioPaisActivo.TabIndex = 15;
            this.radioPaisActivo.TabStop = true;
            this.radioPaisActivo.Text = "Activo";
            this.radioPaisActivo.UseVisualStyleBackColor = true;
            // 
            // btnPaisModificar
            // 
            this.btnPaisModificar.Depth = 0;
            this.btnPaisModificar.Location = new System.Drawing.Point(238, 157);
            this.btnPaisModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPaisModificar.Name = "btnPaisModificar";
            this.btnPaisModificar.Primary = true;
            this.btnPaisModificar.Size = new System.Drawing.Size(102, 36);
            this.btnPaisModificar.TabIndex = 18;
            this.btnPaisModificar.Text = "Modificar";
            this.btnPaisModificar.UseVisualStyleBackColor = true;
            this.btnPaisModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // radioPaisInactivo
            // 
            this.radioPaisInactivo.AutoSize = true;
            this.radioPaisInactivo.Depth = 0;
            this.radioPaisInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioPaisInactivo.Location = new System.Drawing.Point(695, 106);
            this.radioPaisInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioPaisInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioPaisInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioPaisInactivo.Name = "radioPaisInactivo";
            this.radioPaisInactivo.Ripple = true;
            this.radioPaisInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioPaisInactivo.TabIndex = 16;
            this.radioPaisInactivo.Text = "Inactivo";
            this.radioPaisInactivo.UseVisualStyleBackColor = true;
            // 
            // btnPaisListar
            // 
            this.btnPaisListar.Depth = 0;
            this.btnPaisListar.Location = new System.Drawing.Point(434, 157);
            this.btnPaisListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPaisListar.Name = "btnPaisListar";
            this.btnPaisListar.Primary = true;
            this.btnPaisListar.Size = new System.Drawing.Size(108, 36);
            this.btnPaisListar.TabIndex = 19;
            this.btnPaisListar.Text = "Listar";
            this.btnPaisListar.UseVisualStyleBackColor = true;
            this.btnPaisListar.Click += new System.EventHandler(this.btnPaisListar_Click);
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
            this.materialLabel34.Location = new System.Drawing.Point(158, 111);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(15, 19);
            this.materialLabel34.TabIndex = 70;
            this.materialLabel34.Text = "*";
            // 
            // Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 350);
            this.Controls.Add(this.materialLabel34);
            this.Controls.Add(this.dataPais);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnPaisRegistrar);
            this.Controls.Add(this.txtPaisNombre);
            this.Controls.Add(this.btnPaisGuardar);
            this.Controls.Add(this.radioPaisActivo);
            this.Controls.Add(this.btnPaisModificar);
            this.Controls.Add(this.radioPaisInactivo);
            this.Controls.Add(this.btnPaisListar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pais";
            this.Text = "País";
            this.Load += new System.EventHandler(this.Pais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPais;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnPaisRegistrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPaisNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnPaisGuardar;
        private MaterialSkin.Controls.MaterialRadioButton radioPaisActivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnPaisModificar;
        private MaterialSkin.Controls.MaterialRadioButton radioPaisInactivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnPaisListar;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
    }
}