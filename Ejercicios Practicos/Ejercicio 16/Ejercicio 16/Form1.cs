using System;
using System.Windows.Forms;

namespace Ejercicio_16
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        // MÉTODO PARA ESCRIBIR NÚMEROS
        private void EscribirNumero(string numero)
        {
            txtResultado.Text += numero;
        }

        // BOTONES DE NÚMEROS
        private void btn0_Click(object sender, EventArgs e)
        {
            EscribirNumero("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EscribirNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EscribirNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EscribirNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EscribirNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EscribirNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EscribirNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EscribirNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EscribirNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EscribirNumero("9");
        }

        // OPERACIONES
        private void btnSuma_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            operacion = "+";
            txtResultado.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            operacion = "-";
            txtResultado.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            operacion = "*";
            txtResultado.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            operacion = "/";
            txtResultado.Clear();
        }

        // BOTÓN IGUAL
        private void btnIgual_Click(object sender, EventArgs e)
        {
            double numero2 = Convert.ToDouble(txtResultado.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    if (numero2 != 0)
                        resultado = numero1 / numero2;
                    else
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        return;
                    }
                    break;
            }

            txtResultado.Text = resultado.ToString();
        }

        // BOTÓN BORRAR
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            numero1 = 0;
            operacion = "";
        }
    }
}
