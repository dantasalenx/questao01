using System;
using System.Collections.Generic;
using System.Linq;

namespace questao01_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumero = new List<int>();
        
            Console.WriteLine("Digite a quantidade de numeros: ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite um valor: ");
                listaNumero.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("\nNumeros: ");

            foreach (int e in listaNumero)
            {
                Console.WriteLine("\n"+ e);
            }
            Console.WriteLine("\nMin: " + listaNumero.Min());
            Console.WriteLine("\nMax: " + listaNumero.Max());
        }
    }
}
