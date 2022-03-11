using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_C_Teste
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            novoCliente nvCliente = new novoCliente();
            nvCliente.ShowDialog();
        }
    }
}
