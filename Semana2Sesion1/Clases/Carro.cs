using System;
namespace Semana2Sesion1.Clases
{
    public class Carro
    {
        public string color;
        public string marca;
        public int anio;
        public double potencia;
        public string modelo;
        public double kmrecorrido;


        public Carro(string c, string  m, int a, double p, string mo)
        {
            color = c;
            marca = m;
            anio = a;
            potencia = p;
            modelo = mo;
            kmrecorrido = 0;
        }

        // cuando programamos un metodo
        // el objetivo es que interactue con alguna
        // caracteristica de la clase

        public void correr(double kms) {
            kmrecorrido = kmrecorrido + kms;
        }


    }
}
