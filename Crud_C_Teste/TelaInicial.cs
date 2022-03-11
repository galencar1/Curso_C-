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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void adicionarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFuncionario addFun = new addFuncionario();
            addFun.ShowDialog();
        }
    }
}
