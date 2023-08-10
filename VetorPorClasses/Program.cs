using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace VetorPorClasses
{
    class VetorDeClasse
    {
        static void Main(string[] args) {
            Console.WriteLine("Número de produtos à serem cadastrados: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Produtos[] vect = new Produtos[n];
            
            for(int i = 0; i < n; i++) {
                Console.Write("Nome do produto:");
                string nome = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                vect[i] = new Produtos { Nome = nome, Preco = preco };
            }

            double sum = 0;
            for (int i = 0;i < n; i++) {
                sum += vect[i].Preco;
            }

            double media = sum / n;

            Console.WriteLine("Média de preço dos produtos é: " + media.ToString("F2", CultureInfo.InvariantCulture));


       
        }
    }
}
