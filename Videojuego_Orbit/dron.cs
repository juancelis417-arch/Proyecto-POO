using System;

namespace Videojuego_Orbit
{
    internal abstract class Dron
    {
        // Atributos comunes de los drones
        protected int posicion;
        protected int velocidad;
        protected int estado;

        // Constructor
        public Dron(int posicionInicial, int velocidadInicial)
        {
            posicion = posicionInicial;
            velocidad = velocidadInicial;
            estado = 50;
        }

        // Propiedades
        public int Posicion
        {
            get => posicion;
            protected set => posicion = value;
        }

        public int Velocidad
        {
            get => velocidad;
            protected set => velocidad = value;
        }

        public int Estado
        {
            get => estado;
            protected set => estado = value;
        }

        // Método que comparten los drones
        public void VelocidadBaja(int nuevaVelocidad)
        {
            velocidad = nuevaVelocidad;
        }

        // Verifica si el dron está activo
        public bool EstadoCapacidad()
        {
            if (estado > 1)
                return true;
            else
                return false;
        }

        // Cada tipo de dron se mueve de forma diferente
        public abstract string Mover(int posicionActual);
    }
}
