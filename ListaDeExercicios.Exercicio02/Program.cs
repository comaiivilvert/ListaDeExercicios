namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        //2. Crie um programa para calcular o volume de um Cilindro
        // V = pi . Raio 2 * altura
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro");
            double altura = Convert.ToDouble(Console.ReadLine());


            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            
            Console.WriteLine($"O volume é: {volume}");
            
            Console.ReadLine();
            
        }
    }
}
