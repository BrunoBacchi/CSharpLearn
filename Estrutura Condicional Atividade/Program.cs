using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double nota2;
            double soma;

            Console.WriteLine("Qual foram as suas duas notas?");
            nota = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            soma = nota + nota2;

            Console.WriteLine("Nota final é " + soma);

            if (soma < 60.0){
                Console.WriteLine("Você está reprovado");
            }
            Console.ReadLine();
        }
    }
}