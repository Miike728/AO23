namespace boletin9_2
{
    partial class ej6
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCentigrados = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnCentigrados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados centígrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados fahrenheit";
            // 
            // txtCentigrados
            // 
            this.txtCentigrados.Location = new System.Drawing.Point(182, 57);
            this.txtCentigrados.Name = "txtCentigrados";
            this.txtCentigrados.Size = new System.Drawing.Size(100, 20);
            this.txtCentigrados.TabIndex = 2;
            this.txtCentigrados.TextChanged += new System.EventHandler(this.txtCentigrados_TextChanged);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(182, 99);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 3;
            this.txtFahrenheit.TextChanged += new System.EventHandler(this.txtFahrenheit_TextChanged);
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(40, 148);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(129, 23);
            this.btnFahrenheit.TabIndex = 4;
            this.btnFahrenheit.Text = "Convertir a fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnCentigrados
            // 
            this.btnCentigrados.Location = new System.Drawing.Point(191, 148);
            this.btnCentigrados.Name = "btnCentigrados";
            this.btnCentigrados.Size = new System.Drawing.Size(135, 23);
            this.btnCentigrados.TabIndex = 5;
            this.btnCentigrados.Text = "Convertir a centígrados";
            this.btnCentigrados.UseVisualStyleBackColor = true;
            this.btnCentigrados.Click += new System.EventHandler(this.btnCentigrados_Click);
            // 
            // ej6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 200);
            this.Controls.Add(this.btnCentigrados);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCentigrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ej6";
            this.Text = "ej6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCentigrados;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnCentigrados;
    }
}