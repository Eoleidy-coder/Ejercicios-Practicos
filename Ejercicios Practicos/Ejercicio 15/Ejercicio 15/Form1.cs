using System;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        private string rutaArchivo = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog1.FileName;
                txtContenido.Text = File.ReadAllText(rutaArchivo);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }

            File.WriteAllText(rutaArchivo, txtContenido.Text);
            MessageBox.Show("Archivo guardado correctamente");
        }
    }
}
