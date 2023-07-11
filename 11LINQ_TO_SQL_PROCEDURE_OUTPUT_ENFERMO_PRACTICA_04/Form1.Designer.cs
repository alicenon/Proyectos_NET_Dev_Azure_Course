namespace _11LINQ_TO_SQL_PROCEDURE_OUTPUT_ENFERMO_PRACTICA_04
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNSS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO DE LA SEGURIDAD SOCIAL";
            // 
            // txtNSS
            // 
            this.txtNSS.Location = new System.Drawing.Point(226, 128);
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Size = new System.Drawing.Size(297, 24);
            this.txtNSS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEXO";
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerDatos.ForeColor = System.Drawing.Color.White;
            this.btnVerDatos.Location = new System.Drawing.Point(684, 67);
            this.btnVerDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(220, 85);
            this.btnVerDatos.TabIndex = 14;
            this.btnVerDatos.Text = "VER DATOS";
            this.btnVerDatos.UseVisualStyleBackColor = false;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(364, 255);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(281, 18);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "***************************************";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(364, 333);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(281, 18);
            this.lblSexo.TabIndex = 16;
            this.lblSexo.Text = "***************************************";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNSS);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNSS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSexo;
    }
}

