namespace Crud_C_Teste
{
    partial class Tela_Principal
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
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoCliente.Location = new System.Drawing.Point(32, 22);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(122, 122);
            this.btnNovoCliente.TabIndex = 0;
            this.btnNovoCliente.Text = "NOVO CLIENTE";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarCliente.Location = new System.Drawing.Point(160, 22);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(122, 122);
            this.btnConsultarCliente.TabIndex = 1;
            this.btnConsultarCliente.Text = "CONSULTAR CLIENTE";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 190);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Name = "Tela_Principal";
            this.Text = "Tela_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNovoCliente;
        private Button btnConsultarCliente;
    }
}