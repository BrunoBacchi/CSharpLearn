using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();

            string[] v = s.Split(' ');
            string p1 = v[0];
            string p2 = v[1]; 
            string p3 = v[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);  
            Console.WriteLine(p3);

 /*
            Ou pode ser utilizado da seguinte forma caso queira utilizar diferentes valores
            Como Int, float, char no mesmo codigo
            
            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = float.Parse(vet[3]);

            Console.WriteLine(altura);
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
 */
    
        }
    }
}