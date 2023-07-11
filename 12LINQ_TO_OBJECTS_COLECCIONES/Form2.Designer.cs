namespace _12LINQ_TO_OBJECTS_COLECCIONES
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarPeliculas = new System.Windows.Forms.Button();
            this.lstPeliculas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrarPeliculas);
            this.groupBox1.Controls.Add(this.lstPeliculas);
            this.groupBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Location = new System.Drawing.Point(238, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 497);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haciendo uso De ARRAYS con LINQ TO OBJECTS";
            // 
            // btnMostrarPeliculas
            // 
            this.btnMostrarPeliculas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrarPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarPeliculas.ForeColor = System.Drawing.Color.White;
            this.btnMostrarPeliculas.Location = new System.Drawing.Point(440, 32);
            this.btnMostrarPeliculas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMostrarPeliculas.Name = "btnMostrarPeliculas";
            this.btnMostrarPeliculas.Size = new System.Drawing.Size(220, 85);
            this.btnMostrarPeliculas.TabIndex = 15;
            this.btnMostrarPeliculas.Text = "MOSTRAR PELICULAS";
            this.btnMostrarPeliculas.UseVisualStyleBackColor = false;
            this.btnMostrarPeliculas.Click += new System.EventHandler(this.btnMostrarPeliculas_Click);
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.FormattingEnabled = true;
            this.lstPeliculas.ItemHeight = 16;
            this.lstPeliculas.Location = new System.Drawing.Point(68, 136);
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(592, 324);
            this.lstPeliculas.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarPeliculas;
        private System.Windows.Forms.ListBox lstPeliculas;
    }
}