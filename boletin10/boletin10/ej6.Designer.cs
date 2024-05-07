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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ej6));
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
            this.radioTigre.Location = new System.Drawing.Point(28, 90);
            this.radioTigre.Margin = new System.Windows.Forms.Padding(4);
            this.radioTigre.Name = "radioTigre";
            this.radioTigre.Size = new System.Drawing.Size(60, 20);
            this.radioTigre.TabIndex = 2;
            this.radioTigre.Text = "Tigre";
            this.radioTigre.UseVisualStyleBackColor = true;
            this.radioTigre.CheckedChanged += new System.EventHandler(this.radioTigre_CheckedChanged);
            // 
            // radioLobo
            // 
            this.radioLobo.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.radioLobo.AutoSize = true;
            this.radioLobo.Location = new System.Drawing.Point(28, 62);
            this.radioLobo.Margin = new System.Windows.Forms.Padding(4);
            this.radioLobo.Name = "radioLobo";
            this.radioLobo.Size = new System.Drawing.Size(59, 20);
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
            this.radioGato.Location = new System.Drawing.Point(28, 118);
            this.radioGato.Margin = new System.Windows.Forms.Padding(4);
            this.radioGato.Name = "radioGato";
            this.radioGato.Size = new System.Drawing.Size(57, 20);
            this.radioGato.TabIndex = 3;
            this.radioGato.TabStop = true;
            this.radioGato.Text = "Gato";
            this.radioGato.UseVisualStyleBackColor = true;
            this.radioGato.CheckedChanged += new System.EventHandler(this.radioGato_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(141, 16);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 591);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // ej6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 622);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.radioGato);
            this.Controls.Add(this.radioLobo);
            this.Controls.Add(this.radioTigre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 669);
            this.MinimumSize = new System.Drawing.Size(817, 669);
            this.Name = "ej6";
            this.Text = "Ejercicio 6";
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