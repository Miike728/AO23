﻿namespace Boletin9
{
    partial class ej7
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
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.txtEuros = new System.Windows.Forms.TextBox();
            this.btnEuros = new System.Windows.Forms.Button();
            this.btnDolares = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(13, 102);
            this.txtDolares.Margin = new System.Windows.Forms.Padding(4);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(132, 22);
            this.txtDolares.TabIndex = 13;
            this.txtDolares.TextChanged += new System.EventHandler(this.txtDolares_TextChanged);
            // 
            // txtEuros
            // 
            this.txtEuros.Location = new System.Drawing.Point(13, 53);
            this.txtEuros.Margin = new System.Windows.Forms.Padding(4);
            this.txtEuros.Name = "txtEuros";
            this.txtEuros.Size = new System.Drawing.Size(132, 22);
            this.txtEuros.TabIndex = 12;
            this.txtEuros.TextChanged += new System.EventHandler(this.txtEuros_TextChanged);
            // 
            // btnEuros
            // 
            this.btnEuros.Location = new System.Drawing.Point(145, 156);
            this.btnEuros.Margin = new System.Windows.Forms.Padding(4);
            this.btnEuros.Name = "btnEuros";
            this.btnEuros.Size = new System.Drawing.Size(100, 49);
            this.btnEuros.TabIndex = 11;
            this.btnEuros.Text = "Convertir a euros";
            this.btnEuros.UseVisualStyleBackColor = true;
            this.btnEuros.Click += new System.EventHandler(this.btnEuros_Click);
            // 
            // btnDolares
            // 
            this.btnDolares.Location = new System.Drawing.Point(13, 156);
            this.btnDolares.Margin = new System.Windows.Forms.Padding(4);
            this.btnDolares.Name = "btnDolares";
            this.btnDolares.Size = new System.Drawing.Size(100, 49);
            this.btnDolares.TabIndex = 10;
            this.btnDolares.Text = "Convertir a dólares";
            this.btnDolares.UseVisualStyleBackColor = true;
            this.btnDolares.Click += new System.EventHandler(this.btnDolares_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Conversor:";
            // 
            // ej7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 220);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.txtEuros);
            this.Controls.Add(this.btnEuros);
            this.Controls.Add(this.btnDolares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ej7";
            this.Text = "ej7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.TextBox txtEuros;
        private System.Windows.Forms.Button btnEuros;
        private System.Windows.Forms.Button btnDolares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}