namespace Proyecto
{
    partial class ConsultProductForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusquedaCPU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBusquedaAlmacenamiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBusquedaRAM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusquedaGPU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusquedaMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnMovil = new System.Windows.Forms.RadioButton();
            this.rbtnOrdenador = new System.Windows.Forms.RadioButton();
            this.btnMostrarResultados = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(264, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(659, 411);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por código:";
            // 
            // txtCodigoBusqueda
            // 
            this.txtCodigoBusqueda.Location = new System.Drawing.Point(105, 22);
            this.txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            this.txtCodigoBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoBusqueda.TabIndex = 2;
            this.txtCodigoBusqueda.TextChanged += new System.EventHandler(this.txtCodigoBusqueda_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(264, 448);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtBusquedaCPU);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBusquedaAlmacenamiento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBusquedaRAM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBusquedaGPU);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBusquedaMarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 316);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda avanzada";
            // 
            // txtBusquedaCPU
            // 
            this.txtBusquedaCPU.Location = new System.Drawing.Point(105, 133);
            this.txtBusquedaCPU.Name = "txtBusquedaCPU";
            this.txtBusquedaCPU.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaCPU.TabIndex = 9;
            this.txtBusquedaCPU.TextChanged += new System.EventHandler(this.txtBusquedaCPU_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "CPU";
            // 
            // txtBusquedaAlmacenamiento
            // 
            this.txtBusquedaAlmacenamiento.Location = new System.Drawing.Point(105, 107);
            this.txtBusquedaAlmacenamiento.Name = "txtBusquedaAlmacenamiento";
            this.txtBusquedaAlmacenamiento.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaAlmacenamiento.TabIndex = 7;
            this.txtBusquedaAlmacenamiento.TextChanged += new System.EventHandler(this.txtBusquedaAlmacenamiento_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Almacenamiento";
            // 
            // txtBusquedaRAM
            // 
            this.txtBusquedaRAM.Location = new System.Drawing.Point(105, 81);
            this.txtBusquedaRAM.Name = "txtBusquedaRAM";
            this.txtBusquedaRAM.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaRAM.TabIndex = 5;
            this.txtBusquedaRAM.TextChanged += new System.EventHandler(this.txtBusquedaRAM_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RAM";
            // 
            // txtBusquedaGPU
            // 
            this.txtBusquedaGPU.Location = new System.Drawing.Point(105, 55);
            this.txtBusquedaGPU.Name = "txtBusquedaGPU";
            this.txtBusquedaGPU.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaGPU.TabIndex = 3;
            this.txtBusquedaGPU.TextChanged += new System.EventHandler(this.txtBusquedaGPU_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "GPU";
            // 
            // txtBusquedaMarca
            // 
            this.txtBusquedaMarca.Location = new System.Drawing.Point(105, 29);
            this.txtBusquedaMarca.Name = "txtBusquedaMarca";
            this.txtBusquedaMarca.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaMarca.TabIndex = 1;
            this.txtBusquedaMarca.TextChanged += new System.EventHandler(this.txtBusquedaMarca_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marca";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnMovil);
            this.groupBox2.Controls.Add(this.rbtnOrdenador);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 48);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar tipo";
            // 
            // rbtnMovil
            // 
            this.rbtnMovil.AutoSize = true;
            this.rbtnMovil.Location = new System.Drawing.Point(108, 19);
            this.rbtnMovil.Name = "rbtnMovil";
            this.rbtnMovil.Size = new System.Drawing.Size(50, 17);
            this.rbtnMovil.TabIndex = 1;
            this.rbtnMovil.Text = "Móvil";
            this.rbtnMovil.UseVisualStyleBackColor = true;
            // 
            // rbtnOrdenador
            // 
            this.rbtnOrdenador.AutoSize = true;
            this.rbtnOrdenador.Checked = true;
            this.rbtnOrdenador.Location = new System.Drawing.Point(14, 19);
            this.rbtnOrdenador.Name = "rbtnOrdenador";
            this.rbtnOrdenador.Size = new System.Drawing.Size(75, 17);
            this.rbtnOrdenador.TabIndex = 0;
            this.rbtnOrdenador.TabStop = true;
            this.rbtnOrdenador.Text = "Ordenador";
            this.rbtnOrdenador.UseVisualStyleBackColor = true;
            this.rbtnOrdenador.CheckedChanged += new System.EventHandler(this.rbtnOrdenador_CheckedChanged);
            // 
            // btnMostrarResultados
            // 
            this.btnMostrarResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMostrarResultados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrarResultados.Location = new System.Drawing.Point(12, 448);
            this.btnMostrarResultados.Name = "btnMostrarResultados";
            this.btnMostrarResultados.Size = new System.Drawing.Size(119, 23);
            this.btnMostrarResultados.TabIndex = 7;
            this.btnMostrarResultados.Text = "Mostrar resultados";
            this.btnMostrarResultados.UseVisualStyleBackColor = false;
            this.btnMostrarResultados.Click += new System.EventHandler(this.btnMostrarResultados_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCodigoBusqueda);
            this.groupBox3.Location = new System.Drawing.Point(12, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 54);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda sencilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultados de la búsqueda:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Imagen:";
            // 
            // ConsultProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnMostrarResultados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.listView1);
            this.Name = "ConsultProductForm";
            this.Text = "ConsultProductForm";
            this.Load += new System.EventHandler(this.ConsultProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnMovil;
        private System.Windows.Forms.RadioButton rbtnOrdenador;
        private System.Windows.Forms.Button btnMostrarResultados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusquedaMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusquedaCPU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBusquedaAlmacenamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBusquedaRAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaGPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}