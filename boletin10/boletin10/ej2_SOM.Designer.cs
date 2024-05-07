namespace boletin10
{
    partial class ej2_SOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ej2_SOM));
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.listBoxTemario = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(16, 65);
            this.txtProfesor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.ReadOnly = true;
            this.txtProfesor.Size = new System.Drawing.Size(177, 22);
            this.txtProfesor.TabIndex = 7;
            // 
            // listBoxTemario
            // 
            this.listBoxTemario.FormattingEnabled = true;
            this.listBoxTemario.ItemHeight = 16;
            this.listBoxTemario.Location = new System.Drawing.Point(300, 65);
            this.listBoxTemario.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTemario.Name = "listBoxTemario";
            this.listBoxTemario.Size = new System.Drawing.Size(444, 228);
            this.listBoxTemario.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profesor:";
            // 
            // ej2_SOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 321);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.listBoxTemario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(787, 368);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(787, 368);
            this.Name = "ej2_SOM";
            this.Text = "Sistemas operativos monopuesto";
            this.Load += new System.EventHandler(this.ej2_SOM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.ListBox listBoxTemario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}