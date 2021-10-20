using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu ultimo nome, idade e altura ");
            string[] vet = Console.ReadLine().Split(' ');
            string vetUltimoNome = vet[0];
            int vetIdade = int.Parse(vet[1]);
            float vetAltura = float.Parse(vet[2]); 



            Console.WriteLine(nome);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vetUltimoNome);
            Console.WriteLine(vetIdade);
            Console.WriteLine(vetAltura);


        }
    }
}