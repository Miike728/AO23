namespace boletin10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ej5));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxMañana = new System.Windows.Forms.ListBox();
            this.listBoxNoche = new System.Windows.Forms.ListBox();
            this.btnMañanaANoche = new System.Windows.Forms.Button();
            this.btnTodoMañanaANoche = new System.Windows.Forms.Button();
            this.btnNocheAMañana = new System.Windows.Forms.Button();
            this.btnTodoNocheAMañana = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalMañana = new System.Windows.Forms.TextBox();
            this.txtTotalNoche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Empleado:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(165, 18);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(126, 22);
            this.txtEmpleado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elige el turno:";
            // 
            // comboTurno
            // 
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(165, 58);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(126, 24);
            this.comboTurno.TabIndex = 3;
            this.comboTurno.SelectedIndexChanged += new System.EventHandler(this.comboTurno_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno Mañana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Turno Noche:";
            // 
            // listBoxMañana
            // 
            this.listBoxMañana.FormattingEnabled = true;
            this.listBoxMañana.ItemHeight = 16;
            this.listBoxMañana.Location = new System.Drawing.Point(15, 137);
            this.listBoxMañana.Name = "listBoxMañana";
            this.listBoxMañana.Size = new System.Drawing.Size(155, 148);
            this.listBoxMañana.TabIndex = 6;
            // 
            // listBoxNoche
            // 
            this.listBoxNoche.FormattingEnabled = true;
            this.listBoxNoche.ItemHeight = 16;
            this.listBoxNoche.Location = new System.Drawing.Point(251, 137);
            this.listBoxNoche.Name = "listBoxNoche";
            this.listBoxNoche.Size = new System.Drawing.Size(155, 148);
            this.listBoxNoche.TabIndex = 7;
            // 
            // btnMañanaANoche
            // 
            this.btnMañanaANoche.Location = new System.Drawing.Point(187, 137);
            this.btnMañanaANoche.Name = "btnMañanaANoche";
            this.btnMañanaANoche.Size = new System.Drawing.Size(44, 23);
            this.btnMañanaANoche.TabIndex = 8;
            this.btnMañanaANoche.Text = ">";
            this.btnMañanaANoche.UseVisualStyleBackColor = true;
            this.btnMañanaANoche.Click += new System.EventHandler(this.btnMañanaANoche_Click);
            // 
            // btnTodoMañanaANoche
            // 
            this.btnTodoMañanaANoche.Location = new System.Drawing.Point(187, 179);
            this.btnTodoMañanaANoche.Name = "btnTodoMañanaANoche";
            this.btnTodoMañanaANoche.Size = new System.Drawing.Size(44, 23);
            this.btnTodoMañanaANoche.TabIndex = 9;
            this.btnTodoMañanaANoche.Text = ">>";
            this.btnTodoMañanaANoche.UseVisualStyleBackColor = true;
            this.btnTodoMañanaANoche.Click += new System.EventHandler(this.btnTodoMañanaANoche_Click);
            // 
            // btnNocheAMañana
            // 
            this.btnNocheAMañana.Location = new System.Drawing.Point(187, 220);
            this.btnNocheAMañana.Name = "btnNocheAMañana";
            this.btnNocheAMañana.Size = new System.Drawing.Size(44, 23);
            this.btnNocheAMañana.TabIndex = 10;
            this.btnNocheAMañana.Text = "<";
            this.btnNocheAMañana.UseVisualStyleBackColor = true;
            this.btnNocheAMañana.Click += new System.EventHandler(this.btnNocheAMañana_Click);
            // 
            // btnTodoNocheAMañana
            // 
            this.btnTodoNocheAMañana.Location = new System.Drawing.Point(187, 262);
            this.btnTodoNocheAMañana.Name = "btnTodoNocheAMañana";
            this.btnTodoNocheAMañana.Size = new System.Drawing.Size(44, 23);
            this.btnTodoNocheAMañana.TabIndex = 11;
            this.btnTodoNocheAMañana.Text = "<<";
            this.btnTodoNocheAMañana.UseVisualStyleBackColor = true;
            this.btnTodoNocheAMañana.Click += new System.EventHandler(this.btnTodoNocheAMañana_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Mañana:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Noche:";
            // 
            // txtTotalMañana
            // 
            this.txtTotalMañana.Location = new System.Drawing.Point(114, 304);
            this.txtTotalMañana.Name = "txtTotalMañana";
            this.txtTotalMañana.Size = new System.Drawing.Size(44, 22);
            this.txtTotalMañana.TabIndex = 14;
            // 
            // txtTotalNoche
            // 
            this.txtTotalNoche.Location = new System.Drawing.Point(345, 304);
            this.txtTotalNoche.Name = "txtTotalNoche";
            this.txtTotalNoche.Size = new System.Drawing.Size(44, 22);
            this.txtTotalNoche.TabIndex = 15;
            // 
            // ej5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 347);
            this.Controls.Add(this.txtTotalNoche);
            this.Controls.Add(this.txtTotalMañana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTodoNocheAMañana);
            this.Controls.Add(this.btnNocheAMañana);
            this.Controls.Add(this.btnTodoMañanaANoche);
            this.Controls.Add(this.btnMañanaANoche);
            this.Controls.Add(this.listBoxNoche);
            this.Controls.Add(this.listBoxMañana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 394);
            this.MinimumSize = new System.Drawing.Size(441, 394);
            this.Name = "ej5";
            this.Text = "Ejercicio 5";
            this.Load += new System.EventHandler(this.ej5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxMañana;
        private System.Windows.Forms.ListBox listBoxNoche;
        private System.Windows.Forms.Button btnMañanaANoche;
        private System.Windows.Forms.Button btnTodoMañanaANoche;
        private System.Windows.Forms.Button btnNocheAMañana;
        private System.Windows.Forms.Button btnTodoNocheAMañana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalMañana;
        private System.Windows.Forms.TextBox txtTotalNoche;
    }
}