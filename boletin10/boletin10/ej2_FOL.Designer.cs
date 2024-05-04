namespace boletin10
{
    partial class ej2_FOL
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
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.listBoxTemario = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(12, 53);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(134, 20);
            this.txtProfesor.TabIndex = 7;
            // 
            // listBoxTemario
            // 
            this.listBoxTemario.FormattingEnabled = true;
            this.listBoxTemario.Location = new System.Drawing.Point(225, 53);
            this.listBoxTemario.Name = "listBoxTemario";
            this.listBoxTemario.Size = new System.Drawing.Size(334, 186);
            this.listBoxTemario.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profesor:";
            // 
            // ej2_FOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 261);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.listBoxTemario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ej2_FOL";
            this.Text = "ej2_FOL";
            this.Load += new System.EventHandler(this.ej2_FOL_Load);
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