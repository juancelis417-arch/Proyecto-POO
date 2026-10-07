using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class Nucleo_Datos
    {
        int posicionX;
        int posicionY;
        int ordenGemas;
        int estado;
        string nombre;

        public Nucleo_Datos()
        {
            this.posicionX = 0;
            this.posicionY = 0;
            this.ordenGemas = 100;
        }

        public int PosicionX { get => posicionX; set => posicionX = value; }
        public int PosicionY { get => posicionY; set => posicionY = value; }
        public int OrdenGemas { get => ordenGemas; set => ordenGemas = value; }
        public int Estado1 { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void Nombredelnucleo(string NombreActual)
        {
            nombre=NombreActual;
        }

        public void posicioninicial(int NuevaX, int NuevaY)
        {
            posicionX = NuevaX;
            posicionY = NuevaY;


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
