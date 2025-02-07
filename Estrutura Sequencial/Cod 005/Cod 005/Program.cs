using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            Console.Write("Digite o número, quantidade e valor da peça (ex: 1 2 10.50): ");
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.Write("Digite o número, quantidade e valor da peça (ex: 2 3 20.75): ");
            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.Write("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture) + "\n");
        }
    }
}
