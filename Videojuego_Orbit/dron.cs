namespace VideoJuego_Orbit
{
    internal abstract class Dron
    {
        private int x;
        private int y;
        private int velocidad;
        private int estado;

        public int X { get => x; private set => x = value; }
        public int Y { get => y; private set => y = value; }
        public int Velocidad { get => velocidad; private set => velocidad = value; }
        public int Estado { get => estado; private set => estado = value; }

        protected Dron(int xInicial, int yInicial, int velocidadInicial)
        {
            X = xInicial;
            Y = yInicial;
            Velocidad = velocidadInicial;
            Estado = 50;
        }

        protected void CambiarPosicion(int nuevoX, int nuevoY)
        {
            X = nuevoX;
            Y = nuevoY;
        }

        public virtual void Accion()
        {
        }
    }
}
