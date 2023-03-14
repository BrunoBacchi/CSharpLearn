using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
            Console.WriteLine("Entre com seu nome completo ");
            Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em sua sala? ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um preço de um produto: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu Último nome, idade e altura (mesma linha)");

            string[] vet = Console.ReadLine().Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = float.Parse(vet[2]);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}