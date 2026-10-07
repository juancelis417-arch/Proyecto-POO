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
            // ==========================================
            // ORBIT
            // ==========================================

            // Se crea el objeto Orbit
            Orbit jugador = new Orbit();

            Console.WriteLine("---- Estado inicial ORBIT ----");
            Console.WriteLine("Posición: " + jugador.Posicion);
            Console.WriteLine("Vidas: " + jugador.Vidas);
            Console.WriteLine("Puntaje: " + jugador.Puntaje);
            Console.WriteLine("Tiempo restante: " + jugador.TiempoRestante);
            Console.WriteLine();


            // Se prueba mover al jugador
            jugador.Mover(5);

            Console.WriteLine("---- Después de mover ----");
            Console.WriteLine("Posición: " + jugador.Posicion);
            Console.WriteLine();


            // Se prueba sumar puntos
            jugador.Sumarpuntos(100);

            Console.WriteLine("---- Después de sumar puntos ----");
            Console.WriteLine("Puntaje: " + jugador.Puntaje);
            Console.WriteLine();


            // Se prueba perder una vida
            jugador.Perdervida();

            Console.WriteLine("---- Después de perder una vida ----");
            Console.WriteLine("Vidas: " + jugador.Vidas);
            Console.WriteLine();


            // Se verifica la recarga
            jugador.Aumentarestado(30);

            Console.WriteLine("---- Después de aumentar el estado ----");

            if (jugador.Estadocapacidad())
            {
                Console.WriteLine("La recarga es normal.");
            }
            else
            {
                Console.WriteLine("Sobrecarga detectada.");
            }

            Console.WriteLine();


            // Se aumenta nuevamente el estado
            jugador.Aumentarestado(30);

            Console.WriteLine("---- Después de aumentar el estado de nuevo ----");

            if (jugador.Estadocapacidad())
            {
                Console.WriteLine("La recarga es normal.");
            }
            else
            {
                Console.WriteLine("¡Sobrecarga detectada!");
            }

            Console.WriteLine();


            // Tiempo que se juega en la partida
            jugador.Tiemporesta(20);

            Console.WriteLine("---- Después de restar tiempo ----");
            Console.WriteLine("Tiempo restante: " + jugador.TiempoRestante);
            Console.WriteLine();


            // Se resta más tiempo del disponible
            jugador.Tiemporesta(100);

            Console.WriteLine("---- Después de restar más tiempo del disponible ----");
            Console.WriteLine("Tiempo restante: " + jugador.TiempoRestante);
            Console.WriteLine();


            
            
        // ==========================================
        // GEMA DE ENERGÍA ESTÁNDAR
        // ==========================================

Console.WriteLine("***************************");
Console.WriteLine("GEMA DE ENERGIA ESTANDAR");
Console.WriteLine();

// Se crea la gema
// Posición inicial = 3
// Valor en puntos = 50
Gema_Energia_Estandar gema =
    new Gema_Energia_Estandar(3, 50);

Console.WriteLine("---- Estado inicial ----");
Console.WriteLine("Posición: " + gema.Posicion);
Console.WriteLine("Valor en puntos: " + gema.Valor_Puntos);
Console.WriteLine("Recolectada: " + gema.Estado);
Console.WriteLine("Carga disponible: " + gema.CargaDisponible);
Console.WriteLine();

// ORBIT recoge la gema
gema.Recolectar();

Console.WriteLine("---- ORBIT recoge la gema ----");
Console.WriteLine("Gema recolectada: " + gema.EstaRecolectada());
Console.WriteLine("Carga disponible: " + gema.CargaDisponible);
Console.WriteLine("Posición de la gema: " + gema.Posicion);
Console.WriteLine();

// ORBIT utiliza la carga especial
bool ataqueRealizado = gema.UsarCarga();

Console.WriteLine("---- ORBIT utiliza la carga ----");

if (ataqueRealizado == true)
{
    Console.WriteLine("ORBIT utilizó la carga de energía.");
    Console.WriteLine("El dron puede ser desactivado durante "
        + gema.DuracionEfecto + " segundos.");
}
else
{
    Console.WriteLine("ORBIT no tiene una carga disponible.");
}

Console.WriteLine("Carga disponible después de usarla: "
    + gema.CargaDisponible);

Console.WriteLine();




            // ==========================================
            // PUERTA LÁSER
            // ==========================================

Console.WriteLine("***************************");
Console.WriteLine("PUERTA LASER");
Console.WriteLine();

// Se crea una puerta láser
// Posición = 10
// Duración del ciclo = 3 segundos
Puerta_Laser puerta = new Puerta_Laser(10, 3);

Console.WriteLine("---- Estado inicial ----");
Console.WriteLine("Posición: " + puerta.Posicion);

if (puerta.Estado == false)
{
    Console.WriteLine("La puerta está cerrada.");
}

Console.WriteLine("Bloquea el paso: " + puerta.BloquearPaso());
Console.WriteLine();


// Espera los 3 segundos establecidos para el ciclo
Thread.Sleep((int)(puerta.DuracionCiclo * 1000));

// Cambia de cerrada a abierta
puerta.CambiarEstado();

Console.WriteLine("---- Después de 3 segundos ----");

if (puerta.Estado == true)
{
    Console.WriteLine("La puerta está abierta.");
}

