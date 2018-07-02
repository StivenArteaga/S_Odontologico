namespace Oclusoft_Prueba_Material_Design
{
    partial class Departamento
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
            this.dataDepartamento = new System.Windows.Forms.DataGridView();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDepartamentoGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDepartamentoListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboidPais = new System.Windows.Forms.ComboBox();
            this.btnDepartamentoModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDepartamentoNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radioDepartamentoInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioDepartamentoActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDepartamento
            // 
            this.dataDepartamento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDepartamento.Location = new System.Drawing.Point(34, 239);
            this.dataDepartamento.Name = "dataDepartamento";
            this.dataDepartamento.Size = new System.Drawing.Size(724, 132);
            this.dataDepartamento.TabIndex = 22;
            this.dataDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataDepartamento_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(321, 79);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(136, 19);
            this.materialLabel5.TabIndex = 33;
            this.materialLabel5.Text = "DEPARTAMENTOS";
            // 
            // btnDepartamentoGuardar
            // 
            this.btnDepartamentoGuardar.Depth = 0;
            this.btnDepartamentoGuardar.Location = new System.Drawing.Point(650, 197);
            this.btnDepartamentoGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDepartamentoGuardar.Name = "btnDepartamentoGuardar";
            this.btnDepartamentoGuardar.Primary = true;
            this.btnDepartamentoGuardar.Size = new System.Drawing.Size(108, 36);
            this.btnDepartamentoGuardar.TabIndex = 32;
            this.btnDepartamentoGuardar.Text = "Guardar";
            this.btnDepartamentoGuardar.UseVisualStyleBackColor = true;
            this.btnDepartamentoGuardar.Visible = false;
            this.btnDepartamentoGuardar.Click += new System.EventHandler(this.btnDepartamentoGuardar_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(27, 122);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Nombre del país";
            // 
            // btnDepartamentoListar
            // 
            this.btnDepartamentoListar.Depth = 0;
            this.btnDepartamentoListar.Location = new System.Drawing.Point(419, 197);
            this.btnDepartamentoListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDepartamentoListar.Name = "btnDepartamentoListar";
            this.btnDepartamentoListar.Primary = true;
            this.btnDepartamentoListar.Size = new System.Drawing.Size(108, 36);
            this.btnDepartamentoListar.TabIndex = 31;
            this.btnDepartamentoListar.Text = "Listar";
            this.btnDepartamentoListar.UseVisualStyleBackColor = true;
            this.btnDepartamentoListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // comboidPais
            // 
            this.comboidPais.BackColor = System.Drawing.SystemColors.Control;
            this.comboidPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboidPais.FormattingEnabled = true;
            this.comboidPais.Location = new System.Drawing.Point(245, 122);
            this.comboidPais.Name = "comboidPais";
            this.comboidPais.Size = new System.Drawing.Size(154, 24);
            this.comboidPais.TabIndex = 24;
            // 
            // btnDepartamentoModificar
            // 
            this.btnDepartamentoModificar.Depth = 0;
            this.btnDepartamentoModificar.Location = new System.Drawing.Point(223, 197);
            this.btnDepartamentoModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDepartamentoModificar.Name = "btnDepartamentoModificar";
            this.btnDepartamentoModificar.Primary = true;
            this.btnDepartamentoModificar.Size = new System.Drawing.Size(102, 36);
            this.btnDepartamentoModificar.TabIndex = 30;
            this.btnDepartamentoModificar.Text = "Actualizar";
            this.btnDepartamentoModificar.UseVisualStyleBackColor = true;
            this.btnDepartamentoModificar.Click += new System.EventHandler(this.btnDepartamentoModificar_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(30, 164);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(184, 19);
            this.materialLabel4.TabIndex = 25;
            this.materialLabel4.Text = "Nombre del departamento";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(31, 197);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(102, 36);
            this.materialRaisedButton1.TabIndex = 29;
            this.materialRaisedButton1.Text = "Registrar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.btnDepartamentoRegistrar_Click);
            // 
            // txtDepartamentoNombre
            // 
            this.txtDepartamentoNombre.Depth = 0;
            this.txtDepartamentoNombre.Hint = "";
            this.txtDepartamentoNombre.Location = new System.Drawing.Point(245, 164);
            this.txtDepartamentoNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDepartamentoNombre.Name = "txtDepartamentoNombre";
            this.txtDepartamentoNombre.PasswordChar = '\0';
            this.txtDepartamentoNombre.SelectedText = "";
            this.txtDepartamentoNombre.SelectionLength = 0;
            this.txtDepartamentoNombre.SelectionStart = 0;
            this.txtDepartamentoNombre.Size = new System.Drawing.Size(154, 23);
            this.txtDepartamentoNombre.TabIndex = 26;
            this.txtDepartamentoNombre.UseSystemPasswordChar = false;
            this.txtDepartamentoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartamentoNombre_KeyPress);
            // 
            // radioDepartamentoInactivo
            // 
            this.radioDepartamentoInactivo.AutoSize = true;
            this.radioDepartamentoInactivo.Depth = 0;
            this.radioDepartamentoInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioDepartamentoInactivo.Location = new System.Drawing.Point(680, 111);
            this.radioDepartamentoInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioDepartamentoInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioDepartamentoInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioDepartamentoInactivo.Name = "radioDepartamentoInactivo";
            this.radioDepartamentoInactivo.Ripple = true;
            this.radioDepartamentoInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioDepartamentoInactivo.TabIndex = 28;
            this.radioDepartamentoInactivo.Text = "Inactivo";
            this.radioDepartamentoInactivo.UseVisualStyleBackColor = true;
            // 
            // radioDepartamentoActivo
            // 
            this.radioDepartamentoActivo.AutoSize = true;
            this.radioDepartamentoActivo.Checked = true;
            this.radioDepartamentoActivo.Depth = 0;
            this.radioDepartamentoActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioDepartamentoActivo.Location = new System.Drawing.Point(548, 111);
            this.radioDepartamentoActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioDepartamentoActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioDepartamentoActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioDepartamentoActivo.Name = "radioDepartamentoActivo";
            this.radioDepartamentoActivo.Ripple = true;
            this.radioDepartamentoActivo.Size = new System.Drawing.Size(68, 30);
            this.radioDepartamentoActivo.TabIndex = 27;
            this.radioDepartamentoActivo.TabStop = true;
            this.radioDepartamentoActivo.Text = "Activo";
            this.radioDepartamentoActivo.UseVisualStyleBackColor = true;
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
            this.materialLabel1.Location = new System.Drawing.Point(143, 122);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(15, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "*";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.Red;
            this.materialLabel2.Location = new System.Drawing.Point(209, 164);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(15, 19);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "*";
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 383);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataDepartamento);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnDepartamentoGuardar);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnDepartamentoListar);
            this.Controls.Add(this.comboidPais);
            this.Controls.Add(this.btnDepartamentoModificar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtDepartamentoNombre);
            this.Controls.Add(this.radioDepartamentoInactivo);
            this.Controls.Add(this.radioDepartamentoActivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Departamento";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDepartamento;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton btnDepartamentoGuardar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnDepartamentoListar;
        private System.Windows.Forms.ComboBox comboidPais;
        private MaterialSkin.Controls.MaterialRaisedButton btnDepartamentoModificar;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDepartamentoNombre;
        private MaterialSkin.Controls.MaterialRadioButton radioDepartamentoInactivo;
        private MaterialSkin.Controls.MaterialRadioButton radioDepartamentoActivo;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}