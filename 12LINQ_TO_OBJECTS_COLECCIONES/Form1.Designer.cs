namespace _12LINQ_TO_OBJECTS_COLECCIONES
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
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnCargarPares = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 16;
            this.lstNumeros.Location = new System.Drawing.Point(31, 48);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(323, 324);
            this.lstNumeros.TabIndex = 0;
            // 
            // btnCargarPares
            // 
            this.btnCargarPares.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCargarPares.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarPares.ForeColor = System.Drawing.Color.White;
            this.btnCargarPares.Location = new System.Drawing.Point(439, 48);
            this.btnCargarPares.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargarPares.Name = "btnCargarPares";
            this.btnCargarPares.Size = new System.Drawing.Size(220, 85);
            this.btnCargarPares.TabIndex = 15;
            this.btnCargarPares.Text = "CARGAR NUMEROS PARES";
            this.btnCargarPares.UseVisualStyleBackColor = false;
            this.btnCargarPares.Click += new System.EventHandler(this.btnCargarPares_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargarPares);
            this.groupBox1.Controls.Add(this.lstNumeros);
            this.groupBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 497);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haciendo uso De ARRAYS con LINQ TO OBJECTS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 657);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnCargarPares;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

