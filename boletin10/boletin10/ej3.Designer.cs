namespace boletin10
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
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioMilimetros = new System.Windows.Forms.RadioButton();
            this.radioCentimetros = new System.Windows.Forms.RadioButton();
            this.radioDecimetros = new System.Windows.Forms.RadioButton();
            this.radioKilometros = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Metros";
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(117, 18);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(100, 20);
            this.txtMetros.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Conversión";
            // 
            // radioMilimetros
            // 
            this.radioMilimetros.AutoSize = true;
            this.radioMilimetros.Location = new System.Drawing.Point(24, 78);
            this.radioMilimetros.Name = "radioMilimetros";
            this.radioMilimetros.Size = new System.Drawing.Size(73, 17);
            this.radioMilimetros.TabIndex = 3;
            this.radioMilimetros.TabStop = true;
            this.radioMilimetros.Text = "Milímetros";
            this.radioMilimetros.UseVisualStyleBackColor = true;
            // 
            // radioCentimetros
            // 
            this.radioCentimetros.AutoSize = true;
            this.radioCentimetros.Location = new System.Drawing.Point(24, 102);
            this.radioCentimetros.Name = "radioCentimetros";
            this.radioCentimetros.Size = new System.Drawing.Size(82, 17);
            this.radioCentimetros.TabIndex = 4;
            this.radioCentimetros.TabStop = true;
            this.radioCentimetros.Text = "Centímetros";
            this.radioCentimetros.UseVisualStyleBackColor = true;
            // 
            // radioDecimetros
            // 
            this.radioDecimetros.AutoSize = true;
            this.radioDecimetros.Location = new System.Drawing.Point(24, 126);
            this.radioDecimetros.Name = "radioDecimetros";
            this.radioDecimetros.Size = new System.Drawing.Size(78, 17);
            this.radioDecimetros.TabIndex = 5;
            this.radioDecimetros.TabStop = true;
            this.radioDecimetros.Text = "Decimetros";
            this.radioDecimetros.UseVisualStyleBackColor = true;
            // 
            // radioKilometros
            // 
            this.radioKilometros.AutoSize = true;
            this.radioKilometros.Location = new System.Drawing.Point(24, 150);
            this.radioKilometros.Name = "radioKilometros";
            this.radioKilometros.Size = new System.Drawing.Size(73, 17);
            this.radioKilometros.TabIndex = 6;
            this.radioKilometros.TabStop = true;
            this.radioKilometros.Text = "Kilometros";
            this.radioKilometros.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(170, 99);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 8;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(12, 190);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(110, 190);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(107, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo Cálculo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(235, 190);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ej3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 233);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioKilometros);
            this.Controls.Add(this.radioDecimetros);
            this.Controls.Add(this.radioCentimetros);
            this.Controls.Add(this.radioMilimetros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.label1);
            this.Name = "ej3";
            this.Text = "ej3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioMilimetros;
        private System.Windows.Forms.RadioButton radioCentimetros;
        private System.Windows.Forms.RadioButton radioDecimetros;
        private System.Windows.Forms.RadioButton radioKilometros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
    }
}