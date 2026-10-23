using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// clase De Juan
namespace Videojuego_Orbit
{
    internal class Celula_Sobrecarga

    {
        string nombre;
        int posicionX;
        int posicionY;
        bool recolectada;
        public int tiempocelula;
    
        public int segundos;


        int celulaSobrecarga;
        bool sobrecargaActiva;
        int duracionEfecto;


        char s;
        char n;

        public Celula_Sobrecarga(string Nombre,int PosicionX, int PosicionY) 
        {
            this.nombre = Nombre;
            this.posicionX = PosicionX;
            this.posicionY = PosicionY;
            this.duracionEfecto = 10;
            this.recolectada = false;
            this.celulaSobrecarga = 0;
            this.sobrecargaActiva = false;
            this.s = 's';
            this.n = 'n';
        }



        public bool LimiteRecoleccion()
        {
            if (celulaSobrecarga >= 3)
            {

                return false;
            }
            celulaSobrecarga++;
            return true;
        }

        public bool RecolecciondeEnergia()
        {
            if(recolectada==false)
            {
                recolectada = true;
                sobrecargaActiva = true;
                return true;


            }
            else  return false;
        }


        public bool ActivarPoder()
        {
            if (recolectada == true)
            {
                Console.WriteLine("Desea gastar una energia presione la tecla S/N");
                Console.ReadLine();
                if (s == 's')
                {
                    celulaSobrecarga--;
                    IniciarTiempo();
                    SegundosCelula();
                    return true;

                }
            }
            else if (n == 'n')
            {
                return false;
            }
            return false;
        }






        public void IniciarTiempo()
        {
            tiempocelula = 10;

        }


        public void SegundosCelula()
        {
            int fila = Console.CursorTop;
            while (tiempocelula >= 0)
            {

                segundos = tiempocelula % 10;


                //Otra opcion era console clear.

                Console.SetCursorPosition(0, fila);
                Console.WriteLine($"Tiempo restante de la celula: {segundos:D1}");
                tiempocelula--;
                Thread.Sleep(1000);
            }
        }

    }
}


// Preguntar: como se hace lo del power up para activarlo y como es eso 