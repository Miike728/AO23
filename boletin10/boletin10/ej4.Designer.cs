namespace boletin10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ej4));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.radioComboBox = new System.Windows.Forms.RadioButton();
            this.radioListBox = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRegistros = new System.Windows.Forms.ComboBox();
            this.listBoxRegistros = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del campo";
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(152, 30);
            this.txtCampo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(175, 22);
            this.txtCampo.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(383, 27);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 28);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // radioComboBox
            // 
            this.radioComboBox.AutoSize = true;
            this.radioComboBox.Location = new System.Drawing.Point(152, 76);
            this.radioComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.radioComboBox.Name = "radioComboBox";
            this.radioComboBox.Size = new System.Drawing.Size(157, 20);
            this.radioComboBox.TabIndex = 3;
            this.radioComboBox.TabStop = true;
            this.radioComboBox.Text = "Cargar en ComboBox";
            this.radioComboBox.UseVisualStyleBackColor = true;
            // 
            // radioListBox
            // 
            this.radioListBox.AutoSize = true;
            this.radioListBox.Location = new System.Drawing.Point(152, 106);
            this.radioListBox.Margin = new System.Windows.Forms.Padding(4);
            this.radioListBox.Name = "radioListBox";
            this.radioListBox.Size = new System.Drawing.Size(133, 20);
            this.radioListBox.TabIndex = 4;
            this.radioListBox.TabStop = true;
            this.radioListBox.Text = "Cargar en ListBox";
            this.radioListBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Registros";
            // 
            // comboBoxRegistros
            // 
            this.comboBoxRegistros.FormattingEnabled = true;
            this.comboBoxRegistros.Location = new System.Drawing.Point(20, 180);
            this.comboBoxRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRegistros.Name = "comboBoxRegistros";
            this.comboBoxRegistros.Size = new System.Drawing.Size(575, 24);
            this.comboBoxRegistros.TabIndex = 6;
            // 
            // listBoxRegistros
            // 
            this.listBoxRegistros.FormattingEnabled = true;
            this.listBoxRegistros.ItemHeight = 16;
            this.listBoxRegistros.Location = new System.Drawing.Point(20, 213);
            this.listBoxRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRegistros.Name = "listBoxRegistros";
            this.listBoxRegistros.Size = new System.Drawing.Size(575, 228);
            this.listBoxRegistros.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(383, 89);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar en fichero";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ej4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 449);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.listBoxRegistros);
            this.Controls.Add(this.comboBoxRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioListBox);
            this.Controls.Add(this.radioComboBox);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtCampo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 496);
            this.MinimumSize = new System.Drawing.Size(630, 496);
            this.Name = "ej4";
            this.Text = "Ejercicio 4";
            this.Load += new System.EventHandler(this.ej4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RadioButton radioComboBox;
        private System.Windows.Forms.RadioButton radioListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRegistros;
        private System.Windows.Forms.ListBox listBoxRegistros;
        private System.Windows.Forms.Button btnGuardar;
    }
}