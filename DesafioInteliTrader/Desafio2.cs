using System;
using System.Collections.Generic;
using System.IO;

namespace DesafioInteliTrader
{
    internal class Desafio2
    {
        public static void MenuDesafio2()
        {
            Console.Clear();
            Console.WriteLine("Crie uma aplicação que recebe dois arquivos e gera um terceiro arquivo contendo as linhas contidas nos 2 arquivos recebidos" + Environment.NewLine);
            Console.WriteLine("Digite o caminho completo do primeiro arquivo com .txt no final ");
            string arquivo1 = Console.ReadLine();

            Console.WriteLine("Digite o caminho completo do segundo arquivo com .txt no final ");
            string arquivo2 = Console.ReadLine();

            Console.WriteLine("Digite o caminho completo de saída com nome do novo arquivo .txt");
            string arquivoSaida = Console.ReadLine();

            try
            {
                List<string> linhasArquivo1 = Desafio2.ReadAllLines(arquivo1);
                List<string> linhasArquivo2 = Desafio2.ReadAllLines(arquivo2);

                List<string> todasLinhas = new List<string>(linhasArquivo1);

                foreach (string linha in linhasArquivo2)
                {
                    todasLinhas.Add(linha);
                }

                Desafio2.WriteAllLines(arquivoSaida, todasLinhas);

                Console.WriteLine("Arquivo de saída gerado com sucesso no caminho indicado!");
                Console.WriteLine("Desafio finalizado, voltando ao menu principal...");
                Thread.Sleep(4000);
                Menu.ExibirMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro, verifique o caminho e se o arquivo é .txt: " + ex.Message);
            }
        }

        static List<string> ReadAllLines(string filePath)
        {
            List<string> lines = new();
            using (StreamReader reader = new(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }

        static void WriteAllLines(string filePath, List<string> lines)
        {
            using StreamWriter writer = new(filePath);
            foreach (string line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }
}
