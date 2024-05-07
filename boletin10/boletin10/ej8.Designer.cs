namespace boletin10
{
    partial class ej8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ej8));
            this.pictureDado1 = new System.Windows.Forms.PictureBox();
            this.pictureDado3 = new System.Windows.Forms.PictureBox();
            this.pictureDado4 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.pictureDado2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDado2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDado1
            // 
            this.pictureDado1.Location = new System.Drawing.Point(22, 28);
            this.pictureDado1.Name = "pictureDado1";
            this.pictureDado1.Size = new System.Drawing.Size(110, 110);
            this.pictureDado1.TabIndex = 0;
            this.pictureDado1.TabStop = false;
            // 
            // pictureDado3
            // 
            this.pictureDado3.Location = new System.Drawing.Point(22, 170);
            this.pictureDado3.Name = "pictureDado3";
            this.pictureDado3.Size = new System.Drawing.Size(110, 110);
            this.pictureDado3.TabIndex = 2;
            this.pictureDado3.TabStop = false;
            // 
            // pictureDado4
            // 
            this.pictureDado4.Location = new System.Drawing.Point(169, 170);
            this.pictureDado4.Name = "pictureDado4";
            this.pictureDado4.Size = new System.Drawing.Size(110, 110);
            this.pictureDado4.TabIndex = 3;
            this.pictureDado4.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(110, 307);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(78, 39);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pictureDado2
            // 
            this.pictureDado2.Location = new System.Drawing.Point(169, 28);
            this.pictureDado2.Name = "pictureDado2";
            this.pictureDado2.Size = new System.Drawing.Size(110, 110);
            this.pictureDado2.TabIndex = 1;
            this.pictureDado2.TabStop = false;
            this.pictureDado2.Click += new System.EventHandler(this.pictureDado2_Click);
            // 
            // ej8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 363);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pictureDado4);
            this.Controls.Add(this.pictureDado3);
            this.Controls.Add(this.pictureDado2);
            this.Controls.Add(this.pictureDado1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 410);
            this.MinimumSize = new System.Drawing.Size(324, 410);
            this.Name = "ej8";
            this.Text = "Ejercicio 8";
            this.Load += new System.EventHandler(this.ej8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDado2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDado1;
        private System.Windows.Forms.PictureBox pictureDado3;
        private System.Windows.Forms.PictureBox pictureDado4;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox pictureDado2;
    }
}