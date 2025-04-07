namespace ListaDeExercicios.Exercicio09
{
    internal class Program
    {
        //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
           
            int[] numeros = new int[3];

           for (int i = 0; i<3; i++)
            {
                Console.WriteLine($"Digite o: {i} número:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (numeros[0] == numeros[1] || numeros[0] == numeros[2] || numeros[1] == numeros[2])
            {
                Console.WriteLine("Os números devem ser diferentes!");
                return;
            }
            Array.Sort(numeros);

            Console.WriteLine($"Os valores em ordem decrescente são: {numeros[2]}, {numeros[1]}, {numeros[0]}.");
            Console.ReadLine();
        }
    }
}
