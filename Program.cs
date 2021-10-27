using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // Estrutura While
            /*
             * Exercicio 2
             * Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de 
             * pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. 
             * O algoritmo será encerrado quando pelo menos uma de duas coordenadas 
             * for NULA (nesta situação sem escrever mensagem alguma).

             */

            Console.Write("Digite as coordenadas de X e Y: ");
            string[] coordenadas = Console.ReadLine().Split(' ');

            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                if (y > 0 && x > 0)
                {
                    Console.WriteLine("primeiro");

                }
                else if (y > 0 && x < 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (y < 0 && x < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (y < 0 && x > 0)
                {
                    Console.WriteLine("quarto");
                }
                Console.Write("Digite as coordenadas de X e Y: ");
                coordenadas = Console.ReadLine().Split(' ');

                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);

            }
        }
    }
}