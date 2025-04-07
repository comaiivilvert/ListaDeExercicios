using System;

namespace ListaDeExercicios.Exercicio07
{
    internal class Program
    {

        //7. Crie um programa para verificar se um número é primo.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para validar se ele é primo");
            int numero = Convert.ToInt32(Console.ReadLine());


            if (EhPrimo(numero))
                Console.WriteLine($"{numero} é um número primo.");
            else
                Console.WriteLine($"{numero} não é um número primo.");

            Console.ReadLine();
        }

        static bool EhPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

    }
}
