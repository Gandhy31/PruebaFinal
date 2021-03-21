using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFinal
{
    public class Trabajadores
    {
        public List<Trabajador> ListaTrabajador { set; get; }
        public Trabajadores()
        {
            ListaTrabajador = new List<Trabajador>();
        }

        public void AgregarTrabajador(Trabajador trabajador)
        {
            ListaTrabajador.Add(trabajador);
        }

        public List<Trabajador> NombreTermina(string cadena)
        {
            List<Trabajador> auxTrabajador = new List<Trabajador>();
            foreach (Trabajador trabajador in ListaTrabajador)
            {
                if (trabajador.Nombre.EndsWith(cadena))
                {
                    auxTrabajador.Add(trabajador);
                }
            }
            return auxTrabajador;
        }
        public List<Trabajador> MayorSueldo()
        {
            List<Trabajador> auxTrabajador = new List<Trabajador>();
            double x = 0;
            foreach (Trabajador trabajador in ListaTrabajador)
            {
                if (trabajador.Sueldo > x)
                {
                    x = trabajador.Sueldo;
                }

            }
            foreach (Trabajador trabajador in ListaTrabajador)
            {
                if (trabajador.Sueldo == x)
                {
                    auxTrabajador.Add(trabajador);
                }
            }
            return auxTrabajador;
        }
        public List<Trabajador> MayorEdad()
        {
            List<Trabajador> auxTrabajador = new List<Trabajador>();
            foreach (Trabajador trabajador in ListaTrabajador)
            {
                if (trabajador.Edad > 50)
                {
                    auxTrabajador.Add(trabajador);
                }
            }
            return auxTrabajador;
        }
    }
}
