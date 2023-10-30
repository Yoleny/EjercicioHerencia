using Ejercicio_Herencia;
using Ejercicio_Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_Herencia
{
    internal class Vertebrado : Animal
    {


        public string? tipo;
        public bool tienePatas;
        public bool esDomestico;
        public bool esHervivoro;
        public bool esCarnivoro;

        public void imprimirVertebrado()


        {
                Console.WriteLine("Tipo: " + tipo);
                Console.WriteLine("Tiene Patas: " + tienePatas);
                Console.WriteLine("Es Domestico: " + esDomestico);
                Console.WriteLine("Es Hervivoro: " + esHervivoro);
                Console.WriteLine("Es Carnivoro: " + esCarnivoro);
            
        }

    }
}
