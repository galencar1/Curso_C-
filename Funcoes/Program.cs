namespace Funcoes
{
    class Program
    {
        //Criando uma nova função.

        //Pública (Public), Estática(Static), Com retorno (sem o void), retornará um valor inteiro(int), e o nome da função Calcular
        
        public static int Calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b; 
            return c;
        }

        public static void Tabuada(int numero)
        {
            for (int i=0; i <=10; i++)
            {
                Console.WriteLine(numero + "X" + i + "=" + (numero*i));
            }
        }
        
        //Função Estatica(static), Sem retorno(void) , Nome dela é (Main), Parâmetro dela é um Array de String (string[]) com nome (args).
        static void Main(string[] args)
        {
            Console.WriteLine(Calcular());
            Tabuada(3);
            Tabuada(5);
            Console.Read();
        }
    }
}