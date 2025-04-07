namespace ListaDeExercicios.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro para calcular o fatorial: ");
            int A = int.Parse(Console.ReadLine());

            long resultado = 1;

            Console.Write($"{A}! = ");

            for (int i = A; i >= 1; i--)
            {
                Console.Write(i);

                if (i != 1)
                    Console.Write(" x ");

                resultado *= i;
            }

            Console.WriteLine($" = {resultado}");
            Console.ReadLine(); 
        }
    }
}
