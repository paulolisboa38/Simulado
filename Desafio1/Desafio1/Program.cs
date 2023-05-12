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
            Console.Write("Digite uma palavra: ");
            string paraVerificar = Console.ReadLine();
            int count = paraVerificar.Length;
            char[] aux = new char[count];
            aux = paraVerificar.ToCharArray();

            bool flag = false;

            for (int i = 1; i <= count; i++)
            {
                if (aux[i - 1] == aux[count - i])
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                Console.WriteLine($"A string {paraVerificar} não é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"A string {paraVerificar} é um palíndromo.");
            }
        }
    }
}
