namespace Ejercicio_9
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
            txtNumero = new TextBox();
            btnValidar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(87, 52);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(93, 31);
            txtNumero.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(206, 49);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(112, 34);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.White;
            lblResultado.Location = new Point(138, 121);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(112, 25);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "                    ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 207);
            Controls.Add(lblResultado);
            Controls.Add(btnValidar);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Button btnValidar;
        private Label lblResultado;
    }
}
