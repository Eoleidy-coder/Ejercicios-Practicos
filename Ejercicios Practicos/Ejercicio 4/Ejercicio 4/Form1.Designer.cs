namespace Ejercicio_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSumar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.BackColor = Color.AntiqueWhite;
            txtNumero1.Location = new Point(50, 64);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(150, 31);
            txtNumero1.TabIndex = 0;
            txtNumero1.TextChanged += textBox1_TextChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.BackColor = Color.AntiqueWhite;
            txtNumero2.Location = new Point(233, 64);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(150, 31);
            txtNumero2.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.AntiqueWhite;
            btnSumar.Location = new Point(75, 122);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(112, 34);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.AntiqueWhite;
            lblResultado.Location = new Point(270, 127);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 25);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(472, 245);
            Controls.Add(lblResultado);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSumar;
        private Label lblResultado;
    }
}
