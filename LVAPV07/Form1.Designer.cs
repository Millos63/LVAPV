namespace LVAPV07
{
    partial class FrmUno
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
            this.lblFormaUno = new System.Windows.Forms.Label();
            this.btnLlamarForma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormaUno
            // 
            this.lblFormaUno.AutoSize = true;
            this.lblFormaUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaUno.ForeColor = System.Drawing.Color.Crimson;
            this.lblFormaUno.Location = new System.Drawing.Point(145, 27);
            this.lblFormaUno.Name = "lblFormaUno";
            this.lblFormaUno.Size = new System.Drawing.Size(437, 91);
            this.lblFormaUno.TabIndex = 0;
            this.lblFormaUno.Text = "Forma Uno";
            // 
            // btnLlamarForma
            // 
            this.btnLlamarForma.Location = new System.Drawing.Point(603, 317);
            this.btnLlamarForma.Name = "btnLlamarForma";
            this.btnLlamarForma.Size = new System.Drawing.Size(164, 92);
            this.btnLlamarForma.TabIndex = 1;
            this.btnLlamarForma.Text = "Llamar a forma 2";
            this.btnLlamarForma.UseVisualStyleBackColor = true;
            this.btnLlamarForma.Click += new System.EventHandler(this.btnLlamarForma_Click);
            // 
            // FrmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlamarForma);
            this.Controls.Add(this.lblFormaUno);
            this.Name = "FrmUno";
            this.Text = "FormaUno";
            this.Load += new System.EventHandler(this.Frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormaUno;
        private System.Windows.Forms.Button btnLlamarForma;
    }
}

