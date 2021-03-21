namespace PruebaFinal
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.rbtnSueldo = new System.Windows.Forms.RadioButton();
            this.rbtnNombres = new System.Windows.Forms.RadioButton();
            this.rbtnEdad = new System.Windows.Forms.RadioButton();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnMostrar1 = new System.Windows.Forms.Button();
            this.btnMostrar2 = new System.Windows.Forms.Button();
            this.btnMostrar3 = new System.Windows.Forms.Button();
            this.dgvBusquedas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(62, 28);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvTrabajadores
            // 
            this.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadores.Location = new System.Drawing.Point(62, 66);
            this.dgvTrabajadores.Name = "dgvTrabajadores";
            this.dgvTrabajadores.Size = new System.Drawing.Size(434, 150);
            this.dgvTrabajadores.TabIndex = 1;
            // 
            // rbtnSueldo
            // 
            this.rbtnSueldo.AutoSize = true;
            this.rbtnSueldo.Location = new System.Drawing.Point(375, 250);
            this.rbtnSueldo.Name = "rbtnSueldo";
            this.rbtnSueldo.Size = new System.Drawing.Size(162, 17);
            this.rbtnSueldo.TabIndex = 2;
            this.rbtnSueldo.TabStop = true;
            this.rbtnSueldo.Text = "Trabajador con mayor sueldo";
            this.rbtnSueldo.UseVisualStyleBackColor = true;
            this.rbtnSueldo.CheckedChanged += new System.EventHandler(this.rbtnSueldo_CheckedChanged);
            // 
            // rbtnNombres
            // 
            this.rbtnNombres.AutoSize = true;
            this.rbtnNombres.Location = new System.Drawing.Point(62, 250);
            this.rbtnNombres.Name = "rbtnNombres";
            this.rbtnNombres.Size = new System.Drawing.Size(232, 17);
            this.rbtnNombres.TabIndex = 3;
            this.rbtnNombres.TabStop = true;
            this.rbtnNombres.Text = "Trabajadores que terminan con una cadena";
            this.rbtnNombres.UseVisualStyleBackColor = true;
            this.rbtnNombres.CheckedChanged += new System.EventHandler(this.rbtnNombres_CheckedChanged);
            // 
            // rbtnEdad
            // 
            this.rbtnEdad.AutoSize = true;
            this.rbtnEdad.Location = new System.Drawing.Point(609, 250);
            this.rbtnEdad.Name = "rbtnEdad";
            this.rbtnEdad.Size = new System.Drawing.Size(216, 17);
            this.rbtnEdad.TabIndex = 4;
            this.rbtnEdad.TabStop = true;
            this.rbtnEdad.Text = "Trabajadores con edad mayor a 50 años";
            this.rbtnEdad.UseVisualStyleBackColor = true;
            this.rbtnEdad.CheckedChanged += new System.EventHandler(this.rbtnEdad_CheckedChanged);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(62, 276);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 20);
            this.txtCadena.TabIndex = 5;
            this.txtCadena.Visible = false;
            // 
            // btnMostrar1
            // 
            this.btnMostrar1.Location = new System.Drawing.Point(62, 302);
            this.btnMostrar1.Name = "btnMostrar1";
            this.btnMostrar1.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar1.TabIndex = 6;
            this.btnMostrar1.Text = "Mostrar";
            this.btnMostrar1.UseVisualStyleBackColor = true;
            this.btnMostrar1.Visible = false;
            this.btnMostrar1.Click += new System.EventHandler(this.btnMostrar1_Click);
            // 
            // btnMostrar2
            // 
            this.btnMostrar2.Location = new System.Drawing.Point(387, 273);
            this.btnMostrar2.Name = "btnMostrar2";
            this.btnMostrar2.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar2.TabIndex = 7;
            this.btnMostrar2.Text = "Mostrar";
            this.btnMostrar2.UseVisualStyleBackColor = true;
            this.btnMostrar2.Visible = false;
            this.btnMostrar2.Click += new System.EventHandler(this.btnMostrar2_Click);
            // 
            // btnMostrar3
            // 
            this.btnMostrar3.Location = new System.Drawing.Point(609, 273);
            this.btnMostrar3.Name = "btnMostrar3";
            this.btnMostrar3.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar3.TabIndex = 8;
            this.btnMostrar3.Text = "Mostrar";
            this.btnMostrar3.UseVisualStyleBackColor = true;
            this.btnMostrar3.Visible = false;
            this.btnMostrar3.Click += new System.EventHandler(this.btnMostrar3_Click);
            // 
            // dgvBusquedas
            // 
            this.dgvBusquedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedas.Location = new System.Drawing.Point(62, 364);
            this.dgvBusquedas.Name = "dgvBusquedas";
            this.dgvBusquedas.Size = new System.Drawing.Size(434, 150);
            this.dgvBusquedas.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(579, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 31);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 542);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvBusquedas);
            this.Controls.Add(this.btnMostrar3);
            this.Controls.Add(this.btnMostrar2);
            this.Controls.Add(this.btnMostrar1);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.rbtnEdad);
            this.Controls.Add(this.rbtnNombres);
            this.Controls.Add(this.rbtnSueldo);
            this.Controls.Add(this.dgvTrabajadores);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvTrabajadores;
        private System.Windows.Forms.RadioButton rbtnSueldo;
        private System.Windows.Forms.RadioButton rbtnNombres;
        private System.Windows.Forms.RadioButton rbtnEdad;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnMostrar1;
        private System.Windows.Forms.Button btnMostrar2;
        private System.Windows.Forms.Button btnMostrar3;
        private System.Windows.Forms.DataGridView dgvBusquedas;
        private System.Windows.Forms.Button btnSalir;
    }
}