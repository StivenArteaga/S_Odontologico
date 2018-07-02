using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Oclusoft_Prueba_Material_Design
{
    public partial class MediaPlayer : MaterialSkin.Controls.MaterialForm
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        //private string listListaArchivo;

        private void listBoxListaArchivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArchivoMedia archivo = listBoxListaArchivo.SelectedItem as ArchivoMedia;
            if (archivo != null)
            {
                axWindowsMediaPlayer.URL = archivo.ruta;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {
            listBoxListaArchivo.ValueMember = "ruta";
            listBoxListaArchivo.DisplayMember = "nombreArchivo";
        }

        private void seleccioneVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog abrir = new OpenFileDialog()
            {
                Multiselect = true,
                ValidateNames = true,
                Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv"
            })
            {
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    List<ArchivoMedia> archivo = new List<ArchivoMedia>();
                    foreach (string NombreArchivo in abrir.FileNames)
                    {
                        FileInfo archivoInfo = new FileInfo(NombreArchivo);
                        archivo.Add(new ArchivoMedia()
                        {
                            nombreArchivo = Path.GetFileNameWithoutExtension(archivoInfo.FullName),
                            ruta = archivoInfo.FullName
                        });
                    }
                    listBoxListaArchivo.DataSource = archivo;
                }
            }
        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaPlayer.ActiveForm.Close();
        }

    }
}
