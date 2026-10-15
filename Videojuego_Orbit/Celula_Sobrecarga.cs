using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// clase De Juan
namespace Videojuego_Orbit
{
    internal class Celula_Sobrecarga : GemasDelNucleo

    {
        public int tiempocelula;
    
        public int segundos;


        int celulaSobrecarga;
        int duracionEfecto;
        bool estadoDeRecoleccion;

        public Celula_Sobrecarga(string nombre,int posicionX, int posicionY, int totalGemas) : base(nombre, posicionX, posicionY, totalGemas)
        {
            this.duracionEfecto = 10;
            this.estado = false;
            this.celulaSobrecarga = 1;
        }



        public bool Verificacion()
        {
            if (celulaSobrecarga > 3)
            {
                celulaSobrecarga++;
                return false;
            }
            return true;
        }

        public bool RecolecciondeEnergia()
        {
            if(celulaSobrecarga==1)
            {
                SegundosCelula();
                return true;


            }
            else  return false;
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
                Console.WriteLine($"Tiempo restanten de la celula: {segundos:D1}");
                tiempocelula--;
                Thread.Sleep(1000);
            }
        }

    }
}


// Preguntar: como se hace lo del power para activarlo y como es eso 