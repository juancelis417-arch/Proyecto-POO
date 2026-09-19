using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Videojuego_Orbit;

namespace VideoJuego_Orbit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se crea el objeto Orbit
            Orbit jugador = new Orbit();

            Console.WriteLine("---- Estado inicial ----");
            Console.WriteLine("Posición: " + jugador.Posicion);
            Console.WriteLine("Vidas: " + jugador.Vidas);
            Console.WriteLine("Puntaje: " + jugador.Puntaje);
            Console.WriteLine("Tiempo restante: " + jugador.TiempoRestante);
            Console.WriteLine("");

            // Se prueba mover al jugador
            jugador.Mover(5);
            Console.WriteLine("---- Después de mover ----");
            Console.WriteLine("Posición: " + jugador.Posicion);
            Console.WriteLine();

            // Se prueba sumar puntos
            jugador.Sumarpuntos(100);
            Console.WriteLine("---- Después de sumar puntos ---");
            Console.WriteLine("Puntaje: " + jugador.Puntaje);
            Console.WriteLine();

            // Se perder una vida
            jugador.Perdervida();
            Console.WriteLine("---- Después de perder una vida ----");
            Console.WriteLine("Vidas: " + jugador.Vidas);
            Console.WriteLine();

            // Se verifica la recarga
            jugador.Aumentarestado(30);
            Console.WriteLine("---- Después de aumentar el estado ----");
            if (jugador.Estadocapacidad())
                Console.WriteLine("La recarga es normal.");
            else
                Console.WriteLine("Sobrecarga detectada");
            Console.WriteLine();

            // si el estado es normal no hay sobrecarga, pero si se pasa del limite hay una sobrecargfa
            jugador.Aumentarestado(30);
            Console.WriteLine("---- Después de aumentar el estado de nuevo ----");
            if (jugador.Estadocapacidad())
                Console.WriteLine("La recarga es normal.");
            else
                Console.WriteLine("¡Sobrecarga detectada!");
            Console.WriteLine();

            // tiepo que se juega en la partida
            jugador.Tiemporesta(20);
            Console.WriteLine("---- Después de restar tiempo ----");
            Console.WriteLine("Tiempo restante: " + jugador.TiempoRestante);
            Console.WriteLine();

            // tiempo que resta en la partido, si llega a cero se cancela toda la pe+atida
            jugador.Tiemporesta(100);
            Console.WriteLine("---- Después de restar más tiempo del disponible ----");
            Console.WriteLine("Tiempo restante: " + jugador.TiempoRestante);


            // GEMA ENERGIA ESTANDAR

            Console.WriteLine("***************************\n");
            Console.WriteLine("GEMA DE ENERGIA ESTANDAR");
            Console.WriteLine();

            Gema_Energia_Estandar gema = new Gema_Energia_Estandar(50);

            Console.WriteLine("---- Estado inicial ----");
            Console.WriteLine("Posición: " + gema.Posicion);
            Console.WriteLine("Valor en puntos: " + gema.Valor_Puntos);
            Console.WriteLine("Estado: " + gema.Estado);
        

            // Se prueba mover la gema
            gema.mover(3);
            Console.WriteLine("---- Después de mover ----");
            Console.WriteLine("Posición: " + gema.Posicion);
            Console.WriteLine();

            // recoleccion de gema
            gema.aumentarestado(60);
            Console.WriteLine("---- Después de aumentar el estado ----");
            Console.WriteLine("Estado: " + gema.Estado);
            if (gema.Estadocapacidad())
                Console.WriteLine("La gema está recolectada.");
            else
                Console.WriteLine("La gema no está recolectada.");

            Console.ReadKey();
        }
    }


}
    
























































              /*
                // 60 minutos convertidos a segundos totales (3600 segundos)
                int tiempoTotalSegundos = 60 * 60;

                Console.WriteLine("Iniciando temporizador de 60 minutos:");

                while (tiempoTotalSegundos >= 0)
                {
                    // Calculamos los minutos y segundos restantes
                    int minutos = tiempoTotalSegundos / 60;
                    int segundos = tiempoTotalSegundos % 60;

                    // :D2 asegura que siempre se muestren dos dígitos (ej: 05:09 en lugar de 5:9)
                    // \r regresa el cursor al inicio de la línea para sobreescribir el tiempo
                    Console.Write($"\rTiempo restante: {minutos:D2}:{segundos:D2}");

                    // Pausa el programa por 1 segundo (1000 milisegundos)
                    Thread.Sleep(1000);

                    // Disminuye un segundo
                    tiempoTotalSegundos--;
                }

                Console.WriteLine("\n\n¡Tiempo terminado! ⏰");
                Console.ReadLine(); // Evita que la consola se cierre de inmediato
            }*/
        


    
    
        
    

