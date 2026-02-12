using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtElemento.Text))
            {
                listElementos.Items.Add(txtElemento.Text);
                txtElemento.Clear();
                txtElemento.Focus();
            }
            else
            {
                MessageBox.Show("Escribe un elemento primero.");
            }
        }

        // Added handler to match designer's event wiring
        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            // Delegate to existing handler to avoid duplicate code
            btnAgregar_Click(sender, e);
        }
    }
}
