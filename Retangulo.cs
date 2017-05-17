using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Retangulo : Figura
    {
        // ATRIBUTOS
        private double primeiroLado = 0;
        private double segundoLado = 0;

        // CONSTRUTOR
        public Retangulo(double primeiroLado, double segundoLado)
        {
            this.primeiroLado = primeiroLado;
            this.segundoLado = segundoLado;
        }

        // MÉTODOS GETTER
        public override double getArea()
        {
            return primeiroLado * segundoLado;
        }

        public override double getPerimetro()
        {
            return (2 * primeiroLado) + (2 * segundoLado);
        }
    }
}
