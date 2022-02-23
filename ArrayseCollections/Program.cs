namespace ArrayseCollections
{
    class Program
    {
        static void Main (string[] args)
        {
            /*
            //Criou um Array do tipo string com 4 espaços disponíveis.
            string[] s = new string[4]; 
            s[0] = "Gabriel"; // Atribuiu a Array 's' na posição(índica) [0] o valor "Gabriel"
            s[1] = "Thaís"; // Atribuiu a Array 's' na posição(índica) [1] o valor "Thaís"
            s[2] = "Noah Miguel"; // Atribuiu a Array 's' na posição(índica) [2] o valor "Noah Miguel"

            //Para imprimir precisamos utilizar o FOREACH
            foreach(string nome in s)
            {
                Console.WriteLine(nome);
            }
            Console.Read();
            */
            
            //Criando uma Lista
            //Sempre utilizar List para criar a Lista
            List<string> a = new List<string> (); // Cria uma lista, seleciona o tipo de dados que vai receber e cria o objeto.
            a.Add("Gabriel");
            a.Add("Thaís Lima");
            a.Add("Noah Miguel");
            a.Add("Ethan Rafael");

            // Para imprimir os resultados também utilizamos o FOREACH
            foreach(string s in a)
            {   
                
                Console.WriteLine (s);
            }

            Console.Read();

        }
    }
}