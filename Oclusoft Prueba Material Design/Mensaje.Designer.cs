

namespace Oclusoft_Prueba_Material_Design
{
    partial class Mensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensaje));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alertaMensaje = new System.Windows.Forms.Label();
            this.pictureMensaje = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alertaMensaje
            // 
            resources.ApplyResources(this.alertaMensaje, "alertaMensaje");
            this.alertaMensaje.Name = "alertaMensaje";
            // 
            // pictureMensaje
            // 
            resources.ApplyResources(this.pictureMensaje, "pictureMensaje");
            this.pictureMensaje.Name = "pictureMensaje";
            this.pictureMensaje.TabStop = false;
            // 
            // Mensaje
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureMensaje);
            this.Controls.Add(this.alertaMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mensaje";
            this.Opacity = 0.89D;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mensaje_FormClosed);
            this.Load += new System.EventHandler(this.Mensaje_Load);
            this.MouseLeave += new System.EventHandler(this.Mensaje_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Mensaje_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label alertaMensaje;
        private System.Windows.Forms.PictureBox pictureMensaje;
    }
}