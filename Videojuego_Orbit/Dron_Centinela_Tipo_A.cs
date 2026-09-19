using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class Dron_Centinela_Tipo_A
    {
        int posicion;
        string rutaPatrulla;
        int velocidad;
        int estado;
    
        public Dron_Centinela_Tipo_A()
        {
            this.posicion = 1;
            this.rutaPatrulla = "Sin Asingnar"; // no sabemos la ruta de la patrulla
            this.velocidad = 20;
            this.estado = 50;
        }

        public int Posicion { get => posicion; private set => posicion = value; }
        public string RutaPatrulla { get => rutaPatrulla; private set => rutaPatrulla = value; }
        public int Velocidad { get => velocidad; private set => velocidad = value; }
        public int Estado { get => estado; private set => estado = value; }


        public void mover(int posicionactual)
        {
            posicion = posicionactual;
        }

        public void AsignarRuta(string ruta)
        {
            rutaPatrulla = ruta;
        }

        public void velocidadbaja(int nuevaVelocidad)
        {
            velocidad = nuevaVelocidad;
        }


        public bool Estadocapacidad()
        {
            if (estado > 1) // si esta activo, aumenta 
                return true;
            else
                return false;// sino esta desactivado, no esta recogida
        }

    }
}
