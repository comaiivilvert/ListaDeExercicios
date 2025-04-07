namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {   //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor para B:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor para C:");
            int C = Convert.ToInt32(Console.ReadLine());

            if ((A + B) < C)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A som de A + B não é menor que C.");
            }
            Console.ReadLine();
        }
    }
}
