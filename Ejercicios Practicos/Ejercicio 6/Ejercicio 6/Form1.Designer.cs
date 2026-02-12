namespace Ejercicio_6
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
            cmbColores = new ComboBox();
            // 
            // cmbColores
            // 
            cmbColores.FormattingEnabled = true;
            cmbColores.Items.AddRange(new object[] { "Rojo", "Verde", "Azul" });
            cmbColores.Location = new Point(149, 84);
            cmbColores.Name = "cmbColores";
            cmbColores.Size = new Size(182, 33);
            cmbColores.TabIndex = 0;
            cmbColores.SelectedIndexChanged += cmbColores_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 250);
            Controls.Add(cmbColores);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbColores;
    }
}
