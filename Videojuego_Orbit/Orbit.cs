using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Videojuego_Orbit;

//Clase de Juan


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
        double posicion;

        // Posicion del orbit
        double centroX;
        public double centroY;
        double[] radios;
        public int sectores;
        private int carril;
        int sector;


        public double x;
        public double y;







        private List<GemasDelNucleo> gemas = new List<GemasDelNucleo>();

        // Constructor 

        public Orbit()
        {
            this.posicionX = 0;
            this.posicionY = 0;
            this.vidas = 3;
            this.puntaje = 0;
            this.estado = 0;
            this.tiempoPorPartida = 60;
            this.velocidad = 10;


            this.centroX = 0;
            this.centroY = 0;
            this.radios = new double[] { 20, 40, 60, 80, 100 };
            this.sectores = 24;
            this.carril = 4;
            this.sector = 0;






            ActualizarPosicion();
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



        public int Carril { get => carril; }
        public int Sector { get => sector; }
        public int Carriles { get => 5; }
        public int Sectores { get => sectores; }


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

        public double CalcularX(int numeroCarril, int numeroSector)
        {
            double grados = numeroSector * 360.0 / sectores;
            double radianes = grados * Math.PI / 180;
            return Math.Round(centroX + radios[numeroCarril] * Math.Cos(radianes), 1) + 0.0;   // + 0.0 evita el -0
        }



        public double CalcularY(int numeroCarril, int numeroSector)
        {
            double grados = numeroSector * 360.0 / sectores;
            double radianes = grados * Math.PI / 180;
            return Math.Round(centroY + radios[numeroCarril] * Math.Sin(radianes), 1) + 0.0;
        }




        public void ActualizarPosicion()
        {
            posicionX = (int)CalcularX(carril, sector);
            posicionY = (int)CalcularY(carril, sector);
        }




        bool Libre(int nuevoCarril, int nuevoSector, bool[,] muros)
        {
            if (nuevoCarril < 0 || nuevoCarril >= radios.Length)

                return false;                          // ese anillo no existe
            if (nuevoSector < 0 || nuevoSector >= sectores)
                return false;

            if (muros[nuevoCarril, nuevoSector])
                return false;                          // hay un muro
            return true;
        }




        public bool MoverAdelante(bool[,] muros)
        {
            int nuevoSector = (sector + 1) % sectores;
            if (!Libre(carril, nuevoSector, muros))
                return false;

            sector = nuevoSector;
            ActualizarPosicion();
            return true;
        }




        public bool MoverAtras(bool[,] muros)
        {
            int nuevoSector = (sector - 1 + sectores) % sectores;
            if (!Libre(carril, nuevoSector, muros))
                return false;

            sector = nuevoSector;
            ActualizarPosicion();
            return true;
        }


        public bool MoverAfuera(bool[,] muros)
        {
            int nuevoCarril = carril + 1;
            if (!Libre(nuevoCarril, sector, muros))
                return false;

            carril = nuevoCarril;
            ActualizarPosicion();
            return true;
        }


        public bool MoverAdentro(bool[,] muros)
        {
            int nuevoCarril = carril - 1;
            if (!Libre(nuevoCarril, sector, muros))
                return false;

            carril = nuevoCarril;
            ActualizarPosicion();
            return true;
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




       


        public void RecoleccionGemas(GemasDelNucleo gema )
        {
            if (gema.Recoleccion())
                gemas.Add(gema);
            
                

            
        }


        public void SumarGemas(int cantidad)
        {
            totalGemas += cantidad;
        }



        public void Sumarpuntos(int puntos)
        {
            puntaje += puntos;
        }

        public bool Estadocapacidad()
        {
            return estado > 100;
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