Console.WriteLine("Bloquea el paso: " + puerta.BloquearPaso());
Console.WriteLine();


// Espera otros 3 segundos
Thread.Sleep((int)(puerta.DuracionCiclo * 1000));

// Cambia de abierta a cerrada
puerta.CambiarEstado();

Console.WriteLine("---- Después de otros 3 segundos ----");

if (puerta.Estado == false)
{
    Console.WriteLine("La puerta está cerrada.");
}

Console.WriteLine("Bloquea el paso: " + puerta.BloquearPaso());
Console.WriteLine();


            
            
            // ==========================================
            // PORTAL DE SALIDA
            // ==========================================

Console.WriteLine("***************************");
Console.WriteLine("PORTAL DE SALIDA");
Console.WriteLine();

// Se crea el portal
Portal_Salida portal = new Portal_Salida(20);

Console.WriteLine("---- Estado inicial ----");
Console.WriteLine("Posición: " + portal.Posicion);
Console.WriteLine("Portal abierto: " + portal.Estado);
Console.WriteLine();

// Al inicio todavía no se han recogido
// correctamente los tres núcleos
bool nucleosCompletados = false;

portal.ActivarPortal(nucleosCompletados);

if (portal.PuedeSalir())
{
    Console.WriteLine("El portal está abierto. ORBIT puede salir.");
}
else
{
    Console.WriteLine("El portal está cerrado.");
}

Console.WriteLine();


// Simulación:
// Los núcleos fueron recogidos correctamente
// en el orden: amarillo, azul y verde
nucleosCompletados = true;

portal.ActivarPortal(nucleosCompletados);

Console.WriteLine("---- Núcleos completados ----");
Console.WriteLine("Orden correcto: Amarillo -> Azul -> Verde");

if (portal.PuedeSalir())
{
    Console.WriteLine("El portal se abrió.");
    Console.WriteLine("ORBIT puede salir del nivel.");
}
else
{
    Console.WriteLine("El portal continúa cerrado.");
}

Console.WriteLine();



            // ==========================================
            // DRON CENTINELA TIPO A
            // ==========================================

            Console.WriteLine("***************************");
            Console.WriteLine("DRON CENTINELA TIPO A");
            Console.WriteLine();


            // Se crea el Dron Centinela
            Dron_Centinela_Tipo_A centinela =
                new Dron_Centinela_Tipo_A();


            // Se asigna una ruta
            centinela.AsignarRuta("Ruta A");


            Console.WriteLine("---- Estado inicial ----");
            Console.WriteLine("Posición: " + centinela.Posicion);
            Console.WriteLine("Velocidad: " + centinela.Velocidad);
            Console.WriteLine("Estado: " + centinela.Estado);
            Console.WriteLine("Ruta: " + centinela.RutaPatrulla);
            Console.WriteLine();


            // Se prueba el movimiento del Centinela
            string movimientoCentinela = centinela.Mover(5);

            Console.WriteLine("---- Movimiento ----");
            Console.WriteLine(movimientoCentinela);
            Console.WriteLine("Nueva posición: " + centinela.Posicion);
            Console.WriteLine();


            // ==========================================
            // DRON CAZADOR TIPO B
            // ==========================================

            Console.WriteLine("***************************");
            Console.WriteLine("DRON CAZADOR TIPO B");
            Console.WriteLine();


            // Se crea el Dron Cazador
            Dron_Cazador__Tipo_B cazador =
                new Dron_Cazador__Tipo_B(1);


            // Se actualiza la posición de ORBIT
            cazador.calcularDireccion(jugador.Posicion);

            Console.WriteLine("---- Estado inicial ----");
            Console.WriteLine("Posición: " + cazador.Posicion);
            Console.WriteLine("Velocidad: " + cazador.Velocidad);
            Console.WriteLine("Estado: " + cazador.Estado);
            Console.WriteLine("Posición de ORBIT: " + cazador.PosicionObjeto);
            Console.WriteLine();


            // Se prueba el movimiento del Cazador
            string movimientoCazador = cazador.Mover(4);

            Console.WriteLine("---- Movimiento ----");
            Console.WriteLine(movimientoCazador);
            Console.WriteLine("Nueva posición: " + cazador.Posicion);
            Console.WriteLine();



            // ==========================================
            // PRUEBA DE HERENCIA Y POLIMORFISMO
            // ==========================================

            Console.WriteLine("***************************");
            Console.WriteLine("HERENCIA Y POLIMORFISMO");
            Console.WriteLine();


            // Tanto el Centinela como el Cazador
            // pueden ser tratados como objetos de tipo Dron
            Dron dron1 = centinela;
            Dron dron2 = cazador;


            // Se utiliza el mismo método Mover()
            // pero cada dron responde de manera diferente
            string resultadoCentinela = dron1.Mover(6);
            string resultadoCazador = dron2.Mover(7);


            Console.WriteLine("Movimiento del Centinela:");
            Console.WriteLine(resultadoCentinela);
            Console.WriteLine();

            Console.WriteLine("Movimiento del Cazador:");
            Console.WriteLine(resultadoCazador);
            Console.WriteLine();


            Console.WriteLine("***************************");
            Console.WriteLine("Fin de las pruebas.");
            Console.WriteLine();


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
        


    
    
        
    

