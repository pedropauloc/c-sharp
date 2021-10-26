using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // Estrutura condicional
            // Exercicio 5

            /*
             * Com base na tabela abaixo, 
             * escreva um programa que leia o código de um item e a quantidade deste item. 
             * A seguir, calcule e mostre o valor da conta a pagar.
            */

            Console.WriteLine("Digite o codigo e a quantidade: ");
            string[] info = Console.ReadLine().Split(' ');

            int cod = int.Parse(info[0]);
            double qtd = int.Parse(info[1]);
            double total = 0;

            if (cod == 1)
            {
                total = qtd * 4.00;
            } else if (cod == 2)
            {
                total = qtd * 4.50;
            } else if (cod == 3)
            {
                total = qtd * 5.00;
            } else if (cod == 4)
            {
                total = qtd * 2.00;
            } else if (cod == 5)
            {
                total = qtd * 1.50;
            } else
            {
                Console.WriteLine("valor digitado invalido!!");
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2"));


        }
    }
}