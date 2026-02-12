using System.Drawing;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbColores.Items.Add("Rojo");
            cmbColores.Items.Add("Verde");
            cmbColores.Items.Add("Azul");
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColores.SelectedItem.ToString())
            {
                case "Rojo":
                    this.BackColor = Color.Red;
                    break;

                case "Verde":
                    this.BackColor = Color.Green;
                    break;

                case "Azul":
                    this.BackColor = Color.Blue;
                    break;
            }
        }
    }
}
