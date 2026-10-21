namespace VideoJuego_Orbit
{
    internal class Dron_Cazador__Tipo_B : Dron
    {
        private Dron_Cazador__Tipo_B(int xInicial, int yInicial, int velocidadInicial)
            : base(xInicial, yInicial, velocidadInicial)
        {
        }


        public void Perseguir(Orbit orbit)
        {
            int nuevoX = X;
            int nuevoY = Y;

            if (orbit.X > X)
                nuevoX += Velocidad;
            else if (orbit.X < X)
                nuevoX -= Velocidad;

            if (orbit.Y > Y)
                nuevoY += Velocidad;
            else if (orbit.Y < Y)
                nuevoY -= Velocidad;

            CambiarPosicion(nuevoX, nuevoY);
        }

        public override void Accion()
        {
            // La persecucion se realiza con el metodo Perseguir().
        }
    }
}
