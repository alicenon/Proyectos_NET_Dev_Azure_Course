namespace _10LINQ_TO_SQL_PROCEDURE_OUTPUT_PLANTILLA
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
            this.lstPlantilla = new System.Windows.Forms.ListBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPlantilla
            // 
            this.lstPlantilla.FormattingEnabled = true;
            this.lstPlantilla.ItemHeight = 16;
            this.lstPlantilla.Location = new System.Drawing.Point(100, 100);
            this.lstPlantilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPlantilla.Name = "lstPlantilla";
            this.lstPlantilla.Size = new System.Drawing.Size(276, 276);
            this.lstPlantilla.TabIndex = 0;
            this.lstPlantilla.SelectedIndexChanged += new System.EventHandler(this.lstPlantilla_SelectedIndexChanged);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(686, 129);
            this.cmbTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(274, 24);
            this.cmbTurno.TabIndex = 1;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(686, 229);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(274, 22);
            this.txtMedia.TabIndex = 2;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(686, 327);
            this.txtSuma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(274, 22);
            this.txtSuma.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Media Salarial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suma Salarial\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lstPlantilla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlantilla;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

