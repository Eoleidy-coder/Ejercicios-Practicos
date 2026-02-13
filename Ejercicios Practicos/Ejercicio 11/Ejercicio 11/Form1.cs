namespace Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value;

            lblFecha.Text = "Fecha seleccionada: " +
                            fechaSeleccionada.ToShortDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
