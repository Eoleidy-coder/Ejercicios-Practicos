namespace Ejercicio_10
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
            BtnInicio = new Button();
            label1 = new Label();
            txtDatos = new TextBox();
            SuspendLayout();
            // 
            // BtnInicio
            // 
            BtnInicio.Location = new Point(474, 118);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(112, 34);
            BtnInicio.TabIndex = 0;
            BtnInicio.Text = "Inicio";
            BtnInicio.UseVisualStyleBackColor = true;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.Location = new Point(21, 71);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre y Matricula";
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(196, 71);
            txtDatos.Name = "txtDatos";
            txtDatos.Size = new Size(390, 31);
            txtDatos.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(598, 192);
            Controls.Add(txtDatos);
            Controls.Add(label1);
            Controls.Add(BtnInicio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnInicio;
        private Label label1;
        private TextBox txtDatos;
    }
}
