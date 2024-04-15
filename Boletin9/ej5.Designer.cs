namespace Boletin9
{
    partial class ej5
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
            this.txtCalc1 = new System.Windows.Forms.TextBox();
            this.txtCalc2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblDividir = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCalc1
            // 
            this.txtCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalc1.Location = new System.Drawing.Point(13, 13);
            this.txtCalc1.Multiline = true;
            this.txtCalc1.Name = "txtCalc1";
            this.txtCalc1.Size = new System.Drawing.Size(100, 85);
            this.txtCalc1.TabIndex = 0;
            this.txtCalc1.TextChanged += new System.EventHandler(this.txtCalc1_TextChanged);
            // 
            // txtCalc2
            // 
            this.txtCalc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalc2.Location = new System.Drawing.Point(186, 12);
            this.txtCalc2.Multiline = true;
            this.txtCalc2.Name = "txtCalc2";
            this.txtCalc2.Size = new System.Drawing.Size(100, 85);
            this.txtCalc2.TabIndex = 1;
            this.txtCalc2.TextChanged += new System.EventHandler(this.txtCalc2_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(355, 13);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 85);
            this.txtResultado.TabIndex = 2;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(134, 43);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(31, 32);
            this.lblSuma.TabIndex = 3;
            this.lblSuma.Text = "+";
            this.lblSuma.Visible = false;
            // 
            // lblDividir
            // 
            this.lblDividir.AutoSize = true;
            this.lblDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividir.Location = new System.Drawing.Point(142, 43);
            this.lblDividir.Name = "lblDividir";
            this.lblDividir.Size = new System.Drawing.Size(23, 32);
            this.lblDividir.TabIndex = 4;
            this.lblDividir.Text = "/";
            this.lblDividir.Visible = false;
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicacion.Location = new System.Drawing.Point(139, 43);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(26, 32);
            this.lblMultiplicacion.TabIndex = 5;
            this.lblMultiplicacion.Text = "*";
            this.lblMultiplicacion.Visible = false;
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResta.Location = new System.Drawing.Point(141, 43);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(24, 32);
            this.lblResta.TabIndex = 6;
            this.lblResta.Text = "-";
            this.lblResta.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(307, 43);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(31, 32);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "=";
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(13, 135);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(100, 38);
            this.btnSuma.TabIndex = 8;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(129, 135);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(96, 38);
            this.btnResta.TabIndex = 9;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplica.Location = new System.Drawing.Point(242, 135);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(96, 38);
            this.btnMultiplica.TabIndex = 10;
            this.btnMultiplica.Text = "*";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(355, 135);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 38);
            this.btnDivide.TabIndex = 11;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // ej5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 192);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.lblDividir);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtCalc2);
            this.Controls.Add(this.txtCalc1);
            this.Name = "ej5";
            this.Text = "ej5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCalc1;
        private System.Windows.Forms.TextBox txtCalc2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblDividir;
        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnDivide;
    }
}