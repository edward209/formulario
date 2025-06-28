namespace NumeroPerfectoApp
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
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(12, 32);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(98, 13);
            this.lblInstruccion.TabIndex = 0;
            this.lblInstruccion.Text = "Ingresa un número:";
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(117, 32);
            this.mtxtNumero.Mask = "#########";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(100, 20);
            this.mtxtNumero.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(223, 32);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar Perfecto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 130);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.mtxtNumero);
            this.Controls.Add(this.lblInstruccion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.Button btnVerificar;
    }
}

