using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    internal class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = @"D:\Documentos\My_Projects\C#\Curso_C-\Aula07_FuncoesRecursivas\Arquivos\arq" + numeroArquivo + ".txt";
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
            string arquivoComCaminho2 = @"D:\Documentos\My_Projects\C#\Curso_C-\Aula07_FuncoesRecursivas\Arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
