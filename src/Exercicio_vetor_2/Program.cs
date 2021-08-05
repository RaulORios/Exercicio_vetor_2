using System;
using System.Globalization;

namespace Exercicio_vetor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] valores = Console.ReadLine().Split(' ');
                        
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(valores[i],CultureInfo.InvariantCulture);            
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{vet[i].ToString("F1",CultureInfo.InvariantCulture)} ");
            }
            Console.WriteLine();

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma = soma + vet[i];
            }

            double media = soma / n;

            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadKey();

        }
    }
}
