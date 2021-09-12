using System;

namespace GrauDeCPraF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---olá usuário, aqui irei fazer um conversor de temperatura de Celsius para fahrenheit----\n");

            Console.Write("Temperatura em Celsius: ");
            double TemperaturaC = Convert.ToDouble(Console.ReadLine());

            double TemperaturaF = TemperaturaC * 1.8 + 32; 

            Console.WriteLine($"\nTemperatura em fahrenheit: {TemperaturaF}\n"); 


        }
    }
}
