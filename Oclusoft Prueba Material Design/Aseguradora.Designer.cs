namespace Oclusoft_Prueba_Material_Design
{
    partial class Aseguradora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataAseguradora = new System.Windows.Forms.DataGridView();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAseguradoraGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtAseguradoraNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAseguradoraListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAseguradoraModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioAseguradoraActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnAseguradoraRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioAseguradoraInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataAseguradora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAseguradora
            // 
            this.dataAseguradora.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataAseguradora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAseguradora.Location = new System.Drawing.Point(94, 229);
            this.dataAseguradora.Name = "dataAseguradora";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataAseguradora.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataAseguradora.Size = new System.Drawing.Size(725, 99);
            this.dataAseguradora.TabIndex = 22;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(393, 77);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(124, 19);
            this.materialLabel10.TabIndex = 21;
            this.materialLabel10.Text = "ASEGURADORAS";
            // 
            // btnAseguradoraGuardar
            // 
            this.btnAseguradoraGuardar.Depth = 0;
            this.btnAseguradoraGuardar.Location = new System.Drawing.Point(711, 162);
            this.btnAseguradoraGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAseguradoraGuardar.Name = "btnAseguradoraGuardar";
            this.btnAseguradoraGuardar.Primary = true;
            this.btnAseguradoraGuardar.Size = new System.Drawing.Size(108, 35);
            this.btnAseguradoraGuardar.TabIndex = 20;
            this.btnAseguradoraGuardar.Text = "Guardar";
            this.btnAseguradoraGuardar.UseVisualStyleBackColor = true;
            this.btnAseguradoraGuardar.Visible = false;
            this.btnAseguradoraGuardar.Click += new System.EventHandler(this.btnAseguradoraGuardar_Click);
            // 
            // txtAseguradoraNombre
            // 
            this.txtAseguradoraNombre.Depth = 0;
            this.txtAseguradoraNombre.Hint = "";
            this.txtAseguradoraNombre.Location = new System.Drawing.Point(340, 115);
            this.txtAseguradoraNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAseguradoraNombre.Name = "txtAseguradoraNombre";
            this.txtAseguradoraNombre.PasswordChar = '\0';
            this.txtAseguradoraNombre.SelectedText = "";
            this.txtAseguradoraNombre.SelectionLength = 0;
            this.txtAseguradoraNombre.SelectionStart = 0;
            this.txtAseguradoraNombre.Size = new System.Drawing.Size(149, 23);
            this.txtAseguradoraNombre.TabIndex = 14;
            this.txtAseguradoraNombre.UseSystemPasswordChar = false;
            this.txtAseguradoraNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAseguradoraNombre_KeyPress);
            // 
            // btnAseguradoraListar
            // 
            this.btnAseguradoraListar.Depth = 0;
            this.btnAseguradoraListar.Location = new System.Drawing.Point(480, 162);
            this.btnAseguradoraListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAseguradoraListar.Name = "btnAseguradoraListar";
            this.btnAseguradoraListar.Primary = true;
            this.btnAseguradoraListar.Size = new System.Drawing.Size(108, 35);
            this.btnAseguradoraListar.TabIndex = 19;
            this.btnAseguradoraListar.Text = "Listar";
            this.btnAseguradoraListar.UseVisualStyleBackColor = true;
            this.btnAseguradoraListar.Click += new System.EventHandler(this.btnAseguradoraListar_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(90, 119);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(186, 19);
            this.materialLabel9.TabIndex = 13;
            this.materialLabel9.Text = "Nombre de la aseguradora";
            // 
            // btnAseguradoraModificar
            // 
            this.btnAseguradoraModificar.Depth = 0;
            this.btnAseguradoraModificar.Location = new System.Drawing.Point(284, 162);
            this.btnAseguradoraModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAseguradoraModificar.Name = "btnAseguradoraModificar";
            this.btnAseguradoraModificar.Primary = true;
            this.btnAseguradoraModificar.Size = new System.Drawing.Size(102, 35);
            this.btnAseguradoraModificar.TabIndex = 18;
            this.btnAseguradoraModificar.Text = "Actualizar";
            this.btnAseguradoraModificar.UseVisualStyleBackColor = true;
            this.btnAseguradoraModificar.Click += new System.EventHandler(this.btnAseguradoraModificar_Click);
            // 
            // radioAseguradoraActivo
            // 
            this.radioAseguradoraActivo.AutoSize = true;
            this.radioAseguradoraActivo.Checked = true;
            this.radioAseguradoraActivo.Depth = 0;
            this.radioAseguradoraActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioAseguradoraActivo.Location = new System.Drawing.Point(606, 114);
            this.radioAseguradoraActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioAseguradoraActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioAseguradoraActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioAseguradoraActivo.Name = "radioAseguradoraActivo";
            this.radioAseguradoraActivo.Ripple = true;
            this.radioAseguradoraActivo.Size = new System.Drawing.Size(68, 30);
            this.radioAseguradoraActivo.TabIndex = 15;
            this.radioAseguradoraActivo.TabStop = true;
            this.radioAseguradoraActivo.Text = "Activo";
            this.radioAseguradoraActivo.UseVisualStyleBackColor = true;
            // 
            // btnAseguradoraRegistrar
            // 
            this.btnAseguradoraRegistrar.Depth = 0;
            this.btnAseguradoraRegistrar.Location = new System.Drawing.Point(94, 162);
            this.btnAseguradoraRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAseguradoraRegistrar.Name = "btnAseguradoraRegistrar";
            this.btnAseguradoraRegistrar.Primary = true;
            this.btnAseguradoraRegistrar.Size = new System.Drawing.Size(100, 35);
            this.btnAseguradoraRegistrar.TabIndex = 17;
            this.btnAseguradoraRegistrar.Text = "Registrar";
            this.btnAseguradoraRegistrar.UseVisualStyleBackColor = true;
            this.btnAseguradoraRegistrar.Click += new System.EventHandler(this.btnAseguradoraIngresar_Click);
            // 
            // radioAseguradoraInactivo
            // 
            this.radioAseguradoraInactivo.AutoSize = true;
            this.radioAseguradoraInactivo.Depth = 0;
            this.radioAseguradoraInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioAseguradoraInactivo.Location = new System.Drawing.Point(741, 114);
            this.radioAseguradoraInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioAseguradoraInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioAseguradoraInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioAseguradoraInactivo.Name = "radioAseguradoraInactivo";
            this.radioAseguradoraInactivo.Ripple = true;
            this.radioAseguradoraInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioAseguradoraInactivo.TabIndex = 16;
            this.radioAseguradoraInactivo.Text = "Inactivo";
            this.radioAseguradoraInactivo.UseVisualStyleBackColor = true;
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
            this.materialLabel1.Location = new System.Drawing.Point(271, 119);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(15, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "*";
            // 
            // Aseguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 349);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataAseguradora);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.btnAseguradoraGuardar);
            this.Controls.Add(this.txtAseguradoraNombre);
            this.Controls.Add(this.btnAseguradoraListar);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.btnAseguradoraModificar);
            this.Controls.Add(this.radioAseguradoraActivo);
            this.Controls.Add(this.btnAseguradoraRegistrar);
            this.Controls.Add(this.radioAseguradoraInactivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aseguradora";
            this.Text = "Aseguradora";
            this.Load += new System.EventHandler(this.Aseguradora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAseguradora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAseguradora;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialRaisedButton btnAseguradoraGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAseguradoraNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnAseguradoraListar;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialRaisedButton btnAseguradoraModificar;
        private MaterialSkin.Controls.MaterialRadioButton radioAseguradoraActivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnAseguradoraRegistrar;
        private MaterialSkin.Controls.MaterialRadioButton radioAseguradoraInactivo;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}