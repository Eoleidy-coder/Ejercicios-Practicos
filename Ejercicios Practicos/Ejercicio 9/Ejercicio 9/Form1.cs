
namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(txtNumero.Text, out numero))
            {
                lblResultado.Text = "Es un número válido.";
            }
            else
            {
                MessageBox.Show("Error: Debes ingresar un número.");
                lblResultado.Text = "";
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }
    }
}

