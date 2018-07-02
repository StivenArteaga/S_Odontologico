namespace Oclusoft_Prueba_Material_Design
{
    partial class TipoConvencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoConvencion));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreConvencion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureConvencion = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBuscarConvencion = new System.Windows.Forms.PictureBox();
            this.btnGuardarConvencion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblRuta = new MaterialSkin.Controls.MaterialLabel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioActivoTipoConvencion = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioInactivoTipoConvencion = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnModificarTipoConvencion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarTipoConvencion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCodigoTipoConvencion = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConvencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscarConvencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(46, 115);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(180, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nombre de la convención";
            // 
            // txtNombreConvencion
            // 
            this.txtNombreConvencion.Depth = 0;
            this.txtNombreConvencion.Hint = "";
            this.txtNombreConvencion.Location = new System.Drawing.Point(289, 111);
            this.txtNombreConvencion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreConvencion.Name = "txtNombreConvencion";
            this.txtNombreConvencion.PasswordChar = '\0';
            this.txtNombreConvencion.SelectedText = "";
            this.txtNombreConvencion.SelectionLength = 0;
            this.txtNombreConvencion.SelectionStart = 0;
            this.txtNombreConvencion.Size = new System.Drawing.Size(161, 23);
            this.txtNombreConvencion.TabIndex = 1;
            this.txtNombreConvencion.UseSystemPasswordChar = false;
            this.txtNombreConvencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreConvencion_KeyPress);
            // 
            // pictureConvencion
            // 
            this.pictureConvencion.Location = new System.Drawing.Point(289, 157);
            this.pictureConvencion.Name = "pictureConvencion";
            this.pictureConvencion.Size = new System.Drawing.Size(81, 68);
            this.pictureConvencion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureConvencion.TabIndex = 2;
            this.pictureConvencion.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(46, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(167, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Figura de la convención";
            // 
            // pictureBuscarConvencion
            // 
            this.pictureBuscarConvencion.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBuscarConvencion.ErrorImage")));
            this.pictureBuscarConvencion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBuscarConvencion.Image")));
            this.pictureBuscarConvencion.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBuscarConvencion.InitialImage")));
            this.pictureBuscarConvencion.Location = new System.Drawing.Point(395, 157);
            this.pictureBuscarConvencion.Name = "pictureBuscarConvencion";
            this.pictureBuscarConvencion.Size = new System.Drawing.Size(37, 30);
            this.pictureBuscarConvencion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBuscarConvencion.TabIndex = 4;
            this.pictureBuscarConvencion.TabStop = false;
            this.pictureBuscarConvencion.Click += new System.EventHandler(this.pictureBuscarConvencion_Click);
            // 
            // btnGuardarConvencion
            // 
            this.btnGuardarConvencion.Depth = 0;
            this.btnGuardarConvencion.Location = new System.Drawing.Point(98, 240);
            this.btnGuardarConvencion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarConvencion.Name = "btnGuardarConvencion";
            this.btnGuardarConvencion.Primary = true;
            this.btnGuardarConvencion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarConvencion.TabIndex = 5;
            this.btnGuardarConvencion.Text = "Guardar";
            this.btnGuardarConvencion.UseVisualStyleBackColor = true;
            this.btnGuardarConvencion.Click += new System.EventHandler(this.btnGuardarConvencion_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Depth = 0;
            this.lblRuta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRuta.Location = new System.Drawing.Point(46, 79);
            this.lblRuta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(0, 19);
            this.lblRuta.TabIndex = 6;
            this.lblRuta.Visible = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Location = new System.Drawing.Point(375, 240);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // radioActivoTipoConvencion
            // 
            this.radioActivoTipoConvencion.AutoSize = true;
            this.radioActivoTipoConvencion.Checked = true;
            this.radioActivoTipoConvencion.Depth = 0;
            this.radioActivoTipoConvencion.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioActivoTipoConvencion.Location = new System.Drawing.Point(50, 195);
            this.radioActivoTipoConvencion.Margin = new System.Windows.Forms.Padding(0);
            this.radioActivoTipoConvencion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioActivoTipoConvencion.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioActivoTipoConvencion.Name = "radioActivoTipoConvencion";
            this.radioActivoTipoConvencion.Ripple = true;
            this.radioActivoTipoConvencion.Size = new System.Drawing.Size(68, 30);
            this.radioActivoTipoConvencion.TabIndex = 8;
            this.radioActivoTipoConvencion.TabStop = true;
            this.radioActivoTipoConvencion.Text = "Activo";
            this.radioActivoTipoConvencion.UseVisualStyleBackColor = true;
            // 
            // radioInactivoTipoConvencion
            // 
            this.radioInactivoTipoConvencion.AutoSize = true;
            this.radioInactivoTipoConvencion.Depth = 0;
            this.radioInactivoTipoConvencion.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioInactivoTipoConvencion.Location = new System.Drawing.Point(151, 195);
            this.radioInactivoTipoConvencion.Margin = new System.Windows.Forms.Padding(0);
            this.radioInactivoTipoConvencion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioInactivoTipoConvencion.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioInactivoTipoConvencion.Name = "radioInactivoTipoConvencion";
            this.radioInactivoTipoConvencion.Ripple = true;
            this.radioInactivoTipoConvencion.Size = new System.Drawing.Size(68, 30);
            this.radioInactivoTipoConvencion.TabIndex = 9;
            this.radioInactivoTipoConvencion.Text = "Activo";
            this.radioInactivoTipoConvencion.UseVisualStyleBackColor = true;
            // 
            // btnModificarTipoConvencion
            // 
            this.btnModificarTipoConvencion.Depth = 0;
            this.btnModificarTipoConvencion.Location = new System.Drawing.Point(224, 240);
            this.btnModificarTipoConvencion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarTipoConvencion.Name = "btnModificarTipoConvencion";
            this.btnModificarTipoConvencion.Primary = true;
            this.btnModificarTipoConvencion.Size = new System.Drawing.Size(104, 23);
            this.btnModificarTipoConvencion.TabIndex = 10;
            this.btnModificarTipoConvencion.Text = "Modificar";
            this.btnModificarTipoConvencion.UseVisualStyleBackColor = true;
            this.btnModificarTipoConvencion.Click += new System.EventHandler(this.btnModificarTipoConvencion_Click);
            // 
            // btnBuscarTipoConvencion
            // 
            this.btnBuscarTipoConvencion.Depth = 0;
            this.btnBuscarTipoConvencion.Location = new System.Drawing.Point(456, 111);
            this.btnBuscarTipoConvencion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarTipoConvencion.Name = "btnBuscarTipoConvencion";
            this.btnBuscarTipoConvencion.Primary = true;
            this.btnBuscarTipoConvencion.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTipoConvencion.TabIndex = 11;
            this.btnBuscarTipoConvencion.Text = "Buscar";
            this.btnBuscarTipoConvencion.UseVisualStyleBackColor = true;
            this.btnBuscarTipoConvencion.Click += new System.EventHandler(this.btnBuscarTipoConvencion_Click);
            // 
            // lblCodigoTipoConvencion
            // 
            this.lblCodigoTipoConvencion.AutoSize = true;
            this.lblCodigoTipoConvencion.Depth = 0;
            this.lblCodigoTipoConvencion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodigoTipoConvencion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigoTipoConvencion.Location = new System.Drawing.Point(25, 60);
            this.lblCodigoTipoConvencion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoTipoConvencion.Name = "lblCodigoTipoConvencion";
            this.lblCodigoTipoConvencion.Size = new System.Drawing.Size(21, 19);
            this.lblCodigoTipoConvencion.TabIndex = 12;
            this.lblCodigoTipoConvencion.Text = "Id";
            this.lblCodigoTipoConvencion.Visible = false;
            // 
            // TipoConvencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 287);
            this.Controls.Add(this.lblCodigoTipoConvencion);
            this.Controls.Add(this.btnBuscarTipoConvencion);
            this.Controls.Add(this.btnModificarTipoConvencion);
            this.Controls.Add(this.radioInactivoTipoConvencion);
            this.Controls.Add(this.radioActivoTipoConvencion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnGuardarConvencion);
            this.Controls.Add(this.pictureBuscarConvencion);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.pictureConvencion);
            this.Controls.Add(this.txtNombreConvencion);
            this.Controls.Add(this.materialLabel1);
            this.Name = "TipoConvencion";
            this.Text = "Agregar convención";
            this.Load += new System.EventHandler(this.TipoConvencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureConvencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscarConvencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreConvencion;
        private System.Windows.Forms.PictureBox pictureConvencion;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBuscarConvencion;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarConvencion;
        private MaterialSkin.Controls.MaterialLabel lblRuta;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
        private MaterialSkin.Controls.MaterialRadioButton radioInactivoTipoConvencion;
        private MaterialSkin.Controls.MaterialRadioButton radioActivoTipoConvencion;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarTipoConvencion;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificarTipoConvencion;
        private MaterialSkin.Controls.MaterialLabel lblCodigoTipoConvencion;
    }
}