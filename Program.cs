﻿using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            // Simples
            if (x < 11)
            {
                Console.WriteLine("Estrutura simples");
            }

            // Composta
            if (x < 9)
            {
                Console.WriteLine("Saida 1");
            } else
            {
                Console.WriteLine("Saida 2");
            }

            // Encadeada
            if (x == 9)
            {
                Console.WriteLine("Saida 1");
            }
            else if (x > 9)
            {
                Console.WriteLine("Saida 2");
            } else if (x != 10)
            {
                Console.WriteLine("Saida 3");
            } else
            {
                Console.WriteLine("Saida 4");
            }

        }
    }
}