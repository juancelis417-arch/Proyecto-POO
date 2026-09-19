using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class Nucleo_Datos
    {
        int posicion;
        int numeroOrden;
        int estado; 

        public Nucleo_Datos(int posicioninicial, int orden)
        {
            this.posicion = posicioninicial;
            this.numeroOrden = orden; // no se sabe el nuemmro de la orden que indica en el taller 
            this.estado = 50;
        }

        public int Posicion { get => posicion; private set => posicion = value; }
        public int NumeroOrden { get => numeroOrden; private set => numeroOrden = value; }
        public int Estado { get => estado; private set => estado = value; }

        public void posicioninicial(int posicioninicial)
        {
            posicion = posicioninicial;
        }
         
        public void numeroorden()
        {
            NumeroOrden = 0; // preguntar
        }

        public void aumentarestado(int cantidad)
        {
            estado += cantidad;
        }

        public bool Estadodecapacidad()
        {
            if (estado < 100) 
                return true; // Esta recolectada
            else
                return false; // Esta pendiente por ser recolectada 
        }
    }
}
