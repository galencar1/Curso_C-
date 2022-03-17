namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este método só poder ser acessado dentro desse Aseembly Componentes";
        }
        public string MetodoParaTodosQueUtilizarOAssembly()
        {
            return "Esse método é para todos.";
        }

        public bool ValidarID(string id)
        {
            return true;
        }

    }
}