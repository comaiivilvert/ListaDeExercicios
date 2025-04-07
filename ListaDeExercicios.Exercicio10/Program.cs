namespace ListaDeExercicios.Exercicio10
{
    internal class Program
    {
        //Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
        /*
         * calculo: IMC = peso / (altura) 2.
         * IMC em adultos Condição
            ● Abaixo de 18,5 / Abaixo do peso
            ● Entre 18,5 e 25 / Peso normal
            ● Entre 25 e 30 / Acima do peso
            ● Acima de 30 obeso
         */


        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso em KG: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);
            
            //Console.WriteLine($"Seu IMC é de: {imc}");
            Console.WriteLine($"{ValidaIMC(imc)}");
            Console.ReadLine();

        }

        static double ValidaIMC (double imc)
        {
            if (imc < 18.5)
                {
                Console.WriteLine("Você está abaixo do peso!");
                }  
            else if (imc >= 18.5 && imc <=25)
                 {
                    Console.WriteLine("Você está com peso normal!");
                }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Você está acima do peso!");
            }
            else
                Console.WriteLine("Você está obeso");
            return imc;
        }
    }
}
