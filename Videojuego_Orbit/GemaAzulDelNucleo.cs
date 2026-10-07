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

        int GemaAzul;

        public GemaAzulDelNucleo(string nombre, int posicionX, int posicionY, string estado, int totalGemas) : base(nombre, posicionX, posicionY, estado, totalGemas)
        {
            
        }

        public bool Recolectar(int gemaAzul)
        {
            if (GemaAzul == P2_gemaAzul)
            {
                totalGemas += gemaAzul;
                return true;

            }

            else return false;

        }
    }
}
