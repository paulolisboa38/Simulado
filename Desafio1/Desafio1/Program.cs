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
            string palavra = "sim";
            //string resposta = "_____";

            char[] letras = new char[palavra.Length];
            //letras = palavra.ToCharArray();
            for (int i = 0; i < letras.Length; i++)
            {
                letras[i] = '_';
            }

            bool flag = true;

            while (flag)
            {
                Console.Write(" Insira uma letra apenas: ");
                char c = char.Parse(Console.ReadLine());

                if (c == 's')
                {
                    letras[0] = 's';
                    Console.WriteLine();
                }
                else if (c == 'i')
                {
                    letras[1] = 'i';
                    Console.WriteLine();
                }
                else if (c == 'm')
                {
                    letras[2] = 'm';
                    Console.WriteLine();
                }

                Console.Write("-");
                foreach (var item in letras)
                {
                    Console.Write(item);
                }
                Console.Write("-");

                if (letras[0] == 's' && letras[1] == 'i' && letras[2] == 'm')
                {
                    flag = false;
                }

                else if (flag == false)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
