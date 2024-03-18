namespace WindowsFormsApp3
{
    partial class Visor
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
            this.lblSeriesDB = new System.Windows.Forms.Label();
            this.visorSeries = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSeriesDB
            // 
            this.lblSeriesDB.AutoSize = true;
            this.lblSeriesDB.BackColor = System.Drawing.SystemColors.Control;
            this.lblSeriesDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeriesDB.Location = new System.Drawing.Point(12, 9);
            this.lblSeriesDB.Name = "lblSeriesDB";
            this.lblSeriesDB.Size = new System.Drawing.Size(282, 31);
            this.lblSeriesDB.TabIndex = 0;
            this.lblSeriesDB.Text = "Series en base de datos";
            this.lblSeriesDB.Click += new System.EventHandler(this.label1_Click);
            // 
            // visorSeries
            // 
            this.visorSeries.FormattingEnabled = true;
            this.visorSeries.ItemHeight = 16;
            this.visorSeries.Location = new System.Drawing.Point(12, 43);
            this.visorSeries.Name = "visorSeries";
            this.visorSeries.Size = new System.Drawing.Size(282, 260);
            this.visorSeries.TabIndex = 1;
            this.visorSeries.SelectedIndexChanged += new System.EventHandler(this.visorSeries_Load);
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 320);
            this.Controls.Add(this.visorSeries);
            this.Controls.Add(this.lblSeriesDB);
            this.Name = "Visor";
            this.Text = "Visor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeriesDB;
        private System.Windows.Forms.ListBox visorSeries;
    }
}