namespace JCD1._5._3
{
    internal class Program
    {
        static void Main()
        {
            //Criar uma array para armazenar os cinco números
            double[] numeros = new double[5];

            //Solicitar ao usuário para inserir os cinco números
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}° número: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());    
            }

            //Calcular a média 
            double media = CalcularMedia(numeros);

            //Exibir o resultado
            Console.WriteLine($"A média dos números é: {media}");
        }

        //Método para calcular a média de uma array de números 
        static double CalcularMedia(double[] numeros) 

        {
            double soma = 0;

            //Calcular a soma dos números 
            foreach (double num in numeros) 
            { 
                soma += num;
            }

            //Calcular a média 
            double media = soma / numeros.Length;

            return media;
        }
    }
}