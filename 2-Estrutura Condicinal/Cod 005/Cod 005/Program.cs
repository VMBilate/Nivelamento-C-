using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("------------ MENU:--------------");
        Console.WriteLine("1 -   Cachorro Quente  - R$ 4.00");
        Console.WriteLine("2 -   X-Salada         - R$ 4.50");
        Console.WriteLine("3 -   X-Bacon          - R$ 5.00");
        Console.WriteLine("4 -   Torrada Simples  - R$ 2.00");
        Console.WriteLine("5 -   Refrigerante     - R$ 1.50");
        Console.WriteLine("--------------------------------");

        double[] precos = { 4.00, 4.50, 5.00, 2.00, 1.50 };

        Console.Write("Digite o código e a quantidade do item desejado: ");
        string[] entrada = Console.ReadLine().Split(' ');
        int codigo = int.Parse(entrada[0]);
        int quantidade = int.Parse(entrada[1]);

        double total = precos[codigo - 1] * quantidade;

        Console.WriteLine("\nTotal: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
}