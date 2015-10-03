namespace dado_con_random
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTO_JUGAR = new System.Windows.Forms.Button();
            this.LBL_PUNTAJE = new System.Windows.Forms.Label();
            this.LBL_DADO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTO_JUGAR
            // 
            this.BTO_JUGAR.Location = new System.Drawing.Point(98, 175);
            this.BTO_JUGAR.Name = "BTO_JUGAR";
            this.BTO_JUGAR.Size = new System.Drawing.Size(89, 38);
            this.BTO_JUGAR.TabIndex = 0;
            this.BTO_JUGAR.Text = "JUGAR";
            this.BTO_JUGAR.UseVisualStyleBackColor = true;
            this.BTO_JUGAR.Click += new System.EventHandler(this.BTO_JUGAR_Click);
            // 
            // LBL_PUNTAJE
            // 
            this.LBL_PUNTAJE.AutoSize = true;
            this.LBL_PUNTAJE.Location = new System.Drawing.Point(48, 113);
            this.LBL_PUNTAJE.Name = "LBL_PUNTAJE";
            this.LBL_PUNTAJE.Size = new System.Drawing.Size(65, 13);
            this.LBL_PUNTAJE.TabIndex = 1;
            this.LBL_PUNTAJE.Text = "PUNTAJE  :";
            // 
            // LBL_DADO
            // 
            this.LBL_DADO.AutoSize = true;
            this.LBL_DADO.Location = new System.Drawing.Point(153, 113);
            this.LBL_DADO.Name = "LBL_DADO";
            this.LBL_DADO.Size = new System.Drawing.Size(16, 13);
            this.LBL_DADO.TabIndex = 2;
            this.LBL_DADO.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LBL_DADO);
            this.Controls.Add(this.LBL_PUNTAJE);
            this.Controls.Add(this.BTO_JUGAR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTO_JUGAR;
        private System.Windows.Forms.Label LBL_PUNTAJE;
        private System.Windows.Forms.Label LBL_DADO;
    }
}

