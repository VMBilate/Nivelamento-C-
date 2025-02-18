using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}: ");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email= Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Occupied rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}