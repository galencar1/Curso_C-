namespace VariaveisConstantes
{
    class program
    {
        public const int SAIDA_PROGRAMA = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair do programa");
                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
            }
        }
    }
}
