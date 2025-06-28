namespace RangoPrimosApp
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.btnBuscarPrimos = new System.Windows.Forms.Button();
            this.lstPrimos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(12, 21);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(82, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Inicio del rango:";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(101, 21);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 1;
            this.txtInicio.Text = "1";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(15, 59);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(71, 13);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "Fin del rango:";
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(101, 51);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(100, 20);
            this.txtFin.TabIndex = 3;
            this.txtFin.Text = "100";
            // 
            // btnBuscarPrimos
            // 
            this.btnBuscarPrimos.Location = new System.Drawing.Point(101, 77);
            this.btnBuscarPrimos.Name = "btnBuscarPrimos";
            this.btnBuscarPrimos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPrimos.TabIndex = 4;
            this.btnBuscarPrimos.Text = "Buscar Números Primos";
            this.btnBuscarPrimos.UseVisualStyleBackColor = true;
            this.btnBuscarPrimos.Click += new System.EventHandler(this.btnBuscarPrimos_Click);
            // 
            // lstPrimos
            // 
            this.lstPrimos.FormattingEnabled = true;
            this.lstPrimos.Location = new System.Drawing.Point(101, 106);
            this.lstPrimos.Name = "lstPrimos";
            this.lstPrimos.ScrollAlwaysVisible = true;
            this.lstPrimos.Size = new System.Drawing.Size(122, 121);
            this.lstPrimos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 237);
            this.Controls.Add(this.lstPrimos);
            this.Controls.Add(this.btnBuscarPrimos);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.lblInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Button btnBuscarPrimos;
        private System.Windows.Forms.ListBox lstPrimos;
    }
}

