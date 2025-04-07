using System.Net.Http.Headers;

namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        //6. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota da PROVA 1:");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a nota da PROVA 1:");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;

            Console.WriteLine($"A sua média final ficou em {media}.");
            Console.ReadLine();
        }
    }
}
