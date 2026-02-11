using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
        }

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {
            string matricula = TxtMatricula.Text;
        }

        private void butnInicio_Click(object sender, EventArgs e)

        {
            MessageBox.Show(
                "¡Bienvenido al formulario de " + TxtNombre.Text + "\ncon matrícula " + TxtMatricula.Text + "!",
                "Mensaje");
        }
        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}