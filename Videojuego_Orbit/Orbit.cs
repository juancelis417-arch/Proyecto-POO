using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace VideoJuego_Orbit
{
    internal class Orbit
    {
        //Atrubutos
        int posicion;
        int vidas;
        int puntaje;
        int estado;
        double tiempoRestante;

        public Orbit()
        {
            this.posicion = 1;
            this.vidas = 3;
            this.puntaje = 0;
            this.estado = 50;
            this.tiempoRestante = 60;

        }

        public int Posicion { get => posicion; private set => posicion = value; }
        public int Vidas { get => vidas; private set => vidas = value; }
        public int Puntaje { get => puntaje; private set => puntaje = value; }
        public double TiempoRestante { get => tiempoRestante; private set => tiempoRestante = value; }
        public int Estado { get => estado; private set => estado = value; }

        public void Mover(int posicionactual)
        {
            posicion = posicionactual;
        }
        public void Perdervida()
        {
            if (vidas > 0 && vidas <= 3)
                vidas--;


        }

        public void Sumarpuntos(int puntos)
        {
            puntaje += puntos;
        }

        public void Aumentarestado(int cantidad)
        {
            estado += cantidad;
        }

        public bool Estadocapacidad()
        {
            if (estado < 100) // si esta es 100 le recarga seria normal 
                return true;
            else
                return false;// sino es porque la recarga esta sobrecargadd
        }
                 
            
                

        public void Tiemporesta(int tiempo)
        {
            tiempoRestante -= tiempo;
            if (tiempoRestante < 0)
                tiempoRestante = 0;
        }


    }
}
