namespace Oclusoft_Prueba_Material_Design
{
    partial class GrupoSanguineo
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
            this.dataGrupoSanguineo = new System.Windows.Forms.DataGridView();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGrupoSanguineoGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtGrupoSanguineoNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGrupoSanguineoListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGrupoSanguineoModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioGrupoSanguineoActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGrupoSanguineoRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioGrupoSanguineoInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrupoSanguineo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrupoSanguineo
            // 
            this.dataGrupoSanguineo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGrupoSanguineo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrupoSanguineo.Location = new System.Drawing.Point(40, 202);
            this.dataGrupoSanguineo.Name = "dataGrupoSanguineo";
            this.dataGrupoSanguineo.Size = new System.Drawing.Size(725, 159);
            this.dataGrupoSanguineo.TabIndex = 32;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(319, 77);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(145, 19);
            this.materialLabel10.TabIndex = 31;
            this.materialLabel10.Text = "GRUPO SANGUÍNEO";
            // 
            // btnGrupoSanguineoGuardar
            // 
            this.btnGrupoSanguineoGuardar.Depth = 0;
            this.btnGrupoSanguineoGuardar.Location = new System.Drawing.Point(657, 161);
            this.btnGrupoSanguineoGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrupoSanguineoGuardar.Name = "btnGrupoSanguineoGuardar";
            this.btnGrupoSanguineoGuardar.Primary = true;
            this.btnGrupoSanguineoGuardar.Size = new System.Drawing.Size(108, 35);
            this.btnGrupoSanguineoGuardar.TabIndex = 30;
            this.btnGrupoSanguineoGuardar.Text = "Guardar";
            this.btnGrupoSanguineoGuardar.UseVisualStyleBackColor = true;
            this.btnGrupoSanguineoGuardar.Visible = false;
            this.btnGrupoSanguineoGuardar.Click += new System.EventHandler(this.btnGrupoSanguineoGuardar_Click);
            // 
            // txtGrupoSanguineoNombre
            // 
            this.txtGrupoSanguineoNombre.Depth = 0;
            this.txtGrupoSanguineoNombre.Hint = "";
            this.txtGrupoSanguineoNombre.Location = new System.Drawing.Point(286, 114);
            this.txtGrupoSanguineoNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGrupoSanguineoNombre.Name = "txtGrupoSanguineoNombre";
            this.txtGrupoSanguineoNombre.PasswordChar = '\0';
            this.txtGrupoSanguineoNombre.SelectedText = "";
            this.txtGrupoSanguineoNombre.SelectionLength = 0;
            this.txtGrupoSanguineoNombre.SelectionStart = 0;
            this.txtGrupoSanguineoNombre.Size = new System.Drawing.Size(149, 23);
            this.txtGrupoSanguineoNombre.TabIndex = 24;
            this.txtGrupoSanguineoNombre.UseSystemPasswordChar = false;
            this.txtGrupoSanguineoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupoSanguineoNombre_KeyPress);
            // 
            // btnGrupoSanguineoListar
            // 
            this.btnGrupoSanguineoListar.Depth = 0;
            this.btnGrupoSanguineoListar.Location = new System.Drawing.Point(426, 161);
            this.btnGrupoSanguineoListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrupoSanguineoListar.Name = "btnGrupoSanguineoListar";
            this.btnGrupoSanguineoListar.Primary = true;
            this.btnGrupoSanguineoListar.Size = new System.Drawing.Size(108, 35);
            this.btnGrupoSanguineoListar.TabIndex = 29;
            this.btnGrupoSanguineoListar.Text = "Listar";
            this.btnGrupoSanguineoListar.UseVisualStyleBackColor = true;
            this.btnGrupoSanguineoListar.Click += new System.EventHandler(this.btnGrupoSanguineoListar_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(36, 118);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(202, 19);
            this.materialLabel9.TabIndex = 23;
            this.materialLabel9.Text = "Nombre del grupo sanguíneo";
            // 
            // btnGrupoSanguineoModificar
            // 
            this.btnGrupoSanguineoModificar.Depth = 0;
            this.btnGrupoSanguineoModificar.Location = new System.Drawing.Point(230, 161);
            this.btnGrupoSanguineoModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrupoSanguineoModificar.Name = "btnGrupoSanguineoModificar";
            this.btnGrupoSanguineoModificar.Primary = true;
            this.btnGrupoSanguineoModificar.Size = new System.Drawing.Size(102, 35);
            this.btnGrupoSanguineoModificar.TabIndex = 28;
            this.btnGrupoSanguineoModificar.Text = "Actualizar";
            this.btnGrupoSanguineoModificar.UseVisualStyleBackColor = true;
            this.btnGrupoSanguineoModificar.Click += new System.EventHandler(this.btnGrupoSanguineoModificar_Click);
            // 
            // radioGrupoSanguineoActivo
            // 
            this.radioGrupoSanguineoActivo.AutoSize = true;
            this.radioGrupoSanguineoActivo.Checked = true;
            this.radioGrupoSanguineoActivo.Depth = 0;
            this.radioGrupoSanguineoActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioGrupoSanguineoActivo.Location = new System.Drawing.Point(552, 113);
            this.radioGrupoSanguineoActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioGrupoSanguineoActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioGrupoSanguineoActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioGrupoSanguineoActivo.Name = "radioGrupoSanguineoActivo";
            this.radioGrupoSanguineoActivo.Ripple = true;
            this.radioGrupoSanguineoActivo.Size = new System.Drawing.Size(68, 30);
            this.radioGrupoSanguineoActivo.TabIndex = 25;
            this.radioGrupoSanguineoActivo.TabStop = true;
            this.radioGrupoSanguineoActivo.Text = "Activo";
            this.radioGrupoSanguineoActivo.UseVisualStyleBackColor = true;
            // 
            // btnGrupoSanguineoRegistrar
            // 
            this.btnGrupoSanguineoRegistrar.Depth = 0;
            this.btnGrupoSanguineoRegistrar.Location = new System.Drawing.Point(40, 161);
            this.btnGrupoSanguineoRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrupoSanguineoRegistrar.Name = "btnGrupoSanguineoRegistrar";
            this.btnGrupoSanguineoRegistrar.Primary = true;
            this.btnGrupoSanguineoRegistrar.Size = new System.Drawing.Size(100, 35);
            this.btnGrupoSanguineoRegistrar.TabIndex = 27;
            this.btnGrupoSanguineoRegistrar.Text = "Registrar";
            this.btnGrupoSanguineoRegistrar.UseVisualStyleBackColor = true;
            this.btnGrupoSanguineoRegistrar.Click += new System.EventHandler(this.btnGrupoSanguineoRegistrar_Click);
            // 
            // radioGrupoSanguineoInactivo
            // 
            this.radioGrupoSanguineoInactivo.AutoSize = true;
            this.radioGrupoSanguineoInactivo.Depth = 0;
            this.radioGrupoSanguineoInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioGrupoSanguineoInactivo.Location = new System.Drawing.Point(687, 113);
            this.radioGrupoSanguineoInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioGrupoSanguineoInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioGrupoSanguineoInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioGrupoSanguineoInactivo.Name = "radioGrupoSanguineoInactivo";
            this.radioGrupoSanguineoInactivo.Ripple = true;
            this.radioGrupoSanguineoInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioGrupoSanguineoInactivo.TabIndex = 26;
            this.radioGrupoSanguineoInactivo.Text = "Inactivo";
            this.radioGrupoSanguineoInactivo.UseVisualStyleBackColor = true;
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
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(235, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(15, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "*";
            // 
            // GrupoSanguineo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 373);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dataGrupoSanguineo);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.btnGrupoSanguineoGuardar);
            this.Controls.Add(this.txtGrupoSanguineoNombre);
            this.Controls.Add(this.btnGrupoSanguineoListar);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.btnGrupoSanguineoModificar);
            this.Controls.Add(this.radioGrupoSanguineoActivo);
            this.Controls.Add(this.btnGrupoSanguineoRegistrar);
            this.Controls.Add(this.radioGrupoSanguineoInactivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrupoSanguineo";
            this.Text = "Grupo Sanguineo";
            this.Load += new System.EventHandler(this.GrupoSanguineo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrupoSanguineo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrupoSanguineo;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialRaisedButton btnGrupoSanguineoGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGrupoSanguineoNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnGrupoSanguineoListar;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialRaisedButton btnGrupoSanguineoModificar;
        private MaterialSkin.Controls.MaterialRadioButton radioGrupoSanguineoActivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnGrupoSanguineoRegistrar;
        private MaterialSkin.Controls.MaterialRadioButton radioGrupoSanguineoInactivo;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}