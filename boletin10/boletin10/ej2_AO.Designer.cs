namespace boletin10
{
    partial class ej2_AO
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
            this.listBoxTemario = new System.Windows.Forms.ListBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temario:";
            // 
            // listBoxTemario
            // 
            this.listBoxTemario.FormattingEnabled = true;
            this.listBoxTemario.Location = new System.Drawing.Point(225, 53);
            this.listBoxTemario.Name = "listBoxTemario";
            this.listBoxTemario.Size = new System.Drawing.Size(334, 186);
            this.listBoxTemario.TabIndex = 2;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(12, 53);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(166, 20);
            this.txtProfesor.TabIndex = 3;
            // 
            // ej2_AO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 261);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.listBoxTemario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ej2_AO";
            this.Text = "ej2_AO";
            this.Load += new System.EventHandler(this.ej2_AO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTemario;
        private System.Windows.Forms.TextBox txtProfesor;
    }
}