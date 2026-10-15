using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class GemaAmarillaDelNucleo : GemasDelNucleo
    {


        public GemaAmarillaDelNucleo(string nombre, int posicionX, int posicionY, string estado, int totalGemas) : base(nombre, posicionX, posicionY, estado, totalGemas)
        {
            
        }

        public bool Recolecion(int gemaAmarilla)
        {
            if(gemaActual == P1_gemaAmarilla)
            {

                totalGemas += gemaAmarilla;
                gemaActual++;
                return true;

            }
            
            else return false;
            
        }



    }
}
