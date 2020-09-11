namespace TdP2020.Ejercicio01
{
    /// <summary>
    /// Representa un círculo.
    /// </summary>
    /// <example>
    /// <code>
    /// Circulo circulo = new Circulo(1.1, 2.1, 5d);
    /// </code>
    /// </example>
    class Circulo
    {

        /// <summary>
        /// 
        /// </summary>
        private Punto iCentro;

        /// <summary>
        /// 
        /// </summary>
        private double iRadio;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCentro"></param>
        /// <param name="pRadio"></param>
        public Circulo(Punto pCentro, double pRadio)
        {
        }

        public Circulo(double pX, double pY, double pRadio) : this(new Punto(pX, pY), pRadio)
        {
            string
        }

        /// <summary>
        /// 
        /// </summary>
        public Punto Centro { get { return this.iCentro; } }

        public double Radio { get { return this.iRadio; } }

        public double Area { get; }

        public double Perimetro { get; }

    }
}
