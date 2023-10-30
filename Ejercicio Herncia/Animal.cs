using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
     public class Animal
    {
        public string? nombre;
        public string? color;
        public string? tamano;
        public string? familia;

        /* Metodo para imprimir datos*/

        public void imprimir()

        {
            if (validar())
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Nombre: " + color);
                Console.WriteLine("Nombre: " + tamano);
                Console.WriteLine("Nombre: " + familia);
            }
        }


        public bool validar()
        {
            if (nombre != null && color != null && tamano != null && familia != null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
