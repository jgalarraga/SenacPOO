using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Figura
    {
        // ATRIBUTOS
        private double perimetro = 0;
        private double area = 0;

        // MÉTODOS
        public virtual double getPerimetro()
        {
            return 0;
        }

        public virtual double getArea()
        {
            return 0;
        }
    }
}
