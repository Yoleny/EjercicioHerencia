using Ejercicio_Herencia;
using Ejercicio_Herncia;

Console.WriteLine("********************animales vertebrados********************");
Console.WriteLine("");
Vertebrado vertebrado = new Vertebrado();
vertebrado.nombre = "Perro";
vertebrado.color = "Blanco";
vertebrado.tamano = "Mediano";
vertebrado.familia = "Husky";
vertebrado.tipo = "Mamifero";
vertebrado.tienePatas = true;
vertebrado.esDomestico = true;
vertebrado.esHervivoro = false;
vertebrado.esCarnivoro = true;


if (vertebrado.validar())
{
    vertebrado.imprimir();
    vertebrado.imprimirVertebrado();
}
else
{
    Console.WriteLine("ingrese todos los datos");

}
Console.WriteLine("");

vertebrado.nombre = "Oso";
vertebrado.color = "Negro";
vertebrado.tamano = "Grande";
vertebrado.familia = "Salvaje";
vertebrado.tipo = "Mamifero";
vertebrado.tienePatas = true;
vertebrado.esDomestico = false;
vertebrado.esHervivoro = false;
vertebrado.esCarnivoro = true;


if (vertebrado.validar())
{
    vertebrado.imprimir();
    vertebrado.imprimirVertebrado();
}
else
{
    Console.WriteLine("ingrese todos los datos");
}
Console.WriteLine("");
Console.WriteLine("********************animales invertebrados********************");
Console.WriteLine("");

Invertebrado invertebrado = new Invertebrado();

invertebrado.nombre = "Tarantula";
invertebrado.color = "Negra";
invertebrado.tamano = "Pequeno";
invertebrado.familia = "Theraphosidae";
invertebrado.tipo = "Aracnido";
invertebrado.tienePatas = true;
invertebrado.numeroPatas = "8";
invertebrado.tieneConcha = false;


if (invertebrado.validar())
{
    invertebrado.imprimir();
    invertebrado.imprimirInvertebrado();
}
else
{
    Console.WriteLine("ingrese todos los datos");
}

Console.WriteLine("");


invertebrado.nombre = "Caracol";
invertebrado.color = "Blanco";
invertebrado.tamano = "Pequeno";
invertebrado.familia = "Helicidios";
invertebrado.tipo = "Helix pomatia";
invertebrado.tienePatas = false;
invertebrado.numeroPatas = "no tiene patas";
invertebrado.tieneConcha = true;


if (invertebrado.validar())
{
    invertebrado.imprimir();
    invertebrado.imprimirInvertebrado();
}
else
{
    Console.WriteLine("ingrese todos los datos");
}