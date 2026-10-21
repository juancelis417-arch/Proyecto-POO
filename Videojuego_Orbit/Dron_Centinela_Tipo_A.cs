namespace VideoJuego_Orbit
{
    internal class Dron_Centinela_Tipo_A : Dron
    {
        private int direccion;
        private int limiteSuperior;
        private int limiteInferior;

        public int Direccion { get => direccion; private set => direccion = value; }
        public int LimiteSuperior { get => limiteSuperior; private set => limiteSuperior = value; }
        public int LimiteInferior { get => limiteInferior; private set => limiteInferior = value; }

        public Dron_Centinela_Tipo_A(
            int xInicial,
            int yInicial,
            int velocidadInicial,
            int limiteSuperior,
            int limiteInferior)
            : base(xInicial, yInicial, velocidadInicial)
        {
            Direccion = 1;
            LimiteSuperior = limiteSuperior;
            LimiteInferior = limiteInferior;
        }

        public override void Accion()
        {
            // El Centinela solo se mueve de arriba hacia abajo
            // por el mismo pasillo.
            int nuevaY = Y + (Velocidad * Direccion);

            if (nuevaY >= LimiteSuperior)
            {
                nuevaY = LimiteSuperior;
                Direccion = -1;
            }

            if (nuevaY <= LimiteInferior)
            {
                nuevaY = LimiteInferior;
                Direccion = 1;
            }

            CambiarPosicion(X, nuevaY);
        }
    }
}
