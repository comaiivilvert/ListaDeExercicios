namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {

        /* Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
        programa deve solicitar ao usuário:
                ● A quilometragem inicial do veículo no início da viagem.
                ● A quilometragem final ao término da viagem.
                ● A quantidade de combustível consumida durante a viagem(em litros).
            */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a KM inicial do veícullo ");
            int kmInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a KM final do veícullo ");
            int kmFinal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quandos litros de combustivel foram gastos na viagem: ");
            int gasolinaGasta = Convert.ToInt32(Console.ReadLine());

            int mediaKM = (kmFinal - kmInicial) / gasolinaGasta;

            Console.WriteLine($"A média por KM percorrido é de {mediaKM} KM por litro.");
            Console.ReadLine();
        }
    }
}
