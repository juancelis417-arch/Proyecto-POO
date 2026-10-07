using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class GemasDelNucleo
    {
        protected string nombre;
        protected int posicionX;
        protected int posicionY;
        protected bool estado;
        protected int totalGemas;
        private string estado1;
        protected int P1_gemaAmarilla;
        protected int P2_gemaAzul;
        protected int P3_gemaRoja;


        public GemasDelNucleo(string nombre, int posicionX, int posicionY, int totalGemas)
        {
            this.estado = false;
            this.nombre = nombre;
            this.posicionX = posicionX;
            this.posicionY = posicionY;
            this.totalGemas = totalGemas;
            this.P1_gemaAmarilla = 1;
            this.P2_gemaAzul = 2;
            this.P3_gemaRoja = 3;
        
        }

        public GemasDelNucleo(string nombre, int posicionX, int posicionY, string estado1, int totalGemas)
        {
            this.nombre = nombre;
            this.posicionX = posicionX;
            this.posicionY = posicionY;
            this.estado1 = estado1;
            this.totalGemas = totalGemas;
        }

        public void SumarGemas(int cantidad)
        {
            totalGemas += cantidad;
        }

    }
}
