namespace Oclusoft_Prueba_Material_Design
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxListaArchivo = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seleccioneVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(3, 54);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(1058, 378);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // listBoxListaArchivo
            // 
            this.listBoxListaArchivo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBoxListaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxListaArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxListaArchivo.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxListaArchivo.FormattingEnabled = true;
            this.listBoxListaArchivo.Location = new System.Drawing.Point(3, 16);
            this.listBoxListaArchivo.Name = "listBoxListaArchivo";
            this.listBoxListaArchivo.Size = new System.Drawing.Size(1058, 13);
            this.listBoxListaArchivo.TabIndex = 2;
            this.listBoxListaArchivo.SelectedIndexChanged += new System.EventHandler(this.listBoxListaArchivo_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccioneVideoToolStripMenuItem,
            this.reproducirToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seleccioneVideoToolStripMenuItem
            // 
            this.seleccioneVideoToolStripMenuItem.Name = "seleccioneVideoToolStripMenuItem";
            this.seleccioneVideoToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            this.seleccioneVideoToolStripMenuItem.Text = "Seleccione video";
            this.seleccioneVideoToolStripMenuItem.Click += new System.EventHandler(this.seleccioneVideoToolStripMenuItem_Click);
            // 
            // reproducirToolStripMenuItem
            // 
            this.reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            this.reproducirToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.reproducirToolStripMenuItem.Text = "Reproducir";
            this.reproducirToolStripMenuItem.Click += new System.EventHandler(this.reproducirToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.pausarToolStripMenuItem.Text = "Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.pausarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.listBoxListaArchivo);
            this.groupBox1.Location = new System.Drawing.Point(1, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 435);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 501);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MediaPlayer";
            this.Text = "Navegacion del sistema";
            this.Load += new System.EventHandler(this.MediaPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.ListBox listBoxListaArchivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seleccioneVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}