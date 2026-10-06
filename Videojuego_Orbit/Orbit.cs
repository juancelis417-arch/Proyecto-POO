using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VideoJuego_Orbit
{
    internal class Orbit
    {
        //Atrubutos
        string nombre;
        int posicionX;
        int posicionY;
        int vidas;
        int puntaje;
        int estado;
        public int totalGemas;
        double tiempoPorPartida;
        int velocidad;
        int altura;
        //Tiempo del Juego
        public int tiempoTotalSegundos;
        public int minutos;
        public int segundos;


        // Constructor 

        public Orbit()
        {
            this.posicionX = 0;
            this.posicionY = 0;
            this.vidas = 3;
            this.puntaje = 0;
            this.estado = 0;
            this.tiempoPorPartida = 60;
            this.altura = 5;
            this.velocidad = 10;





        }
        //
        public int PosicionX { get => posicionX; }
        public int PosicionY { get => posicionY; }
        public int Vidas { get => vidas; }
        public int Puntaje { get => puntaje; }
        public int Estado { get => estado; }
        public double TiempoPorPartida { get => tiempoPorPartida; }
        public int Velocidad { get => velocidad; }
        public int Altura { get => altura; }
        public int TiempoTotalSegundos { get => tiempoTotalSegundos; }
        public int Minutos { get => minutos; }
        public int Segundos { get => segundos; }
        public int TotalGemas { get => totalGemas; set => totalGemas = value; }
        public string Nombre { get => nombre; }


        //Metodos
        public void NombreDePersonaje(string nombreP)
        {
            nombre = nombreP;
        }

        public void Mover(int nuevaX, int nuevaY, int velocidadConst, int nuevaAltura)
        {
            posicionX = nuevaX;
            posicionY = nuevaY;
            velocidad = velocidadConst;
            altura = nuevaAltura;

        }

        public void moverDerecha()
        {
            posicionX = posicionX + velocidad;

        }

        public void moverIzquierda()
        {
            posicionX = posicionX + velocidad;

        }

        public void Aumentarestado(int cantidad)
        {
            estado += cantidad;
        }
        public void Perdervida()
        {
            if (vidas > 0)
                vidas--;

        }



        public void Sumarpuntos(int puntos)
        {
            puntaje += puntos;
        }

        public void GemaAmarilla(int gemaAmarilla, int nuevaX, int nuevaY)
        {
            posicionX = nuevaX;
            posicionY = nuevaY;
            estado = gemaAmarilla;
            totalGemas += gemaAmarilla;
        }


        public void GemaAzul(int gemaAzul, int nuevaX, int nuevaY)
        {
            posicionX = nuevaX;
            posicionY = nuevaY;
            estado = gemaAzul;
            totalGemas += gemaAzul;
        }


        public void GemaRoja(int gemaRoja, int nuevaX, int nuevaY)
        {
            posicionX = nuevaX;
            posicionY = nuevaY;
            estado = gemaRoja;
            totalGemas += gemaRoja;

        }

        public void SumarGemas(int cantidad)
        {
            totalGemas += cantidad;
        }



        public bool Estadocapacidad()
        {
            if (totalGemas >= 100) // Cuando la carga supera 100, se activa la sobrecarga.
                return true;
            else
                return false;// sino es porque la recarga esta sobrecargado
        }





        public void IniciarTiempo()
        {
            tiempoTotalSegundos = 60;

        }
        public void Minseng()
        {
            int fila = Console.CursorTop;
            while (tiempoTotalSegundos >= 0)
            {
                minutos = tiempoTotalSegundos / 60;
                segundos = tiempoTotalSegundos % 60;


                //Otra opcion era console clear.

                Console.SetCursorPosition(0, fila);
                Console.WriteLine($"Tiempo restante: {minutos:D2}:{segundos:D2}");
                tiempoTotalSegundos--;
                Thread.Sleep(1000);
            }
        }

    }
}
