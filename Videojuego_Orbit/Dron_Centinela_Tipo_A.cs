using System;

namespace Videojuego_Orbit
{
    internal class Dron_Centinela_Tipo_A : Dron
    {
        // Atributo propio del Centinela
        string rutaPatrulla;

        // Constructor
        public Dron_Centinela_Tipo_A()
            : base(1, 20)
        {
            rutaPatrulla = "Sin Asignar";
        }

        // Propiedad
        public string RutaPatrulla
        {
            get => rutaPatrulla;
            private set => rutaPatrulla = value;
        }

        // Asignar la ruta que va a patrullar
        public void AsignarRuta(string ruta)
        {
            rutaPatrulla = ruta;
        }

        // Polimorfismo:
        // El Centinela se mueve patrullando una ruta fija
        public override string Mover(int posicionActual)
        {
            posicion = posicionActual;

            return "El Dron Centinela se mueve por la ruta: "
                   + rutaPatrulla;
        }
    }
}
    

