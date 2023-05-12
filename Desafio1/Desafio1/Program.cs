using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe uma lista de números separados por espaço: ");
            string lista = Console.ReadLine();

            string[] numeros = lista.Split(' ');

            List<int> inteiros = new List<int>();
            List<int> ordenados = new List<int>();

            for (int i = 0; i < numeros.Length; i++)
            {
                inteiros.Add(int.Parse(numeros[i]));
            }

            int menor = 0;
            bool flag = true;

            while (flag)
            {
                int N = 999999999;

                for (int i = 0; i < inteiros.Count; i++)
                {
                    if (inteiros[i] < N)
                    {
                        menor = inteiros[i];
                        N = menor;
                    }
                }

                if (!ordenados.Contains(menor))
                {
                    ordenados.Add(menor);
                    inteiros.Remove(menor);
                }

                if (inteiros.Count == 0)
                {
                    flag = false;
                }
            }

            foreach (var item in ordenados)
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}
