using System;
namespace Semana2Sesion1.Clases
{
    public class Carro
    {
        private string color;
        private string marca;
        private int anio;
        private double potencia;
        private string modelo;
        private double kmrecorrido;
        private double galones;
        private double contador_kms_galones;


        public Carro(string col, string  mar, int year, double pot, string mod)
        {
            color = col;
            marca = mar;
            anio = year;
            potencia = pot;
            modelo = mod;
            kmrecorrido = 0;
        }

        // cuando programamos un metodo
        // el objetivo es que interactue con alguna
        // caracteristica de la clase

        public void correr(double kms) {
            kmrecorrido = kmrecorrido + kms;

            // algoritmo para reducir consumo de gas
            contador_kms_galones = contador_kms_galones + kms;
            if (contador_kms_galones >= 35) {

                contador_kms_galones = 0;
                galones = galones - 1;

            }


        }

        public void llenarTanque(double galones_a_llenar) {

            galones = galones + galones_a_llenar;

        }

        public string ReporteDeUso() {

            return "El Carro ha recorrido un total de kms: " +
                kmrecorrido +
                " El Tanque de Gasolina tiene:" + galones;
        }

    }
}
