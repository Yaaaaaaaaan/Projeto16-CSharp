using System;

namespace Projeto16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];
            Console.WriteLine("Quantia a ser alugada; ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}: ");
            }
        }
    }
}
