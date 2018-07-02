namespace Oclusoft_Prueba_Material_Design
{
    partial class Parentesco
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
            this.dataParentesco = new System.Windows.Forms.DataGridView();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.btnParentescoGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioParentescoActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnParentescoListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.btnParentescoModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtParentescoNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnParentescoRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioParentescoInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataParentesco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataParentesco
            // 
            this.dataParentesco.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataParentesco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataParentesco.Location = new System.Drawing.Point(51, 198);
            this.dataParentesco.Name = "dataParentesco";
            this.dataParentesco.Size = new System.Drawing.Size(725, 153);
            this.dataParentesco.TabIndex = 21;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(351, 68);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(113, 19);
            this.materialLabel19.TabIndex = 12;
            this.materialLabel19.Text = "PARENTESCOS";
            // 
            // btnParentescoGuardar
            // 
            this.btnParentescoGuardar.Depth = 0;
            this.btnParentescoGuardar.Location = new System.Drawing.Point(668, 147);
            this.btnParentescoGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnParentescoGuardar.Name = "btnParentescoGuardar";
            this.btnParentescoGuardar.Primary = true;
            this.btnParentescoGuardar.Size = new System.Drawing.Size(108, 35);
            this.btnParentescoGuardar.TabIndex = 20;
            this.btnParentescoGuardar.Text = "Guardar";
            this.btnParentescoGuardar.UseVisualStyleBackColor = true;
            this.btnParentescoGuardar.Visible = false;
            this.btnParentescoGuardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioParentescoActivo
            // 
            this.radioParentescoActivo.AutoSize = true;
            this.radioParentescoActivo.Checked = true;
            this.radioParentescoActivo.Depth = 0;
            this.radioParentescoActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioParentescoActivo.Location = new System.Drawing.Point(580, 100);
            this.radioParentescoActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioParentescoActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioParentescoActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioParentescoActivo.Name = "radioParentescoActivo";
            this.radioParentescoActivo.Ripple = true;
            this.radioParentescoActivo.Size = new System.Drawing.Size(68, 30);
            this.radioParentescoActivo.TabIndex = 15;
            this.radioParentescoActivo.TabStop = true;
            this.radioParentescoActivo.Text = "Activo";
            this.radioParentescoActivo.UseVisualStyleBackColor = true;
            // 
            // btnParentescoListar
            // 
            this.btnParentescoListar.Depth = 0;
            this.btnParentescoListar.Location = new System.Drawing.Point(437, 147);
            this.btnParentescoListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnParentescoListar.Name = "btnParentescoListar";
            this.btnParentescoListar.Primary = true;
            this.btnParentescoListar.Size = new System.Drawing.Size(108, 35);
            this.btnParentescoListar.TabIndex = 19;
            this.btnParentescoListar.Text = "Listar";
            this.btnParentescoListar.UseVisualStyleBackColor = true;
            this.btnParentescoListar.Click += new System.EventHandler(this.button3_Click);
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(47, 111);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(166, 19);
            this.materialLabel18.TabIndex = 13;
            this.materialLabel18.Text = "Nombre del parentesco";
            // 
            // btnParentescoModificar
            // 
            this.btnParentescoModificar.Depth = 0;
            this.btnParentescoModificar.Location = new System.Drawing.Point(241, 147);
            this.btnParentescoModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnParentescoModificar.Name = "btnParentescoModificar";
            this.btnParentescoModificar.Primary = true;
            this.btnParentescoModificar.Size = new System.Drawing.Size(102, 35);
            this.btnParentescoModificar.TabIndex = 18;
            this.btnParentescoModificar.Text = "Modificar";
            this.btnParentescoModificar.UseVisualStyleBackColor = true;
            this.btnParentescoModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtParentescoNombre
            // 
            this.txtParentescoNombre.Depth = 0;
            this.txtParentescoNombre.Hint = "";
            this.txtParentescoNombre.Location = new System.Drawing.Point(297, 107);
            this.txtParentescoNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtParentescoNombre.Name = "txtParentescoNombre";
            this.txtParentescoNombre.PasswordChar = '\0';
            this.txtParentescoNombre.SelectedText = "";
            this.txtParentescoNombre.SelectionLength = 0;
            this.txtParentescoNombre.SelectionStart = 0;
            this.txtParentescoNombre.Size = new System.Drawing.Size(149, 23);
            this.txtParentescoNombre.TabIndex = 14;
            this.txtParentescoNombre.UseSystemPasswordChar = false;
            this.txtParentescoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParentescoNombre_KeyPress);
            // 
            // btnParentescoRegistrar
            // 
            this.btnParentescoRegistrar.Depth = 0;
            this.btnParentescoRegistrar.Location = new System.Drawing.Point(51, 147);
            this.btnParentescoRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnParentescoRegistrar.Name = "btnParentescoRegistrar";
            this.btnParentescoRegistrar.Primary = true;
            this.btnParentescoRegistrar.Size = new System.Drawing.Size(100, 35);
            this.btnParentescoRegistrar.TabIndex = 17;
            this.btnParentescoRegistrar.Text = "Registrar";
            this.btnParentescoRegistrar.UseVisualStyleBackColor = true;
            this.btnParentescoRegistrar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // radioParentescoInactivo
            // 
            this.radioParentescoInactivo.AutoSize = true;
            this.radioParentescoInactivo.Depth = 0;
            this.radioParentescoInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioParentescoInactivo.Location = new System.Drawing.Point(698, 100);
            this.radioParentescoInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioParentescoInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioParentescoInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioParentescoInactivo.Name = "radioParentescoInactivo";
            this.radioParentescoInactivo.Ripple = true;
            this.radioParentescoInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioParentescoInactivo.TabIndex = 16;
            this.radioParentescoInactivo.Text = "Inactivo";
            this.radioParentescoInactivo.UseVisualStyleBackColor = true;
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
            this.materialLabel34.Location = new System.Drawing.Point(209, 111);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(15, 19);
            this.materialLabel34.TabIndex = 70;
            this.materialLabel34.Text = "*";
            // 
            // Parentesco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 363);
            this.Controls.Add(this.materialLabel34);
            this.Controls.Add(this.dataParentesco);
            this.Controls.Add(this.materialLabel19);
            this.Controls.Add(this.btnParentescoGuardar);
            this.Controls.Add(this.radioParentescoActivo);
            this.Controls.Add(this.btnParentescoListar);
            this.Controls.Add(this.materialLabel18);
            this.Controls.Add(this.btnParentescoModificar);
            this.Controls.Add(this.txtParentescoNombre);
            this.Controls.Add(this.btnParentescoRegistrar);
            this.Controls.Add(this.radioParentescoInactivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Parentesco";
            this.Text = "Parentesco";
            this.Load += new System.EventHandler(this.Parentesco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataParentesco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataParentesco;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialRaisedButton btnParentescoGuardar;
        private MaterialSkin.Controls.MaterialRadioButton radioParentescoActivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnParentescoListar;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialRaisedButton btnParentescoModificar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtParentescoNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnParentescoRegistrar;
        private MaterialSkin.Controls.MaterialRadioButton radioParentescoInactivo;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
    }
}