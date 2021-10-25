﻿using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // debuggiging
            // f5 rodar em modo debugging
            // f10 executar o proximo passo
            // f11 executa o passo mas entra na função
            // f9 marcar breakpoint
            // shift + f11 sai do metodo em execucao
            // shift + f5 para o debug


            Console.WriteLine("Digite 3 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            } else if (b > c)
            {
                m = b;
            } else
            {
                m = c;
            }
            return m;
        }
    }
}