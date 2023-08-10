using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInteliTrader
{
    internal class Desafio1
    {
        public static void MenuDesafio()
        {
            Console.Clear();
            Console.WriteLine("Crie uma aplicação capaz de realizar multiplicação de números com mais de 22 caracteres (bigInt)" + Environment.NewLine);
            Console.WriteLine("Digite o primeiro número:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo número:");
            string num2 = Console.ReadLine();

            string result = MultiplyBigIntegers(num1, num2);

            Console.WriteLine("Resultado da multiplicação:");
            Console.WriteLine(result);

            Console.WriteLine("Desafio finalizado, voltando ao menu principal...");
            Thread.Sleep(4000);
            Menu.ExibirMenu();

        }

        static string MultiplyBigIntegers(string num1, string num2)
        {
            int len1 = num1.Length;
            int len2 = num2.Length;

            int[] resultArray = new int[len1 + len2];

            for (int i = len1 - 1; i >= 0; i--)
            {
                int digit1 = num1[i] - '0';

                for (int j = len2 - 1; j >= 0; j--)
                {
                    int digit2 = num2[j] - '0';

                    int product = digit1 * digit2;

                    int sum = product + resultArray[i + j + 1];

                    resultArray[i + j + 1] = sum % 10;
                    resultArray[i + j] += sum / 10;
                }
            }

            string result = string.Join("", resultArray);
            result = result.TrimStart('0');

            return string.IsNullOrEmpty(result) ? "0" : result;
        }
 
    }
}
