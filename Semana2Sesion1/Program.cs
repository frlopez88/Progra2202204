using System;
using Semana2Sesion1.Clases;

namespace Semana2Sesion1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime f = new DateTime(1985, 2, 5);
            Persona x = new Persona( "Cristiano Ronaldo", f, 180);

            x.comer();
            x.comer();
            x.comer();
            x.comer();
            x.comer();

            Console.WriteLine("El peso de "+ x.nombre + " es :"+ x.peso);

            Carro x1 = new Carro("Rojo", "Toyota", 2000, 1.8, "Turismo");

            x1.correr(10);
            x1.correr(100);
            x1.correr(500);

            Console.WriteLine("El Kilometraje del carro es: " + x1.kmrecorrido);
            Console.WriteLine("El Kilometraje del carro es: " + x1.kmrecorrido);
            Console.WriteLine("El Kilometraje del carro es: " + x1.kmrecorrido);
            Console.WriteLine("El Kilometraje del carro es: " + x1.kmrecorrido);

        }
    }
}
