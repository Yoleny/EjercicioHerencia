using Ejercicio_Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herncia
{
    internal class Invertebrado : Animal
    {



        public string? tipo;
        public bool tienePatas;
        public string? numeroPatas;
        public bool tieneConcha;
       

        public void imprimirInvertebrado()


        {
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Tiene Patas: " + tienePatas);
            Console.WriteLine("numero de Patas: " + numeroPatas);
            Console.WriteLine("Tiene Concha: " + tieneConcha);
        }
    }
}
