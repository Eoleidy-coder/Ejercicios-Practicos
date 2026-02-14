namespace Ejercicio_14
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            lblMensajes = new Label();
            lblAdvertencia = new Label();
            lblErrores = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(55, 55);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(401, 181);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblMensajes);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(348, 112);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mensajes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblAdvertencia);
            tabPage2.ForeColor = Color.Coral;
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(393, 143);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Advertencia";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(806, 449);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(300, 150);
            tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(292, 112);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(292, 112);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(lblErrores);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(393, 143);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Errores";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblMensajes
            // 
            lblMensajes.AutoSize = true;
            lblMensajes.Location = new Point(88, 43);
            lblMensajes.Name = "lblMensajes";
            lblMensajes.Size = new Size(165, 25);
            lblMensajes.TabIndex = 0;
            lblMensajes.Text = "No tienes mensajes";
            lblMensajes.Click += lblMensajes_Click;
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.Location = new Point(6, 45);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(387, 25);
            lblAdvertencia.TabIndex = 0;
            lblAdvertencia.Text = "Los Archivos de la papeleria se borraran pronto";
            // 
            // lblErrores
            // 
            lblErrores.AutoSize = true;
            lblErrores.ForeColor = Color.Red;
            lblErrores.Location = new Point(101, 53);
            lblErrores.Name = "lblErrores";
            lblErrores.Size = new Size(186, 25);
            lblErrores.TabIndex = 0;
            lblErrores.Text = "0 Errores Encontrados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 320);
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label lblMensajes;
        private Label lblAdvertencia;
        private Label lblErrores;
    }
}
