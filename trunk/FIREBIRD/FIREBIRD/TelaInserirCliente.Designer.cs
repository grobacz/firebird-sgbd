namespace FIREBIRD
{
    partial class TelaInserirCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.tbEnderecaoCliente = new System.Windows.Forms.TextBox();
            this.tbDataNasc = new System.Windows.Forms.TextBox();
            this.tbCpfCliente = new System.Windows.Forms.TextBox();
            this.tbTelefoneCliente = new System.Windows.Forms.TextBox();
            this.bInserirCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone:";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(67, 30);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(366, 20);
            this.tbNomeCliente.TabIndex = 5;
            // 
            // tbEnderecaoCliente
            // 
            this.tbEnderecaoCliente.Location = new System.Drawing.Point(85, 63);
            this.tbEnderecaoCliente.Name = "tbEnderecaoCliente";
            this.tbEnderecaoCliente.Size = new System.Drawing.Size(348, 20);
            this.tbEnderecaoCliente.TabIndex = 6;
            // 
            // tbDataNasc
            // 
            this.tbDataNasc.Location = new System.Drawing.Point(136, 95);
            this.tbDataNasc.Name = "tbDataNasc";
            this.tbDataNasc.Size = new System.Drawing.Size(100, 20);
            this.tbDataNasc.TabIndex = 7;
            // 
            // tbCpfCliente
            // 
            this.tbCpfCliente.Location = new System.Drawing.Point(289, 95);
            this.tbCpfCliente.Name = "tbCpfCliente";
            this.tbCpfCliente.Size = new System.Drawing.Size(144, 20);
            this.tbCpfCliente.TabIndex = 8;
            // 
            // tbTelefoneCliente
            // 
            this.tbTelefoneCliente.Location = new System.Drawing.Point(81, 127);
            this.tbTelefoneCliente.Name = "tbTelefoneCliente";
            this.tbTelefoneCliente.Size = new System.Drawing.Size(155, 20);
            this.tbTelefoneCliente.TabIndex = 9;
            // 
            // bInserirCliente
            // 
            this.bInserirCliente.Location = new System.Drawing.Point(289, 127);
            this.bInserirCliente.Name = "bInserirCliente";
            this.bInserirCliente.Size = new System.Drawing.Size(144, 23);
            this.bInserirCliente.TabIndex = 10;
            this.bInserirCliente.Text = "Inserir Cliente";
            this.bInserirCliente.UseVisualStyleBackColor = true;
            this.bInserirCliente.Click += new System.EventHandler(this.bInserirCliente_Click);
            // 
            // TelaInserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 175);
            this.Controls.Add(this.bInserirCliente);
            this.Controls.Add(this.tbTelefoneCliente);
            this.Controls.Add(this.tbCpfCliente);
            this.Controls.Add(this.tbDataNasc);
            this.Controls.Add(this.tbEnderecaoCliente);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaInserirCliente";
            this.Text = "Inserir Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.TextBox tbEnderecaoCliente;
        private System.Windows.Forms.TextBox tbDataNasc;
        private System.Windows.Forms.TextBox tbCpfCliente;
        private System.Windows.Forms.TextBox tbTelefoneCliente;
        private System.Windows.Forms.Button bInserirCliente;
    }
}