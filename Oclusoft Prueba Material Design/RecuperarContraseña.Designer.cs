namespace Oclusoft_Prueba_Material_Design
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(89, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(195, 215);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(186, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Ingrese correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Hint = "";
            this.txtCorreo.Location = new System.Drawing.Point(129, 267);
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(317, 23);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Depth = 0;
            this.button1.Location = new System.Drawing.Point(188, 337);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(202, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Recuperar contraseña";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar contraseña";
            this.Load += new System.EventHandler(this.RecuperarContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider error;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}