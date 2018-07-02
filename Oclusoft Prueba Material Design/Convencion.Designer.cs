namespace Oclusoft_Prueba_Material_Design
{
    partial class Convencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convencion));
            this.comboConvencion = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.colorAzul = new MaterialSkin.Controls.MaterialRadioButton();
            this.colorRojo = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureImgConvencion = new System.Windows.Forms.PictureBox();
            this.btnElegir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.agregarTipoDocumento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImgConvencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // comboConvencion
            // 
            this.comboConvencion.BackColor = System.Drawing.SystemColors.Control;
            this.comboConvencion.FormattingEnabled = true;
            this.comboConvencion.Location = new System.Drawing.Point(25, 103);
            this.comboConvencion.Name = "comboConvencion";
            this.comboConvencion.Size = new System.Drawing.Size(194, 21);
            this.comboConvencion.TabIndex = 0;
            this.comboConvencion.DropDown += new System.EventHandler(this.comboConvencion_DropDown);
            this.comboConvencion.SelectedIndexChanged += new System.EventHandler(this.comboConvencion_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(69, 67);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "CONVENCIONES";
            // 
            // colorAzul
            // 
            this.colorAzul.AutoSize = true;
            this.colorAzul.Depth = 0;
            this.colorAzul.Font = new System.Drawing.Font("Roboto", 10F);
            this.colorAzul.Location = new System.Drawing.Point(298, 97);
            this.colorAzul.Margin = new System.Windows.Forms.Padding(0);
            this.colorAzul.MouseLocation = new System.Drawing.Point(-1, -1);
            this.colorAzul.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorAzul.Name = "colorAzul";
            this.colorAzul.Ripple = true;
            this.colorAzul.Size = new System.Drawing.Size(56, 30);
            this.colorAzul.TabIndex = 2;
            this.colorAzul.TabStop = true;
            this.colorAzul.Text = "Azul";
            this.colorAzul.UseVisualStyleBackColor = true;
            // 
            // colorRojo
            // 
            this.colorRojo.AutoSize = true;
            this.colorRojo.BackColor = System.Drawing.Color.Red;
            this.colorRojo.Depth = 0;
            this.colorRojo.Font = new System.Drawing.Font("Roboto", 10F);
            this.colorRojo.Location = new System.Drawing.Point(392, 97);
            this.colorRojo.Margin = new System.Windows.Forms.Padding(0);
            this.colorRojo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.colorRojo.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorRojo.Name = "colorRojo";
            this.colorRojo.Ripple = true;
            this.colorRojo.Size = new System.Drawing.Size(57, 30);
            this.colorRojo.TabIndex = 3;
            this.colorRojo.TabStop = true;
            this.colorRojo.Text = "Rojo";
            this.colorRojo.UseVisualStyleBackColor = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(344, 67);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "COLOR";
            // 
            // pictureImgConvencion
            // 
            this.pictureImgConvencion.Location = new System.Drawing.Point(181, 163);
            this.pictureImgConvencion.Name = "pictureImgConvencion";
            this.pictureImgConvencion.Size = new System.Drawing.Size(101, 75);
            this.pictureImgConvencion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImgConvencion.TabIndex = 5;
            this.pictureImgConvencion.TabStop = false;
            this.pictureImgConvencion.Visible = false;
            // 
            // btnElegir
            // 
            this.btnElegir.Depth = 0;
            this.btnElegir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnElegir.Location = new System.Drawing.Point(360, 204);
            this.btnElegir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Primary = true;
            this.btnElegir.Size = new System.Drawing.Size(89, 34);
            this.btnElegir.TabIndex = 6;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(189, 67);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(15, 19);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "*";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(397, 67);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(15, 19);
            this.materialLabel4.TabIndex = 28;
            this.materialLabel4.Text = "*";
            // 
            // agregarTipoDocumento
            // 
            this.agregarTipoDocumento.ErrorImage = ((System.Drawing.Image)(resources.GetObject("agregarTipoDocumento.ErrorImage")));
            this.agregarTipoDocumento.Image = ((System.Drawing.Image)(resources.GetObject("agregarTipoDocumento.Image")));
            this.agregarTipoDocumento.InitialImage = ((System.Drawing.Image)(resources.GetObject("agregarTipoDocumento.InitialImage")));
            this.agregarTipoDocumento.Location = new System.Drawing.Point(225, 103);
            this.agregarTipoDocumento.Name = "agregarTipoDocumento";
            this.agregarTipoDocumento.Size = new System.Drawing.Size(23, 21);
            this.agregarTipoDocumento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agregarTipoDocumento.TabIndex = 55;
            this.agregarTipoDocumento.TabStop = false;
            this.agregarTipoDocumento.Click += new System.EventHandler(this.agregarTipoDocumento_Click);
            // 
            // Convencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnElegir;
            this.ClientSize = new System.Drawing.Size(478, 247);
            this.Controls.Add(this.agregarTipoDocumento);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.pictureImgConvencion);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.colorRojo);
            this.Controls.Add(this.colorAzul);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.comboConvencion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Convencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convencion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Convencion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Convencion_FormClosed);
            this.Load += new System.EventHandler(this.Convencion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImgConvencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarTipoDocumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboConvencion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton colorAzul;
        private MaterialSkin.Controls.MaterialRadioButton colorRojo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureImgConvencion;
        private MaterialSkin.Controls.MaterialRaisedButton btnElegir;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox agregarTipoDocumento;
    }
}