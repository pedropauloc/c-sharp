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
             * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, s
             * abendo que o mesmo pode começar em um dia e terminar em outro, 
             * tendo uma duração mínima de 1 hora e máxima de 24 horas.
            */

            Console.WriteLine("Digite a hora inicial e final ");
            string[] hora = Console.ReadLine().Split(' ');

            int horaInicio = int.Parse(hora[0]);
            int horaFim = int.Parse(hora[1]);
            int duracao;

            if(horaInicio < horaFim)
            {
                duracao = horaFim - horaInicio;
            } else
            {
                duracao = 24 - horaInicio + horaFim;
            }

            Console.WriteLine($"O jogo durou {duracao} Horas.");


        }
    }
}