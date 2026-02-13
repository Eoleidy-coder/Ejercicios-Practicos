using System;
using System.Windows.Forms;

namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        // Variable para guardar el conteo
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            contador++; // Aumenta en 1
            lblContador.Text = contador.ToString(); // Muestra el número en el Label
        }
    }
}

