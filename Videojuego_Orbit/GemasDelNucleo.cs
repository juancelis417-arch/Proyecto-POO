using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
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

        string tipo;
        int valor;
        int orden;
        bool recolectada;
        private static int gemaActual = 1;
        private static int totalGemas = 0;


        private Portal_Salida portalAsociado;



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
            if (totalGemas >= 100)
            {
                portalAsociado.ActivarPortal(true);
                return true;
            }
            return false;
        }
    }
}
