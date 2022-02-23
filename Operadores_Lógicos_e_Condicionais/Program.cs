using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Logicos_e_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entendendo Estrutura de Condição If Else.
            /*
            var a = 0;
            if (a == 1)
            {
                Console.WriteLine("Entrou na condição do If");
                Console.WriteLine("=============");
            }
            else
            {
                Console.WriteLine("Caiu no Bloco do Se Não");
            }
            */


            //==============================================================================================================================

            // Entendendo Estrutura de condição Switch.
            // Condição com múltipla escolha.
            /*
            var b = 0;
            switch (b)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default Case");
                    break ;
            */

            //==================================================================================================================================

            //Entendendo o operador ternário

            var a = 2;
            string teste = (a == 1 ? "o Valor de a" : "mais um");
            Console.WriteLine("Olá Pessoal" + teste);
            Console.Read();

        }
    }
}

