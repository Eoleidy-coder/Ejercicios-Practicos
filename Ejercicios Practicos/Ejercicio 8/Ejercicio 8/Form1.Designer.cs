namespace Ejercicio_8
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
            btnContar = new Button();
            lblContador = new Label();
            SuspendLayout();
            // 
            // btnContar
            // 
            btnContar.Location = new Point(50, 44);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(112, 34);
            btnContar.TabIndex = 0;
            btnContar.Text = "Precionar";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.BackColor = SystemColors.Control;
            lblContador.Location = new Point(90, 102);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(22, 25);
            lblContador.TabIndex = 1;
            lblContador.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(211, 192);
            Controls.Add(lblContador);
            Controls.Add(btnContar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContar;
        private Label lblContador;
    }
}
