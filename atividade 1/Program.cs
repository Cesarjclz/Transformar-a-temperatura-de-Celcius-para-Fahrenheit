
            using System;

namespace Exercicio1
    {
        class Program
        {
            static void Main(string[] args)
            {


                double celcius;
                double fahrenheit;

                Console.WriteLine("Saber a temperatura em graus celcius para Fahrenheit!");

                Console.WriteLine("Digite a temperatura em graus celcius:");
                celcius = double.Parse(Console.ReadLine());
                fahrenheit = (celcius * 9 / 5) + 32;
                Console.WriteLine("A temperatura em Fahrenheit é: {0} ", fahrenheit);














            }
        }
    }
