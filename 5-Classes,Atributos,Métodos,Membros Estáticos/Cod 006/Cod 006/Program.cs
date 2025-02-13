using System;
using System.Globalization;

namespace Exercicio6
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal (double quantia, double cotacao)
        {
            double total = quantia * cotacao;   
            return total + total * Iof / 100.0;   
        }
    }
}

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais é de R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}