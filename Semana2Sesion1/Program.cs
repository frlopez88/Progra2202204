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

            // Las clases sirven para representar objetos de vida real en programacion
            // se guarda informacion de objetos
            // El proceso de Guardar informacion en variables o propiedades se le llama
            // Encapsulamiento

            // Vamos a Definir un Cliente del Gym y lo Vamos a Ejercitar


            Cliente c1 = new Cliente("Claudia Sanchez", "0801",
                f, "Femenino", 120.00, 1.65);


            Console.WriteLine ("El Cliente Creado es: " +
                c1.GetNombre() +
                " Tiene un peso de " + c1.GetPeso());


            c1.correr(5);
            c1.nadar(50);

            c1.correr(5);
            c1.nadar(70);

            Console.WriteLine("El Cliente Creado es: " +
                c1.GetNombre() +
                " Tiene un peso de " + c1.GetPeso());

            Console.WriteLine("Reporte de Contadores " + c1.GetReporteContador());
        }
    }
}
