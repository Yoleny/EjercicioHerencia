using Ejercicio_Herencia;

Animal animal = new Animal();
animal.nombre = "Perro";
animal.color = "Blanco";
animal.tamano = "Mediano";
animal.familia = "Husky";


if (animal.validar())
{
    animal.imprimir();
}
else
{
    Console.WriteLine("ingrese todos los datos");
}
