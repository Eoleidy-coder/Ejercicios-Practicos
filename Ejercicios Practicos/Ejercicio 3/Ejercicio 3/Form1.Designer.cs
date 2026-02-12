namespace Ejercicio_3
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
            txtTexto = new TextBox();
            BtnMostrar = new Button();
            LblResultado = new Label();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(44, 66);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(419, 31);
            txtTexto.TabIndex = 0;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(192, 119);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(112, 34);
            BtnMostrar.TabIndex = 1;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.BackColor = Color.White;
            LblResultado.Location = new Point(132, 173);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(237, 25);
            LblResultado.TabIndex = 2;
            LblResultado.Text = "                                             ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(523, 277);
            Controls.Add(LblResultado);
            Controls.Add(BtnMostrar);
            Controls.Add(txtTexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTexto;
        private Button BtnMostrar;
        private Label LblResultado;
    }
}
