using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002;
            int senha;

            Console.WriteLine("Bem-vindo! Para acessar o sistema, digite a senha correta.");
            Console.WriteLine("Dica: A senha é um número de 4 dígitos.");

            while (true)
            {
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());

                if (senha == senhaCorreta)
                {
                    Console.WriteLine("Acesso Permitido! Bem-vindo ao sistema.");
                    break; 
                }

                Console.WriteLine("Senha Invalida. Tente novamente.");
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}
