namespace PruebaFinal
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
            this.mtxtNombre = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtEdad = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtSueldo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // mtxtNombre
            // 
            this.mtxtNombre.Location = new System.Drawing.Point(224, 88);
            this.mtxtNombre.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtNombre.Name = "mtxtNombre";
            this.mtxtNombre.Size = new System.Drawing.Size(100, 20);
            this.mtxtNombre.TabIndex = 1;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Location = new System.Drawing.Point(224, 133);
            this.mtxtCedula.Mask = "0000000000";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(100, 20);
            this.mtxtCedula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cédula:";
            // 
            // mtxtEdad
            // 
            this.mtxtEdad.Location = new System.Drawing.Point(224, 179);
            this.mtxtEdad.Mask = "00";
            this.mtxtEdad.Name = "mtxtEdad";
            this.mtxtEdad.Size = new System.Drawing.Size(100, 20);
            this.mtxtEdad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad:";
            // 
            // mtxtSueldo
            // 
            this.mtxtSueldo.Location = new System.Drawing.Point(224, 221);
            this.mtxtSueldo.Mask = "0000.##";
            this.mtxtSueldo.Name = "mtxtSueldo";
            this.mtxtSueldo.Size = new System.Drawing.Size(100, 20);
            this.mtxtSueldo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sueldo:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(161, 327);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(307, 327);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "INGRESO DE TRABAJADORES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mtxtSueldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtNombre;
        private System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtSueldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label5;
    }
}

