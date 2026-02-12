namespace Ejercicio_7
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
            BtnAgregar = new Button();
            txtElemento = new TextBox();
            listElementos = new ListBox();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(259, 45);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(112, 34);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click_1;
            // 
            // txtElemento
            // 
            txtElemento.BackColor = Color.AntiqueWhite;
            txtElemento.Location = new Point(32, 45);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(183, 31);
            txtElemento.TabIndex = 1;
            // 
            // listElementos
            // 
            listElementos.BackColor = Color.AntiqueWhite;
            listElementos.FormattingEnabled = true;
            listElementos.ItemHeight = 25;
            listElementos.Location = new Point(420, 45);
            listElementos.Name = "listElementos";
            listElementos.Size = new Size(180, 129);
            listElementos.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(655, 276);
            Controls.Add(listElementos);
            Controls.Add(txtElemento);
            Controls.Add(BtnAgregar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregar;
        private TextBox txtElemento;
        private ListBox listElementos;
    }
}
