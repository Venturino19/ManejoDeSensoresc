namespace ManejoDeSensores
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
            this.lbLim = new System.Windows.Forms.Label();
            this.tbLimTemp = new System.Windows.Forms.TextBox();
            this.lbConexion = new System.Windows.Forms.Label();
            this.btConectar = new System.Windows.Forms.Button();
            this.btDesconectar = new System.Windows.Forms.Button();
            this.lbTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLim
            // 
            this.lbLim.AutoSize = true;
            this.lbLim.Location = new System.Drawing.Point(184, 169);
            this.lbLim.Name = "lbLim";
            this.lbLim.Size = new System.Drawing.Size(108, 13);
            this.lbLim.TabIndex = 0;
            this.lbLim.Text = "Limite de temperatura";
            // 
            // tbLimTemp
            // 
            this.tbLimTemp.Location = new System.Drawing.Point(336, 166);
            this.tbLimTemp.Name = "tbLimTemp";
            this.tbLimTemp.Size = new System.Drawing.Size(159, 20);
            this.tbLimTemp.TabIndex = 1;
            // 
            // lbConexion
            // 
            this.lbConexion.AutoSize = true;
            this.lbConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConexion.ForeColor = System.Drawing.Color.Red;
            this.lbConexion.Location = new System.Drawing.Point(507, 272);
            this.lbConexion.Name = "lbConexion";
            this.lbConexion.Size = new System.Drawing.Size(96, 13);
            this.lbConexion.TabIndex = 2;
            this.lbConexion.Text = "SIN CONEXIÓN";
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(214, 356);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(78, 28);
            this.btConectar.TabIndex = 3;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            // 
            // btDesconectar
            // 
            this.btDesconectar.Location = new System.Drawing.Point(541, 356);
            this.btDesconectar.Name = "btDesconectar";
            this.btDesconectar.Size = new System.Drawing.Size(78, 28);
            this.btDesconectar.TabIndex = 4;
            this.btDesconectar.Text = "Desconectar";
            this.btDesconectar.UseVisualStyleBackColor = true;
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.Location = new System.Drawing.Point(334, 237);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(125, 73);
            this.lbTemp.TabIndex = 5;
            this.lbTemp.Text = "0.0";
            this.lbTemp.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.btDesconectar);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.lbConexion);
            this.Controls.Add(this.tbLimTemp);
            this.Controls.Add(this.lbLim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLim;
        private System.Windows.Forms.TextBox tbLimTemp;
        private System.Windows.Forms.Label lbConexion;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button btDesconectar;
        private System.Windows.Forms.Label lbTemp;
    }
}

