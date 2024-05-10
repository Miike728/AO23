namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValoracion = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVisor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValoracion
            // 
            this.lblValoracion.AutoSize = true;
            this.lblValoracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoracion.Location = new System.Drawing.Point(12, 79);
            this.lblValoracion.Name = "lblValoracion";
            this.lblValoracion.Size = new System.Drawing.Size(98, 20);
            this.lblValoracion.TabIndex = 1;
            this.lblValoracion.Text = "Valoracion";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(134, 38);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 22);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtValoracion
            // 
            this.txtValoracion.Location = new System.Drawing.Point(134, 79);
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.Size = new System.Drawing.Size(100, 22);
            this.txtValoracion.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(145, 131);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVisor
            // 
            this.btnVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisor.Location = new System.Drawing.Point(251, 50);
            this.btnVisor.Name = "btnVisor";
            this.btnVisor.Size = new System.Drawing.Size(149, 40);
            this.btnVisor.TabIndex = 5;
            this.btnVisor.Text = "Abrir visor";
            this.btnVisor.UseVisualStyleBackColor = true;
            this.btnVisor.Click += new System.EventHandler(this.btnVisor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 355);
            this.Controls.Add(this.btnVisor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtValoracion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblValoracion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValoracion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtValoracion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVisor;
    }
}

