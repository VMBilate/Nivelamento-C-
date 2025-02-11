using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;
            int codigo;

            Console.WriteLine("Bem-vindo ao Posto de Combustíveis!");
            Console.WriteLine("Digite o código do combustível abastecido:");
            Console.WriteLine("1 - Álcool | 2 - Gasolina | 3 - Diesel | 4 - Encerrar");

            while (true)
            {
                Console.Write("Informe o código: ");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 4)
                {
                    break; // Sai do loop quando o código for 4
                }

                switch (codigo)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    default:
                        Console.WriteLine("Código inválido! Tente novamente.");
                        continue; // Pula para a próxima iteração do loop
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
