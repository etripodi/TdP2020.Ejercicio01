﻿namespace TdP2020.Ejercicio01
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
        /// Inicializa una nueva instancia del circulo.
        /// </summary>
        /// <param name="pCentro"></param>
        /// <param name="pRadio"></param>
        public Circulo(Punto pCentro, double pRadio)
        {

            this.iCentro = pCentro;

            this.iRadio = pRadio;

        }

        public Circulo(double pX, double pY, double pRadio) : this(new Punto(pX, pY), pRadio)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public Punto Centro { get { return this.iCentro; } }

        public double Radio { get { return this.iRadio; } }

        public double CalcularArea() { throw new System.NotImplementedException(); }

        public double Perimetro { get; }

    }
}
