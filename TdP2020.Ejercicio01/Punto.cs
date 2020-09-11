using System;

namespace TdP2020.Ejercicio01
{
    /// <summary>
    /// Representa un punto.
    /// </summary>
    class Punto
    {

        /// <summary>
        /// Constructor del punto.
        /// </summary>
        /// <param name="pX">Coordenada X.</param>
        /// <param name="pY">Coordenada Y.</param>
        public Punto(double pX, double pY)
        {

        }

        public int X { get; set; }

        public int Y { get; set; }

        /// <summary>
        /// Calcula la distancia.
        /// </summary>
        /// <param name="pPunto">Punto con el cual se quiere determinar la distancia.</param>
        /// <returns>Devuelve la distancia entre el punto y <paramref name="pPunto"/>.</returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            throw new NotImplementedException();
        }

    }
}
