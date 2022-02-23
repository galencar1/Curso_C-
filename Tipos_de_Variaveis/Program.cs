using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; // Tipagem Estática Forte. Criei uma variável inteira e atribui o valor 1 a ela.
            //i = "s"; // Nesse caso por ser uma variável do tipo inteiro não pode receber uma string.
            
            var x = 1; // Tipagem dinâmica Forte.
            //x = "333";
            Console.WriteLine(i);
            Console.WriteLine(x);

            string s = "Gabriel"; // Tipagem Estática
            Console.WriteLine(s);

            var s2 = "Gabriel 2"; // Tipagem Dinãmica
            Console.WriteLine(s2);

            var f = 1.5f; //Variável do tipo Float com tipagem Dinâmica
            float f2 = 1.5f; // Variável do tipo Float com tipagem Estática

            Console.WriteLine(f);
            Console.WriteLine(f2);

            var d = 2.5; // Variável tipo double com tipagem dinamica ( Para utilizar o double NÃO colocamos a letra f após o valor.
            double d2 = 2.5;
            Console.WriteLine(d);
            Console.WriteLine(d2);

            var bo1 = true; // Variável Booleana com tipagem dinamica
            var bo2 = false;

            bool bo3 = false;// Variável Booleana com Tipager estática
            bool bo4 = true;

            Console.WriteLine(bo1);
            Console.WriteLine(bo2);
            Console.WriteLine(bo3);
            Console.WriteLine(bo4);

            // Tipos de Conversão

            //bool boolean = "true"; // Uma variável boolean não pode ser string.
            //Podemos converter utilizando o Parse.
            bool boolean = bool.Parse("true");//Parse converte somente para String

            // Podemos também utilizar o ConvertTo
            bool boolean2 = Convert.ToBoolean("false");// ConvertTo Converte pra vários tipos de variáveis primitivas  e para objetos.

            Animal a = new Animal();
            Leao l = new Leao();
            //l = a; // Erro. Não é possível Converter animal para Leão;
            l = (Leao)a; // Posso utilizar um casting para enganar o programa.
            a = l; // Não da erro pois Leão Herda de Animal.

        }
    }
    public class Animal
    {

    }

    public class Leao : Animal
    {

    }

}



