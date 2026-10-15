using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class GemaAzulDelNucleo : GemasDelNucleo
    {

        

        public GemaAzulDelNucleo(string nombre, int posicionX, int posicionY, string estado, int totalGemas) : base(nombre, posicionX, posicionY, estado, totalGemas)
        {
            
        }

        public bool Recolectar(int gemaAzul)
        {
            if (gemaActual == P2_gemaAzul)
            {
                totalGemas += gemaAzul;
                gemaActual++;
                return true;

            }

            else return false;

        }
    }
}
