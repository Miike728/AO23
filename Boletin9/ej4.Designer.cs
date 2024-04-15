namespace Boletin9
{
    partial class ej4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Horas";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(171, 37);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(82, 22);
            this.txtHoras.TabIndex = 1;
            this.txtHoras.TextChanged += new System.EventHandler(this.txtHoras_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutos";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(101, 156);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(91, 22);
            this.txtMinutos.TabIndex = 4;
            // 
            // txtSegundos
            // 
            this.txtSegundos.Location = new System.Drawing.Point(302, 156);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(100, 22);
            this.txtSegundos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Segundos";
            // 
            // ej4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.label1);
            this.Name = "ej4";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ej4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.Label label3;
    }
}