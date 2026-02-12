using System.Reflection.Emit;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Seleccionaste: Opción 1";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Seleccionaste: Opción 2";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Seleccionaste: Opción 3";
            }
            else
            {
                label1.Text = "No has seleccionado ninguna opción";
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
