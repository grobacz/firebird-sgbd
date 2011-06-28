namespace FIREBIRD
{
    partial class Principal
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageLocacao = new System.Windows.Forms.TabPage();
            this.dgvLocacao = new System.Windows.Forms.DataGridView();
            this.bLocAtualizar = new System.Windows.Forms.Button();
            this.bLocRemover = new System.Windows.Forms.Button();
            this.bLocInserir = new System.Windows.Forms.Button();
            this.tabPageFilme = new System.Windows.Forms.TabPage();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.bFilmesAtualizar = new System.Windows.Forms.Button();
            this.bFilmesRemover = new System.Windows.Forms.Button();
            this.bFilmesInserir = new System.Windows.Forms.Button();
            this.tabPageCliente = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.bClientesAtualizar = new System.Windows.Forms.Button();
            this.bClientesRemover = new System.Windows.Forms.Button();
            this.bClientesInserir = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageLocacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).BeginInit();
            this.tabPageFilme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            this.tabPageCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageLocacao);
            this.tabControl.Controls.Add(this.tabPageFilme);
            this.tabControl.Controls.Add(this.tabPageCliente);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(628, 376);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageLocacao
            // 
            this.tabPageLocacao.Controls.Add(this.dgvLocacao);
            this.tabPageLocacao.Controls.Add(this.bLocAtualizar);
            this.tabPageLocacao.Controls.Add(this.bLocRemover);
            this.tabPageLocacao.Controls.Add(this.bLocInserir);
            this.tabPageLocacao.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocacao.Name = "tabPageLocacao";
            this.tabPageLocacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocacao.Size = new System.Drawing.Size(620, 350);
            this.tabPageLocacao.TabIndex = 0;
            this.tabPageLocacao.Text = "Locação";
            this.tabPageLocacao.UseVisualStyleBackColor = true;
            // 
            // dgvLocacao
            // 
            this.dgvLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocacao.Location = new System.Drawing.Point(17, 16);
            this.dgvLocacao.Name = "dgvLocacao";
            this.dgvLocacao.Size = new System.Drawing.Size(585, 279);
            this.dgvLocacao.TabIndex = 3;
            // 
            // bLocAtualizar
            // 
            this.bLocAtualizar.Location = new System.Drawing.Point(351, 309);
            this.bLocAtualizar.Name = "bLocAtualizar";
            this.bLocAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bLocAtualizar.TabIndex = 2;
            this.bLocAtualizar.Text = "Atualizar";
            this.bLocAtualizar.UseVisualStyleBackColor = true;
            this.bLocAtualizar.Click += new System.EventHandler(this.bLocAtualizar_Click);
            // 
            // bLocRemover
            // 
            this.bLocRemover.Location = new System.Drawing.Point(269, 310);
            this.bLocRemover.Name = "bLocRemover";
            this.bLocRemover.Size = new System.Drawing.Size(75, 23);
            this.bLocRemover.TabIndex = 1;
            this.bLocRemover.Text = "Remover";
            this.bLocRemover.UseVisualStyleBackColor = true;
            this.bLocRemover.Click += new System.EventHandler(this.bLocRemover_Click);
            // 
            // bLocInserir
            // 
            this.bLocInserir.Location = new System.Drawing.Point(187, 311);
            this.bLocInserir.Name = "bLocInserir";
            this.bLocInserir.Size = new System.Drawing.Size(75, 23);
            this.bLocInserir.TabIndex = 0;
            this.bLocInserir.Text = "Inserir";
            this.bLocInserir.UseVisualStyleBackColor = true;
            this.bLocInserir.Click += new System.EventHandler(this.bLocInserir_Click);
            // 
            // tabPageFilme
            // 
            this.tabPageFilme.Controls.Add(this.dgvFilmes);
            this.tabPageFilme.Controls.Add(this.bFilmesAtualizar);
            this.tabPageFilme.Controls.Add(this.bFilmesRemover);
            this.tabPageFilme.Controls.Add(this.bFilmesInserir);
            this.tabPageFilme.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilme.Name = "tabPageFilme";
            this.tabPageFilme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilme.Size = new System.Drawing.Size(620, 350);
            this.tabPageFilme.TabIndex = 1;
            this.tabPageFilme.Text = "Filmes";
            this.tabPageFilme.UseVisualStyleBackColor = true;
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Location = new System.Drawing.Point(17, 16);
            this.dgvFilmes.MultiSelect = false;
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.Size = new System.Drawing.Size(585, 279);
            this.dgvFilmes.TabIndex = 3;
            // 
            // bFilmesAtualizar
            // 
            this.bFilmesAtualizar.Location = new System.Drawing.Point(349, 311);
            this.bFilmesAtualizar.Name = "bFilmesAtualizar";
            this.bFilmesAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bFilmesAtualizar.TabIndex = 2;
            this.bFilmesAtualizar.Text = "Atualizar";
            this.bFilmesAtualizar.UseVisualStyleBackColor = true;
            this.bFilmesAtualizar.Click += new System.EventHandler(this.bFilmesAtualizar_Click);
            // 
            // bFilmesRemover
            // 
            this.bFilmesRemover.Location = new System.Drawing.Point(268, 311);
            this.bFilmesRemover.Name = "bFilmesRemover";
            this.bFilmesRemover.Size = new System.Drawing.Size(75, 23);
            this.bFilmesRemover.TabIndex = 1;
            this.bFilmesRemover.Text = "Remover";
            this.bFilmesRemover.UseVisualStyleBackColor = true;
            this.bFilmesRemover.Click += new System.EventHandler(this.bFilmesRemover_Click);
            // 
            // bFilmesInserir
            // 
            this.bFilmesInserir.Location = new System.Drawing.Point(187, 311);
            this.bFilmesInserir.Name = "bFilmesInserir";
            this.bFilmesInserir.Size = new System.Drawing.Size(75, 23);
            this.bFilmesInserir.TabIndex = 0;
            this.bFilmesInserir.Text = "Inserir";
            this.bFilmesInserir.UseVisualStyleBackColor = true;
            this.bFilmesInserir.Click += new System.EventHandler(this.bFilmesInserir_Click);
            // 
            // tabPageCliente
            // 
            this.tabPageCliente.Controls.Add(this.dgvClientes);
            this.tabPageCliente.Controls.Add(this.bClientesAtualizar);
            this.tabPageCliente.Controls.Add(this.bClientesRemover);
            this.tabPageCliente.Controls.Add(this.bClientesInserir);
            this.tabPageCliente.Location = new System.Drawing.Point(4, 22);
            this.tabPageCliente.Name = "tabPageCliente";
            this.tabPageCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCliente.Size = new System.Drawing.Size(620, 350);
            this.tabPageCliente.TabIndex = 2;
            this.tabPageCliente.Text = "Clientes";
            this.tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(17, 16);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(585, 279);
            this.dgvClientes.TabIndex = 3;
            // 
            // bClientesAtualizar
            // 
            this.bClientesAtualizar.Location = new System.Drawing.Point(349, 311);
            this.bClientesAtualizar.Name = "bClientesAtualizar";
            this.bClientesAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bClientesAtualizar.TabIndex = 2;
            this.bClientesAtualizar.Text = "Atualizar";
            this.bClientesAtualizar.UseVisualStyleBackColor = true;
            this.bClientesAtualizar.Click += new System.EventHandler(this.bClientesAtualizar_Click);
            // 
            // bClientesRemover
            // 
            this.bClientesRemover.Location = new System.Drawing.Point(268, 311);
            this.bClientesRemover.Name = "bClientesRemover";
            this.bClientesRemover.Size = new System.Drawing.Size(75, 23);
            this.bClientesRemover.TabIndex = 1;
            this.bClientesRemover.Text = "Remover";
            this.bClientesRemover.UseVisualStyleBackColor = true;
            this.bClientesRemover.Click += new System.EventHandler(this.bClientesRemover_Click);
            // 
            // bClientesInserir
            // 
            this.bClientesInserir.Location = new System.Drawing.Point(187, 311);
            this.bClientesInserir.Name = "bClientesInserir";
            this.bClientesInserir.Size = new System.Drawing.Size(75, 23);
            this.bClientesInserir.TabIndex = 0;
            this.bClientesInserir.Text = "Inserir";
            this.bClientesInserir.UseVisualStyleBackColor = true;
            this.bClientesInserir.Click += new System.EventHandler(this.bClientesInserir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 400);
            this.Controls.Add(this.tabControl);
            this.Name = "Principal";
            this.Text = "Principal";
            this.tabControl.ResumeLayout(false);
            this.tabPageLocacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).EndInit();
            this.tabPageFilme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            this.tabPageCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageLocacao;
        private System.Windows.Forms.DataGridView dgvLocacao;
        private System.Windows.Forms.Button bLocAtualizar;
        private System.Windows.Forms.Button bLocRemover;
        private System.Windows.Forms.Button bLocInserir;
        private System.Windows.Forms.TabPage tabPageFilme;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.Button bFilmesAtualizar;
        private System.Windows.Forms.Button bFilmesRemover;
        private System.Windows.Forms.Button bFilmesInserir;
        private System.Windows.Forms.TabPage tabPageCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button bClientesAtualizar;
        private System.Windows.Forms.Button bClientesRemover;
        private System.Windows.Forms.Button bClientesInserir;
    }
}