using System;

namespace FigurasGeometricas
{
    class Circulo : Figura
    {
        // ATRIBUTOS
        private double raio = 0;
        private readonly double pi = 3.14;

        // MÉTODO CONSTRUTOR
        public Circulo (double raio)
        {
            this.raio = raio;
        }

        // MÉTODOS GETTER
        public override double getArea()
        {
            return pi * Math.Pow(raio, 2);
        }

        public override double getPerimetro()
        {
            return 2 * pi * raio;
        }
    }
}
