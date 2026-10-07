using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class GemaRojaDelNucleo : GemasDelNucleo
    {
        int GemaRoja;
        public GemaRojaDelNucleo(string nombre, int posicionX, int posicionY, int totalGemas) : base(nombre, posicionX, posicionY, totalGemas)
        {

        }

        public bool Recolectar(int gemaRoja )
        {
            if (GemaRoja == P3_gemaRoja)
            {
                totalGemas += gemaRoja;
                return true;

            }

            else return false;
        }
    }
}
