namespace boletin9_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDolares = new System.Windows.Forms.Button();
            this.btnEuros = new System.Windows.Forms.Button();
            this.txtEuros = new System.Windows.Forms.TextBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "$";
            // 
            // btnDolares
            // 
            this.btnDolares.Location = new System.Drawing.Point(24, 140);
            this.btnDolares.Name = "btnDolares";
            this.btnDolares.Size = new System.Drawing.Size(75, 40);
            this.btnDolares.TabIndex = 3;
            this.btnDolares.Text = "Convertir a dólares";
            this.btnDolares.UseVisualStyleBackColor = true;
            this.btnDolares.Click += new System.EventHandler(this.btnDolares_Click);
            // 
            // btnEuros
            // 
            this.btnEuros.Location = new System.Drawing.Point(123, 140);
            this.btnEuros.Name = "btnEuros";
            this.btnEuros.Size = new System.Drawing.Size(75, 40);
            this.btnEuros.TabIndex = 4;
            this.btnEuros.Text = "Convertir a euros";
            this.btnEuros.UseVisualStyleBackColor = true;
            this.btnEuros.Click += new System.EventHandler(this.btnEuros_Click);
            // 
            // txtEuros
            // 
            this.txtEuros.Location = new System.Drawing.Point(24, 56);
            this.txtEuros.Name = "txtEuros";
            this.txtEuros.Size = new System.Drawing.Size(100, 20);
            this.txtEuros.TabIndex = 5;
            this.txtEuros.TextChanged += new System.EventHandler(this.txtEuros_TextChanged);
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(24, 96);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(100, 20);
            this.txtDolares.TabIndex = 6;
            this.txtDolares.TextChanged += new System.EventHandler(this.txtDolares_TextChanged);
            // 
            // ej7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDolares;
        private System.Windows.Forms.Button btnEuros;
        private System.Windows.Forms.TextBox txtEuros;
        private System.Windows.Forms.TextBox txtDolares;
    }
}