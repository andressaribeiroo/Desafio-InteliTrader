using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInteliTrader
{
    internal class Menu
    {
        public static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo(a) aos Desafios InteliTrader");
            Console.WriteLine("Escolha uma das Opções:");
            Console.WriteLine("1. Desafio da Multiplicação");
            Console.WriteLine("2. Desafio Intercessão de Arquivos");
            Console.WriteLine("0. Sair" + Environment.NewLine);

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Desafio1.MenuDesafio(); break;
                case 2: Desafio2.MenuDesafio2(); break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    Environment.Exit(0);
                    break;

                default: ExibirMenu(); break;
            }
        }
    }
}
