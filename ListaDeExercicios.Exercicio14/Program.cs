namespace ListaDeExercicios.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para sequencia Fibonacci até este valor: ");

            int numeroFibo = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;

            Console.WriteLine("Sequencia de Fibonacci: ");

            while (a <= numeroFibo)
            { 
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
