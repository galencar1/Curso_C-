﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudForm_Teste
{
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnExTodos_Click(object sender, EventArgs e)
        {
            ListarClientes lisCliente = new ListarClientes();
            MessageBox.Show(lisCliente.mensagem);
            
        }

    }
}
