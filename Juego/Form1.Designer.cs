namespace Juego
{
    partial class frmJuego
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
            this.components = new System.ComponentModel.Container();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.trcVelocidad = new System.Windows.Forms.TrackBar();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.pctEnemy = new System.Windows.Forms.PictureBox();
            this.nudVelocidadPlayer = new System.Windows.Forms.NumericUpDown();
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).BeginInit();
            this.grpLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocidadPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(998, 649);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 1;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(1160, 649);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 2;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(1079, 620);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 3;
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(1079, 649);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 4;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.button2_Click);
            // 
            // trcVelocidad
            // 
            this.trcVelocidad.Location = new System.Drawing.Point(1000, 530);
            this.trcVelocidad.Name = "trcVelocidad";
            this.trcVelocidad.Size = new System.Drawing.Size(237, 56);
            this.trcVelocidad.TabIndex = 7;
            this.trcVelocidad.Scroll += new System.EventHandler(this.tcrVelocidad_Scroll);
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.pctPlayer);
            this.grpLevel.Controls.Add(this.pctEnemy);
            this.grpLevel.Location = new System.Drawing.Point(5, 5);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(968, 682);
            this.grpLevel.TabIndex = 9;
            this.grpLevel.TabStop = false;
            this.grpLevel.Enter += new System.EventHandler(this.grpLevel_Enter);
            // 
            // pctPlayer
            // 
            this.pctPlayer.Image = global::Juego.Properties.Resources.Zelda;
            this.pctPlayer.Location = new System.Drawing.Point(157, 55);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(119, 126);
            this.pctPlayer.TabIndex = 0;
            this.pctPlayer.TabStop = false;
            this.pctPlayer.Click += new System.EventHandler(this.pctPlayer_Click);
            // 
            // pctEnemy
            // 
            this.pctEnemy.Image = global::Juego.Properties.Resources.Planta_carnivora;
            this.pctEnemy.Location = new System.Drawing.Point(354, 461);
            this.pctEnemy.Name = "pctEnemy";
            this.pctEnemy.Size = new System.Drawing.Size(151, 163);
            this.pctEnemy.TabIndex = 8;
            this.pctEnemy.TabStop = false;
            // 
            // nudVelocidadPlayer
            // 
            this.nudVelocidadPlayer.Location = new System.Drawing.Point(1117, 592);
            this.nudVelocidadPlayer.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudVelocidadPlayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVelocidadPlayer.Name = "nudVelocidadPlayer";
            this.nudVelocidadPlayer.Size = new System.Drawing.Size(120, 22);
            this.nudVelocidadPlayer.TabIndex = 5;
            this.nudVelocidadPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVelocidadPlayer.ValueChanged += new System.EventHandler(this.nudIncrementoPlayer_ValueChanged);
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Enabled = true;
            this.tmrPlayer.Interval = 500;
            this.tmrPlayer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Enabled = true;
            this.tmrEnemy.Interval = 300;
            this.tmrEnemy.Tick += new System.EventHandler(this.tmrEnemy_Tick);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 716);
            this.Controls.Add(this.grpLevel);
            this.Controls.Add(this.trcVelocidad);
            this.Controls.Add(this.nudVelocidadPlayer);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.KeyPreview = true;
            this.Name = "frmJuego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmJuego_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).EndInit();
            this.grpLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocidadPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPlayer;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TrackBar trcVelocidad;
        private System.Windows.Forms.PictureBox pctEnemy;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.NumericUpDown nudVelocidadPlayer;
        private System.Windows.Forms.Timer tmrPlayer;
        private System.Windows.Forms.Timer tmrEnemy;
    }
}

