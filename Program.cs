using System;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual figura será estudada? ");
            string nomeFigura = Console.ReadLine();
            Console.WriteLine("");

            if (nomeFigura.ToUpper().Equals("CIRCULO") || nomeFigura.ToUpper().Equals("CÍRCULO"))
            {
                Console.WriteLine("---------------");
                Console.WriteLine("    CÍRCULO    ");
                Console.WriteLine("---------------");
                Console.Write("Raio: ");
                double raio = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                Circulo c = new Circulo(raio);

                Console.WriteLine(" >> A área do círculo é {0}", c.getArea());
                Console.WriteLine(" >> O perímetro do círculo é {0}", c.getPerimetro());

            } else if (nomeFigura.ToUpper().Equals("RETANGULO") || nomeFigura.ToUpper().Equals("RETÂNGULO"))
            {
                Console.WriteLine("---------------");
                Console.WriteLine("   RETÂNGULO   ");
                Console.WriteLine("---------------");
                Console.Write("Lado 1: ");
                double primeiroLado = double.Parse(Console.ReadLine());
                Console.Write("Lado 2: ");
                double segundoLado = double.Parse(Console.ReadLine());

                Retangulo r = new Retangulo(primeiroLado, segundoLado);

                Console.WriteLine(" >> A área do retângulo é {0}", r.getArea());
                Console.WriteLine(" >> O perímetro do retângulo é {0}", r.getPerimetro());

            } else
            {
                Console.WriteLine("Seu apressadinho! Estamos aprendendo apenas sobre círculos ou retângulos no momento.");
            }
            Console.WriteLine("");
        }
    }
}
