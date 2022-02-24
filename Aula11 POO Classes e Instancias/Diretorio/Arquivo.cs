using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    internal class Arquivo
    {
        private static string CaminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];
        }

        public static void Ler(int numeroArquivo)
        {
            
            string arquivoComCaminho =  CaminhoArquivo() + "arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            Console.WriteLine("\n ======================================================================");
            string arquivoComCaminho2 = CaminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}