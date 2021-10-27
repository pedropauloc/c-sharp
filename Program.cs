using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // Estrutura condicional
            /*
             * Exercicio 8
             */

            Console.Write("Digite o salario: ");
            double salario = double.Parse(Console.ReadLine());
            double total;

            if (salario >= 0.0 && salario <= 2000)
            {
                Console.WriteLine("Insento");
            }
            else if (salario > 2000 && salario <= 3000)
            {
                // 8%

                total = (salario - 2000.0) * 0.08;
                

            }
            else if (salario > 3000 && salario <= 4500)
            {
                // 18%
                total = (salario - 2000) * (18 / 100);
                Console.WriteLine("R$ " + total);
            }
            else if (salario > 4500)
            {
                // 28%
                total = (salario - 2000) * (28 / 100);
                Console.WriteLine("R$ " + total);
            }
            else
            {
                Console.WriteLine("Valor digitado invalido");
            }

            Console.WriteLine(total);
        }
  
    }
}