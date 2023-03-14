using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("O Valor de i: " + i);
            }
        }
    }
}