using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFinal
{
    public class Trabajador
    {
        public string Nombre { set; get; }
        public string Cedula { set; get; }
        public int Edad { set; get; }
        public double Sueldo { set; get; }

        public Trabajador(string nombre, string cedula, int edad, double sueldo)
        {
            Nombre = nombre;
            Cedula = cedula;
            Edad = edad;
            Sueldo = sueldo;
        }

        public Trabajador()
        {
        }

    }
}
