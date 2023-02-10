namespace PromedioEstudiantes
{
    partial class Tarea2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Parcial1TextBox1 = new System.Windows.Forms.TextBox();
            this.Parcial2TextBox2 = new System.Windows.Forms.TextBox();
            this.Parcial3TextBox3 = new System.Windows.Forms.TextBox();
            this.PromedioButton1 = new System.Windows.Forms.Button();
            this.Parcial4TextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Parcial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Parcial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tercer Parcial";
            // 
            // Parcial1TextBox1
            // 
            this.Parcial1TextBox1.Location = new System.Drawing.Point(172, 40);
            this.Parcial1TextBox1.Name = "Parcial1TextBox1";
            this.Parcial1TextBox1.Size = new System.Drawing.Size(162, 22);
            this.Parcial1TextBox1.TabIndex = 3;
            // 
            // Parcial2TextBox2
            // 
            this.Parcial2TextBox2.Location = new System.Drawing.Point(172, 80);
            this.Parcial2TextBox2.Name = "Parcial2TextBox2";
            this.Parcial2TextBox2.Size = new System.Drawing.Size(162, 22);
            this.Parcial2TextBox2.TabIndex = 4;
            // 
            // Parcial3TextBox3
            // 
            this.Parcial3TextBox3.Location = new System.Drawing.Point(172, 119);
            this.Parcial3TextBox3.Name = "Parcial3TextBox3";
            this.Parcial3TextBox3.Size = new System.Drawing.Size(162, 22);
            this.Parcial3TextBox3.TabIndex = 5;
            // 
            // PromedioButton1
            // 
            this.PromedioButton1.Location = new System.Drawing.Point(196, 207);
            this.PromedioButton1.Name = "PromedioButton1";
            this.PromedioButton1.Size = new System.Drawing.Size(107, 34);
            this.PromedioButton1.TabIndex = 6;
            this.PromedioButton1.Text = "Promediar";
            this.PromedioButton1.UseVisualStyleBackColor = true;
            this.PromedioButton1.Click += new System.EventHandler(this.PromedioButton1_Click);
            // 
            // Parcial4TextBox1
            // 
            this.Parcial4TextBox1.Location = new System.Drawing.Point(172, 163);
            this.Parcial4TextBox1.Name = "Parcial4TextBox1";
            this.Parcial4TextBox1.Size = new System.Drawing.Size(162, 22);
            this.Parcial4TextBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuarto Parcial";
            // 
            // Tarea2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 338);
            this.Controls.Add(this.Parcial4TextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PromedioButton1);
            this.Controls.Add(this.Parcial3TextBox3);
            this.Controls.Add(this.Parcial2TextBox2);
            this.Controls.Add(this.Parcial1TextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tarea2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Parcial1TextBox1;
        private System.Windows.Forms.TextBox Parcial2TextBox2;
        private System.Windows.Forms.TextBox Parcial3TextBox3;
        private System.Windows.Forms.Button PromedioButton1;
        private System.Windows.Forms.TextBox Parcial4TextBox1;
        private System.Windows.Forms.Label label4;
    }
}

