using System;
namespace Semana2Sesion1.Clases
{
    public class Cliente
    {
        private string nombre;
        private string identidad;
        private DateTime fecha_nacimiento;
        private string genero;
        private double peso;
        private double altura;
        private int contadorMinNado;
        private int contadorKmRecorrido;
        private int contadorMnPesas;

        public Cliente(string nm, string id, DateTime fecha, string gn,
            double ps, double alt)
        {

            nombre = nm;
            identidad = id;
            fecha_nacimiento = fecha;
            genero = gn;
            peso = ps;
            altura = alt;
            contadorMinNado = 0;
            contadorKmRecorrido = 0;
            contadorMnPesas = 0;
        }

        public void nadar(int min) {

            contadorMinNado = contadorMinNado + min;

            if (contadorMinNado >= 100) {
                peso = peso - 1;
                contadorMinNado = contadorMinNado - 100;
            }

        }

        public void correr(int km) {

            contadorKmRecorrido = contadorKmRecorrido + km;


            if (contadorKmRecorrido >= 20) {

                peso = peso - 1;

                contadorKmRecorrido = contadorKmRecorrido - 20;
            }

        }

        public void pesas (int min)
        {

            contadorMnPesas = contadorMnPesas + min;

            if (contadorMnPesas >= 100)
            {
                peso = peso + 0.5;
                contadorMnPesas = contadorMnPesas - 100;

            }

        }

        public string GetNombre() {

            return nombre;

        }

    }
}
