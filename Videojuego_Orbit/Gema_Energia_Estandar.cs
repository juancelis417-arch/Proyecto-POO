using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego_Orbit
{
    internal class Gema_Energia_Estandar
    {
        // Atributos
        int posicion;
        int valor_Puntos;
        bool estado; // false = no recolectada, true = recolectada
        bool cargaDisponible;
        int duracionEfecto;

        // Constructor
        public Gema_Energia_Estandar(int posicionInicial, int puntos)
        {
            this.posicion = posicionInicial;
            this.valor_Puntos = puntos;
            this.estado = false;
            this.cargaDisponible = false;
            this.duracionEfecto = 6;
        }

        // Propiedades
        public int Posicion
        {
            get => posicion;
            private set => posicion = value;
        }

        public int Valor_Puntos
        {
            get => valor_Puntos;
            private set => valor_Puntos = value;
        }

        public bool Estado
        {
            get => estado;
            private set => estado = value;
        }

        public bool CargaDisponible
        {
            get => cargaDisponible;
            private set => cargaDisponible = value;
        }

        public int DuracionEfecto
        {
            get => duracionEfecto;
            private set => duracionEfecto = value;
        }

        // ORBIT recoge la gema y obtiene la carga especial
        public void Recolectar()
        {
            estado = true;
            cargaDisponible = true;
            Desaparecer();
        }

        // Verificar si la gema fue recolectada
        public bool EstaRecolectada()
        {
            return estado;
        }

        // Utilizar la carga especial
        public bool UsarCarga()
        {
            if (cargaDisponible == true)
            {
                cargaDisponible = false;
                return true;
            }

            return false;
        }

        // La gema desaparece del mapa
        public void Desaparecer()
        {
            posicion = -1;
        }
    }
}
