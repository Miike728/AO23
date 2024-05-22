namespace ProyectoFinal
{
    partial class EditorDBs
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
            this.comboSelectorDBs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDBs = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDBs)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSelectorDBs
            // 
            this.comboSelectorDBs.FormattingEnabled = true;
            this.comboSelectorDBs.Location = new System.Drawing.Point(12, 55);
            this.comboSelectorDBs.Name = "comboSelectorDBs";
            this.comboSelectorDBs.Size = new System.Drawing.Size(121, 24);
            this.comboSelectorDBs.TabIndex = 0;
            this.comboSelectorDBs.SelectedIndexChanged += new System.EventHandler(this.comboSelectorDBs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona una DB";
            // 
            // dataGridDBs
            // 
            this.dataGridDBs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDBs.Location = new System.Drawing.Point(162, 94);
            this.dataGridDBs.Name = "dataGridDBs";
            this.dataGridDBs.RowHeadersWidth = 51;
            this.dataGridDBs.RowTemplate.Height = 24;
            this.dataGridDBs.Size = new System.Drawing.Size(670, 340);
            this.dataGridDBs.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 470);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(218, 41);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar cambios de esta DB";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // EditorDBs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 539);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridDBs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSelectorDBs);
            this.Name = "EditorDBs";
            this.Text = "EditorDBs";
            this.Load += new System.EventHandler(this.EditorDBs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDBs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSelectorDBs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDBs;
        private System.Windows.Forms.Button btnGuardar;
    }
}