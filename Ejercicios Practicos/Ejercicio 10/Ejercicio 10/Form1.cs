namespace Ejercicio_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          

        private void BtnInicio_Click(object sender, EventArgs e)
        {
       
            string datos = txtDatos.Text.Trim();

            if (datos == "")
            {
                MessageBox.Show("Escribe tu nombre y matrícula.");
                return;
            }

            int espacio = datos.LastIndexOf(" ");

            if (espacio > 0)
            {
                string nombre = datos.Substring(0, espacio);
                string matricula = datos.Substring(espacio + 1);

                MessageBox.Show("Hola, soy " + nombre + " y " + matricula);
            }
            else
            {
                MessageBox.Show("Debes separar nombre y matrícula con un espacio.");
            }
        }
    }

}