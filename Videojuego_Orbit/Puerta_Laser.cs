using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class Puerta_Laser
    {
        // Atributos
        int posicion;
        bool estado; // true = abierta, false = cerrada
        double duracionCiclo;

        // Constructor
        public Puerta_Laser(int posicionInicial, double duracion)
        {
            this.posicion = posicionInicial;
            this.estado = false;
            this.duracionCiclo = duracion;
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

        public double DuracionCiclo
        {
            get => duracionCiclo;
            private set => duracionCiclo = value;
        }

        // Abrir la puerta
        public void Abrir()
        {
            estado = true;
        }

        // Cerrar la puerta
        public void Cerrar()
        {
            estado = false;
        }

        // Cambiar automáticamente el estado de la puerta
        public void CambiarEstado()
        {
            if (estado == false)
                Abrir();
            else
                Cerrar();
        }

        // Verificar si bloquea el paso
        public bool BloquearPaso()
        {
            if (estado == false)
                return true;
            else
                return false;
        }
    }
}
