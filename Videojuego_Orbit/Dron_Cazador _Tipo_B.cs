using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class Dron_Cazador__Tipo_B
    {
        int posicion;
        int velocidad;
        int posicionObjeto;//posicion objeto orbit
        int estado;

        public Dron_Cazador__Tipo_B(int posicionInicial)
        {
            this.posicion = posicionInicial;
            this.velocidad = 20;
            this.posicionObjeto = 2; //indicar al equipo donde se van a encontar las pocicion del objeto
            this.estado = 50;
        }




        public int Posicion { get => posicion; private set => posicion = value; }
        public int Velocidad { get => velocidad; private set => velocidad = value; }
        public int PosicionObjeto { get => posicionObjeto; private set => posicionObjeto = value; }
        public int Estado { get => estado; private set => estado = value; }


        public void mover(int posicionactual)
        {
            posicion = posicionactual;
        }

        public void velocidadbaja(int nuevaVelocidad)
        {
            velocidad = nuevaVelocidad;
        }

        public void calcularDireccion(int nuevaPosicionOrbit)
        {
            posicionObjeto = nuevaPosicionOrbit;
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
