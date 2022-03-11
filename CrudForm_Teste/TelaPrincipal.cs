namespace CrudForm_Teste
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
           Novo_Cliente nvCliente = new Novo_Cliente();
            nvCliente.ShowDialog();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente consCliente = new ConsultarCliente();
            consCliente.ShowDialog();
        }
    }
}