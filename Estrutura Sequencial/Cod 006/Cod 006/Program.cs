using System;
using System.Globalization;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.Write("Digite três valores separados por espaço (ex: 3.0 4.0 5.2): ");
            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.Write("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture) + "\n");
            Console.Write("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture) + "\n");
            Console.Write("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture) + "\n");
            Console.Write("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture) + "\n");
            Console.Write("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture) + "\n");
        }
    }
}
