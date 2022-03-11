namespace CrudForm_Teste
{
    partial class ConsultarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesqNome = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExTodos = new System.Windows.Forms.Button();
            this.listarClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvdados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listarClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar por Nome: ";
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.Location = new System.Drawing.Point(177, 16);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(611, 23);
            this.txtPesqNome.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(178, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 117);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnExTodos
            // 
            this.btnExTodos.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExTodos.Location = new System.Drawing.Point(301, 57);
            this.btnExTodos.Name = "btnExTodos";
            this.btnExTodos.Size = new System.Drawing.Size(117, 117);
            this.btnExTodos.TabIndex = 4;
            this.btnExTodos.Text = "EXIBIR TODOS";
            this.btnExTodos.UseVisualStyleBackColor = true;
            this.btnExTodos.Click += new System.EventHandler(this.btnExTodos_Click);
            // 
            // listarClientesBindingSource
            // 
            this.listarClientesBindingSource.DataSource = typeof(CrudForm_Teste.ListarClientes);
            // 
            // dgvdados
            // 
            this.dgvdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdados.Location = new System.Drawing.Point(12, 180);
            this.dgvdados.Name = "dgvdados";
            this.dgvdados.RowTemplate.Height = 25;
            this.dgvdados.Size = new System.Drawing.Size(776, 265);
            this.dgvdados.TabIndex = 5;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvdados);
            this.Controls.Add(this.btnExTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPesqNome);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.listarClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPesqNome;
        private Button btnBuscar;
        private Button btnExTodos;
        private BindingSource listarClientesBindingSource;
        public DataGridView dgvdados;
    }
}