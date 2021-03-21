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
    public partial class Form1 : Form
    {
        Trabajadores trabajadores = new Trabajadores();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Control())
            {
                Trabajador trabajador = new Trabajador();
                trabajador.Nombre = mtxtNombre.Text;
                trabajador.Cedula = mtxtCedula.Text;
                trabajador.Edad = Convert.ToInt32(mtxtEdad.Text);
                trabajador.Sueldo = Convert.ToDouble(mtxtSueldo.Text);
                trabajadores.AgregarTrabajador(trabajador);
                MessageBox.Show("Datos ingresados correctamente");
                Limpiar();
            }
            else 
            {
                MessageBox.Show("Ingrese toda la información");
            }
            
        }
        public void Limpiar()
        {
            mtxtNombre.Text="";
            mtxtCedula.Text="";
            mtxtEdad.Text = "";
            mtxtNombre.Text = "";
            mtxtSueldo.Text="";
        }
        public bool Control()
        {
            bool bandera = false;
            if (mtxtNombre.Text != "" && mtxtCedula.Text != "" && mtxtEdad.Text != "" && mtxtSueldo.Text != "")
            {
                bandera = true;
            }
            return bandera;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.MisTrabajadores = trabajadores;
            this.Hide();
        }
    }
}
