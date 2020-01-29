namespace miprimerproyecto
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
            this.btnprocesar = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.grboperaciones = new System.Windows.Forms.GroupBox();
            this.optsuma = new System.Windows.Forms.RadioButton();
            this.optresta = new System.Windows.Forms.RadioButton();
            this.optmulti = new System.Windows.Forms.RadioButton();
            this.optdivi = new System.Windows.Forms.RadioButton();
            this.grboperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnprocesar
            // 
            this.btnprocesar.BackColor = System.Drawing.Color.Bisque;
            this.btnprocesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocesar.Location = new System.Drawing.Point(146, 133);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(75, 36);
            this.btnprocesar.TabIndex = 0;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = false;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(57, 18);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(54, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(167, 18);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(54, 20);
            this.txtnum2.TabIndex = 2;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(8, 21);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(47, 13);
            this.lblnum1.TabIndex = 3;
            this.lblnum1.Text = "Num: 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(118, 21);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(47, 13);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "Num: 2";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.Location = new System.Drawing.Point(70, 61);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(82, 13);
            this.lblrespuesta.TabIndex = 5;
            this.lblrespuesta.Text = "Respuesta: ?";
            // 
            // grboperaciones
            // 
            this.grboperaciones.Controls.Add(this.optdivi);
            this.grboperaciones.Controls.Add(this.optmulti);
            this.grboperaciones.Controls.Add(this.optresta);
            this.grboperaciones.Controls.Add(this.optsuma);
            this.grboperaciones.Location = new System.Drawing.Point(12, 105);
            this.grboperaciones.Name = "grboperaciones";
            this.grboperaciones.Size = new System.Drawing.Size(108, 100);
            this.grboperaciones.TabIndex = 6;
            this.grboperaciones.TabStop = false;
            this.grboperaciones.Text = "Operaciones";
            // 
            // optsuma
            // 
            this.optsuma.AutoSize = true;
            this.optsuma.Checked = true;
            this.optsuma.Location = new System.Drawing.Point(7, 17);
            this.optsuma.Name = "optsuma";
            this.optsuma.Size = new System.Drawing.Size(52, 17);
            this.optsuma.TabIndex = 0;
            this.optsuma.TabStop = true;
            this.optsuma.Text = "Suma";
            this.optsuma.UseVisualStyleBackColor = true;
            // 
            // optresta
            // 
            this.optresta.AutoSize = true;
            this.optresta.Location = new System.Drawing.Point(7, 38);
            this.optresta.Name = "optresta";
            this.optresta.Size = new System.Drawing.Size(53, 17);
            this.optresta.TabIndex = 1;
            this.optresta.Text = "Resta";
            this.optresta.UseVisualStyleBackColor = true;
            // 
            // optmulti
            // 
            this.optmulti.AutoSize = true;
            this.optmulti.Location = new System.Drawing.Point(7, 59);
            this.optmulti.Name = "optmulti";
            this.optmulti.Size = new System.Drawing.Size(89, 17);
            this.optmulti.TabIndex = 2;
            this.optmulti.Text = "Multiplicación";
            this.optmulti.UseVisualStyleBackColor = true;
            // 
            // optdivi
            // 
            this.optdivi.AutoSize = true;
            this.optdivi.Location = new System.Drawing.Point(7, 79);
            this.optdivi.Name = "optdivi";
            this.optdivi.Size = new System.Drawing.Size(63, 17);
            this.optdivi.TabIndex = 3;
            this.optdivi.Text = "Divición";
            this.optdivi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(263, 229);
            this.Controls.Add(this.grboperaciones);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btnprocesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grboperaciones.ResumeLayout(false);
            this.grboperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.GroupBox grboperaciones;
        private System.Windows.Forms.RadioButton optdivi;
        private System.Windows.Forms.RadioButton optmulti;
        private System.Windows.Forms.RadioButton optresta;
        private System.Windows.Forms.RadioButton optsuma;
    }
}

