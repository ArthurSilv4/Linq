namespace aaaaaaaa
{
    partial class Form1
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
            this.btAgrupar = new System.Windows.Forms.Button();
            this.btMaiuscula = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgrupar
            // 
            this.btAgrupar.Location = new System.Drawing.Point(713, 196);
            this.btAgrupar.Name = "btAgrupar";
            this.btAgrupar.Size = new System.Drawing.Size(75, 23);
            this.btAgrupar.TabIndex = 0;
            this.btAgrupar.Text = "Agrupar";
            this.btAgrupar.UseVisualStyleBackColor = true;
            this.btAgrupar.Click += new System.EventHandler(this.btAgrupar_Click);
            // 
            // btMaiuscula
            // 
            this.btMaiuscula.Location = new System.Drawing.Point(383, 196);
            this.btMaiuscula.Name = "btMaiuscula";
            this.btMaiuscula.Size = new System.Drawing.Size(75, 23);
            this.btMaiuscula.TabIndex = 1;
            this.btMaiuscula.Text = "Maiuscula";
            this.btMaiuscula.UseVisualStyleBackColor = true;
            this.btMaiuscula.Click += new System.EventHandler(this.btMaiuscula_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(12, 196);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btFiltrar.TabIndex = 2;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 213);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.btMaiuscula);
            this.Controls.Add(this.btAgrupar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgrupar;
        private System.Windows.Forms.Button btMaiuscula;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

