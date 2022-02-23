namespace ProgramacaoFuncional
{
    class program
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Menu()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n Utilizando Programação Funcional" +
                    "\n   Digite uma das opções abaixo:" +
                    "\n     0 - Sair do Programa" +
                    "\n     1 - Para Ler Arquivos" +
                    "\n     2 - Para Executar a Tabuada" +
                    "\n     3 - Calcular média de Alunos";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("=============================Opção Ler Arquivos======================");
                    LerArquivos(1);
                    Console.WriteLine("=====================================================================");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("==========================Opção Tabuada==============================");
                    Console.WriteLine("Digite o número que deseja na tabuada:");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                    Console.WriteLine("=====================================================================");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("==========================Opção Calculo de Média=====================");
                    CalcularMediaAluno();
                    Console.WriteLine("=====================================================================");
                }
                else
                {
                    Console.WriteLine("Opção Inválida - Digite Novamente");
                }


            }
        }


        public static void Tabuada (int numero)
        {
            Console.WriteLine("=====================Calculo da tabuada do " + numero + "============================");
            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("======================================================================================");
        }

        public static void LerArquivos (int numeroArquivo)
        {
            string arquivoComCaminho = @"D:\Documentos\My_Projects\C#\Curso_C-\Aula07_FuncoesRecursivas\Arquivos\arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using(StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            Console.WriteLine("\n ======================================================================");
            string arquivoComCaminho2 = @"D:\Documentos\My_Projects\C#\Curso_C-\Aula07_FuncoesRecursivas\Arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivos(numeroArquivo + 1);
            }
        }

        public static void CalcularMediaAluno()
        {
            Console.WriteLine("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno: ");
            List<int> notas = new List<int>();
            int totalNotas = 0;
            for ( int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota número " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno " + nome + " é: " + media);
            Console.WriteLine("Suas notas são: \n");
            foreach (int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
