namespace Boletin9
{
    partial class ej3
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
            this.txtLado = new System.Windows.Forms.TextBox();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLadoMayor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLadoMenor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular áreas de diferentes polígonos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor del lado:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(129, 71);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(39, 22);
            this.txtLado.TabIndex = 2;
            this.txtLado.TextChanged += new System.EventHandler(this.txtLado_TextChanged);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(494, 71);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(102, 23);
            this.btnCuadrado.TabIndex = 3;
            this.btnCuadrado.Text = "Cuadrado";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor del lado mayor:";
            // 
            // txtLadoMayor
            // 
            this.txtLadoMayor.Location = new System.Drawing.Point(165, 138);
            this.txtLadoMayor.Name = "txtLadoMayor";
            this.txtLadoMayor.Size = new System.Drawing.Size(39, 22);
            this.txtLadoMayor.TabIndex = 5;
            this.txtLadoMayor.TextChanged += new System.EventHandler(this.txtLadoMayor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor del lado menor";
            // 
            // txtLadoMenor
            // 
            this.txtLadoMenor.Location = new System.Drawing.Point(402, 141);
            this.txtLadoMenor.Name = "txtLadoMenor";
            this.txtLadoMenor.Size = new System.Drawing.Size(39, 22);
            this.txtLadoMenor.TabIndex = 7;
            this.txtLadoMenor.TextChanged += new System.EventHandler(this.txtLadoMenor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor de la base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor de la altura";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(165, 210);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(39, 22);
            this.txtBase.TabIndex = 10;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(402, 213);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(39, 22);
            this.txtAltura.TabIndex = 11;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(494, 138);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(102, 23);
            this.btnRectangulo.TabIndex = 12;
            this.btnRectangulo.Text = "Rectángulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(494, 207);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(102, 23);
            this.btnTriangulo.TabIndex = 13;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "RESULTADO";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(191, 315);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 15;
            // 
            // ej3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 355);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLadoMenor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLadoMayor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ej3";
            this.Text = "ej3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLadoMayor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLadoMenor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResultado;
    }
}