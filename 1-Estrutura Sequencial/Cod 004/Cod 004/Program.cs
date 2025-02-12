using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero, horas;
            double valorHora, salario;

            Console.Write("Digite o número do funcionário: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da hora trabalhada: ");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
