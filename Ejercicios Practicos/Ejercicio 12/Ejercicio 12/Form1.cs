using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLetrro_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double celsius;

            if (double.TryParse(txtCelsius.Text, out celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblResultado.Text = celsius + " °C = " + fahrenheit.ToString("F2") + " °F";
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número válido.");
                txtCelsius.Clear();
                txtCelsius.Focus();
            }
        }
    }
}