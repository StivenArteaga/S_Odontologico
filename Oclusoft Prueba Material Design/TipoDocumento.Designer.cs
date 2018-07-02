namespace Oclusoft_Prueba_Material_Design
{
    partial class TipoDocumento
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
            this.dataTipoDocumento = new System.Windows.Forms.DataGridView();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btnTipoDocumentoGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtTipoDocumentoNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnTipoDocumentoListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnTipoDocumentoModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioTipoDocumentoActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnTipoDocumentoRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioTipoDocumentoInactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTipoDocumento
            // 
            this.dataTipoDocumento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTipoDocumento.Location = new System.Drawing.Point(52, 201);
            this.dataTipoDocumento.Name = "dataTipoDocumento";
            this.dataTipoDocumento.Size = new System.Drawing.Size(725, 135);
            this.dataTipoDocumento.TabIndex = 32;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(330, 77);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(178, 19);
            this.materialLabel10.TabIndex = 31;
            this.materialLabel10.Text = "TIPOS DE DOCUMENTOS";
            // 
            // btnTipoDocumentoGuardar
            // 
            this.btnTipoDocumentoGuardar.Depth = 0;
            this.btnTipoDocumentoGuardar.Location = new System.Drawing.Point(669, 160);
            this.btnTipoDocumentoGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoDocumentoGuardar.Name = "btnTipoDocumentoGuardar";
            this.btnTipoDocumentoGuardar.Primary = true;
            this.btnTipoDocumentoGuardar.Size = new System.Drawing.Size(108, 35);
            this.btnTipoDocumentoGuardar.TabIndex = 30;
            this.btnTipoDocumentoGuardar.Text = "Guardar";
            this.btnTipoDocumentoGuardar.UseVisualStyleBackColor = true;
            this.btnTipoDocumentoGuardar.Visible = false;
            this.btnTipoDocumentoGuardar.Click += new System.EventHandler(this.btnTipoDocumentoGuardar_Click);
            // 
            // txtTipoDocumentoNombre
            // 
            this.txtTipoDocumentoNombre.Depth = 0;
            this.txtTipoDocumentoNombre.Hint = "";
            this.txtTipoDocumentoNombre.Location = new System.Drawing.Point(298, 113);
            this.txtTipoDocumentoNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTipoDocumentoNombre.Name = "txtTipoDocumentoNombre";
            this.txtTipoDocumentoNombre.PasswordChar = '\0';
            this.txtTipoDocumentoNombre.SelectedText = "";
            this.txtTipoDocumentoNombre.SelectionLength = 0;
            this.txtTipoDocumentoNombre.SelectionStart = 0;
            this.txtTipoDocumentoNombre.Size = new System.Drawing.Size(149, 23);
            this.txtTipoDocumentoNombre.TabIndex = 24;
            this.txtTipoDocumentoNombre.UseSystemPasswordChar = false;
            this.txtTipoDocumentoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoDocumentoNombre_KeyPress);
            // 
            // btnTipoDocumentoListar
            // 
            this.btnTipoDocumentoListar.Depth = 0;
            this.btnTipoDocumentoListar.Location = new System.Drawing.Point(438, 160);
            this.btnTipoDocumentoListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoDocumentoListar.Name = "btnTipoDocumentoListar";
            this.btnTipoDocumentoListar.Primary = true;
            this.btnTipoDocumentoListar.Size = new System.Drawing.Size(108, 35);
            this.btnTipoDocumentoListar.TabIndex = 29;
            this.btnTipoDocumentoListar.Text = "Listar";
            this.btnTipoDocumentoListar.UseVisualStyleBackColor = true;
            this.btnTipoDocumentoListar.Click += new System.EventHandler(this.btnTipoDocumentoListar_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(48, 117);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(217, 19);
            this.materialLabel9.TabIndex = 23;
            this.materialLabel9.Text = "Nombre del tipo de documento";
            // 
            // btnTipoDocumentoModificar
            // 
            this.btnTipoDocumentoModificar.Depth = 0;
            this.btnTipoDocumentoModificar.Location = new System.Drawing.Point(242, 160);
            this.btnTipoDocumentoModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoDocumentoModificar.Name = "btnTipoDocumentoModificar";
            this.btnTipoDocumentoModificar.Primary = true;
            this.btnTipoDocumentoModificar.Size = new System.Drawing.Size(102, 35);
            this.btnTipoDocumentoModificar.TabIndex = 28;
            this.btnTipoDocumentoModificar.Text = "Modificar";
            this.btnTipoDocumentoModificar.UseVisualStyleBackColor = true;
            this.btnTipoDocumentoModificar.Click += new System.EventHandler(this.btnTipoDocumentoModificar_Click);
            // 
            // radioTipoDocumentoActivo
            // 
            this.radioTipoDocumentoActivo.AutoSize = true;
            this.radioTipoDocumentoActivo.Checked = true;
            this.radioTipoDocumentoActivo.Depth = 0;
            this.radioTipoDocumentoActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioTipoDocumentoActivo.Location = new System.Drawing.Point(564, 112);
            this.radioTipoDocumentoActivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioTipoDocumentoActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioTipoDocumentoActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioTipoDocumentoActivo.Name = "radioTipoDocumentoActivo";
            this.radioTipoDocumentoActivo.Ripple = true;
            this.radioTipoDocumentoActivo.Size = new System.Drawing.Size(68, 30);
            this.radioTipoDocumentoActivo.TabIndex = 25;
            this.radioTipoDocumentoActivo.TabStop = true;
            this.radioTipoDocumentoActivo.Text = "Activo";
            this.radioTipoDocumentoActivo.UseVisualStyleBackColor = true;
            // 
            // btnTipoDocumentoRegistrar
            // 
            this.btnTipoDocumentoRegistrar.Depth = 0;
            this.btnTipoDocumentoRegistrar.Location = new System.Drawing.Point(52, 160);
            this.btnTipoDocumentoRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTipoDocumentoRegistrar.Name = "btnTipoDocumentoRegistrar";
            this.btnTipoDocumentoRegistrar.Primary = true;
            this.btnTipoDocumentoRegistrar.Size = new System.Drawing.Size(100, 35);
            this.btnTipoDocumentoRegistrar.TabIndex = 27;
            this.btnTipoDocumentoRegistrar.Text = "Registrar";
            this.btnTipoDocumentoRegistrar.UseVisualStyleBackColor = true;
            this.btnTipoDocumentoRegistrar.Click += new System.EventHandler(this.btnTipoDocumentoRegistrar_Click);
            // 
            // radioTipoDocumentoInactivo
            // 
            this.radioTipoDocumentoInactivo.AutoSize = true;
            this.radioTipoDocumentoInactivo.Depth = 0;
            this.radioTipoDocumentoInactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioTipoDocumentoInactivo.Location = new System.Drawing.Point(699, 112);
            this.radioTipoDocumentoInactivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioTipoDocumentoInactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioTipoDocumentoInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioTipoDocumentoInactivo.Name = "radioTipoDocumentoInactivo";
            this.radioTipoDocumentoInactivo.Ripple = true;
            this.radioTipoDocumentoInactivo.Size = new System.Drawing.Size(78, 30);
            this.radioTipoDocumentoInactivo.TabIndex = 26;
            this.radioTipoDocumentoInactivo.Text = "Inactivo";
            this.radioTipoDocumentoInactivo.UseVisualStyleBackColor = true;
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
            this.materialLabel34.Location = new System.Drawing.Point(260, 117);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(15, 19);
            this.materialLabel34.TabIndex = 70;
            this.materialLabel34.Text = "*";
            // 
            // TipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 348);
            this.Controls.Add(this.materialLabel34);
            this.Controls.Add(this.dataTipoDocumento);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.btnTipoDocumentoGuardar);
            this.Controls.Add(this.txtTipoDocumentoNombre);
            this.Controls.Add(this.btnTipoDocumentoListar);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.btnTipoDocumentoModificar);
            this.Controls.Add(this.radioTipoDocumentoActivo);
            this.Controls.Add(this.btnTipoDocumentoRegistrar);
            this.Controls.Add(this.radioTipoDocumentoInactivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoDocumento";
            this.Text = "Tipo Documento";
            this.Load += new System.EventHandler(this.TipoDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTipoDocumento;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialRaisedButton btnTipoDocumentoGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTipoDocumentoNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnTipoDocumentoListar;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialRaisedButton btnTipoDocumentoModificar;
        private MaterialSkin.Controls.MaterialRadioButton radioTipoDocumentoActivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnTipoDocumentoRegistrar;
        private MaterialSkin.Controls.MaterialRadioButton radioTipoDocumentoInactivo;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
    }
}