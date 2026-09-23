using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class Gema_Energia_Estandar
    {
        // Atributos
        int posicion;
        int valor_Puntos;
        bool estado; // false = no recolectada, true = recolectada

        // Constructor
        public Gema_Energia_Estandar(int posicionInicial, int puntos)
        {
            this.posicion = posicionInicial;
            this.valor_Puntos = puntos;
            this.estado = false;
        }

        // Propiedades
        public int Posicion
        {
            get => posicion;
            private set => posicion = value;
        }

        public int Valor_Puntos
        {
            get => valor_Puntos;
            private set => valor_Puntos = value;
        }

        public bool Estado
        {
            get => estado;
            private set => estado = value;
        }

        // Método para recolectar la gema
        public void Recolectar()
        {
            estado = true;
        }

        // Método para verificar si la gema fue recolectada
        public bool EstaRecolectada()
        {
            return estado;
        }

        // La gema desaparece del mapa
        public void Desaparecer()
        {
            posicion = -1;
        }
    }
}

        public bool Estadocapacidad()
        {
            if (estado > 1) // si esta es recolectada
                return true;
            else
                return false;// sino esta recolectada
        }
    }

}
