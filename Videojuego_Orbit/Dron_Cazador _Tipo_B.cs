using System;

namespace Videojuego_Orbit
{
    internal class Dron_Cazador__Tipo_B : Dron
    {
        // Atributo propio del Dron Cazador
        int posicionObjeto; // Posición de ORBIT

        // Constructor
        public Dron_Cazador__Tipo_B(int posicionInicial)
            : base(posicionInicial, 20)
        {
            this.posicionObjeto = 2;
        }

        // Propiedad propia del Cazador
        public int PosicionObjeto
        {
            get => posicionObjeto;
            private set => posicionObjeto = value;
        }

        // Actualiza la posición de ORBIT
        public void calcularDireccion(int nuevaPosicionOrbit)
        {
            posicionObjeto = nuevaPosicionOrbit;
        }

        // Polimorfismo:
        // El Cazador se mueve persiguiendo a ORBIT
        public override string Mover(int posicionActual)
        {
            posicion = posicionActual;

            return "El Dron Cazador se mueve hacia ORBIT en la posición: "
                   + posicionObjeto;
        }
    }
}
