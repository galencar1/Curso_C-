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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesqNome = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnConsultar = new System.Windows.Forms.Panel();
            this.btnExTodos = new System.Windows.Forms.Button();
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
            // pnConsultar
            // 
            this.pnConsultar.Location = new System.Drawing.Point(12, 180);
            this.pnConsultar.Name = "pnConsultar";
            this.pnConsultar.Size = new System.Drawing.Size(776, 258);
            this.pnConsultar.TabIndex = 3;
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
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExTodos);
            this.Controls.Add(this.pnConsultar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPesqNome);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPesqNome;
        private Button btnBuscar;
        private Panel pnConsultar;
        private Button btnExTodos;
    }
}