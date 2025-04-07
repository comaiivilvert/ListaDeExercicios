using System;

namespace ListaDeExercicios.Exercicio04
{
    internal class Program
    {
        //4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura atual em graus celsius: ");
            int temperaturaC = Convert.ToInt32(Console.ReadLine());

            decimal temperaturaF = Convert.ToDecimal((temperaturaC * 9/5) + 32);

            Console.WriteLine($"A temperatura em Fahrenheit é: {temperaturaF} graus.");
            Console.ReadLine();
        }
    }
}
