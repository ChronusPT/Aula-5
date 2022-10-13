using System;

namespace Aula_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nome = "João";
            //string tempoatual = "Chuva";
            //string tempatual = "18";

            //Console.WriteLine($"Ola {nome}, hoje está um dia de {tempoatual}.Estão {tempatual}º");

            //Exercicio 1

            int valor1 = 0;
            int valor2 = 0;

            Console.WriteLine("Indique um valor -> ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indique outro valor -> ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 == valor2)
                Console.WriteLine("Os valores são iguais!");
            else
                Console.WriteLine("Os valores são diferentes!");


          

        }
    }
}
