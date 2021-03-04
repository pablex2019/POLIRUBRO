namespace Polirubro
{
    partial class frmArticuloIndice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
<<<<<<< HEAD
<<<<<<< HEAD
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
=======
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Articulos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 154);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(96, 187);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Descargar";
            this.button4.UseVisualStyleBackColor = true;
=======
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(177, 186);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(258, 186);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(75, 23);
            this.btnDescargar.TabIndex = 5;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
<<<<<<< HEAD
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
            // 
            // frmArticuloIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(461, 221);
<<<<<<< HEAD
<<<<<<< HEAD
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
=======
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.btnEliminar);
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.btnEliminar);
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmArticuloIndice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo - Indice";
            this.Load += new System.EventHandler(this.frmArticuloIndice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
<<<<<<< HEAD
<<<<<<< HEAD
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
=======
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDescargar;
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
=======
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDescargar;
>>>>>>> 11e1ba6cab6cd76a6df98deed3ba91941d60cb8c
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}