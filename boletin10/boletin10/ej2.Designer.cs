namespace boletin10
{
    partial class ej2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ej2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio1GMI = new System.Windows.Forms.RadioButton();
            this.radio2GMI = new System.Windows.Forms.RadioButton();
            this.listBoxAsignaturas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione su curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sus asignaturas son:";
            // 
            // radio1GMI
            // 
            this.radio1GMI.AutoSize = true;
            this.radio1GMI.Location = new System.Drawing.Point(16, 53);
            this.radio1GMI.Margin = new System.Windows.Forms.Padding(4);
            this.radio1GMI.Name = "radio1GMI";
            this.radio1GMI.Size = new System.Drawing.Size(67, 20);
            this.radio1GMI.TabIndex = 2;
            this.radio1GMI.TabStop = true;
            this.radio1GMI.Text = "1º GMI";
            this.radio1GMI.UseVisualStyleBackColor = true;
            this.radio1GMI.CheckedChanged += new System.EventHandler(this.radio1GMI_CheckedChanged);
            // 
            // radio2GMI
            // 
            this.radio2GMI.AutoSize = true;
            this.radio2GMI.Location = new System.Drawing.Point(16, 81);
            this.radio2GMI.Margin = new System.Windows.Forms.Padding(4);
            this.radio2GMI.Name = "radio2GMI";
            this.radio2GMI.Size = new System.Drawing.Size(67, 20);
            this.radio2GMI.TabIndex = 3;
            this.radio2GMI.TabStop = true;
            this.radio2GMI.Text = "2º GMI";
            this.radio2GMI.UseVisualStyleBackColor = true;
            this.radio2GMI.CheckedChanged += new System.EventHandler(this.radio2GMI_CheckedChanged);
            // 
            // listBoxAsignaturas
            // 
            this.listBoxAsignaturas.FormattingEnabled = true;
            this.listBoxAsignaturas.ItemHeight = 16;
            this.listBoxAsignaturas.Location = new System.Drawing.Point(256, 53);
            this.listBoxAsignaturas.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAsignaturas.Name = "listBoxAsignaturas";
            this.listBoxAsignaturas.Size = new System.Drawing.Size(291, 132);
            this.listBoxAsignaturas.TabIndex = 4;
            this.listBoxAsignaturas.SelectedIndexChanged += new System.EventHandler(this.listBoxAsignaturas_SelectedIndexChanged);
            // 
            // ej2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 321);
            this.Controls.Add(this.listBoxAsignaturas);
            this.Controls.Add(this.radio2GMI);
            this.Controls.Add(this.radio1GMI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(787, 368);
            this.MinimumSize = new System.Drawing.Size(787, 368);
            this.Name = "ej2";
            this.Text = "Ejercicio 2";
            this.Load += new System.EventHandler(this.ej2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio1GMI;
        private System.Windows.Forms.RadioButton radio2GMI;
        private System.Windows.Forms.ListBox listBoxAsignaturas;
    }
}