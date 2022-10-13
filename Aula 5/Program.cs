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
            //int valor2 = 0;

            //Console.WriteLine("Indique um valor -> ");
            //valor1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Indique outro valor -> ");
            //valor2 = int.Parse(Console.ReadLine());

            //if (valor1 == valor2)
            //    Console.WriteLine("Os valores são iguais!");
            //else
            //    Console.WriteLine("Os valores são diferentes!");


            ////Exercicio 2

            //Console.WriteLine("Indique a sua idade ->");
            //valor1 = int.Parse(Console.ReadLine());

            //if (valor1 < 18)
            //    Console.WriteLine("Você não pode votar !");
            //else
            //    Console.WriteLine("Voce pode votar");


            // Exercicio 3

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Indique um número ->");
                valor1 = int.Parse(Console.ReadLine());


                switch (valor1)
                {
                    case (1):
                        Console.WriteLine("\nSegunda-Feira");
                        break;
                    case (2):
                        Console.WriteLine("\nTerça-Feira");
                        break;
                    case (3):
                        Console.WriteLine("\nQuarta-Feira");
                        break;
                    case (4):
                        Console.WriteLine("\nQuinta-Feira");
                        break;
                    case (5):
                        Console.WriteLine("\nSexta-Feira");
                        break;
                    case (6):
                        Console.WriteLine("\nSábado");
                        break;
                    case (7):
                        Console.WriteLine("\nDomingo");
                        break;
                    default:
                        Console.WriteLine("\nExistem apenas 7 dias da semana");
                        break;
                }

            }
        }
    }
}
