using System;
using System.Collections.Specialized;

namespace Projeto16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];
            Console.WriteLine("Quantia a ser alugada; ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}: ");
                Console.WriteLine("Nome; ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email; ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto; ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados; ");
            for (int i = 0;i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(i+ "; " + vetor[i]);
                }
            }
            Console.ReadLine();

        }
    }
}
