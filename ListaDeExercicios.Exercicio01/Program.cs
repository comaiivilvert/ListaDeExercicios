namespace ListaDeExercicios.Exercicio01
{
    internal class Program
    {

        //1. Crie um programa para calcular o volume de uma caixa retangular
        // VOLUME CAIXA = COMPRIMENTO * LARGURA * ALTURA
        static void Main(string[] args)
        {
            Console.WriteLine("Digita o comprimento da caixa:");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digita a largura da caixa:");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digita a altura da caixa:");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = comprimento * largura * altura;

            Console.WriteLine($"O resultado é: {resultado}");

        }
    }
}
