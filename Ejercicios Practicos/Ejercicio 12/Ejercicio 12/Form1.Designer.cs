namespace Ejercicio_12
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
            lblResultado = new Label();
            btnConvertir = new Button();
            txtCelsius = new TextBox();
            lblLetrro = new Label();
            txtLetrero = new TextBox();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Gainsboro;
            lblResultado.Location = new Point(345, 62);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(22, 25);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "0";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(184, 58);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(112, 32);
            btnConvertir.TabIndex = 1;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(36, 59);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(110, 31);
            txtCelsius.TabIndex = 2;
            // 
            // lblLetrro
            // 
            lblLetrro.AutoSize = true;
            lblLetrro.BackColor = Color.Gainsboro;
            lblLetrro.Location = new Point(82, 6);
            lblLetrro.Name = "lblLetrro";
            lblLetrro.Size = new Size(0, 25);
            lblLetrro.TabIndex = 3;
            lblLetrro.Click += lblLetrro_Click;
            // 
            // txtLetrero
            // 
            txtLetrero.Location = new Point(82, 12);
            txtLetrero.Name = "txtLetrero";
            txtLetrero.Size = new Size(282, 31);
            txtLetrero.TabIndex = 4;
            txtLetrero.Text = "     Convierte Celsius a \nFahrenheit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(427, 131);
            Controls.Add(txtLetrero);
            Controls.Add(lblLetrro);
            Controls.Add(txtCelsius);
            Controls.Add(btnConvertir);
            Controls.Add(lblResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnConvertir;
        private TextBox txtCelsius;
        private Label lblLetrro;
        private TextBox txtLetrero;
    }
}
