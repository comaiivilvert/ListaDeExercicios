namespace ListaDeExercicios.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abaixo estão todos os numeros IMPARES entre 1 e 100:");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine($"{i}");
            }

            Console.ReadLine(); 
        }
    }
}
