using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculo;
using Diretorio;
using Funcoes;

namespace Tela
{
    internal class Menu
    {

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Criar()
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
                    Arquivo.Ler(1);
                    Console.WriteLine("=====================================================================");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("==========================Opção Tabuada==============================");
                    Console.WriteLine("Digite o número que deseja na tabuada:");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("=====================================================================");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("==========================Opção Calculo de Média=====================");
                    CalculoMedia.CalcularMediaAluno();
                    Console.WriteLine("=====================================================================");
                }
                else
                {
                    Console.WriteLine("Opção Inválida - Digite Novamente");
                }


            }
        }
    }
}
