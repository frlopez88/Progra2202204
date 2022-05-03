using System;
using System.Collections.Generic;
using Semana2Sesion1.Clases;

namespace Semana2Sesion1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Problema de Clientes
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
            */

            // Problema de Autos

            Carro carro1 = new Carro("Rojo", "Toyota", 2015,1.8,"Corolla");

            carro1.llenarTanque(9);
            carro1.correr(15);
            carro1.correr(20);
            carro1.correr(10);

            List<Carro> l = new List<Carro>();

            l.Add(carro1);

            l.Add(new Carro("Azul", "Honda", 2018, 1.8, "Civic" ));
            l.Add(new Carro("Verde", "Toyota", 2020, 2.2, "RAV 4" ));


            l.ForEach(delegate (Carro x)
            {
                x.llenarTanque(10);
                x.correr(35);

            });

            l.ForEach(delegate (Carro x)
            {
                x.correr(35);

            });

            l.ForEach(delegate (Carro x)
            {
                Console.WriteLine(x.ReporteDeUso());


            });



        }
    }
}
