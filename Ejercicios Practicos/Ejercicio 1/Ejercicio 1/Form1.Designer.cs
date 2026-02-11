namespace Ejercicio_1
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
            labelPrincipal = new Label();
            labelNombre = new Label();
            labelMatricula = new Label();
            TxtNombre = new TextBox();
            TxtMatricula = new TextBox();
            butnInicio = new Button();
            SuspendLayout();
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.BackColor = Color.Snow;
            labelPrincipal.ForeColor = Color.Black;
            labelPrincipal.Location = new Point(256, 36);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(77, 25);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Registro";
            labelPrincipal.Click += label1_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.White;
            labelNombre.Location = new Point(77, 84);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(78, 25);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre";
            labelNombre.Click += label1_Click_1;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.BackColor = Color.White;
            labelMatricula.Location = new Point(71, 134);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(84, 25);
            labelMatricula.TabIndex = 2;
            labelMatricula.Text = "Matricula";
            labelMatricula.Click += label2_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(161, 84);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(335, 31);
            TxtNombre.TabIndex = 3;
            // 
            // TxtMatricula
            // 
            TxtMatricula.Location = new Point(161, 134);
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.Size = new Size(335, 31);
            TxtMatricula.TabIndex = 4;
            // 
            // butnInicio
            // 
            butnInicio.Location = new Point(236, 197);
            butnInicio.Name = "butnInicio";
            butnInicio.Size = new Size(112, 34);
            butnInicio.TabIndex = 5;
            butnInicio.Text = "Inicio";
            butnInicio.UseVisualStyleBackColor = true;
            butnInicio.Click += butnInicio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(549, 262);
            Controls.Add(butnInicio);
            Controls.Add(TxtMatricula);
            Controls.Add(TxtNombre);
            Controls.Add(labelMatricula);
            Controls.Add(labelNombre);
            Controls.Add(labelPrincipal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrincipal;
        private Label labelNombre;
        private Label labelMatricula;
        private TextBox TxtNombre;
        private TextBox TxtMatricula;
        private Button butnInicio;
    }
}