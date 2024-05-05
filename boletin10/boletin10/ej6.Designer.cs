namespace boletin10
{
    partial class ej6
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
            this.radioTigre = new System.Windows.Forms.RadioButton();
            this.radioLobo = new System.Windows.Forms.RadioButton();
            this.radioGato = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // radioTigre
            // 
            this.radioTigre.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.radioTigre.AutoSize = true;
            this.radioTigre.Location = new System.Drawing.Point(21, 73);
            this.radioTigre.Name = "radioTigre";
            this.radioTigre.Size = new System.Drawing.Size(49, 17);
            this.radioTigre.TabIndex = 2;
            this.radioTigre.Text = "Tigre";
            this.radioTigre.UseVisualStyleBackColor = true;
            this.radioTigre.CheckedChanged += new System.EventHandler(this.radioTigre_CheckedChanged);
            // 
            // radioLobo
            // 
            this.radioLobo.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.radioLobo.AutoSize = true;
            this.radioLobo.Location = new System.Drawing.Point(21, 50);
            this.radioLobo.Name = "radioLobo";
            this.radioLobo.Size = new System.Drawing.Size(49, 17);
            this.radioLobo.TabIndex = 1;
            this.radioLobo.TabStop = true;
            this.radioLobo.Text = "Lobo";
            this.radioLobo.UseVisualStyleBackColor = true;
            this.radioLobo.CheckedChanged += new System.EventHandler(this.radioLobo_CheckedChanged);
            // 
            // radioGato
            // 
            this.radioGato.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.radioGato.AutoSize = true;
            this.radioGato.Location = new System.Drawing.Point(21, 96);
            this.radioGato.Name = "radioGato";
            this.radioGato.Size = new System.Drawing.Size(48, 17);
            this.radioGato.TabIndex = 3;
            this.radioGato.TabStop = true;
            this.radioGato.Text = "Gato";
            this.radioGato.UseVisualStyleBackColor = true;
            this.radioGato.CheckedChanged += new System.EventHandler(this.radioGato_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(106, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(480, 480);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // ej6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 505);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.radioGato);
            this.Controls.Add(this.radioLobo);
            this.Controls.Add(this.radioTigre);
            this.Name = "ej6";
            this.Text = "ej6";
            this.Load += new System.EventHandler(this.ej6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioTigre;
        private System.Windows.Forms.RadioButton radioLobo;
        private System.Windows.Forms.RadioButton radioGato;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}