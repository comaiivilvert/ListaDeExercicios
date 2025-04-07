namespace ListaDeExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero e direi se é PAR ou IMPAR:");
            int numero = Convert.ToInt32(Console.ReadLine());

           
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

            Console.ReadLine();
        }
    }
}
