namespace FuncoesRecursivas
{
    class program
    {
        //Função para ler apenas um arquivo
        private static void LerArquivo(string nomeArquivo)
        {
            using (StreamReader arquivo = File.OpenText(nomeArquivo))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }

        //Função para ler mais de um arquivo utilizando RECURSIVIDADE
        private static void LerArquivos (int numeroArquivo)
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
                
            string arquivoComCaminho2 = @"D:\Documentos\My_Projects\C#\Curso_C-\Aula07_FuncoesRecursivas\Arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivos(numeroArquivo + 1);
            }
        }

        static void Main(string[] args)
        {
            LerArquivos(1);
        }

    }

}

