using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VideoJuego_Orbit;

//Clase de Juan

namespace Videojuego_Orbit
{
    internal class GemasDelNucleo
    {
        protected string nombre;
        protected int posicionX;
        protected int posicionY;
        public int tiempocelula;
        public int segundos;

        string tipo;
        int valor;
        int orden;
        bool recolectada;
        private static int gemaActual = 1;
        private static int totalGemas = 0;


        private Portal_Salida portalAsociado;

        private Orbit jugador;



        public GemasDelNucleo(string nombre, int posicionX, int posicionY, string Tipo, int Orden, int Valor, Portal_Salida Portal)
        {
            this.nombre = nombre;
            this.posicionX = posicionX;
            this.posicionY = posicionY;


            this.tipo = Tipo;
            this.orden = Orden;
            this.valor = Valor;
            this.recolectada = false;
            this.portalAsociado = Portal;
  



        }



        public GemasDelNucleo(string tipo, int orden, int valor, int posicionX, int posicionY, Orbit jugador)

        {
            this.tipo = tipo;
            this.orden = orden;
            this.valor = valor;
            this.posicionX = posicionX;
            this.posicionY = posicionY;
            this.jugador = jugador;
        }

        public GemasDelNucleo()
        {
        }

        public bool Recoleccion()
        {
            if (orden == gemaActual && !recolectada)
            {
                recolectada = true;
                SumarGemas(valor);
                gemaActual++;

                return true;
            }

            return false;
        }












        public void SumarGemas(int cantidad)
        {
            totalGemas += cantidad;
        }

        public bool AbrirPortal()
        {
            if (totalGemas >= 100 && portalAsociado !=null)
            {
                portalAsociado.ActivarPortal(true);
                return true;
            }
            return false;
        }





        public void IniciarTiempo()
        {
            tiempocelula = 10;

        }
        public void SegundosCelula()
        {
            int fila = Console.CursorTop;
            while (tiempocelula >= 0)
            {

                segundos = tiempocelula % 10;


                //Otra opcion era console clear.

                Console.SetCursorPosition(0, fila);
                Console.WriteLine($"Tiempo restanten de la celula: {segundos:D1}");
                tiempocelula--;
                Thread.Sleep(1000);
            }
        }
    }
}
