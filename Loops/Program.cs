
//Loop While - Enquanto a variável não atingir o valor estipulado ele continua executando.
/*
var a = 1;
while (a <= 5)
{
    Console.WriteLine(a);
    a++;    
}
*/


//While com Continue para pular um valor especificado
/*
var a = 0;
while (a <= 10)
{
    if(a==3) // Vai pular o número 3
    {
        a++;
        continue;
    }
    Console.WriteLine(a);
    a++;
}
*/

//While con Break. Finalizando o Loop antes da condição estabelecida.
/*
var a = 0;
while (a <= 10)
{
    if(a == 3) // Conta até dois, chegando no três ele interrompe.
    {
        break;
    }
    Console.WriteLine(a);
    a++;
}
*/

//==========================================================================================

//Loop Do While - Faça determinado situãção Enquanto a condição for respeitada.
/*
var b = 1;
do
{
    Console.WriteLine(b);
    b++;    
} while (b <= 5);
*/

//============================================================================================

// Loop For - Durante
/*
for (int c = 0; c <= 5; c++)
{
    Console.WriteLine(c);
}
*/

//===========================================================================================

// Loop For Each (Para cada um)-- Trabalha com Arrays

/*
int[] d = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Criando a Array.

foreach (int v in d) // Percorre toda a array da variável d e coloca os valores na variável d.
{
    Console.WriteLine(v);
}
*/

//==============================================================================================4

// Loop com Função recursiva. 
/*
namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            looping(1);//Atribui o valor inicial a função.
        }
        public static void looping(int e) // Função Looping com variável inteira e
        {
            Console.WriteLine(e); // Imprime o valor atribuido a variável e
            if ( e <= 10)   // Estrutura if ( Se o valor de 'e' for menor ou igual a 10 chama a função looping atribuindo +1 ao valor de 'e'
            {    
                looping(e + 1); // Chamou a função e adicionou mais um a variável 'e'
            }
        }
    }

}
*/




