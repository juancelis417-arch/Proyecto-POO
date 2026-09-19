using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class Gema_Energia_Estandar
    {
        int posicion;
        int valor_Puntos;
        int estado; // true = si esta recolectado, false = no esta recolectada


        public int Posicion { get => posicion; private set => posicion = value; }
        public int Valor_Puntos { get => valor_Puntos; private set => valor_Puntos = value; }
        public int Estado { get => estado; private set => estado = value; }

        public Gema_Energia_Estandar(int puntos)
        {
            this.posicion = 0;
            this.valor_Puntos = puntos;
            this.estado = 50;
        }

        public void mover(int posicionactual)
        {
            posicion = posicionactual;
        }

        public void aumentarestado(int cantidad)
        {
          
            estado += cantidad; // para aumentar si esta recolectada  
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
