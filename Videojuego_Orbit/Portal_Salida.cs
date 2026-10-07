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
        int posicion;
        bool estado; // true = abierto, false = cerrado

        // Constructor
        public Portal_Salida(int posicionInicial)
        {
            this.posicion = posicionInicial;
            this.estado = false;
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
            private set => estado = value;
        }

        // Verificar si se puede activar el portal
        public bool ActivarPortal(bool nucleosCompletados)
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
