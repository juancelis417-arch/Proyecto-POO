using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class Portal_Salida
    {
        // Atributos
        protected   int posicion;
        protected bool estado; // true = abierto, false = cerrado

        // Constructor
        public Portal_Salida(int posicionInicial)
        {
            this.posicion = posicionInicial;
            this.estado = false;
        }

        public Portal_Salida()
        {
        }



        // Propiedades
        public int Posicion
        {
            get => posicion;
            private set => posicion = value;
        }

        public bool Estado
        {
            get => estado;
            protected set => estado = value;
        }

        // Verificar si se puede activar el portal
        protected bool ActivarPortal(bool nucleosCompletados)
        {
            if (nucleosCompletados == true)
            {
                estado = true;
            }

            return estado;
        }

        // Verificar si ORBIT puede salir
        public bool PuedeSalir()
        {
            return estado;
        }
    }
}
