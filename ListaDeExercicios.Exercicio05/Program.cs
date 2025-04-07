namespace ListaDeExercicios.Exercicio05
{
    internal class Program
    {

        //5. Crie um programa para calcular o salário total de um vendedor.
        //Deverá ser informado o salário base e o total de vendas.
        //A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            Console.WriteLine("Qual salario base do vendedor?");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual total de vendas deste mês?");
            double totalVendas= Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Qual a % de comissão o vendedor recebe sobre as vendas?");
            double porcentagem = Convert.ToDouble(Console.ReadLine())/100;
            double comissao = totalVendas * porcentagem;

            double salarioTotal = comissao + salario;

            Console.WriteLine($"O total de vendas foi {totalVendas}.");
            Console.WriteLine($"A comissão do vendedor foi de {comissao}.");
            Console.WriteLine($"O salário total do vendedor foi de {salarioTotal}.");
            Console.ReadLine();
        }
    }
}
