using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] line = Console.ReadLine().Split(' ');
            int x = int.Parse(line[0]);
            int y = int.Parse(line[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primero");
                    Console.ReadLine();
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                    Console.ReadLine();
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Segundo");
                    Console.ReadLine();
                }

                line = Console.ReadLine().Split(' ');
                x = int.Parse(line[0]);
                y = int.Parse(line[1]);
            }
        }
    }
}