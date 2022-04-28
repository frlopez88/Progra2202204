using System;
namespace Semana2Sesion1.Clases
{
    public class Persona
    {
        public string nombre;
        public DateTime fechaNacimiento;
        public double peso;

        public Persona( string n, DateTime fecha, double p ) // Constructor
        {
            // Metodo Constructor da nacimiento al objeto
            nombre = n;
            fechaNacimiento = fecha;
            peso = p;
        }

        // Definiendo un metodo que es correr
        public void correr() {
            peso = peso - 1;
        }

        public void comer()
        {
            peso = peso + 1;
        }

    }
}
