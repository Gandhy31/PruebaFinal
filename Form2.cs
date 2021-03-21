using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaFinal
{
    public partial class Form2 : Form
    {
        public Trabajadores MisTrabajadores { set; get; }
        public Form2()
        {
            InitializeComponent();
            MisTrabajadores = new Trabajadores();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvTrabajadores.DataSource = MisTrabajadores.ListaTrabajador;
        }

        private void rbtnNombres_CheckedChanged(object sender, EventArgs e)
        {
            txtCadena.Visible = true;
            btnMostrar1.Visible = true;
            btnMostrar3.Visible = false;
            btnMostrar2.Visible = false;
        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            dgvBusquedas.Columns.Clear();
            dgvBusquedas.DataSource = MisTrabajadores.NombreTermina(txtCadena.Text);
        }

        private void rbtnSueldo_CheckedChanged(object sender, EventArgs e)
        {
            btnMostrar2.Visible = true;
            txtCadena.Visible = false;
            btnMostrar1.Visible = false;
            btnMostrar3.Visible = false;
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            dgvBusquedas.Columns.Clear();
            dgvBusquedas.DataSource = MisTrabajadores.MayorSueldo();
        }

        private void rbtnEdad_CheckedChanged(object sender, EventArgs e)
        {
            btnMostrar3.Visible = true;
            txtCadena.Visible = false;
            btnMostrar1.Visible = false;
            btnMostrar2.Visible = false;
        }

        private void btnMostrar3_Click(object sender, EventArgs e)
        {
            dgvBusquedas.Columns.Clear();
            dgvBusquedas.DataSource = MisTrabajadores.MayorEdad();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
